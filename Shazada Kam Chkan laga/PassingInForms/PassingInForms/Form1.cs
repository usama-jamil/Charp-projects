using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassingInForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string name, fruit, city, surName;
        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            surName = textBox2.Text;
            fruit = listBox1.Text;
            city = comboBox1.Text;

            var form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
