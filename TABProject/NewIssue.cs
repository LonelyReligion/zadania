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
    public partial class NewIssue : Form
    {
        private decimal id_request;
        public NewIssue()
        {
            InitializeComponent();
            FillComboBox();
        }

        public NewIssue(decimal id_request)
        {
            this.id_request = id_request;
            InitializeComponent();
            FillComboBox();
        }

        private void bReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FillComboBox()
        {
            using (var db = new TABContext())
            {
                var productManagerIds = db.app_user.Where(p => p.type == "ProductMan").Select(p => p.id_app_user).ToList();
                var type = db.issues.Select(p => p.type).Distinct().ToList();

                cbProductMan.DataSource = productManagerIds;
                cbType.DataSource = type;
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {

            String typee = cbType.Text;
            String descc = tbDesc.Text;
            decimal pm_id = (decimal)cbProductMan.SelectedItem;
            DateTime dtOpen = DateTime.Now;

            using (var db = new TABContext())
            {
                var newRecord = new issue
                {                   
                    type = typee,
                    status = "Open",
                    id_product_manager = pm_id,
                    description = descc,
                    dt_open = dtOpen,
                    id_request = id_request
                };

                db.issues.Add(newRecord);

                db.SaveChanges();

            }

            this.Hide();
        }
    }
}
