namespace ShoppingListApp
{
    using System.Collections.Specialized;
    using System.Security;
    public partial class frm_HomePage : Form
    {
        string searchItem;
        public frm_HomePage()
        {
            InitializeComponent();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            searchItem = txt_Search.Text;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Form productPage = new SearchForm(searchItem);
            productPage.Show();
        }

        private void btn_ToList_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will link to the shopping list.");
        }
    }
}