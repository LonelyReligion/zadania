using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TABProject
{
    public partial class ACCManager : Form
    {
        decimal acc_id;
        decimal request_id;
        decimal issuse_id;

        IQueryable<issue> issue = null;

        private void dane()
        {
            using (var db = new TABContext())
            {
                issue = db.issues.Where(b => b.id_request == request_id);
                dataGridView1.DataSource = issue.ToList();
            }
        }

        public ACCManager()
        {
            InitializeComponent();
        }

        public ACCManager(decimal request_id)
        {
            this.request_id = request_id;
            InitializeComponent();
        }

      //public ACCManager(decimal id_Request): base()
      // {
      //     this.id = id_Request;
      //     InitializeComponent();
      //  }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new NewIssue().Show();
            //this.Hide();
        }

        private void ACCManager_Load(object sender, EventArgs e)
        {
            using (var db = new TABContext())
            {
                var rqst = db.requests.Find(request_id);
                String desc = rqst.description;
                String stat = rqst.status;
                String res = rqst.result;
                decimal idAcc = rqst.id_account_manager;
                tbRequestID.Text = "Id Reqst: " + this.request_id.ToString() + Environment.NewLine +
                  "Desc: " + desc + Environment.NewLine +
                  "Status: " + stat + Environment.NewLine +
                  "Res: " + res + Environment.NewLine +
                  "Id ACCMan: " + idAcc.ToString();
            }
            dane();
        }

        private void bReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tbResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                using (var db = new TABContext())
                {
                    var iss = db.issues.Find(row.Cells[0].Value);//id taska potrzebne do zmiany
                    issuse_id = iss.id_issue;
                }
                EditIssue editIssue = new EditIssue(issuse_id);
                editIssue.Show();
            }
            catch (Exception ex)
            {
                //ktos nie zaznaczyl wiersza :/
            }
            //
            //new EditIssue().Show();
            //this.Hide();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            try
            {
                //DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                using (var db = new TABContext())
                {
                    var rqst = db.requests.Find(request_id);//id taska potrzebne do zmiany
                    if (rbInProgress.Checked)
                    {
                        rqst.status = "in progr";
                        rqst.dt_final_cancel = null;
                    }
                    else if (rbCancel.Checked)
                    {
                        rqst.status = "cancelled";
                        rqst.dt_final_cancel = DateTime.Now;
                    }
                    else if (rbFinal.Checked)
                    {
                        rqst.status = "closed";
                        rqst.result = tbResult.Text; //results
                        rqst.dt_final_cancel = DateTime.Now;
                    }
                    db.SaveChanges();
                    //dataGridView1.DataSource = tasks.ToList(); //niedziala:/
                    //dataGridView1.Refresh(); //niedziala:/
                    String desc = rqst.description;
                    String stat = rqst.status;
                    String res = rqst.result;
                    decimal idAcc = rqst.id_account_manager;
                    tbRequestID.Text = "Id Reqst: " + this.request_id.ToString() + Environment.NewLine +
                   "Desc: " + desc + Environment.NewLine +
                   "Status: " + stat + Environment.NewLine +
                   "Res: " + res + Environment.NewLine +
                   "Id ACCMan: " + idAcc.ToString();
                }
            }
            catch (Exception ex)
            {
                //ktos nie zaznaczyl wiersza :/
            }
        }
    }
}
