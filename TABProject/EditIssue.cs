using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TABProject
{
    public partial class EditIssue : Form
    {
        decimal issuse_id;
        IQueryable<issue> issue = null;
        //private ACCManager accManagerForm;

        public EditIssue(decimal issuse_id) //, ACCManager accManagerForm)
        {
            this.issuse_id = issuse_id;
            InitializeComponent();
           // this.accManagerForm = accManagerForm;
        }

        public EditIssue()
        {
            InitializeComponent();
        }

        private void FillComboBox()
        {
            using (var db = new TABContext())
            {
                var productManagerIds = db.app_user.Where(p => p.type == "ProductMan").Select(p => p.id_app_user).ToList();
                var type = db.issues.Select(p => p.type).Distinct().ToList();
                var stat = db.issues.Select(p => p.status).Distinct().ToList();
                var iss = db.issues.Find(issuse_id);


                cbProdM.DataSource = productManagerIds;
                cbType.DataSource = type;
                cbStatus.DataSource = stat;
                cbProdM.SelectedItem = iss.id_product_manager;
                cbType.SelectedItem = iss.type;
                cbStatus.SelectedItem = iss.status;
                tbDesc.Text = iss.description;
            }
        }

        private void bReturn_Click(object sender, EventArgs e)
        {
            this.Hide();       
        }

        private void EditIssue_Load(object sender, EventArgs e)
        {
      
                using (var db = new TABContext())
                {
                var iss = db.issues.Find(issuse_id);

                String descc = iss.description;
                String statt = iss.status;
                String ress = iss.result;
                String typee = iss.type;
                String id_prod_man = iss.id_product_manager.ToString();
                //decimal idProd = iss.id_product_manager;
                tbIssueID.Text = "Id Issue: " + this.issuse_id.ToString() + Environment.NewLine
                       + "Desc: " + descc + Environment.NewLine
                       + "Status: " + statt + Environment.NewLine
                       + "Type: " + typee + Environment.NewLine
                       + "Product Manager ID: " + id_prod_man + Environment.NewLine
                       + "Res: " + ress;
            }

            FillComboBox();
        }

        private void comboBoxPM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bSave_Click(object sender, EventArgs e)
        {

            using (var db = new TABContext())
            {
                var iss = db.issues.Find(issuse_id);

                if (cbType.SelectedItem != null)
                {
                    iss.type = cbType.SelectedItem.ToString();
                }
                if (cbStatus.SelectedItem != null)
                {
                    iss.status = cbStatus.SelectedItem.ToString();
                }
                if (cbProdM.SelectedItem != null)
                {
                    iss.id_product_manager = (decimal) cbProdM.SelectedItem;
                }
                if(tbDesc.Text != null) 
                {
                    iss.description = tbDesc.Text;
                }
                else
                {
                    iss.description = null;
                }
                db.SaveChanges();                
                                               
                String descc = iss.description;
                String statt = iss.status;
                String ress = iss.result;
                String typee = iss.type;
                String id_prod_man = iss.id_product_manager.ToString();
                //decimal idProd = iss.id_product_manager;
                tbIssueID.Text = "Id Issue: " + this.issuse_id.ToString() + Environment.NewLine
                       + "Desc: " + descc + Environment.NewLine
                       + "Status: " + statt + Environment.NewLine
                       + "Type: " + typee + Environment.NewLine
                       + "Product Manager ID: " + id_prod_man + Environment.NewLine
                       + "Res: " + ress;

            }
        }

        private void EditIssue_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Sprawdzamy czy forma poprzedzająca to ACCManager
            if (this.Owner is ACCManager parentForm)
            {
                // Odświeżamy DataGridView w ACCManager
                parentForm.RefreshDataGridView();
            }
        }
    }
}
