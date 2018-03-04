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
    public partial class print : Form
    {
        public print()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            label2.Visible=true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
