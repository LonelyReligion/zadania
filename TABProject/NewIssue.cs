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
        public NewIssue()
        {
            InitializeComponent();
        }

        private void bReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
