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
    public partial class PO_Dashboard : Form
    {
        public PO_Dashboard()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Page = new PO_Inventory();
            Page.Show();
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            var Page = new RequestPurchase();
            Page.Show();
            this.Close();
        }
    }
}
