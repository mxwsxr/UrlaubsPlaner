using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrlaubsPlaner
{
    public partial class Employee_Form : Form
    {
        public Employee_Form()
        {
            InitializeComponent();
            this.Hide();
        }

        private void Employee_Form_Load(object sender, EventArgs e)
        {

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
