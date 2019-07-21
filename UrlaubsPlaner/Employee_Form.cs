﻿using System;
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

        public Employee_Form()
        {
            InitializeComponent();
            this.Hide();
        }

        private void Employee_Form_Load(object sender, EventArgs e)
        {
            Countries = DataBaseConnection.GetCountries();
            cbx_country.Items.AddRange(Countries.ToArray());         
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Btn_create_Click(object sender, EventArgs e)
        {

        }
    }
}
