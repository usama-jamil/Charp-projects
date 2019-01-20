using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int mili=0, second=0, minute=0, hour=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            mili++;
            label4.Text = AddZero(mili);

            if (mili==100)
            {
                mili = 0;
                label4.Text = AddZero(mili);

                second++;
                label3.Text = AddZero(second);
            }
            else if (second==60)
            {
                second = 0;
                label3.Text = AddZero(second);

                minute++;
                label2.Text = AddZero(minute);
            }
            else if(minute==60)
            {
                minute = 0;
                label2.Text = AddZero(minute);

                hour++;
                label1.Text = AddZero(hour);
            }
        }

        private string AddZero(int number)
        {
            var value = "";

            if (number<10)
            {
                value = "0" + number;
            }
            else
            {
                value = ""+number;
            }

            return value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                timer1.Start();

                button1.Text = "Stop";
            }
            else
            {
                timer1.Stop();

                button1.Text = "Start";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
