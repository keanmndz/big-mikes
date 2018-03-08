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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var page = new Employee_Profile();
            this.Hide();

            page.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var page = new Employee_Attendance();
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

        private void button12_Click(object sender, EventArgs e)
        {
            var page = new Employee_Request();
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
