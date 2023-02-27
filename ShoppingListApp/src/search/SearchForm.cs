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
            this.Icon = Properties.Resources.UFix_Logo_Icon;
            BorderlessUtils.HookUninteractableControls(this);

            BorderlessUtils bu = new BorderlessUtils(this);
            bu.CreateCloseButton(FlatStyle.Flat, Color.Goldenrod);

            txtSearch.Text = _searchItem;
            prevForm = _prevForm;
            //wbvAsda.EnsureCoreWebView2Async(default, default);
            //wbvTesco.EnsureCoreWebView2Async(default, default);
            //wbvSainsburys.EnsureCoreWebView2Async(default, default);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //wbvAsda.CoreWebView2.Navigate("https://groceries.asda.com/search/" + txtSearch.Text + "/products?sort=price+asc");
            //wbvTesco.CoreWebView2.Navigate("https://www.tesco.com/groceries/en-GB/search?query=" + txtSearch.Text + "&sortBy=price-ascending");
            //wbvSainsburys.CoreWebView2.Navigate("https://www.sainsburys.co.uk/gol-ui/SearchResults/"+ txtSearch.Text + "/category:/sort:price");
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Form filterForm = new FormFilter();
            filterForm.ShowDialog(this);
        }
    }
}
