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
    public partial class frmSearch : Form
    {
        //string searchItem;
        public frmSearch(string searchItem)
        {
            InitializeComponent();
            if (searchItem != null)
            {
                txtSearch.Text = searchItem;
            }
        }
    }
}
