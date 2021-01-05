using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowDate_Click(object sender, EventArgs e)
        {
            //Declare a string variable
            string output;
            output = txtDayOfWeek.Text + " " + txtMonth.Text + " " + txtDayOfMonth.Text + txtYear.Text;

            //Display the result.
            txtOutput.Text = output;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear the textboxes.
            txtDayOfWeek.Text = "";
            txtMonth.Text = "";
            txtDayOfMonth.Text = "";
            txtYear.Text = "";
            txtOutput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
