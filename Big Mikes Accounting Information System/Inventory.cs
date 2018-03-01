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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Page = new CashFlow();
            Page.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Page = new SalesAnalysis();
            Page.Show();
            this.Close();
        }
    }
}
