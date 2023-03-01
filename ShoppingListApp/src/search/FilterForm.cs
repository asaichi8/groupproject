using System;
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

            BorderlessUtils.MakeFormDraggable(this);

            // borderless filter is too ambiguous
            //BorderlessUtils bu = new BorderlessUtils(this);
            //bu.CreateTitlebarButtons(FlatStyle.Flat, Color.Goldenrod);
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            if (Shop.AllShops.Count == 0)
                throw new InvalidOperationException("No shops were found. Add at least one shop before using the application.");

            CreateCheckboxes();
        }

        private void FilterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveFilters();
        }

        /// <summary>
        /// Dynamically creates a CheckBox control for each shop and adds it to the form.
        /// </summary>
        /// <remarks>
        /// Each CheckBox control is positioned below the previous one and its text and checked state are
        /// set based on the corresponding shop's name and filter status.
        /// </remarks>
        private void CreateCheckboxes()
        {
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

        /// <summary>
        /// Saves the filter settings for each shop based on the corresponding CheckBox control's checked state.
        /// </summary>
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
