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

        private void bReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EditIssue_Load(object sender, EventArgs e)
        {
            using (var db = new TABContext())
            {
                var iss = db.issues.Find(issuse_id);
                String desc = iss.description;
                String stat = iss.status;
                String res = iss.result;
                //decimal idProd = iss.id_product_manager;
                tbRequestID.Text = "Id Issue: " + this.issuse_id.ToString() + " Desc: " + desc + " Status: " + stat +
                   " Res: " + res;
            }
        }
    }
}
