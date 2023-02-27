using ShoppingListApp.src;
using ShoppingListApp.src.search;

namespace ShoppingListApp
{
    public partial class FormHomePage : Form
    {
        readonly Form frmLogin;
        readonly string username;
        string? searchItem;

        public FormHomePage(Form _frmLogin, string _username)
        {
            InitializeComponent();
            username = _username;
            frmLogin = _frmLogin;
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"User: {username}";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchItem = txtSearch.Text;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (searchItem is null)
            {
                MessageBox.Show("Please enter the product name before attempting to search.", "Could not search",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form productPage = new FormSearch(this, searchItem);
            productPage.SwapForm(this);
            productPage.CenterChild(this);
        }

        private void btnToList_Click(object sender, EventArgs e)
        {
            Form formList = new FormList(this, username);
            formList.SwapForm(this);
            formList.CenterChild(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin.SwapForm(this, true);
            Logout();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Form frmFilter = new FormFilter();
            frmFilter.ShowDialog(this);
        }

        private void FormHomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
                return;

            frmLogin.Show();
            Logout();
        }

        void Logout()
        {
            Shop.DisableAllFilters();
        }
    }
}