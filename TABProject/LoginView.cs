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
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "acc" && tbPassword.Text == "password") {
                new ACCManager().Show();
                this.Hide();
            }
            else if(tbEmail.Text == "productM" && tbPassword.Text == "password") {
                new ProductManager().Show();
                this.Hide();
            }
            else if (tbEmail.Text == "admin" && tbPassword.Text == "password")
            {
                new AdminView().Show();
                this.Hide();
            }
            else if (tbEmail.Text == "worker" && tbPassword.Text == "password")
            {
                new Worker().Show();
                this.Hide();
            }
            else {
                lLoginResults.Text = "Login failed. Check your password and email";
                tbEmail.Clear();
                tbPassword.Clear();
            }
        }

        private void LoginView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                button1_Click(sender, e);
            }
        }
    }
}
