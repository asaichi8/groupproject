using ShoppingListApp.src;
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
    public partial class FormSearch : Form
    {
        Form prevForm;
        public FormSearch(Form _prevForm, string _searchItem)
        {
            InitializeComponent();
            txtSearch.Text = _searchItem;
            prevForm = _prevForm;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            prevForm.SwapForm(this, true);
        }
    }
}
