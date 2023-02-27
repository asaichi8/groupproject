using ShoppingListApp.src;
using ShoppingListApp.src.search;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core;
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
            //wbv_Asda.EnsureCoreWebView2Async(default, default);
            //wbv_Tesco.EnsureCoreWebView2Async(default, default);
            //wbv_Sainsburys.EnsureCoreWebView2Async(default, default);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            prevForm.SwapForm(this, true);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //wbv_Asda.CoreWebView2.Navigate("https://groceries.asda.com/search/" + txtSearch.Text + "/products?sort=price+asc");
            //wbv_Tesco.CoreWebView2.Navigate("https://www.tesco.com/groceries/en-GB/search?query=" + txtSearch.Text + "&sortBy=price-ascending");
            //wbv_Sainsburys.CoreWebView2.Navigate("https://www.sainsburys.co.uk/gol-ui/SearchResults/"+ txtSearch.Text + "/category:/sort:price");
        }

        // this button doesn't exist?
        private void btn_Filter_Click(object sender, EventArgs e)
        {
            Form filterForm = new FormFilter();
            filterForm.ShowDialog();
        }
    }
}
