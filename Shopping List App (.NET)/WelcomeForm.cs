using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_List_App__.NET_
{
    public partial class frm_HomePage : Form
    {
        string searchItem;

        public frm_HomePage()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Form productPage;
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            searchItem = txt_Search.Text;
        }
    }
}
