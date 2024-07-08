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
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            new LoginView().Show();
            this.Hide();
        }

        private void lEmail_Click(object sender, EventArgs e)
        {

        }

        private void bDelete_Click(object sender, EventArgs e)
        {

        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSet1.app_user' . Możesz go przenieść lub usunąć.
            this.app_userTableAdapter1.Fill(this.dataSet1.app_user);
            // TODO: This line of code loads data into the 'tABDataSet.app_user' table. You can move, or remove it, as needed.
            this.app_userTableAdapter.Fill(this.tABDataSet.app_user);

        }
    }
}
