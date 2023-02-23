﻿using System;
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
using System.Security.Cryptography;
using Konscious.Security.Cryptography;

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

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
