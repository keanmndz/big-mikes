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
    public partial class CashFlow : Form
    {

        //DataSet ds = null;
        //DataTable dt = null;
        
        public CashFlow()
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

            this.dataGridView1.Rows.Add(14);
            this.dataGridView1.Rows[0].Cells[0].Value = "Beginning Cash Balance:";
            this.dataGridView1.Rows[1].Cells[0].Value = "    Cash in-flows(Receipts)";
            this.dataGridView1.Rows[2].Cells[0].Value = "       Cash Receipts:";
            this.dataGridView1.Rows[3].Cells[0].Value = "       Card Receipts:";
            this.dataGridView1.Rows[4].Cells[0].Value = "       Others:";
            this.dataGridView1.Rows[5].Cells[0].Value = "    Total Cash-InFlows:";
            this.dataGridView1.Rows[6].Cells[0].Value = "    Cash Outflows (payment)";
            this.dataGridView1.Rows[7].Cells[0].Value = "       Food Stocks:";
            this.dataGridView1.Rows[8].Cells[0].Value = "       Beverage Stocks:";
            this.dataGridView1.Rows[9].Cells[0].Value = "       Other Suplies and Services:";
            this.dataGridView1.Rows[10].Cells[0].Value = "      Payroll:";
            this.dataGridView1.Rows[11].Cells[0].Value = "      Utility:";
            this.dataGridView1.Rows[12].Cells[0].Value = "Total Cash Out-Flows:";
            this.dataGridView1.Rows[13].Cells[0].Value = "Ending Cash Balance:";

        }

        private void Template_Load(object sender, EventArgs e)
        {
            //ds = new DataSet();
            //dt = new DataTable();

            //dt = GetCustomers();
            //ds.Tables.Add(dt);

            //DataView my_DataView = ds.Tables[0].DefaultView;
            //this.dataGridView1.DataSource = my_DataView;
            
            
        }
        //private static DataTable GetCustomers()
        //{
        //    DataTable table = new DataTable();
        //    table.TableName = "Customers";

        //    table.Columns.Add("Description", typeof(string));
        //    table.Columns.Add("Week1", typeof(string));
        //    table.Columns.Add("Week2", typeof(string));
        //    table.Columns.Add("Week3", typeof(string));
        //    table.Columns.Add("Week4", typeof(string));
        //    table.Columns.Add("Week5", typeof(string));


        //    table.Rows.Add(new object[] { "Beginning Cash Balance", "111", "1111" });
        //    table.Rows.Add(new object[] { "Cash in-flows receipts:", "2222", "2222" });
        //    table.Rows.Add(new object[] { "Card Receipts:", "33333", "33333" });
        //    table.Rows.Add(new object[] { "Others:", "33333", "33333" });

        //    table.AcceptChanges();

        //    return table;
        //}


        //public DataSet FlipDataSet(DataSet my_DataSet)
        //{
        //    DataSet ds = new DataSet();

        //    foreach (DataTable dt in my_DataSet.Tables)
        //    {
        //        DataTable table = new DataTable();

        //        for (int i = 0; i <= dt.Rows.Count; i++)
        //        {
        //            table.Columns.Add(Convert.ToString(i));
        //        }
        //        DataRow r;
        //        for (int k = 0; k < dt.Columns.Count; k++)
        //        {
        //            r = table.NewRow();
        //            r[0] = dt.Columns[k].ToString();
        //            for (int j = 1; j <= dt.Rows.Count; j++)
        //                r[j] = dt.Rows[j - 1][k];
        //            table.Rows.Add(r);
        //        }

        //        ds.Tables.Add(table);
        //    }
            
        //    return ds;
        //}
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

            var Page = new SalesAnalysis();
            Page.Show();
            this.Close();
            //DataSet new_ds = FlipDataSet(ds); // Flip the DataSet
            //DataView my_DataView = new_ds.Tables[0].DefaultView;
            //this.dataGridView1.DataSource = my_DataView;
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(0, 255, 255, 255);
            button2.BackColor = Color.FromArgb(241, 99, 0);
            button3.BackColor = Color.FromArgb(0, 255, 255, 255);
            button4.BackColor = Color.FromArgb(0, 255, 255, 255);
            button5.BackColor = Color.FromArgb(0, 255, 255, 255);

            //DataView my_DataView = ds.Tables[0].DefaultView;
            //this.dataGridView1.DataSource = my_DataView;


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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void templateBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void programBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = comboBox1.SelectedItem.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
