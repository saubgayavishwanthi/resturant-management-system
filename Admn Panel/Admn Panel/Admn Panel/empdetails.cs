using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Admn_Panel
{
    public partial class empdetails : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public empdetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            if (gunaRadioButton3.Checked == true)
            {
                connection.Open();

                if (string.IsNullOrEmpty(gunaTextBox1.Text) || string.IsNullOrEmpty(gunaTextBox2.Text) || string.IsNullOrEmpty(gunaRadioButton3.Text) || string.IsNullOrEmpty(gunaTextBox3.Text) || string.IsNullOrEmpty(gunaTextBox4.Text) || string.IsNullOrEmpty(gunaTextBox5.Text))
                {
                    MessageBox.Show("Please fill out all information!", "Error");
                    return;
                }

                /* else
                 {
                     

                         MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM logindatabase.cashier WHERE Username = @UserName", connection),
                         cmd2 = new MySqlCommand("SELECT * FROM logindatabase.cashier WHERE Email = @UserEmail", connection);


                         cmd1.Parameters.AddWithValue("@UserName", txtUsername.Text);
                         cmd2.Parameters.AddWithValue("@UserEmail", txtEmail.Text);

                         bool userExists = false, mailExists = false;

                         using (var dr1 = cmd1.ExecuteReader())
                             if (userExists = dr1.HasRows) MessageBox.Show("Username not available!");

                         using (var dr2 = cmd2.ExecuteReader())
                             if (mailExists = dr2.HasRows) MessageBox.Show("Email not available!");


                       */
                // if (!(userExists || mailExists))
                //  {
            }
            else
            {
                string iquery = "INSERT INTO logindatabase.admin(`id`,`fullname`,`address`,`password`, `confirmpassword`,`hiredate`) VALUES ( '" + gunaTextBox1.Text + "', '" + gunaTextBox2.Text + "', '" + gunaTextBox3.Text + "', '" + gunaTextBox4.Text + "', '" + gunaTextBox5.Text + "', '" + gunaDateTimePicker1.Text + "',)";
                MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                commandDatabase.CommandTimeout = 60;

                try
                {
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                }
                catch (Exception ex)
                {
                    // Show any error message.
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Account Successfully Created!");

                //  }

                connection.Close();
            }
        }





        private void gunaTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaRadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
