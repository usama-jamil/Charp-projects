using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertingMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1, number2, sum;

            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32( textBox2.Text);

            sum = number1 + number2;

            label4.Visible = true;

            label4.Text = sum.ToString();
        }
    }
}
