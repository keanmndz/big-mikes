﻿using System;
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
    public partial class Secretary_Remittance : Form
    {
        public Secretary_Remittance()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_Payroll();
            Page.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_Emplist();
            Page.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_dashboard();
            Page.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_Attendance();
            Page.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var Page = new Secretary_Payroll();
            Page.Show();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            var Page = new Secretary_Remittance_Pagibig();
            Page.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            var Page = new Secretary_Remittance_Philhealth();
            Page.Show();
        }
    }
}