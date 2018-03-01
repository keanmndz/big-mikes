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
    public partial class Secretary_NewEmployee : Form
    {
        public Secretary_NewEmployee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_Emplist();
            Page.Show();
        }

        private void Secretary_NewEmployee_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_Emplist();
            Page.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_dashboard();
            Page.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_Payroll();
            Page.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_Attendance();
            Page.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var page = new Login();
            page.Show();
        }
    }
}
