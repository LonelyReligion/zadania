using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TABProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            using (var db = new TABContext())
            {
                var user = new app_user {type="type",  password="admin", login="admin", active=true};
                db.app_user.Add(user);
                db.SaveChanges();

                var query = from b in db.app_user
                            orderby b.login
                            select b;
                Console.WriteLine("Wszystkie loginy w bazie:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.login);
                };

                //sprzatamy po sobie 
                db.app_user.Remove(user);
                db.SaveChanges();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginView());
            }
        }
    }
}

        
            


            

       
        
