namespace ShoppingListApp
{
    using System.Collections.Specialized;
    using System.Security;
    public partial class frmHomePage : Form
    {
        string searchItem;
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            searchItem = txtSearch.Text;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Form productPage = new frmSearch(searchItem);
            productPage.Show();
        }

        private void btn_ToList_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will link to the shopping list.");
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {

        }
    }
}