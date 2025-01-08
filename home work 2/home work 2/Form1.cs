using System;
using System.Windows.Forms;

namespace home_work_2
{
    public partial class Form1 : Form
    {
        
        private readonly decimal[] beveragePrices = { 1.95m, 2.50m, 3.00m };
        private readonly decimal[] appetizerPrices = { 5.95m, 6.95m, 8.95m };
        private readonly decimal[] mainCoursePrices = { 12.95m, 14.95m, 16.95m };
        private readonly decimal[] dessertPrices = { 3.95m, 4.95m, 5.95m };

        public Form1()
        {
            InitializeComponent();
            InitializeMenu();
        }

        private void InitializeMenu()
        {
          
            cboBeverage.Items.AddRange(new string[] { "Soda", "Tea", "Coffee" });
            cboAppetizer.Items.AddRange(new string[] { "Nachos", "Soup", "Salad" });
            cboMainCourse.Items.AddRange(new string[] { "Chicken Alfredo", "Steak", "Salmon" });
            cboDessert.Items.AddRange(new string[] { "Apple Pie", "Cheesecake", "Ice Cream" });
        }

        private void CalculateBill()
        {
            decimal subtotal = 0;

           
            if (cboBeverage.SelectedIndex >= 0)
                subtotal += beveragePrices[cboBeverage.SelectedIndex];

            if (cboAppetizer.SelectedIndex >= 0)
                subtotal += appetizerPrices[cboAppetizer.SelectedIndex];

            if (cboMainCourse.SelectedIndex >= 0)
                subtotal += mainCoursePrices[cboMainCourse.SelectedIndex];

            if (cboDessert.SelectedIndex >= 0)
                subtotal += dessertPrices[cboDessert.SelectedIndex];

          
            decimal tax = subtotal * 0.16m;
            decimal total = subtotal + tax;

            lblSubtotal.Text = "$" + subtotal.ToString("0.00");
            lblTax.Text = "$" + tax.ToString("0.00");
            lblTotal.Text = "$" + total.ToString("0.00");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            cboBeverage.SelectedIndex = -1;
            cboAppetizer.SelectedIndex = -1;
            cboMainCourse.SelectedIndex = -1;
            cboDessert.SelectedIndex = -1;

           
            lblSubtotal.Text = "$0.00";
            lblTax.Text = "$0.00";
            lblTotal.Text = "$0.00";
        }

        private void Cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateBill();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateBill();
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateBill();
        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateBill();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void Label7_Click(object sender, EventArgs e)
        {
        }
    }
}
