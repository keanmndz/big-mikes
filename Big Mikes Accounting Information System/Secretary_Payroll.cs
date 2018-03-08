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
            this.Hide();
            Page.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_Emplist();
            this.Hide();
            Page.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_Attendance();
            this.Hide();
            Page.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_Disburse();
            this.Hide();
            Page.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_Payslip();
            this.Hide();
            Page.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_Remittance();
            this.Hide();
            Page.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var page = new Login();
            this.Hide();
            page.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var page = new Secretary_Request();
            this.Hide();
            page.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var page = new Secretary_PayrollReport();
            page.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var page = new Secretary_DeductionReport();
            page.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var page = new Secretary_AddorDeduct();
            this.Hide();
            page.Show();
        }
    }
}
