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

namespace TABProject
{
    public partial class ACCRequestList : Form

    { 

        IQueryable<request> request = null;
        decimal request_id;

        private void dane()
        {
            using (var db = new TABContext())
            {
                request = db.requests;
                dgTabela.DataSource = request.ToList();
            }
        }

        public ACCRequestList(decimal request_id)
        {
             this.request_id = request_id;
             InitializeComponent();
        }
        public ACCRequestList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            dane();
        }

        private void bSelect_Click(object sender, EventArgs e)
        {
            try { 
            DataGridViewRow row = this.dgTabela.SelectedRows[0];
            using (var db = new TABContext())
            {
                var rqst = db.requests.Find(row.Cells[0].Value);//id taska potrzebne do zmiany
                request_id = rqst.id_request;
            }
            ACCManager requestDetailFrm = new ACCManager(request_id);
            requestDetailFrm.Show();
            }
            catch (Exception ex)
            {
                //ktos nie zaznaczyl wiersza :/
            }
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            using (var db = new TABContext())
            {

                if (cbMine.Checked && dataTime.Checked && cbStatus.SelectedItem != null)
                {
                    request = db.requests.Where(b => b.id_request == request_id)
                                         .Where(b => b.dt_open.Year == dataTime.Value.Date.Year &&
                                                     b.dt_open.Month == dataTime.Value.Date.Month &&
                                                     b.dt_open.Day == dataTime.Value.Date.Day)
                                         .Where(b => b.status == cbStatus.SelectedItem.ToString());
                }
                else if (cbMine.Checked && dataTime.Checked)
                {
                    request = db.requests.Where(b => b.id_request == request_id)
                                         .Where(b => b.dt_open.Year == dataTime.Value.Date.Year &&
                                                     b.dt_open.Month == dataTime.Value.Date.Month &&
                                                     b.dt_open.Day == dataTime.Value.Date.Day);
                }
                else if (cbMine.Checked && cbStatus.SelectedItem != null)
                {
                    request = db.requests.Where(b => b.id_request == request_id)
                                         .Where(b => b.status == cbStatus.SelectedItem.ToString());
                }
                else if (dataTime.Checked && cbStatus.SelectedItem != null)
                {
                    request = db.requests.Where(b => b.dt_open.Year == dataTime.Value.Date.Year &&
                                                     b.dt_open.Month == dataTime.Value.Date.Month &&
                                                     b.dt_open.Day == dataTime.Value.Date.Day)
                                         .Where(b => b.status == cbStatus.SelectedItem.ToString());
                }
                else if (cbMine.Checked)
                {
                    request = db.requests.Where(b => b.id_request == request_id);
                }
                else if (dataTime.Checked)
                {
                    request = db.requests.Where(b => b.dt_open.Year == dataTime.Value.Date.Year &&
                                                     b.dt_open.Month == dataTime.Value.Date.Month &&
                                                     b.dt_open.Day == dataTime.Value.Date.Day);
                }
                else if (cbStatus.SelectedItem != null)
                {
                    request = db.requests.Where(b => b.status == cbStatus.SelectedItem.ToString());
                }
                else
                {
                    request = db.requests;
                }

                dgTabela.DataSource = request.ToList();
            }
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
