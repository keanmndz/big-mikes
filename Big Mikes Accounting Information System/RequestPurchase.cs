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
    public partial class RequestPurchase : Form
    {
        public RequestPurchase()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Page = new PO_Inventory();
            Page.Show();
            this.Close();
        }
    }
}
