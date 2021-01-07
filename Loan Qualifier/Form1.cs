using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        const decimal MINIMUM_SALARY = 40000M;
        const int MINIMUM_YEARS_ON_JOB = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            decimal salary = decimal.Parse(txtSalary.Text);
            int yearsOnJob = int.Parse(txtYears.Text);
            //Determine whether the user qualifies.
            if(salary >= MINIMUM_SALARY)
            {
                if(yearsOnJob >= MINIMUM_YEARS_ON_JOB)
                {
                    txtDecision.Text = "You qualify for the loan";
                }
                else{
                    txtDecision.Text = "Minimum years at current " + " job not met";

                }
            }
            else
            {
                txtDecision.Text = "Minimum salary requirement " + " not met";
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSalary.Text = "";
            txtYears.Text = "";
            txtDecision.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
