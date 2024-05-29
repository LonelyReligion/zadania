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
        decimal worker_id;
        public Worker(decimal worker_id)
        {
            this.worker_id = worker_id;
            InitializeComponent();
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            new LoginView().Show();
            this.Hide();
        }

        private void dane()
        {
            using (var db = new TABContext())
            {
                var tasks = db.worker_task
                   .Where(b => b.id_worker == worker_id);
                    dataGridView1.DataSource = tasks.ToList();
            }
        }
        private void Worker_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tABDataSet3.worker_task' table. You can move, or remove it, as needed.
            //this.worker_taskTableAdapter.Fill(this.tABDataSet3.worker_task);
            dane();
        }
    }
}
