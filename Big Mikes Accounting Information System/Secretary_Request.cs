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
    public partial class Secretary_Request : Form
    {
        public Secretary_Request()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var page = new Secretary_Emplist();

            this.Hide();
            page.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var page = new Secretary_dashboard();

            this.Hide();
            page.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var page = new Secretary_Payroll();

            this.Hide();
            page.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var page = new Secretary_Attendance();

            this.Hide();
            page.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var page = new Login();

            this.Hide();
            page.Show();
        }
    }
}
