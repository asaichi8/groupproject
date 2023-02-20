using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_List_App__.NET_
{
    public partial class frm_Login : Form
    {
        string username;
        string password;

        public frm_Login()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txt_User_TextChanged(object sender, EventArgs e)
        {
            username = txt_User.Text;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            // This whole section will be built upon, basic for now.

            if (txt_User.Text == "admin" && txt_Pass.Text == "Password")
            {
                MessageBox.Show("Welcome administrator!", "Sign in successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Sign in error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbx_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_ShowPass.Checked)
            {
                txt_Pass.PasswordChar = '\0';  // If the show bassword box is checked, then get rid of the password char.
            }

            else
            {
                txt_Pass.PasswordChar = '•';
            }
        }
    }
}
