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
    public partial class Employee_Attendance : Form
    {
        public Employee_Attendance()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var page = new Employee_Profile();
            this.Hide();

            page.Show();
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

        private void button12_Click(object sender, EventArgs e)
        {

            var page = new Employee_Request();
            this.Hide();

            page.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var page = new Secretary_AttendanceReport();
            page.Show();
        }
    }
}
