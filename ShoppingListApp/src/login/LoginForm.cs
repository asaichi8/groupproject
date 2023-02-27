using ShoppingListApp.src.Login;
using ShoppingListApp.Properties;
using System.Collections.Generic;
using System.Net.Sockets;
using static System.Net.Mime.MediaTypeNames;

namespace ShoppingListApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
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

        private void cbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cbxShowPass.Checked;
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            // disallow any characters in the username textbox that aren't allowed in a username
            e.Handled = !LoginUtils.isUsernameCharValid(e.KeyChar);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string userDir = LoginUtils.GetUserDir(user);

            if (!Directory.Exists(userDir))
            {
                SetStatus("Invalid username.", Color.Red);
                return;
            }

            byte[]? hashedPassword = LoginUtils.ReadPasswordFile(user);
            if (hashedPassword is null || hashedPassword.Length != LoginUtils.PASSWORD_LENGTH_BYTES)
            {
                SetStatus("Could not read password file.", Color.Red);
                return;
            }

            if (!Hasher.VerifyHash(txtPassword.Text, hashedPassword))
            {
                SetStatus("Invalid password.", Color.Red);
                return;
            }

            // remember me
            Properties.Settings.Default.LastUsername = user;
            Reset();
            txtUser.Text = Properties.Settings.Default.LastUsername; // remember last username

            this.Hide();
            Form welcomeForm = new FormHomePage(this, user);
            welcomeForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Thread tRegister = new Thread(new ThreadStart(Register));
            tRegister.Start();
        }

        // TODO: make sure passwords are secure enough, maybe based on their entropy?
        //       https://en.wikipedia.org/wiki/Entropy_%28information_theory%29
        void Register()
        {
            SetStatus("Attempting to register...", Color.Orange);
            System.Windows.Forms.Application.UseWaitCursor = true;

            Invoke((MethodInvoker)delegate
            {
                SetLoginControlsEnabled(false);
            });

            Thread.Sleep(250);

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
                Invoke((MethodInvoker)delegate
                {
                    SetLoginControlsEnabled(true);
                });

                System.Windows.Forms.Application.UseWaitCursor = false;
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

        private void SetStatus(string status, Color color)
        {
            tmrResponseTimeout.Stop();
            tmrResponseTimeout.Start();

            Invoke((MethodInvoker)delegate
            {
                lblLoginResponse.Text = status;
                lblLoginResponse.ForeColor = color;
            });
        }

        private void tmrResponseTimeout_Tick(object sender, EventArgs e)
        {
            ((System.Windows.Forms.Timer)sender).Stop();

            if (this.Visible)
                lblLoginResponse.ResetText();
        }
    }
}
