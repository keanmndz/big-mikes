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
    public partial class Secretary_Remittance_Philhealth : Form
    {
        public Secretary_Remittance_Philhealth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Page = new Secretary_Payroll();
            this.Hide();
            Page.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var Page = new Secretary_Remittance();
            this.Hide();
            Page.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var Page = new Secretary_Remittance_Pagibig();
            this.Hide();
            Page.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            var Page = new Secretary_Remittance_Philhealth();
            this.Hide();
            Page.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var page = new Login();
            this.Hide();
            page.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var page = new Secretary_PhilHealthReport();
            page.Show();
        }
    }
}
