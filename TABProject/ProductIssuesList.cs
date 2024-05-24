using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TABProject
{
    public partial class ProductIssuesList : Form
    {
        public ProductIssuesList()
        {
            InitializeComponent();
        }

        private void bSelect_Click(object sender, EventArgs e)
        {
            new ProductManager().Show();
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            new LoginView().Show();
            this.Hide();
        }
    }
}
