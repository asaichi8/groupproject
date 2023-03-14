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
using System.Net.Http;
using System.Windows.Forms;

namespace ShoppingListApp
{
    public partial class FormSearch : Form
    {
        static HttpClient tescoScraperAPI = new HttpClient();

        public struct searchConditions
        {
            public string itemName;
        }

        public struct APIResults
        {
            string itemName;
            double price;
            string imageURL;
        }

        Form prevForm;

        public FormSearch(Form _prevForm, string _searchItem)
        {
            InitializeComponent();

            this.Icon = Properties.Resources.UFix_Logo_Icon;

            BorderlessUtils.MakeFormDraggable(this);

            // create minimise, maximise, close buttons
            CornerButton cb = new CornerButton(this);
            cb.CreateTitlebarButtons(FlatStyle.Flat, Color.Goldenrod);

            txtSearch.Text = _searchItem;
            prevForm = _prevForm;

            tescoScraperAPI.BaseAddress = new Uri("https://api.apify.com/v2/acts/jupri~tesco-grocery/run-sync-get-dataset-items?token=apify_api_PdfwX5PDapGYM6FV2CQI5oBeqvEnp82YBVWG");
            tescoScraperAPI.DefaultRequestHeaders.Accept.Clear();

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
            // show filter form
            Form filterForm = new FormFilter();
            filterForm.ShowDialog(this);
        }
    }
}
