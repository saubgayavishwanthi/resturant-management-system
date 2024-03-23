using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admn_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            gunaPanel2.Height = gunaButton2.Height;
            gunaPanel2.Top = gunaButton2.Top;

            reprots1.Hide();
            empdetails1.Hide();
            product_details1.Hide();
            home1.Show();

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            gunaPanel2.Height = gunaButton3.Height;
            gunaPanel2.Top = gunaButton3.Top;

            Billing_System f2 = new Billing_System();
            f2.Show();
            Visible = false;
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            gunaPanel2.Height = gunaButton4.Height;
            gunaPanel2.Top = gunaButton4.Top;
            reprots1.Hide();
            empdetails1.Show();
            product_details1.Hide();
            home1.Hide();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            gunaPanel2.Height = gunaButton5.Height;
            gunaPanel2.Top = gunaButton5.Top;

            reprots1.Hide();
            empdetails1.Hide();
            product_details1.Show();
            home1.Hide();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {

            gunaPanel2.Height = gunaButton6.Height;
            gunaPanel2.Top = gunaButton6.Top;

            reprots1.Show();
            empdetails1.Hide();
            product_details1.Hide();
            home1.Hide();
        }

        private void employees1_Load(object sender, EventArgs e)
        {

        }

        private void product_details1_Load(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void empdetails1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reprots1.Hide();
            empdetails1.Hide();
            product_details1.Hide();
            home1.Show();
        }

        private void reprots1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
