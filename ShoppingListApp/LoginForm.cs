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

    public partial class frm_Login : Form
    {
        //string username;
        //SecureString password;
        public frm_Login()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginInfo_TextChanged(object sender, EventArgs e)
        {
            if (txt_password.Text.Length == 0 || txt_user.Text.Length == 0)
            {
                btn_Login.Enabled = false;
                btn_Register.Enabled = false;
                return;
            }

            btn_Login.Enabled = true;
            btn_Register.Enabled = true;
        }

        private void cbx_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = !cbx_showPass.Checked;
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
