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
    public partial class SalesAnalysis : Form
    {
        public SalesAnalysis()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SalesAnalysis_Load(object sender, EventArgs e)
        {
            chart1.Series["Date"].Points.AddXY("March 9,2018", 10);
            chart1.Series["Date"].Points.AddXY("March 10,2018", 8);
            chart1.Series["Date"].Points.AddXY("March 11,2018", 15);
            chart1.Series["Date"].Points.AddXY("March 12,2018", 5);
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Page = new CashFlow();
            Page.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Page = new Purchasing();
            Page.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Page = new Inventory();
            Page.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login obj1 = new Login();
            obj1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu obj1 = new Menu();
            obj1.Show();
            this.Hide();
        }
    }
}
