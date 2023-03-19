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
            public string itemName;
            public double price;
            public string imageURL;
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

            searchConditions conditions = new searchConditions();

            txtSearch.Text = _searchItem;
            prevForm = _prevForm;
            txtTescoName.Enabled = false;
            txtTescoPrice.Enabled = false;

            txtAsdaName.Enabled = false;
            txtAsdaPrice.Enabled = false;

            conditions.itemName = _searchItem;

            tescoScraperAPI.BaseAddress = new Uri("https://api.apify.com/v2/acts/jupri~tesco-grocery/run-sync-get-dataset-items?token=apify_api_PdfwX5PDapGYM6FV2CQI5oBeqvEnp82YBVWG");
            tescoScraperAPI.DefaultRequestHeaders.Accept.Clear();
            wbvSainsburys.EnsureCoreWebView2Async(default, default);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchItem = txtSearch.Text;
                var apiResults = await GetItemDataFromAPIAsync(searchItem);

                if (apiResults.HasValue)
                {
                    txtTescoName.Text = "Item Name: " + apiResults.Value.itemName;
                    txtTescoPrice.Text = "Item Price: " + apiResults.Value.price.ToString("C2");

                    // Load the image from the URL
                    Image itemImage = await LoadImageFromUrlAsync(apiResults.Value.imageURL);
                    pbxTesco.Image = itemImage;
                }
                else
                {
                    txtTescoName.Text = "Item Name: Not found";
                    txtTescoPrice.Text = "Item Price: -";
                    pbxTesco.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task<APIResults?> GetItemDataFromAPIAsync(string searchItem)
        {
            HttpResponseMessage response = await tescoScraperAPI.GetAsync($"&kw={searchItem}");

            if (response.IsSuccessStatusCode)
            {
                var items = await response.Content.ReadAsAsync<List<APIResults>>();
                if (items.Count > 0)
                {
                    return new APIResults
                    {
                        itemName = items[0].itemName,
                        price = items[0].price,
                        imageURL = items[0].imageURL
                    };
                }
                else
                {
                    return null;
                }
            }
            else


            {
                throw new Exception("Failed to retrieve data from the API.");
            }
        }

        private async Task<Image> LoadImageFromUrlAsync(string url)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    return Image.FromStream(stream);
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // show filter form
            Form filterForm = new FormFilter();
            filterForm.ShowDialog(this);
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {

        }

        private void pbxTesco_Click(object sender, EventArgs e)
        {

        }

        private void txtTescoName_TextChanged(object sender, EventArgs e)
        {
            if (txtTescoName.Text == "Not found")
            {
                txtTescoName.Text = "Item Name: Not found";
            }
            else
            {
                txtTescoName.Text = "Item Name: " + txtTescoName.Text;
            }
        }

        private void txtTescoPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtTescoPrice.Text == "-")
            {
                txtTescoPrice.Text = "Item Price: -";
            }
            else
            {
                txtTescoPrice.Text = "Item Price: " + txtTescoPrice.Text;
            }
        }
    }

}
