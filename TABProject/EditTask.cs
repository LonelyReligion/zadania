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
    public partial class EditTask : Form
    {
        decimal task_id;
        IQueryable<worker_task> task = null;

        public EditTask()
        {
            InitializeComponent();
        }

        public EditTask(decimal task_id)
        {
            this.task_id = task_id;
            InitializeComponent();
        }

        private void FillComboBox()
        {
            using (var db = new TABContext())
            {
                var workerIds = db.app_user.Where(p => p.type == "Worker").Select(p => p.id_app_user).ToList();
                var stat = db.worker_task.Select(p => p.status).Distinct().ToList();
                var tas = db.worker_task.Find(task_id);

                cbWorker.DataSource = workerIds;
                cbStatus.DataSource = stat;
                cbWorker.SelectedItem = tas.id_worker;
                cbStatus.SelectedItem = tas.status;
                tbDesc.Text = tas.description;
            }
        }

        private void bReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EditTask_Load(object sender, EventArgs e)
        {
            using (var db = new TABContext())
            {
                var tas = db.worker_task.Find(task_id);

                String descc = tas.description;
                String statt = tas.status;
                String ress = tas.result;      
                String id_wor = tas.id_worker.ToString();
                tbTaskID.Text = "Id Task: " + this.task_id.ToString() + Environment.NewLine
                       + "Desc: " + descc + Environment.NewLine
                       + "Status: " + statt + Environment.NewLine
                       + "Worker ID: " + id_wor + Environment.NewLine
                       + "Res: " + ress;
            }

            FillComboBox();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            using (var db = new TABContext())
            {
                var tas = db.worker_task.Find(task_id);
          
                if (cbStatus.SelectedItem != null)
                {
                    tas.status = cbStatus.SelectedItem.ToString();
                }
                if (cbWorker.SelectedItem != null)
                {
                    tas.id_worker = (decimal)cbWorker.SelectedItem;
                }
                if (tbDesc.Text != null)
                {
                    tas.description = tbDesc.Text;
                }
                else
                {
                    tas.description = null;
                }
                db.SaveChanges();

                String descc = tas.description;
                String statt = tas.status;
                String ress = tas.result;
                String id_wor = tas.id_worker.ToString();
                tbTaskID.Text = "Id Task: " + this.task_id.ToString() + Environment.NewLine
                       + "Desc: " + descc + Environment.NewLine
                       + "Status: " + statt + Environment.NewLine
                       + "Worker ID: " + id_wor + Environment.NewLine
                       + "Res: " + ress;

            }
        }
    }
}
