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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace ShoppingListApp
{
    public partial class FormSearch : Form
    {
        static HttpClient tescoScraperAPI = new HttpClient();
        static HttpClient asdaScraperAPI = new HttpClient();

        static HttpClient tescoAPIResults = new HttpClient();
        static HttpClient asdaAPIResults = new HttpClient();

        public struct TescoSearchConditions
        {
            public string query; // The names of the structs are the same as the expected API input.
            public int page;
            public int limit;
            public string sort;

            public TescoSearchConditions(string itemName)
            {
                query = itemName;
                page = 1;
                limit = 1;
                sort = "price-ascending";
            }
        }

        public struct AsdaSearchConditions
        {
            public string keywords;
            public int limit;
            public int page;

            public AsdaSearchConditions(string itemName)
            {
                keywords = itemName;
                limit = 1;
                page = 0;
            }
        }

        public struct APIResults
        {
            public string title;
            public string image;
            public string price;
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

            tescoScraperAPI.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            tescoAPIResults.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            asdaScraperAPI.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            asdaAPIResults.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            callAPIs(_searchItem);

            wbvSainsburys.EnsureCoreWebView2Async(default, default);
        }

        private async void callAPIs(string itemName)
        {
            pbxTesco.Image = Properties.Resources.loading;
            pbxAsda.Image = Properties.Resources.loading;

            TescoSearchConditions tescoConditions = new TescoSearchConditions(itemName);
            AsdaSearchConditions asdaConditions = new AsdaSearchConditions(itemName);

            // create a new thread for each shop
            Task tescoThread = Task.Run(async () =>
            {
                await tescoScraperAPI.PostAsJsonAsync("https://api.apify.com/v2/acts/jupri~tesco-grocery/run-sync-get-dataset-items?token=apify_api_PdfwX5PDapGYM6FV2CQI5oBeqvEnp82YBVWG", tescoConditions);

                HttpResponseMessage tescoResponse = await tescoAPIResults.GetAsync("https://api.apify.com/v2/acts/jupri~tesco-grocery/runs/last/dataset/items?token=apify_api_PdfwX5PDapGYM6FV2CQI5oBeqvEnp82YBVWG");
                string tescoJson = await tescoResponse.Content.ReadAsStringAsync();
                var parsedTescoJson = JArray.Parse(tescoJson);

                if (parsedTescoJson.Count > 0)
                {
                    var tescoResults = parsedTescoJson[0];

                    // controls are on a seperate thread, so we invoke to access them
                    Invoke((MethodInvoker)delegate
                    {
                        txtTescoName.Text = tescoResults["title"].ToString();
                        txtTescoPrice.Text = tescoResults["price"].ToString();
                        pbxTesco.ImageLocation = tescoResults["image"].ToString();
                    });
                }
            });

            Task asdaThread = Task.Run(async () =>
            {
                /// TODO: asda search returns the same thing every time, pls fix
                HttpResponseMessage asdaResponse = await asdaAPIResults.GetAsync("https://api.apify.com/v2/acts/jupri~asda-scraper/runs/last/dataset/items?token=apify_api_PdfwX5PDapGYM6FV2CQI5oBeqvEnp82YBVWG");
                string asdaJson = await asdaResponse.Content.ReadAsStringAsync();
                var parsedAsdaJson = JArray.Parse(asdaJson);

                if (parsedAsdaJson.Count > 0)
                {
                    var asdaResults = parsedAsdaJson[0];

                    Invoke((MethodInvoker)delegate
                    {
                        txtAsdaName.Text = asdaResults["item"]["picker_desc"].ToString();
                        txtAsdaPrice.Text = asdaResults["price"]["price_info"]["price"].ToString();
                        pbxAsda.ImageLocation = string.Concat(asdaResults["item"]["images"]["scene7_host"].ToString(), asdaResults["item"]["images"]["scene7_id"].ToString());
                    });
                }
            });

            // wait for all the tasks to be completed
            await Task.WhenAll(tescoThread, asdaThread);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            callAPIs(txtSearch.Text);

            /*
            try
            {
                string searchItem = txtSearch.Text;
                //var apiResults = await GetItemDataFromAPIAsync(searchItem);

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
            */
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

        private void txtTescoName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTescoPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
