using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Computer, Physics, Average;

            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);

            Computer = Convert.ToInt32(textBox2.Text);
            Physics = Convert.ToInt32(textBox3.Text);

            Average = (Computer + Physics) / 2;

            listBox4.Items.Add(Average);

            if (Average>=50)
            {
                listBox5.Items.Add("Passed!");
            }
            else
            {
                listBox5.Items.Add("Fail!");
            }
        }
    }
}
