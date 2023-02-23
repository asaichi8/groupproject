using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingListApp
{
    using System.Security;
    using System.Text.RegularExpressions;

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

        private void loginInfo_TextChanged(object sender, EventArgs e)
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

        private void cbx_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cbxShowPass.Checked;
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {

        }

        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regexValidCharacters = new(@"^[A-Za-z0-9\b]");

            if (char.IsControl(e.KeyChar)) // allow shortcuts e.g. ctrl+c, ctrl+a etc.
                return;

            e.Handled = !regexValidCharacters.IsMatch(e.KeyChar.ToString());
        }
    }
}
