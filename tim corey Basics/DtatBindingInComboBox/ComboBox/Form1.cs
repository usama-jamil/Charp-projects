using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            var netAmount = 0.00; 
            var quantity = 0.00;
            var result = 0.00;
            labelResult.Visible = true;

            if (double.TryParse(textBoxNetAmount.Text, out netAmount)
                &&
                double.TryParse( textBoxQuantity.Text , out quantity ))
            {
                result = netAmount / quantity;

                labelResult.Text = result.ToString();
            }
            else
            {
                labelResult.Text = "Incorrect Number";
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }
    }
}
