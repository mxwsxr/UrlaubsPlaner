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
                //var firstname = Console.ReadLine();

                //var employee = new Employee { Firstname = firstname };
                //db.Employees.Add(employee);
                //db.SaveChanges();

                //var query = from e in db.Employees
                //            orderby e.Firstname
                //            select e;

                //foreach (var item in query)
                //{
                //    Console.WriteLine(item.Firstname);
                //}

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form_Main() { DbContext = db });
            }
        }
    }
}