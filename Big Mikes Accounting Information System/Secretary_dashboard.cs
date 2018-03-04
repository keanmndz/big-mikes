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
    public partial class Secretary_dashboard : Form
    {
        public Secretary_dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_Emplist();
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

        private void Secretary_dashboard_Load(object sender, EventArgs e)
        {
            chart1.Series["Salary"].Points.AddXY("Crew", 80);
            chart1.Series["Bonus"].Points.AddXY("Crew", 20);
            chart1.Series["Overtime"].Points.AddXY("Crew", 10);


            chart1.Series["Salary"].Points.AddXY("Cook", 90);
            chart1.Series["Bonus"].Points.AddXY("Cook", 10);
            chart1.Series["Overtime"].Points.AddXY("Cook", 5);


            chart1.Series["Salary"].Points.AddXY("Cashier", 70);
            chart1.Series["Bonus"].Points.AddXY("Cashier", 20);
            chart1.Series["Overtime"].Points.AddXY("Cashier", 6);


            chart1.Series["Salary"].Points.AddXY("Maintenance", 60);
            chart1.Series["Bonus"].Points.AddXY("Maintenance", 20);
            chart1.Series["Overtime"].Points.AddXY("Maintenance", 10);


            chart2.Series["Department"].Points.AddXY("Crew", 8);
            chart2.Series["Department"].Points.AddXY("Cashier", 3);
            chart2.Series["Department"].Points.AddXY("Cook", 2);
            chart2.Series["Department"].Points.AddXY("Maintenance", 2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var page = new Login();
            this.Hide();
            page.Show();
        }
    }
}
