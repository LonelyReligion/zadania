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
    public partial class ProductManager : Form
    {
        public ProductManager()
        {
            InitializeComponent();
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            new LoginView().Show();
            this.Hide();
        }

        private void bAddNewTask_Click(object sender, EventArgs e)
        {
            new AddTask().Show();
            //this.Hide();
        }

        private void lRequest_Click(object sender, EventArgs e)
        {

        }

        private void bReturn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void bAddNewTask_Click_1(object sender, EventArgs e)
        {
            new AddTask().Show();
        }

        private void bEditTask_Click(object sender, EventArgs e)
        {
            new EditTask().Show();
            //this.Hide();
        }
    }
}
