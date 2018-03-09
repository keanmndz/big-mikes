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
    public partial class GeneralLedger : Form
    {
        public GeneralLedger()
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

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(TransData);
            row.Cells[0].Value = "Sales";
            row.Cells[1].Value = "201801";
            row.Cells[2].Value = "01/03/2018";
            row.Cells[3].Value = "123456";
            row.Cells[4].Value = "2000.00";
            TransData.Rows.Add(row);

            DataGridViewRow row2 = new DataGridViewRow();
            row2.CreateCells(COA);
            row2.Cells[0].Value = "13562-0001";
            row2.Cells[1].Value = "order";
            row2.Cells[2].Value = "sales";
            row2.Cells[3].Value = "2000.00";
            row2.Cells[4].Value = "0.00";
            row2.Cells[5].Value = "Food & beverages";
            COA.Rows.Add(row2);

            DataGridViewRow row3 = new DataGridViewRow();
            row3.CreateCells(COA);
            row3.Cells[0].Value = "12821-0001";
            row3.Cells[1].Value = "marinated beef";
            row3.Cells[2].Value = "purchasing";
            row3.Cells[3].Value = "0.00";
            row3.Cells[4].Value = "6000.00";
            row3.Cells[5].Value = "ingridients";
            COA.Rows.Add(row3);

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
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var Page = new Login();
            Page.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void reports_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void chaccounts_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void Total_Click(object sender, EventArgs e)
        {

        }

        private void Find_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void Help_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {

        }

        private void Add1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Hellp_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click_1(object sender, EventArgs e)
        {

        }

        private void Find_Click_1(object sender, EventArgs e)
        {

        }

        private void Total_Click_1(object sender, EventArgs e)
        {
            string firstCellValue = TransData.SelectedRows[0].Cells[4].Value.ToString();
            string secondCellValue = TransData.SelectedRows[0].Cells[1].Value.ToString();
            Transnum.Text = secondCellValue;
            PostTotal.Text = firstCellValue;
        }

        private void InsertData_Click(object sender, EventArgs e)
        {

        }

        private void TransData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
