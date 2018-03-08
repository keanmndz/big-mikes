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
    public partial class Secretary_Payslip : Form
    {
        public Secretary_Payslip()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_Payroll();
            this.Hide();
            Page.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var page = new Login();
            this.Hide();
            page.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var page = new Secretary_Request();
            this.Hide();
            page.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var page = new Secretary_Report();
            page.Show();
        }
    }
}
