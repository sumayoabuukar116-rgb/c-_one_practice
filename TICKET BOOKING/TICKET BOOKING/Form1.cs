using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TICKET_BOOKING
{
    public partial class frmAirlineBooking : Form
    {
        public frmAirlineBooking()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Variables
            string passengerName = txtPassengerName.Text;
            int age, tickets;
            double baggageWeight;

            bool bookingApproved = true;

            lstBookingDetails.Items.Clear();

            // Validate inputs
            if (passengerName.Trim() == "")
            {
                MessageBox.Show("Please enter passenger name.");
                return;
            }

            if (!int.TryParse(txtPassengerAge.Text, out age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            if (!int.TryParse(txtNumberOfTickets.Text, out tickets))
            {
                MessageBox.Show("Please enter a valid number of tickets.");
                return;
            }

            if (!double.TryParse(txtBaggageWeight.Text, out baggageWeight))
            {
                MessageBox.Show("Please enter a valid baggage weight.");
                return;
            }

            // Validation rules
            if (age < 1 || age > 100)
            {
                MessageBox.Show("Age must be between 1 and 100.");
                return;
            }

            if (tickets < 1 || tickets > 5)
            {
                MessageBox.Show("Tickets must be between 1 and 5.");
                return;
            }

            if (baggageWeight < 0 || baggageWeight > 50)
            {
                MessageBox.Show("Baggage must be between 0 and 50 kg.");
                return;
            }

            // Travel class
            string travelClass = "";
            double ticketPrice = 0;

            if (rdoFirstClass.Checked)
            {
                travelClass = "First Class";
                ticketPrice = 500;

                if (age < 12)
                {
                    bookingApproved = false;
                    MessageBox.Show(
                        "Booking rejected: Children below 12 cannot book First Class.");
                    return;
                }
            }
            else if (rdoNormalClass.Checked)
            {
                travelClass = "Normal Class";
                ticketPrice = 200;
            }
            else if (rdoBusinessClass.Checked)
            {
                travelClass = "Business Class";
                ticketPrice = 350;
            }
            else
            {
                MessageBox.Show("Please select a travel class.");
                return;
            }

            // Basic ticket cost
            double basicCost = ticketPrice * tickets;
            double discount = 0;

            // Ticket discount
            if (tickets >= 3 && tickets <= 4)
            {
                discount += basicCost * 0.05;
            }
            else if (tickets == 5)
            {
                discount += basicCost * 0.10;
            }

            // Child or senior discount
            if (age < 12)
            {
                discount += basicCost * 0.20;
            }
            else if (age >= 60)
            {
                discount += basicCost * 0.10;
            }

            // Insurance
            double insuranceCost = 0;

            if (chkTravelInsurance.Checked)
            {
                insuranceCost = 25 * tickets;
            }

            // Baggage cost
            double baggageCost = 0;

            if (baggageWeight > 20)
            {
                baggageCost = (baggageWeight - 20) * 10;
            }

            // Total cost
            double totalCost = basicCost - discount
                               + insuranceCost + baggageCost;

            // Booking approved
            bookingApproved = true;

            // Display results in ListBox
            lstBookingDetails.Items.Add("AIRLINE BOOKING DETAILS");
            lstBookingDetails.Items.Add("------------------------------");
            lstBookingDetails.Items.Add("Passenger Name: " + passengerName);
            lstBookingDetails.Items.Add("Passenger Age: " + age);
            lstBookingDetails.Items.Add("Travel Class: " + travelClass);
            lstBookingDetails.Items.Add("Number of Tickets: " + tickets);
            lstBookingDetails.Items.Add("Baggage Weight: " + baggageWeight + " kg");
            lstBookingDetails.Items.Add("Ticket Price: $" + ticketPrice);
            lstBookingDetails.Items.Add("Basic Cost: $" + basicCost.ToString("0.00"));
            lstBookingDetails.Items.Add("Discount: $" + discount.ToString("0.00"));
            lstBookingDetails.Items.Add("Insurance: $" + insuranceCost.ToString("0.00"));
            lstBookingDetails.Items.Add("Baggage Fee: $" + baggageCost.ToString("0.00"));
            lstBookingDetails.Items.Add("------------------------------");
            lstBookingDetails.Items.Add("Total Cost: $" + totalCost.ToString("0.00"));
            lstBookingDetails.Items.Add("Booking Approved: " + bookingApproved);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassengerName.Clear();
            txtPassengerAge.Clear();
            txtNumberOfTickets.Clear();
            txtBaggageWeight.Clear();

            rdoFirstClass.Checked = false;
            rdoNormalClass.Checked = false;
            rdoBusinessClass.Checked = false;

            chkTravelInsurance.Checked = false;

            lstBookingDetails.Items.Clear();

            txtPassengerName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
