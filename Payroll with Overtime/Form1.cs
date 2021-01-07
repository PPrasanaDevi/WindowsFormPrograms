using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //Named constants

                const decimal BASE_HOURS = 40m;
                const decimal OT_MULTIPLIER = 1.5m;

                //Local Variables
                decimal hoursWorked;
                decimal hourlyPayRate;
                decimal basePay;
                decimal overtimeHours;
                decimal overtimePay;
                decimal grossPay;

                //Get the hours worked and hourly pay rate.
                hoursWorked = decimal.Parse(txtHoursWorked.Text);
                hourlyPayRate = decimal.Parse(txtPayRate.Text);

                overtimeHours = hoursWorked - BASE_HOURS;

                if (hoursWorked > BASE_HOURS)
                {
                    overtimeHours = hoursWorked - BASE_HOURS;

                    basePay = hourlyPayRate * BASE_HOURS;
                    overtimePay = overtimeHours * hourlyPayRate + OT_MULTIPLIER;

                    grossPay = basePay + overtimePay;

                }
                else
                {
                    grossPay = hoursWorked * hourlyPayRate;

                }
                txtGrossPay.Text = grossPay.ToString("c");


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHoursWorked.Text = "";
            txtPayRate.Text = "";
            txtGrossPay.Text = "";

            txtHoursWorked.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
