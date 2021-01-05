using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Formatting
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

                decimal originalPrice; //The item's original price.
                decimal discountPercentage; //The discount Percentage.
                decimal discountAmount; //The amount of discount.
                decimal salePrice; //The item's sale price.



                originalPrice = decimal.Parse(txtOriginalPrice.Text);

                discountPercentage = decimal.Parse(txtPercentage.Text);
                discountPercentage = discountPercentage / 100;
                discountAmount = originalPrice * discountPercentage;

                salePrice = originalPrice - discountAmount;

                txtSalePrice.Text = salePrice.ToString("c");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
