using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latin_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSinister_Click(object sender, EventArgs e)
        {
            txtSinister.Text = "left";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDexter.Text = "right";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtMedium.Text = "center";
        }
    }
}
