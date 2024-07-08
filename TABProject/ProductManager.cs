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
    public partial class ProductManager : Form
    {

        decimal prodm_id;
        decimal issuse_id;
        decimal task_id;

        IQueryable<worker_task> task = null;

        private void dane()
        {
            using (var db = new TABContext())
            {
                task = db.worker_task.Where(b => b.id_issue == issuse_id);
                dataGridView1.DataSource = task.ToList();
            }
        }

        public ProductManager()
        {
            InitializeComponent();
        }
        public ProductManager(decimal id_issue)
        {
            this.issuse_id = id_issue;
            InitializeComponent();
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            new LoginView().Show();
            this.Hide();
        }

        private void bAddNewTask_Click(object sender, EventArgs e)
        {
            new AddTask().ShowDialog();
            //this.Hide();
        }

        private void lRequest_Click(object sender, EventArgs e)
        {

        }

        private void bReturn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void bAddNewTask_Click_1(object sender, EventArgs e)
        {
            new AddTask(issuse_id).ShowDialog();
            dane();
        }

        private void bEditTask_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                using (var db = new TABContext())
                {
                    var tas = db.worker_task.Find(row.Cells[0].Value);//id taska potrzebne do zmiany
                    task_id = tas.id_worker_task;
                }
                EditTask editTask = new EditTask(task_id); //, this);
                editTask.ShowDialog();
                dane();
            }
            catch (Exception ex)
            {
                //ktos nie zaznaczyl wiersza :/
            }

            //new EditTask(task_id).Show();
            //this.Hide();
        }

        private void ProductManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tABDataSet.worker_task' table. You can move, or remove it, as needed.
            this.worker_taskTableAdapter.Fill(this.tABDataSet.worker_task);
            using (var db = new TABContext())
            {
                var iss = db.issues.Find(issuse_id);
                String desc = iss.description;
                String stat = iss.status;
                String res = iss.result;
                String pm_id = iss.id_product_manager.ToString();
                tbIssueID.Text = "Id Reqst: " + this.issuse_id.ToString() + Environment.NewLine +
                  "Desc: " + desc + Environment.NewLine +
                  "Status: " + stat + Environment.NewLine +
                  "Res: " + res + Environment.NewLine +
                  "Id ProdMan: " + pm_id;
            }
            dane();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            try
            {
                //DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                using (var db = new TABContext())
                {
                    var iss = db.issues.Find(issuse_id);
                    if (rbInProgress.Checked)
                    {
                        iss.status = "in progr";
                        //iss.result = tbResult.Text; //results
                        iss.dt_final_cancel = null;
                    }
                    else if (rbCancel.Checked)
                    {
                        iss.status = "cancelled";
                        //iss.result = tbResult.Text; //results
                        iss.dt_final_cancel = DateTime.Now;
                    }
                    else if (rbFinal.Checked)
                    {
                        iss.status = "closed";
                        iss.result = tbResult.Text; //results
                        iss.dt_final_cancel = DateTime.Now;
                    }
                    db.SaveChanges();
                    //dataGridView1.DataSource = tasks.ToList(); //niedziala:/
                    //dataGridView1.Refresh(); //niedziala:/
                    String desc = iss.description;
                    String stat = iss.status;
                    String res = iss.result;
                    String pm_id = iss.id_product_manager.ToString();
                    tbIssueID.Text = "Id Reqst: " + this.issuse_id.ToString() + Environment.NewLine +
                      "Desc: " + desc + Environment.NewLine +
                      "Status: " + stat + Environment.NewLine +
                      "Res: " + res + Environment.NewLine +
                      "Id ProdMan: " + pm_id;
                }
            }
            catch (Exception ex)
            {
                //ktos nie zaznaczyl wiersza :/
            }
        }

        private void bDeleteTask_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult result = MessageBox.Show("Are you sure you want to delete this task?", "Delete task", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                    using (var db = new TABContext())
                    {
                        var tas = db.worker_task.Find(row.Cells[0].Value);//id taska potrzebne do zmiany

                        db.worker_task.Remove(tas);
                        db.SaveChanges();
                        dane();

                    }
                }
                else
                {
                    // Użytkownik anulował operację usuwania, nie rób nic
                }

            }
            catch (Exception ex)
            {
                //ktos nie zaznaczyl wiersza :/
            }
        }
    }
}
