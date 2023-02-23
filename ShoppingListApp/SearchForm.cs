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
    public partial class SearchForm : Form
    {
        //string searchItem;
        public SearchForm(string searchItem)
        {
            InitializeComponent();
            if(searchItem != null)
            {
                txt_Search.Text = searchItem;
            }
        }
    }
}
