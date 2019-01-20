using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaHouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);

            listBox4.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);

            label6.Text = checkBox1.Text;
            label7.Text = checkBox2.Text;
            label8.Text = checkBox3.Text;
            listBox6.Items.Add($"{label6.Text} , {label7.Text} , {label8.Text}");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            comboBox1.Text = "";
            comboBox2.Text = "";

            listBox1.Items.RemoveAt(0);
            listBox2.Items.RemoveAt(0);
            listBox3.Items.RemoveAt(0);
            listBox4.Items.RemoveAt(0);
            listBox5.Items.RemoveAt(0);
            listBox6.Items.RemoveAt(0);
        }
    }
}
