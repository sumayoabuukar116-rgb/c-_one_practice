using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electricity_Bill_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Creating Variables
            string customerName;
            double previousReading;
            double currentReading;
            double pricePerUnit;
            double usage;
            double energyCost;
            double tax;
            double fixedCharge;
            double totalBill;

            // Assigning Variables
            customerName = txtCustomer.Text;
            previousReading = double.Parse(txtPrevious.Text);
            currentReading = double.Parse(txtCurrent.Text);
            pricePerUnit = double.Parse(txtUnitPrice.Text);
            fixedCharge = 5.00;

            // Calculating Variables
            usage = currentReading - previousReading;
            energyCost = usage * pricePerUnit;
            tax = energyCost * 0.07;
            totalBill = energyCost + tax + fixedCharge;

            // Displaying Output
            txtUsage.Text = usage.ToString();
            txttax.Text = "$" + tax.ToString("0.00");
            txtTotal.Text = "$" + totalBill.ToString("0.00");
        }
    }
}
