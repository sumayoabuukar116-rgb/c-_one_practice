using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT_INFO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();
            lbloutput.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            string student_name, department;
            int student_id, semester;
            string fullInfo;

            student_name = txtname.Text;
            student_id = int.Parse(txtstudentid.Text);
            department = txtdepartment.Text;
            semester = int.Parse(txtsemester.Text);

           
            fullInfo = "STUDENT NAME :"+ student_name + student_id + "," + department +", " + semester;

            lbloutput.Text = fullInfo;
        }
    }
}
