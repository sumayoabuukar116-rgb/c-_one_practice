using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSIGMENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {

            dayOfWeekTextBox.Text = "";

            dayOfMonthTextBox.Clear();

            monthTextBox.Text = string.Empty;

            yearTextBox.Text = string.Empty;

            dateOutputLabel.Text = string.Empty;
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
           

            string DayoftheWeek, Month, Day, Year, FullDate;

           

            DayoftheWeek = dayOfWeekTextBox.Text;

            Month = monthTextBox.Text;

            Day = dayOfMonthTextBox.Text;

            Year = yearTextBox.Text;

            

            FullDate = DayoftheWeek +"," + Month + "," + Day + "," + Year;

            dateOutputLabel.Text = FullDate;



        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
