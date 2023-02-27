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
        public FormFilter()
        {
            InitializeComponent();
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            // dynamically size filter box
            // dynamically load names of all shops into checkboxes
        }

        private void FilterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // save results to Shop.allShops

            /*foreach (Shop shop in Shop.AllShops) 
            {
                
            }*/
        }
    }
}
