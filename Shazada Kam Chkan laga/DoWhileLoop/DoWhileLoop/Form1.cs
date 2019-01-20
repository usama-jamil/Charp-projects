using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoWhileLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i=0;
            while (i<=10)
            {
                listBox1.Items.Add(i);
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            
            do
                {
                  listBox2.Items.Add(i);
                  i++;

                }
            while (i<=10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var  numbers =new int[]
                            {1,23,4,5,6,7};

            foreach (var number in numbers)
            {
                listBox3.Items.Add(number);
            }
            
        }
    }
}
