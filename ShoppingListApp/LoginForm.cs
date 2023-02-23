using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Text.RegularExpressions;

namespace ShoppingListApp
{
    public partial class frmLogin : Form
    {
        //string username;
        //SecureString password;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginInfo_TextChanged(object sender, EventArgs e)
        {
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
            if (!LoginUtils.CreateUserFolders(txtUser.Text))
            {
                lblLoginResponse.Text = "Failed to create user folders.";
                return;
            }

            // ...

            lblLoginResponse.Text = "Register successful.";
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !LoginUtils.isUsernameCharValid(e.KeyChar);
        }
    }

    public static class LoginUtils
    {
        private static bool CreateFolder(string name, string dir = "")
        {
            try
            {
                if (dir == null) 
                    dir = Directory.GetCurrentDirectory();

                string profilesPath = Path.Combine(dir, name);

                // CreateDirectory won't do anything if the folder already exists
                Directory.CreateDirectory(profilesPath);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static bool CreateUserFolders(string username)
        {
            const string INITIAL_FOLDER = "profiles";
            string curDir = Directory.GetCurrentDirectory();

            if (!CreateFolder(INITIAL_FOLDER))
                return false;

            string tarDir = Path.Combine(curDir, INITIAL_FOLDER);
            if (!CreateFolder(username, tarDir))
                return false;

            return true;
        }

        public static bool isUsernameCharValid(char c)
        {
            Regex regexValidCharacter = new(@"^[A-Za-z0-9\b]");

            if (char.IsControl(c)) // allow shortcuts e.g. ctrl+c, ctrl+a etc.
                return true;

            return regexValidCharacter.IsMatch(c.ToString());
        }
    }
}
