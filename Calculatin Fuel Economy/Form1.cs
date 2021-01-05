using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatin_Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double miles; // To Hold miles
            double gallons; //To hold gallons used;
            double mpg;  //To hold MPG

            miles = double.Parse(txtMiles.Text);
            gallons = double.Parse(txtGasGallons.Text);


            //Calculate MPG
            mpg = miles / gallons;

            txtMPG.Text = mpg.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
