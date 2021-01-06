using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            double temperature = Convert.ToDouble(txtTemperature.Text);
            double fahrenheit = (9 / 5 * temperature) + 32;
            txtConvertedTemperature.Text = fahrenheit.ToString("n1");
        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            double temperature = Convert.ToDouble(txtTemperature.Text);
            double celsius = 9 / 5*(temperature - 32);
            txtConvertedTemperature.Text = celsius.ToString("n1");

        }
    }
}
