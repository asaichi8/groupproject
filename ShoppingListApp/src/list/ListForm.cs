using ShoppingListApp.src;

namespace ShoppingListApp
{
    public partial class FormList : Form
    {
        readonly Form prevForm;
        readonly string username;
        public FormList(Form _prevForm, string _username)
        {
            InitializeComponent();
            prevForm = _prevForm;
            username = _username;
        }

        private void frmList_Load(object sender, EventArgs e)
        {
            CenterToParent();
            lblListForUser.Text = $"Showing list for user {username}...";
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            prevForm.SwapForm(this, true);
        }
    }
}
