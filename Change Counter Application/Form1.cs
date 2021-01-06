using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter_Application
{
    public partial class Form1 : Form
    {

        const decimal FIVE_CENTS_VALUE = 0.05m;
        const decimal TEN_CENTS_VALUE = 0.10m;
        const decimal TWENTY_FIVE_CENTS_VALUE = 0.25m;
        const decimal FIFTY_CENTS_VALUE = 0.50m;

        private decimal total = 0m;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            total += FIVE_CENTS_VALUE;
            txtTotal.Text = total.ToString();
        }

        private void picTenCents_Click(object sender, EventArgs e)
        {
            total += TEN_CENTS_VALUE;
            txtTotal.Text = total.ToString();
        }

        private void picTwentyFiveCents_Click(object sender, EventArgs e)
        {
            total +=  TWENTY_FIVE_CENTS_VALUE;            
            txtTotal.Text = total.ToString();
        }

        private void picFivftyCents_Click(object sender, EventArgs e)
        {
            total += FIFTY_CENTS_VALUE;
            txtTotal.Text = total.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
