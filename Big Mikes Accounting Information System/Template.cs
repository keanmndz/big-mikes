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
    public partial class Template : Form
    {
        public Template()
        {
            var prevpage = new Login();
            prevpage.Close();

            InitializeComponent();


            button6.TabStop = false;
            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 0;

            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            button2.TabStop = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            button3.TabStop = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            button4.TabStop = false;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            button5.TabStop = false;
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void Template_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(241, 99, 0);
            button2.BackColor = Color.FromArgb(0, 255, 255, 255);
            button3.BackColor = Color.FromArgb(0, 255, 255, 255);
            button4.BackColor = Color.FromArgb(0, 255, 255, 255);
            button5.BackColor = Color.FromArgb(0, 255, 255, 255);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(0, 255, 255, 255);
            button2.BackColor = Color.FromArgb(241, 99, 0);
            button3.BackColor = Color.FromArgb(0, 255, 255, 255);
            button4.BackColor = Color.FromArgb(0, 255, 255, 255);
            button5.BackColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(0, 255, 255, 255);
            button2.BackColor = Color.FromArgb(0, 255, 255, 255);
            button3.BackColor = Color.FromArgb(241, 99, 0);
            button4.BackColor = Color.FromArgb(0, 255, 255, 255);
            button5.BackColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(0, 255, 255, 255);
            button2.BackColor = Color.FromArgb(0, 255, 255, 255);
            button3.BackColor = Color.FromArgb(0, 255, 255, 255);
            button4.BackColor = Color.FromArgb(241, 99, 0);
            button5.BackColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(0, 255, 255, 255);
            button2.BackColor = Color.FromArgb(0, 255, 255, 255);
            button3.BackColor = Color.FromArgb(0, 255, 255, 255);
            button4.BackColor = Color.FromArgb(0, 255, 255, 255);
            button5.BackColor = Color.FromArgb(241, 99, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var Page = new Login();
            Page.Show();
            this.Close();

        }

        
    }
}
