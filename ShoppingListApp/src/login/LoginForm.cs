using ShoppingListApp.src.Login;
using ShoppingListApp.Properties;

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
                btnLogin.Enabled = false;
                btnRegister.Enabled = false;
                return;
            }

            btnLogin.Enabled = true;
            btnRegister.Enabled = true;
        }

        private void cbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cbxShowPass.Checked;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // TODO: make sure passwords are secure enough, maybe based on their entropy?
            //       https://en.wikipedia.org/wiki/Entropy_%28information_theory%29
            string user = txtUser.Text;

            bool? bCreateUserFolder = LoginUtils.CreateUserFolders(user);
            if (bCreateUserFolder is null)
            {
                SetStatus(lblLoginResponse, "Failed to create user folders.", Color.Red);
                return;
            }
            else if (bCreateUserFolder is false)
            {
                SetStatus(lblLoginResponse, "Username already exists.", Color.Red);
                return;
            }

            byte[] hashedPassword = Hasher.Hash(txtPassword.Text);

            if (!LoginUtils.CreatePasswordFile(user, hashedPassword))
            {
                SetStatus(lblLoginResponse, "Failed to store password.", Color.Red);
                return;
            }

            SetStatus(lblLoginResponse, "Register successful.", Color.Green);
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
                SetStatus(lblLoginResponse, "Invalid username.", Color.Red);
                return;
            }

            byte[]? hashedPassword = LoginUtils.ReadPasswordFile(user);
            if (hashedPassword is null || hashedPassword.Length != LoginUtils.PASSWORD_LENGTH_BYTES)
            {
                SetStatus(lblLoginResponse, "Could not read password file.", Color.Red);
                return;
            }

            if (!Hasher.VerifyHash(txtPassword.Text, hashedPassword))
            {
                SetStatus(lblLoginResponse, "Invalid password.", Color.Red);
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

        private void Reset()
        {
            txtPassword.ResetText();
            lblLoginResponse.ResetText();
            cbxShowPass.Checked = false;
        }

        private void SetStatus(object o, string status, Color color)
        {
            if (o is not Label label)
                return;

            tmrResponseTimeout.Stop();
            tmrResponseTimeout.Start();
            label.Text = status;
            label.ForeColor = color;
        }

        private void tmrResponseTimeout_Tick(object sender, EventArgs e)
        {
            ((System.Windows.Forms.Timer)sender).Stop();

            if (this.Visible)
                lblLoginResponse.ResetText();
        }
    }
}
