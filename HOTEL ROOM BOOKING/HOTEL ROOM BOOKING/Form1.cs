using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_ROOM_BOOKING
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string guestName = txtGuestName.Text;
            int age, nights, guests;
            bool bookingApproved = true;

            BookingDetails.Items.Clear();

            // Validate guest name
            if (guestName.Trim() == "")
            {
                MessageBox.Show("Please enter guest name.");
                bookingApproved = false;
                return;
            }

            // Validate numeric inputs using TryParse
            if (!int.TryParse(txtGuestAge.Text, out age))
            {
                MessageBox.Show("Enter a valid guest age.");
                bookingApproved = false;
                return;
            }

            if (!int.TryParse(txtNights.Text, out nights))
            {
                MessageBox.Show("Enter a valid number of nights.");
                bookingApproved = false;
                return;
            }

            if (!int.TryParse(txtGuests.Text, out guests))
            {
                MessageBox.Show("Enter a valid number of guests.");
                bookingApproved = false;
                return;
            }

            // Validate ranges
            if (age < 18 || age > 90)
            {
                MessageBox.Show("Age must be between 18 and 90.");
                bookingApproved = false;
                return;
            }

            if (nights < 1 || nights > 30)
            {
                MessageBox.Show("Nights must be between 1 and 30.");
                bookingApproved = false;
                return;
            }

            if (guests < 1 || guests > 6)
            {
                MessageBox.Show("Guests must be between 1 and 6.");
                bookingApproved = false;
                return;
            }

            // Determine room type and rate using switch
            string roomType = "";
            double roomRate = 0;
            int maxGuests = 0;

            if (rdoStandard.Checked)
            {
                roomType = "Standard";
            }
            else if (rdoNormal.Checked)
            {
                roomType = "Normal";
            }
            else if (rdoHight.Checked)
            {
                roomType = "Hight";
            }
            else
            {
                MessageBox.Show("Please select a room type.");
                bookingApproved = false;
                return;
            }

            switch (roomType)
            {
                case "Standard":
                    roomRate = 50;
                    maxGuests = 2;
                    break;

                case "Normal":
                    roomRate = 80;
                    maxGuests = 4;
                    break;

                case "Hight":
                    roomRate = 130;
                    maxGuests = 6;
                    break;
            }

            // Check room capacity
            if (guests > maxGuests)
            {
                MessageBox.Show(
                    roomType + " room allows a maximum of "
                    + maxGuests + " guests.");

                bookingApproved = false;
                return;
            }

            // Calculate basic cost
            double basicCost = roomRate * nights;

            // Night discount
            double discountRate = 0;

            if (nights >= 5 && nights <= 9)
            {
                discountRate = 0.05;
            }
            else if (nights >= 10)
            {
                discountRate = 0.12;
            }

            double nightDiscount = basicCost * discountRate;

            // Senior discount
            double seniorDiscount = 0;

            if (age >= 60)
            {
                seniorDiscount = basicCost * 0.05;
            }

            // Breakfast cost
            double breakfastCost = 0;

            if (chkBreakfast.Checked)
            {
                breakfastCost = 10 * guests * nights;
            }

            // Service surcharge
            double serviceSurcharge = 0;

            if (guests > 4)
            {
                serviceSurcharge = basicCost * 0.05;
            }

            // Calculate total
            double totalCost = basicCost
                               - nightDiscount
                               - seniorDiscount
                               + breakfastCost
                               + serviceSurcharge;

            bookingApproved = true;

            // Display results in ListBox
            BookingDetails.Items.Add("HOTEL BOOKING DETAILS");
            BookingDetails.Items.Add("-----------------------------");
            BookingDetails.Items.Add("Guest Name: " + guestName);
            BookingDetails.Items.Add("Guest Age: " + age);
            BookingDetails.Items.Add("Room Type: " + roomType);
            BookingDetails.Items.Add("Room Rate: $" + roomRate);
            BookingDetails.Items.Add("Number of Nights: " + nights);
            BookingDetails.Items.Add("Number of Guests: " + guests);
            BookingDetails.Items.Add("Basic Cost: $" + basicCost.ToString("0.00"));
            BookingDetails.Items.Add("Night Discount: $" + nightDiscount.ToString("0.00"));
            BookingDetails.Items.Add("Senior Discount: $" + seniorDiscount.ToString("0.00"));
            BookingDetails.Items.Add("Breakfast: $" + breakfastCost.ToString("0.00"));
            BookingDetails.Items.Add("Service Surcharge: $" + serviceSurcharge.ToString("0.00"));
            BookingDetails.Items.Add("-----------------------------");
            BookingDetails.Items.Add("Total Cost: $" + totalCost.ToString("0.00"));
            BookingDetails.Items.Add("Booking Approved: " + bookingApproved);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGuestName.Clear();
            txtGuestAge.Clear();
            txtNights.Clear();
            txtGuests.Clear();

            rdoStandard.Checked = false;
            rdoNormal.Checked = false;
            rdoHight.Checked = false;

            chkBreakfast.Checked = false;

            BookingDetails.Items.Clear();

            txtGuestName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
