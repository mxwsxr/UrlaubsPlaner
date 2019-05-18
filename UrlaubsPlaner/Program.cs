using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrlaubsPlaner.Entities;

namespace UrlaubsPlaner
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            using (var db = new DataBaseContext())
            {
                // Create and save a new Blog
                Console.Write("Enter a firstname for a new Employee: ");
                var firstname = Console.ReadLine();

                var employee = new Employee { Firstname = firstname };
                db.Employees.Add(employee);
                db.SaveChanges();

                // Display all Blogs from the database
                var query = from e in db.Employees
                            orderby e.Firstname
                            select e;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Firstname);
                }

                Console.WriteLine("Press any key to exit...");
                //Console.ReadKey();
            }
        }
    }
}