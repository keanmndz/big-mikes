using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Big_Mikes_Accounting_Information_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(UsernameTextbox.Text == "" || PasswordTextbox.Text == "")
            {
                MessageBox.Show("Please accomplish the username and password fields.", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                var Page = new SalesAnalysis();
                Page.Show();
                this.Hide();
                
            }
        }
    }
}
