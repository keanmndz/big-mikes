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
    public partial class Sub_Categories : Form
    {
        public Sub_Categories()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sub_Categories_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Menu obj1 = new Menu();
            obj1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Sub_Categories obj1 = new Sub_Categories();
            obj1.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddSubcategories obj1 = new AddSubcategories();
            obj1.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EditSubCategory obj1 = new EditSubCategory();
            obj1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesAnalysis obj1 = new SalesAnalysis();
            obj1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login obj1 = new Login();
            obj1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CashFlow obj1 = new CashFlow();
            obj1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inventory obj1 = new Inventory();
            obj1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Purchasing obj1 = new Purchasing();
            obj1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu obj1 = new Menu();
            obj1.ShowDialog();
        }
    }
}
