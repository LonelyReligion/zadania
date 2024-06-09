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
        IQueryable<issue> issue = null;
        decimal issue_id;

        private void FillComboBox()
        {
            using (var db = new TABContext())
            {
                var stat = db.issues.Select(p => p.status).Distinct().ToList();

                cbStatus.DataSource = stat;

            }
        }

        private void dane()
        {
            using (var db = new TABContext())
            {
                issue = db.issues;
                dgTabela.DataSource = issue.ToList();
            }
        }

        public ProductIssuesList()
        {
            InitializeComponent();
        }

        public ProductIssuesList(decimal issue_id)
        {
            this.issue_id = issue_id;
            InitializeComponent();
        }

        private void bSelect_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgTabela.SelectedRows[0];
                using (var db = new TABContext())
                {
                    var iss = db.issues.Find(row.Cells[0].Value);//id taska potrzebne do zmiany
                    issue_id = iss.id_issue;
                }
                ProductManager issuesDetailFrm = new ProductManager(issue_id);
                issuesDetailFrm.Show();
            }
            catch (Exception ex)
            {
                //ktos nie zaznaczyl wiersza :/
            }
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            new LoginView().Show();
            this.Hide();
        }

        private void ProductIssuesList_Load(object sender, EventArgs e)
        {
            FillComboBox();
            dane();
            cbStatus.SelectedItem = null;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            using (var db = new TABContext())
            {

                if (cbMine.Checked && dataTime.Checked && cbStatus.SelectedItem != null)
                {
                    issue = db.issues.Where(b => b.id_issue == issue_id)
                                         .Where(b => b.dt_open.Year == dataTime.Value.Date.Year &&
                                                     b.dt_open.Month == dataTime.Value.Date.Month &&
                                                     b.dt_open.Day == dataTime.Value.Date.Day)
                                         .Where(b => b.status == cbStatus.SelectedItem.ToString());
                }
                else if (cbMine.Checked && dataTime.Checked)
                {
                    issue = db.issues.Where(b => b.id_issue == issue_id)
                                         .Where(b => b.dt_open.Year == dataTime.Value.Date.Year &&
                                                     b.dt_open.Month == dataTime.Value.Date.Month &&
                                                     b.dt_open.Day == dataTime.Value.Date.Day);
                }
                else if (cbMine.Checked && cbStatus.SelectedItem != null)
                {
                    issue = db.issues.Where(b => b.id_issue == issue_id)
                                         .Where(b => b.status == cbStatus.SelectedItem.ToString());
                }
                else if (dataTime.Checked && cbStatus.SelectedItem != null)
                {
                    issue = db.issues.Where(b => b.dt_open.Year == dataTime.Value.Date.Year &&
                                                     b.dt_open.Month == dataTime.Value.Date.Month &&
                                                     b.dt_open.Day == dataTime.Value.Date.Day)
                                         .Where(b => b.status == cbStatus.SelectedItem.ToString());
                }
                else if (cbMine.Checked)
                {
                    issue = db.issues.Where(b => b.id_issue == issue_id);
                }
                else if (dataTime.Checked)
                {
                    issue = db.issues.Where(b => b.dt_open.Year == dataTime.Value.Date.Year &&
                                                     b.dt_open.Month == dataTime.Value.Date.Month &&
                                                     b.dt_open.Day == dataTime.Value.Date.Day);
                }
                else if (cbStatus.SelectedItem != null)
                {
                    issue = db.issues.Where(b => b.status == cbStatus.SelectedItem.ToString());
                }
                else
                {
                    issue = db.issues;
                }

                dgTabela.DataSource = issue.ToList();
            }
        }
    }
}
