using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Big_Mikes_Accounting_Information_System
{
    public partial class Login : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BigMikesCS"].ConnectionString;

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginButton.Image = new Bitmap(Properties.Resources.login_icon_white, new Size(40, 40));
            button2.Image = new Bitmap(Properties.Resources.attendance_icon_transparent, new Size(30, 28));
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextbox.Text == "" || PasswordTextbox.Text == "")
            {
                MessageBox.Show("Please accomplish the username and password fields.", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(UsernameTextbox.Text == "manager")
                {
                    SalesAnalysis Sales = new SalesAnalysis();
                    Sales.Show();
                    Hide();
                }
                if (UsernameTextbox.Text == "owner")
                {
                    GeneralLedger gen = new GeneralLedger();
                    gen.Show();
                    Hide();
                }
                if (UsernameTextbox.Text == "cashier")
                {
                    POS POS = new POS();
                    POS.Show();
                    Hide();
                }
                if (UsernameTextbox.Text == "secretary")
                {
                    Secretary_dashboard sec = new Secretary_dashboard();
                    sec.Show();
                    Hide();
                }
            }
            //else
            //{
            //    string query = "SELECT * FROM UserAccounts Where Username = @Username AND Password = @Password";

            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    {
            //        using (SqlCommand command = new SqlCommand(query, connection))
            //        {
            //            connection.Open();
            //            command.Parameters.AddWithValue("@Username", UsernameTextbox.Text);
            //            command.Parameters.AddWithValue("@Password", PasswordTextbox.Text);
            //            using (SqlDataReader reader = command.ExecuteReader())
            //            {
            //                if (reader.HasRows)
            //                {
            //                    reader.Read();
            //                    if (reader["UserType"].ToString() == "Owner")
            //                    {
            //                        GeneralLedger generalLedger = new GeneralLedger();
            //                        generalLedger.Show();
            //                        Hide();
            //                    }
            //                    else if (reader["UserType"].ToString() == "Manager")
            //                    {
            //                        //GeneralLedger generalLedger = new GeneralLedger();
            //                        //generalLedger.Show();
            //                        //Hide();
            //                    }
            //                    else if (reader["UserType"].ToString() == "Secretary")
            //                    {
            //                        //GeneralLedger generalLedger = new GeneralLedger();
            //                        //generalLedger.Show();
            //                        //Hide();
            //                    }
            //                    else if (reader["UserType"].ToString() == "Cashier")
            //                    {
            //                        POS pos = new POS();
            //                        pos.Show();
            //                        Hide();
            //                    }
            //                }
            //                else
            //                {
            //                    MessageBox.Show("The entered credentials are invalid.", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                }
            //            }
            //        }
            //    }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pp = new Secretary_Timesheet();
            pp.Show();
        }
    }
}
