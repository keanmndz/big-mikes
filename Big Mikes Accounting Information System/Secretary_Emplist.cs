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
    public partial class Secretary_Emplist : Form
    {
        public Secretary_Emplist()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_dashboard();
            this.Hide();
            Page.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_Payroll();
            this.Hide();
            Page.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_Attendance();
            this.Hide();
            Page.Show();
        }

        private void Secretary_Emplist_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_NewEmployee();
            this.Hide();
            Page.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_Payslip();
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
    }
}
