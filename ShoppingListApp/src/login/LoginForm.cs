﻿using ShoppingListApp.src.Login;
using ShoppingListApp.src;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Net.Sockets;

namespace ShoppingListApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.UFix_Logo_Icon; 

            BorderlessUtils.MakeFormDraggable(this);

            // create minimise, maximise, close buttons
            CornerButton cb = new CornerButton(this);
            cb.CreateTitlebarButtons(FlatStyle.Flat, Color.Goldenrod);
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
            // asynchronously run the Register method so the ui doesn't hang while registering
            await Task.Run(() => { Register(); });
        }

        static int failedLogins = 0;
        private void LoginFailed()
        {
            const int MAX_FAILED_LOGINS = 3;

            failedLogins++;

            if (failedLogins < MAX_FAILED_LOGINS)
                return;

            DisableLoginSystem();

            failedLogins = 0;
        }

        public delegate void DisableLoginSystemHandler();
        private async void DisableLoginSystem()
        {
            if (InvokeRequired) // if caller is on a different thread...
            {
                // ...invoke same function current thread
                Invoke(new DisableLoginSystemHandler(DisableLoginSystem), new object[] { });
                return;
            }
            const int UPDATE_TIME = 1;
            int banTime = 60;

            System.Windows.Forms.Application.UseWaitCursor = false;

            SetLoginControlsEnabled(false);

            while (banTime > 1)
            {
                banTime--;
                SetStatus($"Too many failed attempts. Try again in {banTime} seconds.", Color.Maroon);
                await Task.Delay(TimeSpan.FromSeconds(UPDATE_TIME));
            }

            SetStatus("", Color.Black);
            SetLoginControlsEnabled(true);
        }

        /// <summary>
        /// Attempt to authenticate user's login details.
        /// </summary>
        /// <param name="user">Username of the user attempting to log in.</param>
        /// <returns>TRUE if login is successful, FALSE otherwise.</returns>
        bool AttemptLogin(string user)
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
        void LoginComplete()
        {
            // remember me
            string user = txtUser.Text;
            Properties.Settings.Default.LastUsername = user;
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
        void Register()
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

#if !DEBUG
                /* passwords must contain:
                //  - minimum 8 characters
                //  - one uppercase character
                //  - one lowercase character
                //  - one number
                //  - one special character     */
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
        void SetLoginControlsEnabled(bool enabled, bool buttonsOnly = false)
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
    }
}
