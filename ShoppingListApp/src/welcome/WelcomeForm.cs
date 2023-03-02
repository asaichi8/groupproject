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

            this.Icon = Properties.Resources.UFix_Logo_Icon;

            BorderlessUtils.MakeFormDraggable(this);

            // create minimise, maximise, close buttons
            CornerButton cb = new CornerButton(this);
            cb.CreateTitlebarButtons(FlatStyle.Flat, Color.Goldenrod);

            frmLogin = _frmLogin;
            username = _username;

            this.Text = "Welcome - " + username;
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

            // show search form
            Form productPage = new FormSearch(this, searchItem);
            productPage.ShowDialog(this);
            productPage.CenterChild(this);
        }

        private void btnToList_Click(object sender, EventArgs e)
        {
            // show list form
            Form formList = new FormList(this, username);
            formList.ShowDialog(this);
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

        /// <summary>
        /// Called when logging out. Resets variables to get ready for the next user to log in.
        /// </summary>
        void Logout()
        {
            Shop.DisableAllFilters();
        }
    }
}