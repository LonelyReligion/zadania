using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TABProject
{
    public partial class EditIssue : Form
    {
        decimal issuse_id;
        IQueryable<issue> issue = null;
        public EditIssue()
        {
            InitializeComponent();
        }

        public EditIssue(decimal issuse_id)
        {
            this.issuse_id = issuse_id;
            InitializeComponent();
        }

        private void FillProductManagersComboBox()
        {
            using (var db = new TABContext())
            {
                var productManagerIds = db.app_user.Where(p => p.type == "ProductMan").Select(p => p.id_app_user).ToList();
                var type = db.issues.Select(p => p.type).Distinct().ToList();
                var stat = db.issues.Select(p => p.status).Distinct().ToList();
                comboBoxProdM.DataSource = productManagerIds;
                cbType.DataSource = type;
                cbStatus.DataSource = stat;
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
                if (iss != null)
                {
                    String desc = iss.description;
                    String stat = iss.status;
                    String res = iss.result;
                    //decimal idProd = iss.id_product_manager;
                    tbRequestID.Text = "Id Issue: " + this.issuse_id.ToString() + " Desc: " + desc + " Status: " + stat +
                       " Res: " + res;
                }
                String descc = iss.description;
                String statt = iss.status;
                String ress = iss.result;
                //decimal idProd = iss.id_product_manager;
                tbRequestID.Text = "Id Issue: " + this.issuse_id.ToString() + " Desc: " + descc + " Status: " + statt +
                   " Res: " + ress;

            }
            FillProductManagersComboBox();
        }

        private void comboBoxPM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
