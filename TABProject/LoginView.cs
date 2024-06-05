using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

            //AGA 
            using (var db = new TABContext())
            {
                var correct_login = db.app_user
                    .Where(b => b.login == tbEmail.Text)
                    .FirstOrDefault();

                if (correct_login != null)
                {
                    bool correct_password = correct_login.password.Trim().Equals(tbPassword.Text); //z jakiegos powodu bez trim nie dziala, jakas roznica w formatowaniu musi byc

                    if (correct_password /*&& correct_login.active == true*/)
                    {
                        Console.WriteLine("Correct password!");
                        if (correct_login.type.Trim().ToLower().Equals("ACCManager".ToLower()))
                        {
                            //new ACCManager().Show();
                            new ACCRequestList().Show();
                            this.Hide();
                        }
                        else if (correct_login.type.Trim().ToLower().Equals("ProductMan".ToLower()))
                        {
                            new ProductIssuesList().Show();
                            this.Hide();
                        }
                        else if (correct_login.type.Trim().ToLower().Equals("Worker".ToLower())) {
                            new Worker(correct_login.id_app_user).Show();
                            this.Hide();
                        }
                        else if (correct_login.type.Trim().ToLower().Equals("Admin".ToLower()))
                        {
                            new AdminView().Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong password " + tbPassword.Text + "+" + correct_login.password + " " + correct_password);
                    }
                }
                else {
                    lLoginResults.Text = "Wrong login or password!";
                    Console.WriteLine("Wrong login\n");
                }
            }

            //odkomentowac do testowania jakby powyzszy kod nie dzialal
                /*            if (tbEmail.Text == "acc" && tbPassword.Text == "password") {
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
                            }*/
            }

        private void LoginView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                button1_Click(sender, e);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoginView_Load(object sender, EventArgs e)
        {
        }

        private void lEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
