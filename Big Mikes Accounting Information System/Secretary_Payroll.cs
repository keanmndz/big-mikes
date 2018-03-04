using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Big_Mikes_Accounting_Information_System
{
    public partial class Secretary_Payroll : Form
    {
        public Secretary_Payroll()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_dashboard();
            Page.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_Emplist();
            Page.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_Attendance();
            Page.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_Disburse();
            Page.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_Payslip();
            Page.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_Remittance();
            Page.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var page = new Login();
            this.Hide();
            page.Show();
        }
    }
}
