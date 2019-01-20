using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiaqatProjectLearn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // label1.Text = Resource1.String1;

            // var manno = new ComponentResourceManager();

            //label1.Text =  Properties.Resources.String1;

            // var a = File.ReadAllBytes("sdkfj");
            SelectButton(button4,homePage1);



        }


        private void button4_Click(object sender, EventArgs e)
        {
            SelectButton(button4 , homePage1);
            

        }

        private  void SelectButton(Button selectedButton, Control selectedControl)
        {
            SidePanel.Top = selectedButton.Top;
            selectedControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectButton(button1, carBrands1);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
