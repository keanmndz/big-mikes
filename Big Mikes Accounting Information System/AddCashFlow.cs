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
    public partial class AddCashFlow : Form
    {
        public AddCashFlow()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" )
            {
                var Page = new norecord();
                Page.Show();
            }
            else
            {
                var Page = new success();
                Page.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {  
            if (textBox10.Text == "" || textBox9.Text == "" || monthCalendar1.SelectionStart==null)
            {
                var Page = new norecord();
                Page.Show();
            }
            else
            {
                var Page = new success();
                Page.Show();
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "")
            {
                var Page = new norecord();
                Page.Show();
            }
            else
            {
                var Page = new success();
                Page.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            var Page = new CashFlow();
            Page.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.SelectionRange.Start.ToString();
        }
    }
}
