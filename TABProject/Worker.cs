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
    public partial class Worker : Form
    {
        public Worker()
        {
            InitializeComponent();
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            new LoginView().Show();
            this.Hide();
        }

        private void Worker_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tABDataSet3.worker_task' table. You can move, or remove it, as needed.
            this.worker_taskTableAdapter.Fill(this.tABDataSet3.worker_task);

        }
    }
}
