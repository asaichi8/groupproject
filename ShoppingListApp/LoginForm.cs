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
    public partial class frm_Login : Form
    {
        string username;
        SecureString password;
        public frm_Login()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {
            username = txt_password.Text;
        }
    }
}
