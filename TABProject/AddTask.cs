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
    public partial class AddTask : Form
    {
        private decimal id_issue;

        public AddTask()
        {
            InitializeComponent();
            FillComboBox();
        }
        public AddTask(decimal id_issue)
        {
            this.id_issue = id_issue;
            InitializeComponent();
            FillComboBox();
        }
        private void FillComboBox()
        {
            using (var db = new TABContext())
            {
                var workerIds = db.app_user.Where(p => p.type == "Worker").Select(p => p.id_app_user).ToList();
                
                cbWorkerID.DataSource = workerIds;
            }
        }

        private void bReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            String descc = tbDesc.Text;
            decimal worker_id = (decimal)cbWorkerID.SelectedItem;
            DateTime dtOpen = DateTime.Now;

            using (var db = new TABContext())
            {
                var newRecord = new worker_task
                {
                    status = "Open",
                    id_worker = worker_id,
                    description = descc,
                    dt_open = dtOpen,
                    id_issue = id_issue,
                    result = " "
                };

                db.worker_task.Add(newRecord);

                db.SaveChanges();

            }

            this.Hide();
        }
    }
}
