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
    public partial class ACCRequestList : Form
    {
        public ACCRequestList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ACCManager requestDetailFrm = new ACCManager(1);
            requestDetailFrm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            new LoginView().Show();
            this.Hide();
        }

        private void ACCRequestList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tABDataSet2.request' table. You can move, or remove it, as needed.
            this.requestTableAdapter1.Fill(this.tABDataSet2.request);
            // TODO: This line of code loads data into the 'tABDataSet2.app_user' table. You can move, or remove it, as needed.
            this.app_userTableAdapter1.Fill(this.tABDataSet2.app_user);
            // TODO: This line of code loads data into the 'tABDataSet1.request' table. You can move, or remove it, as needed.
            this.requestTableAdapter.Fill(this.tABDataSet1.request);
            // TODO: This line of code loads data into the 'tABDataSet.app_user' table. You can move, or remove it, as needed.
            this.app_userTableAdapter.Fill(this.tABDataSet.app_user);

        }
    }
}
