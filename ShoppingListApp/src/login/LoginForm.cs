using ShoppingListApp.src.Login;
using ShoppingListApp.Properties;
using System.Collections.Generic;
using System.Net.Sockets;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Text;

namespace ShoppingListApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.UFix_Logo_Icon;
            HookUninteractableControls();
        }

        private void Uninteractable_MouseDown(object sender, MouseEventArgs e)
        {

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
            e.Handled = !LoginUtils.isUsernameCharValid(e.KeyChar);
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                return AttemptLogin(txtUser.Text);
            }).ContinueWith(task =>
            {
                if (task.Result)
                    LoginComplete();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            await Task.Run(() => { Register(); });
        }



        bool AttemptLogin(string user)
        {
            Invoke((MethodInvoker)delegate
            {
                SetLoginControlsEnabled(false);
            });

            SetStatus("Logging in...", Color.Orange, false);
            System.Windows.Forms.Application.UseWaitCursor = true;

            Thread.Sleep(250);

            try
            {
                string userDir = LoginUtils.GetUserDir(user);

                if (!Directory.Exists(userDir))
                {
                    SetStatus("Invalid username.", Color.Red);
                    return false;
                }

                byte[]? hashedPassword = LoginUtils.ReadPasswordFile(user);
                if (hashedPassword is null || hashedPassword.Length != LoginUtils.PASSWORD_LENGTH_BYTES)
                {
                    SetStatus("Could not read password file.", Color.Red);
                    return false;
                }

                if (!Hasher.VerifyHash(txtPassword.Text, hashedPassword))
                {
                    SetStatus("Invalid password.", Color.Red);
                    return false;
                }

                return true;
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

        void LoginComplete()
        {
            // remember me
            string user = txtUser.Text;
            Properties.Settings.Default.LastUsername = user;
            Reset();
            txtUser.Text = Properties.Settings.Default.LastUsername; // remember last username

            this.Hide();
            Form welcomeForm = new FormHomePage(this, user);
            welcomeForm.Show();
        }

        // TODO: make sure passwords are secure enough, maybe based on their entropy?
        //       https://en.wikipedia.org/wiki/Entropy_%28information_theory%29
        void Register()
        {
            Invoke((MethodInvoker)delegate
            {
                SetLoginControlsEnabled(false);
            });

            SetStatus("Attempting to register...", Color.Orange);
            System.Windows.Forms.Application.UseWaitCursor = true;

            Thread.Sleep(500);

            try
            { 
                string user = txtUser.Text;

                bool? bCreateUserFolder = LoginUtils.CreateUserFolders(user);
                if (bCreateUserFolder is null)
                {
                    SetStatus("Failed to create user folders.", Color.Red);
                    return;
                }
                else if (bCreateUserFolder is false)
                {
                    SetStatus("Username already exists.", Color.Red);
                    return;
                }

                byte[] hashedPassword = Hasher.Hash(txtPassword.Text);

                if (!LoginUtils.CreatePasswordFile(user, hashedPassword))
                {
                    SetStatus("Failed to store password.", Color.Red);
                    return;
                }

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

        private void Reset()
        {
            txtPassword.ResetText();
            lblLoginResponse.ResetText();
            cbxShowPass.Checked = false;
        }

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

        private void HookUninteractableControls()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button || c is CheckBox || c is TextBox)
                    continue;

                c.MouseDown += Uninteractable_MouseDown;
            }

            this.MouseDown += Uninteractable_MouseDown;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
