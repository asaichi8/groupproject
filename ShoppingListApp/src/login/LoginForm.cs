using ShoppingListApp.src.login;

namespace ShoppingListApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

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
            if (!LoginUtils.CreateUserFolders(user))
            {
                lblLoginResponse.Text = "Failed to create user folders.";
                return;
            }

            byte[] hashedPassword = Hasher.Hash(txtPassword.Text);

            if (!LoginUtils.CreatePasswordFile(user, hashedPassword))
            {
                lblLoginResponse.Text = "Failed to store password.";
                return;
            }

            lblLoginResponse.Text = "Register successful.";
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
                lblLoginResponse.Text = "Invalid username.";
                return;
            }

            byte[]? hashedPassword = LoginUtils.ReadPasswordFile(user);
            if (hashedPassword == null || hashedPassword.Length != 64)
            {
                lblLoginResponse.Text = "Could not read password file.";
                return;
            }

            if (!Hasher.VerifyHash(txtPassword.Text, hashedPassword))
            {
                lblLoginResponse.Text = "Invalid password.";
                return;
            }

            // TODO: boot up welcome form instead of changing login response
            lblLoginResponse.Text = "success";
        }
    }
}
