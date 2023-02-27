﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingListApp.src.search
{
    public partial class FormFilter : Form
    {
        readonly Point INITIAL_CBX_POS = new Point(12, 14);
        readonly int CBX_DIFF_Y = 8;

        public FormFilter()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.UFix_Logo_Icon;
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            if (Shop.AllShops.Count == 0)
            {
                MessageBox.Show("ERROR: No shops were found. Please contact an admin.", "No shops found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
                return;
            }

            CreateCheckboxes();
        }

        private void FilterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveFilters();
        }


        private void CreateCheckboxes()
        {
            // dynamically create new checkboxes for each shop
            Point lastCbxPos = INITIAL_CBX_POS;

            foreach (Shop shop in Shop.AllShops)
            {
                // create a new CheckBox control
                CheckBox cbx = new CheckBox
                {
                    Location = lastCbxPos,
                    Name = "cbxFilter" + shop.Name,
                    Text = shop.Name,
                    Checked = shop.IsFiltered
                };

                grpShops.Controls.Add(cbx);

                int newSpace = INITIAL_CBX_POS.Y + CBX_DIFF_Y; // amount of new space created by adding button

                btnClose.Location = new Point(btnClose.Location.X, btnClose.Location.Y + newSpace);
                grpShops.Size = new Size(grpShops.Width, grpShops.Height + newSpace);
                this.Size = new Size(this.Width, this.Height + newSpace);

                lastCbxPos = new Point(lastCbxPos.X, lastCbxPos.Y + newSpace);
            }
        }

        // save results to Shop.allShops
        private void SaveFilters()
        {
            // for each checkbox in the group that owns a tag...
            foreach (CheckBox cbx in grpShops.Controls.OfType<CheckBox>())
            {
                // will throw an exception if nothing is found, but that should never happen
                Shop shop = Shop.AllShops.First(shop => shop.Name == cbx.Text);

                if (shop is null)
                    continue;

                shop.IsFiltered = cbx.Checked;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
