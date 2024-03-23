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
    public partial class Billing_System : Form
    {
        public Billing_System()
        {
            InitializeComponent();
        }
        public double cost_of_Item()
        {
            double sum = 0;
            int i = 0;
            for (i = 0; i < (dataGridView1.Rows.Count);
                i++)
            {
                sum = sum + Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
            }
            return sum;
        }

        private void AddCost()
        {
            Double Tax = 0.2, g;
            if (dataGridView1.Rows.Count > 0)
            {
                txtService.Text = Convert.ToString(cost_of_Item() * Tax);
                txtsubtotal.Text = Convert.ToString(cost_of_Item());
                g = cost_of_Item() * Tax;
                txttotal.Text = Convert.ToString(cost_of_Item() + g);
            }

        }

        private void Change()
        {
            Double Tax = 0.2, g, c;
            if (dataGridView1.Rows.Count > 0)
            {
                g = (cost_of_Item() * Tax) + cost_of_Item();
                c = Convert.ToInt32(txtcost.Text);
                txtchange.Text = Convert.ToString(c - g);
            }
        }

        Bitmap bitmap;

        private void gunaPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton13_Click(object sender, EventArgs e)
        {

        }

        private void gunaLinePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Billing_System_Load(object sender, EventArgs e)
        {
            // burger1.Show();
            // pizza1.Hide();
            // dessert1.Hide();
            // pepsi.Hide();
        }

        private void gunaButton19_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton15_Click(object sender, EventArgs e)
        {
            //  burger1.Show();
            //  pizza1.Hide();
            //  dessert1.Hide();
            //pepsi.Hide();

        }

        private void gunaButton16_Click(object sender, EventArgs e)
        {
            //  burger1.Hide();
            //  pizza1.Show();
            //   dessert1.Hide();
            //   pepsi.Hide();
        }

        private void gunaButton17_Click(object sender, EventArgs e)
        {
            // burger1.Hide();
            // pizza1.Hide();
            // dessert1.Show();
            //pepsi.Hide();
        }

        private void gunaButton18_Click(object sender, EventArgs e)
        {
            // burger1.Hide();
            //pizza1.Hide();
            //dessert1.Hide();
            //pepsi.Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {

                int height = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                dataGridView1.Height = height;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                txtService.Text = "";
                txtchange.Text = "";
                txtsubtotal.Text = "";
                txttotal.Text = "";
                txtcost.Text = "";
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                cbpayment.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaLabel7_Click(object sender, EventArgs e)
        {

        }

        private void txtcost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // Prevent the character from being entered
            }

            // Allow only one negative sign at the beginning
            if (e.KeyChar == '-' && ((sender as TextBox).Text.IndexOf('-') >= 0 || (sender as TextBox).SelectionStart != 0))
            {
                e.Handled = true;
            }
        }

        private void txtsubtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // Prevent the character from being entered
            }

            // Allow only one negative sign at the beginning
            if (e.KeyChar == '-' && ((sender as TextBox).Text.IndexOf('-') >= 0 || (sender as TextBox).SelectionStart != 0))
            {
                e.Handled = true;
            }
        }

        private void txtService_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // Prevent the character from being entered
            }

            // Allow only one negative sign at the beginning
            if (e.KeyChar == '-' && ((sender as TextBox).Text.IndexOf('-') >= 0 || (sender as TextBox).SelectionStart != 0))
            {
                e.Handled = true;
            }
        }

        private void txttotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // Prevent the character from being entered
            }

            // Allow only one negative sign at the beginning
            if (e.KeyChar == '-' && ((sender as TextBox).Text.IndexOf('-') >= 0 || (sender as TextBox).SelectionStart != 0))
            {
                e.Handled = true;
            }
        }

        private void txtchange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // Prevent the character from being entered
            }

            // Allow only one negative sign at the beginning
            if (e.KeyChar == '-' && ((sender as TextBox).Text.IndexOf('-') >= 0 || (sender as TextBox).SelectionStart != 0))
            {
                e.Handled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
            AddCost();

            if (cbpayment.Text == "Cash")
            {
                Change();

            }
            else
            {
                txtchange.Text = "";
                txtcost.Text = "0";

            }

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cbpayment.Text == "Cash")
            {
                Change();

            }
            else
            {
                txtchange.Text = "";
                txtcost.Text = "0";

            }

        }

        private void cola_Load(object sender, EventArgs e)
        {


        }

        private void Sprite_Click(object sender, EventArgs e)
        {



        }

        private void pepsi_Click(object sender, EventArgs e)
        {




        }

        private void gunaButton12_Click(object sender, EventArgs e)
        {
            Double costofitem = 450;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Chicken Burger")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Chicken Burger", "1", costofitem);
            AddCost();
        }


        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Double costofitem = 390;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Hamburger")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Hamburger", "1", costofitem);
            AddCost();
        }
        
        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            Double costofitem = 420;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Double Cheese Burger")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Double Cheese Burger", "1", costofitem);
            AddCost();
        }
        
        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Double costofitem = 550;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Beef Burger")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Beef Burger", "1", costofitem);
            AddCost();
        }

        private void gunaButton17_Click_1(object sender, EventArgs e)
        {
            Double costofitem = 110;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Chocolate Cake Slice")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Chocolate Cake Slice", "1", costofitem);
            AddCost();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Double costofitem = 450;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Turky Burger")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Turky Burger", "1", costofitem);
            AddCost();
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            Double costofitem = 120;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "pepsi")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("pepsi", "1", costofitem);
            AddCost();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Double costofitem = 300;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Tuna Burger")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Tuna Burger", "1", costofitem);
            AddCost();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Double costofitem = 420;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Veggie Burger")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Veggie Burger", "1", costofitem);
            AddCost();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Double costofitem = 400;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Black Been Burger")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Black Been Burger", "1", costofitem);
            AddCost();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Double costofitem = 300;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Falafel Burger")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Falafel Burger", "1", costofitem);
            AddCost();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            Double costofitem = 600;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Chicken Pizza")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Chicken Pizza", "1", costofitem);
            AddCost();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            Double costofitem = 690;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "BBQ Chicken Pizza")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("BBQ Chicken Pizza", "1", costofitem);
            AddCost();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            Double costofitem = 720;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Cheese and Ham Pizza")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Cheese and Ham Pizza", "1", costofitem);
            AddCost();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            Double costofitem = 500;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Ham and Pineapple Pizza")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Ham and Pineapple Pizza", "1", costofitem);
            AddCost();
        }

        private void gunaLabel25_Click(object sender, EventArgs e)
        {

        }

        private void btn14_Click(object sender, EventArgs e)
        {
            Double costofitem = 570;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Buffalo Pizza")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Buffalo Pizza", "1", costofitem);
            AddCost();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            Double costofitem = 450;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Sausage Pizza")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Sausage Pizza", "1", costofitem);
            AddCost();
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            Double costofitem = 450;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Margherita Pizza")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Margherita Pizza", "1", costofitem);
            AddCost();
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            Double costofitem = 450;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Mozzarella Cheese Pizza")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Mozzarella Cheese Pizza", "1", costofitem);
            AddCost();
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            Double costofitem = 110;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Doughnut")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Doughnut", "1", costofitem);
            AddCost();
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            Double costofitem = 150;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Choco Croissant")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Choco Croissant", "1", costofitem);
            AddCost();
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            Double costofitem = 250;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Waffel")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Waffel", "1", costofitem);
            AddCost();
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            Double costofitem = 50;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Coffee")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Coffee", "1", costofitem);
            AddCost();
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            Double costofitem = 290;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Cappuccino")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Cappuccino", "1", costofitem);
            AddCost();
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            Double costofitem = 350;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Sprite")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Sprite", "1", costofitem);
            AddCost();
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            Double costofitem = 350;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "7up")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("7up", "1", costofitem);
            AddCost();
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            Double costofitem = 450;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Coca Cola")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Coca Cola", "1", costofitem);
            AddCost();
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            Double costofitem = 400;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((string)row.Cells[0].Value == "Mountain Dew")
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * costofitem;

                }
            }
            dataGridView1.Rows.Add("Mountain Dew", "1", costofitem);
            AddCost();
        }
    }
}