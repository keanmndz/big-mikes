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
    public partial class Secretary_Timesheet : Form
    {
        public Secretary_Timesheet()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var page = new Login();
            this.Hide();
            page.Show();
        }
    }
}
