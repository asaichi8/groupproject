namespace ShoppingListApp
{
    public partial class frmHomePage : Form
    {
        Form frmLogin;
        string username;
        string? searchItem;

        public frmHomePage(Form _frmLogin, string _username)
        {
            InitializeComponent();
            username = _username;
            frmLogin = _frmLogin;
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"User: {username}";
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            searchItem = txtSearch.Text;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (searchItem is null)
                return;

            Form productPage = new frmSearch(searchItem);
            productPage.Show();
        }

        private void btn_ToList_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will link to the shopping list.");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // set the location of frmLogin to the center of the current form
            frmLogin.Location = new Point(
                this.Location.X + (this.Size.Width / 2) - (frmLogin.Size.Width / 2),
                this.Location.Y + (this.Size.Height / 2) - (frmLogin.Size.Height / 2)
            );

            frmLogin.Show();
            Close();
        }
    }
}