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
        private bool IsInsert = true;
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
                var selectedItem = Employees[index];
                txtbx_firstname.Text = selectedItem.Firstname;
                txtbx_city.Text = selectedItem.City;
                txtbx_email.Text = selectedItem.Email;
                txtbx_housenumber.Text = selectedItem.Housenumber;
                txtbx_id.Text = selectedItem.EmployeeId.ToString();
                txtbx_lastname.Text = selectedItem.Lastname;
                txtbx_number.Text = selectedItem.EmployeeNumber.ToString();
                txtbx_postalcode.Text = selectedItem.Postalcode;
                txtbx_street.Text = selectedItem.Street;
                txtbx_telefonnumber.Text = selectedItem.Phonenumber;
                dtm_birthday.Value = selectedItem.Birthday.GetValueOrDefault();
                cbx_country.SelectedItem = Countries.Find(x => x.CountryId == selectedItem.Country.CountryId);

                ToggleInsertOrUpdate(true);
            }
        }

        private void ToggleInsertOrUpdate(bool visible)
        {
            IsInsert = !visible;
            ToggleButtonVisibility(visible);
            ChangeButtonText(!visible);

            if (!visible)
                ClearTextBoxes();
        }

        private void ToggleButtonVisibility(bool visible)
        {
            txtbx_id.Visible = visible;
            lbl_ID.Visible = visible;
            btn_clear.Visible = visible;
            txtbx_number.Visible = visible;
            lbl_number.Visible = visible;
        }

        private void ClearTextBoxes()
        {
            txtbx_id.Text = string.Empty;
            txtbx_city.Text = string.Empty;
            txtbx_email.Text = string.Empty;
            txtbx_firstname.Text = string.Empty;
            txtbx_lastname.Text = string.Empty;
            txtbx_number.Text = string.Empty;
            txtbx_postalcode.Text = string.Empty;
            txtbx_street.Text = string.Empty;
            txtbx_housenumber.Text = string.Empty;
            txtbx_telefonnumber.Text = string.Empty;
            dtm_birthday.Value = DateTime.Now;
            cbx_country.SelectedItem = null;
        }

        private void ChangeButtonText(bool isInsert)
        {
            if (isInsert)
            {
                btn_create.Text = "Erstellen";
            }
            else
            {
                btn_create.Text = "Aktualisieren";
            }
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            ToggleInsertOrUpdate(false);
        }
    }
}
