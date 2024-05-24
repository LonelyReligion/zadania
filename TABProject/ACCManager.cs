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
    public partial class ACCManager : Form
    {
        decimal id;
        public ACCManager()
        {
            InitializeComponent();
        }

        public ACCManager(decimal id_Request): base()
        {
            this.id = id_Request;
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new NewIssue().Show();
            //this.Hide();
        }

        private void ACCManager_Load(object sender, EventArgs e)
        {
            tbRequestID.Text = this.id.ToString();
        }

        private void bReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
