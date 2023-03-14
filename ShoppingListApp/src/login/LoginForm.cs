using ShoppingListApp.src.Login;
using ShoppingListApp.src;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Configuration;

namespace ShoppingListApp
{
    public partial class FormLogin : Form
    {
        const int BAN_TIME = 15;
        int m_iFailedLogins = 0;

        public FormLogin()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.UFix_Logo_Icon;

            BorderlessUtils.MakeFormDraggable(this);

            // create minimise, maximise, close buttons
            CornerButton cb = new CornerButton(this);
            cb.CreateTitlebarButtons(FlatStyle.Flat, Color.Goldenrod);
        }

        // since invoking a control requires its handle to be created, we can't run DisableLoginSystem() in the constructor,
        // and instead must check if the user is banned after the handle has been created. we could also use the HandleCreated
        // event, but overriding OnLoad works just fine.
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // keep user banned if they were banned but closed the application
            if (IsBanned())
                DisableLoginSystem();
        }

        private void LoginInfo_TextChanged(object sender, EventArgs e)
        {
            // usernames and passwords cannot be empty, so disable the text boxes if they are
            if (txtPassword.Text.Length == 0 || txtUser.Text.Length == 0)
            {
                SetLoginControlsEnabled(false, true);
                return;
            }

            SetLoginControlsEnabled(true, true);
        }

        private void tmrResponseTimeout_Tick(object sender, EventArgs e)
        {
            ((System.Windows.Forms.Timer)sender).Stop();

            if (this.Visible)
                lblLoginResponse.ResetText();
        }

        private void cbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cbxShowPass.Checked;
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            // disallow any characters in the username textbox that aren't allowed in a username
            e.Handled = !LoginUtils.IsUsernameCharValid(e.KeyChar);
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsBanned())
            {
                SetStatus("Cannot login while banned.", Color.Red);
                return;
            }

            // asynchronously run the AttemptLogin method so the ui doesn't hang while logging in
            await Task.Run(() =>
            {
                return AttemptLogin(txtUser.Text);
            }).ContinueWith(task => // after the method has completed:
            {
                if (task.Result) // if AttemptLogin succeeded...
                    LoginComplete(); // ...run LoginComplete method
                else if (!task.Result)
                    LoginFailed();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (IsBanned())
            {
                SetStatus("Cannot register while banned.", Color.Red);
                return;
            }

            // asynchronously run the Register method so the ui doesn't hang while registering
            await Task.Run(() => { Register(); });
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save(); // ensure settings are saved when application is closed
        }

        /// <summary>
        /// Increments the count of failed login attempts and disables the login system
        /// if the maximum number of allowed failed attempts is reached.
        /// </summary>
        private void LoginFailed()
        {
            const int MAX_FAILED_LOGINS = 3;

            m_iFailedLogins++;

            if (m_iFailedLogins < MAX_FAILED_LOGINS)
                return;

            // more than MAX_FAILED_LOGINS login attempts, so ban user
            DisableLoginSystem();

            m_iFailedLogins = 0;
        }

        /// <summary>
        /// Disables the login system by setting the BanTime property in the application's
        /// settings and preventing further login attempts for the specified duration.
        /// </summary>
        private async void DisableLoginSystem()
        {
            System.Windows.Forms.Application.UseWaitCursor = false;

            // disable login controls on ui thread to prevent user input while banned
            Invoke((MethodInvoker)delegate
            {
                SetLoginControlsEnabled(false);
            });

            // if not currently banned, then ban
            if (!IsBanned())
                Properties.Settings.Default.BanTime = BAN_TIME;

            // save the time banned to file
            Properties.Settings.Default.Save();

            while (IsBanned()) // loop until BanTime is 0
            {
                SetStatus($"Too many failed attempts. Try again in {Properties.Settings.Default.BanTime} seconds.", Color.Maroon);
                Properties.Settings.Default.BanTime--;

                await Task.Delay(TimeSpan.FromSeconds(1));
            }

            // save the time banned (should now be 0) to file, unbanning the user
            Properties.Settings.Default.Save();

            SetStatus("You may now login.", Color.Green);

            // re-enable login controls
            Invoke((MethodInvoker)delegate {
                SetLoginControlsEnabled(true);
            });
        }

        /// <summary>
        /// Attempt to authenticate user's login details.
        /// </summary>
        /// <param name="user">Username of the user attempting to log in.</param>
        /// <returns>TRUE if login is successful, FALSE otherwise.</returns>
        private bool AttemptLogin(string user)
        {
            // disable login controls on ui thread to prevent user input while logging in
            Invoke((MethodInvoker)delegate
            {
                SetLoginControlsEnabled(false);
            });

            SetStatus("Logging in...", Color.Orange, false);

            // change cursor to wait cursor to indicate to user something is happening
            System.Windows.Forms.Application.UseWaitCursor = true;

            // simulate processing time
            Thread.Sleep(250);

            try
            {
                string userDir = LoginUtils.GetUserDir(user);

                // if directory doesn't exist, username was invalid
                if (!Directory.Exists(userDir))
                {
                    SetStatus("Invalid username.", Color.Red);
                    return false;
                }

                byte[]? hashedPassword = LoginUtils.ReadPasswordFile(user);

                // if password file could not be read or has incorrect length, method failed
                if (hashedPassword is null || hashedPassword.Length != LoginUtils.PASSWORD_LENGTH_BYTES)
                {
                    SetStatus("Could not read password file.", Color.Red);
                    return false;
                }

                // verify entered password against hashed password
                if (!Hasher.VerifyHash(txtPassword.Text, hashedPassword))
                {
                    SetStatus("Invalid password.", Color.Red);
                    return false;
                }

                return true;
            }
            finally
            {
                // reset cursor to default
                System.Windows.Forms.Application.UseWaitCursor = false;

                // re-enable login controls on ui thread
                Invoke((MethodInvoker)delegate
                {
                    SetLoginControlsEnabled(true);
                });
            }
        }

        /// <summary>
        /// Handles the completion of a successful login by remembering the user's username, resetting the login form,
        /// and showing the main form with the specified user.
        /// </summary>
        /// <remarks>
        /// This method is typically called after a successful login and is responsible for performing any necessary post-login tasks.
        /// </remarks>
        private void LoginComplete()
        {
            m_iFailedLogins = 0;

            // remember me
            string user = txtUser.Text;
            Properties.Settings.Default.LastUsername = user;
            Properties.Settings.Default.Save();
            Reset();
            txtUser.Text = Properties.Settings.Default.LastUsername; // remember last username

            // switch to welcome form
            this.Hide();
            Form welcomeForm = new FormHomePage(this, user);
            welcomeForm.Show();
        }

        /// <summary>
        /// Attempts to register a new user by creating a user directory and storing a hashed password for the user.
        /// </summary>
        /// <remarks>
        /// This method is typically called when the user clicks the "Register" button on the login form.
        /// </remarks>
        /// <exception cref="System.Security.Cryptography.CryptographicException">
        /// Thrown when an error occurs during password hashing.
        /// </exception>
        private void Register()
        {
            // disable login controls on ui thread to prevent user input while registering
            Invoke((MethodInvoker)delegate
            {
                SetLoginControlsEnabled(false);
            });

            SetStatus("Attempting to register...", Color.Orange);

            // change cursor to wait cursor to indicate to user something is happening
            System.Windows.Forms.Application.UseWaitCursor = true;

            Thread.Sleep(500); // simulate processing time

            try
            { 
                string user = txtUser.Text;

                /* passwords must contain:
                //  - minimum 8 characters
                //  - one uppercase character
                //  - one lowercase character
                //  - one number
                //  - one special character     */
#if !DEBUG
                if (!LoginUtils.ValidatePassword(txtPassword.Text))
                {
                    SetStatus("Please create a more secure password.", Color.Red);
                    return;
                }
#endif

                // attempt to create user directory for new user
                bool? userFolderCreationResult = LoginUtils.CreateUserFolders(user);
                if (userFolderCreationResult is null) // creation failed
                {
                    SetStatus("Failed to create user folders.", Color.Red);
                    return;
                }
                else if (userFolderCreationResult is false) // user already exists
                {
                    SetStatus("Username already exists.", Color.Red);
                    return;
                }

                // hash the password and store it in a password file for the new user
                byte[] hashedPassword = Hasher.Hash(txtPassword.Text);

                // attempt to create password file for new user
                bool createPasswordFileResult = LoginUtils.CreatePasswordFile(user, hashedPassword);
                if (createPasswordFileResult is false) // creation failed
                {
                    // TODO: fix "ghost user" bug: user is created with no password file
                    SetStatus("Failed to store password.", Color.Red);
                    return;
                }

                // everything succeeded
                SetStatus("Register successful.", Color.Green);
            }
            finally
            {
                System.Windows.Forms.Application.UseWaitCursor = false;

                Invoke((MethodInvoker)delegate
                {
                    SetLoginControlsEnabled(true);
                });
            }
        }

        /// <summary>
        /// Enables or disables login controls based on the specified flag.
        /// </summary>
        /// <param name="enabled">A boolean value indicating whether controls should be enabled.</param>
        /// <param name="buttonsOnly">If true, only login and register buttons are affected.</param>
        private void SetLoginControlsEnabled(bool enabled, bool buttonsOnly = false)
        {
            btnLogin.Enabled = enabled;
            btnRegister.Enabled = enabled;

            if (buttonsOnly)
                return;

            txtUser.Enabled = enabled;
            txtPassword.Enabled = enabled;
            cbxShowPass.Enabled = enabled;
        }

        /// <summary>
        /// Determines whether the current user is banned based on the value of the BanTime property in the application's settings.
        /// </summary>
        /// <returns>TRUE if user is banned, otherwise FALSE.</returns>
        private bool IsBanned()
        {
            return Properties.Settings.Default.BanTime > 0;
        }

        /// <summary>
        /// Attempts to clear the login form to its default state.
        /// </summary>
        private void Reset()
        {
            txtPassword.ResetText();
            lblLoginResponse.ResetText();
            cbxShowPass.Checked = false;
        }

        /// <summary>
        /// Sets the text and color of the login response label and starts a timer to clear the message after a certain interval.
        /// </summary>
        /// <param name="status">The status message to display.</param>
        /// <param name="color">The color of the status message.</param>
        /// <param name="shouldTimeout">A boolean value indicating whether the message should disappear automatically after a certain interval.</param>
        private void SetStatus(string status, Color color, bool shouldTimeout = true)
        {
            Invoke((MethodInvoker)delegate
            {
                lblLoginResponse.Text = status;
                lblLoginResponse.ForeColor = color;

                if (!shouldTimeout)
                    return;

                tmrResponseTimeout.Stop();
                tmrResponseTimeout.Start();
            });
        }

        private void btnTerms_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By registering for this program, you acknowledge that:\n"
                            + "1) Brainvire Ltd. and Ufix Ltd. do not profit from any of the results shown in this program.\n"
                            + "2) Results from the program may not be completely accurate to the users search."
                            ,"Terms of service", MessageBoxButtons.OK);
        }
    }
}
