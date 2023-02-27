﻿using ShoppingListApp.src;
using System.Windows.Forms.DataVisualization.Charting;

namespace ShoppingListApp
{
    public partial class FormList : Form
    {
        readonly Form prevForm;
        readonly string username;
        public FormList(Form _prevForm, string _username)
        {
            InitializeComponent();
            this.Icon = Properties.Resources.UFix_Logo_Icon;
            prevForm = _prevForm;
            username = _username;
        }

        private void frmList_Load(object sender, EventArgs e)
        {
            CenterToParent();
            lblListForUser.Text = $"Showing list for user {username}...";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
