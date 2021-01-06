using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double test1 = Convert.ToDouble(txtTest1.Text);
            double test2 = Convert.ToDouble(txtTest2.Text);
            double test3 = Convert.ToDouble(txtTest3.Text);

            double average = (test1 + test2 + test3) / 3.0;

            txtAverage.Text = average.ToString("n1");

            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTest1.Text = "";
            txtTest2.Text = "";
            txtTest3.Text = "";
            txtAverage.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
