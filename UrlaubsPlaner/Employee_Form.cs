using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrlaubsPlaner.DBInteraction;
using UrlaubsPlaner.Entities;

namespace UrlaubsPlaner
{
    public partial class Employee_Form : Form
    {
        private List<Country> Countries;
        private List<Employee> Employees;

        public Employee_Form()
        {
            InitializeComponent();
            this.Hide();
        }

        private void Employee_Form_Load(object sender, EventArgs e)
        {
            Employees = DataBaseConnection.GetFullEmployees();
            Countries = DataBaseConnection.GetCountries();
            cbx_country.Items.AddRange(Countries.ToArray());

            employeeListView.Items.AddRange(Employees.Select(x
                => new ListViewItem(new string[]
                {
                    x.EmployeeId.ToString(),
                    x.EmployeeNumber.ToString(),
                    x.Country.Code,
                    x.Firstname,
                    x.Lastname,
                    x.Email
                })).ToArray());            
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Btn_create_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeListView_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employeeListView.SelectedIndices.Count == 1)
            {
                var index = employeeListView.SelectedIndices[0];
                var listViewItem = employeeListView.Items[index];
                txtbx_firstname.Text = listViewItem.SubItems[3].Text;
            }
        }
    }
}
