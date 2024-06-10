using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

//AGA
namespace TABProject
{
    public partial class Worker : Form
    {
        IQueryable<worker_task> tasks = null;
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
                tasks = db.worker_task;
                dataGridView1.DataSource = tasks.ToList();
            }
        }

        private void Worker_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tABDataSet.worker_task' table. You can move, or remove it, as needed.
            this.worker_taskTableAdapter.Fill(this.tABDataSet.worker_task);
            // TODO: This line of code loads data into the 'tABDataSet3.worker_task' table. You can move, or remove it, as needed.
            //this.worker_taskTableAdapter.Fill(this.tABDataSet3.worker_task);
            dane();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            using (var db = new TABContext())
            {
                if (cbMine.Checked && dataTime.Checked)
                {
                    tasks = db.worker_task.Where(b => b.id_worker == worker_id).Where(b => b.dt_open.Year == dataTime.Value.Date.Year &&
                    b.dt_open.Month == dataTime.Value.Date.Month && b.dt_open.Day == dataTime.Value.Date.Day);
                }
                else if (cbMine.Checked)
                {
                     tasks = db.worker_task.Where(b => b.id_worker == worker_id);   
                }
                else if (dataTime.Checked)
                {
                    tasks = db.worker_task.Where(b => b.dt_open.Year == dataTime.Value.Date.Year &&
                    b.dt_open.Month == dataTime.Value.Date.Month && b.dt_open.Day == dataTime.Value.Date.Day);
                }
                else {
                    tasks = db.worker_task;
                }
                dataGridView1.DataSource = tasks.ToList();
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                using (var db = new TABContext())
                {
                    var tsk = db.worker_task.Find(row.Cells[0].Value);//id taska potrzebne do zmiany
                    if (rbInProg.Checked)
                    {
                        tsk.status = "in progr";
                        //tsk.result = textBox1.Text; //results
                        tsk.dt_final_cancel = null;
                    }
                    else if (rbCancel.Checked)
                    {
                        tsk.status = "canceled";
                        //tsk.result = textBox1.Text; //results
                        tsk.dt_final_cancel = DateTime.Now;
                    }
                    else if (rbFinal.Checked)
                    {
                        tsk.status = "closed";
                        tsk.result = textBox1.Text; //results
                        tsk.dt_final_cancel = DateTime.Now;
                    }
                    db.SaveChanges();
                    //dataGridView1.DataSource = tasks.ToList(); //niedziala:/
                    //dataGridView1.Refresh(); //niedziala:/
                }
            }catch(Exception ex)
            {
                //ktos nie zaznaczyl wiersza :/
            }
        }
    }
}
