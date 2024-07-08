using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace TABProject
{
    public partial class LoginView : Form
    {
        public void password_encryption()
        {
            using (var db = new TABContext())
            {
                var users = db.app_user.ToList();

                foreach (var user in users)
                {
                    user.password = Hash.GetHashSha256(user.password.Trim()); //dodane haszhowanie
                    //user.password = "Password"; 
                }

                try
                {
                    db.SaveChanges();
                    Console.WriteLine("All passwords have been encrypted.");
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Console.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                        }
                    }
                    throw;
                }
            }
        }

        public LoginView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //password_encryption();
            //AGA 
            using (var db = new TABContext())
            {
                var correct_login = db.app_user
                    .Where(b => b.login == tbEmail.Text)
                    .FirstOrDefault();

                if (correct_login != null)
                {

                    string hashResult = Hash.GetHashSha256(tbPassword.Text.Trim());
                    bool correct_password = correct_login.password.Trim().Equals(hashResult);
                   
                   // Console.WriteLine(correct_login.password);
                  //  Console.WriteLine(hashResult);

                   // bool correct_password = correct_login.password.Trim().Equals(tbPassword.Text);

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
                        else if (correct_login.type.Trim().ToLower().Equals("Worker".ToLower()))
                        {
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
                        lLoginResults.Text = "Wrong login or password!";
                        Console.WriteLine("Wrong password " + tbPassword.Text + "+" + correct_login.password + " " + correct_password);
                    }
                }
                else
                {
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
            if (e.KeyCode == Keys.Enter)
            {
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
    public class Hash
    {
        public static string GetHashSha256(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            using (SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider())
            {
                byte[] hash = sha256.ComputeHash(bytes);
                StringBuilder hashString = new StringBuilder();
                foreach (byte x in hash)
                {
                    hashString.Append(x.ToString("x2"));
                }
                return hashString.ToString();
            }
        }
    }

}