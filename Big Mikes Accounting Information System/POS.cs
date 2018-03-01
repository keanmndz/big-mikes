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
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Login obj1 = new Login();
            obj1.Show();
            this.Hide();
        }
    }
}
