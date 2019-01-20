using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmClockApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            for (int i = 0; i < 24; i++)
            {
                comboBox1.Items.Add(i);
            }

            for (int j = 0; j < 60; j++)
            {
                comboBox2.Items.Add(j);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now
                                      .Hour
                                      .ToString();
            label2.Text = DateTime.Now
                                      .Minute
                                      .ToString();
            label3.Text = DateTime.Now
                                      .Second
                                      .ToString();
            RingAlarm();
        }

        private void RingAlarm()
        {
            if (hour==label1.Text && minute==label2.Text )
            {
                label10.Text = "Alarm is ringing";
            }
            else
            {
                label10.Text = "no";
            }
        }

        string minute, hour;
        private void button1_Click(object sender, EventArgs e)
        {
            hour = comboBox1.Text;
            minute = comboBox2.Text;
        }
    }
}
