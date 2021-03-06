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
    public partial class Employee_Profile : Form
    {
        public Employee_Profile()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var page = new Employee();
            this.Hide();
            page.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var page = new Employee_Apply();
            this.Hide();

            page.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var page = new Login();
            this.Hide();

            page.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var page = new Employee_Attendance();
            this.Hide();

            page.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            var page = new Employee_Request();
            this.Hide();

            page.Show();
        }
    }
}
