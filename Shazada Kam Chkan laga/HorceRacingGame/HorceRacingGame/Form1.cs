using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorceRacingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int timer;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            label4.Text = timer.ToString();

            int horceWidth = pictureBox1.Width
                ,finishBoardLocation =label8.Left;

            pictureBox1.Left += random.Next(1,16) ;
            pictureBox2.Left += random.Next(1,16) ;
            pictureBox3.Left += random.Next(1,16) ;

            if (pictureBox1.Left + horceWidth > finishBoardLocation)
            {
                timer1.Stop();
                MessageBox.Show("Horce 1 is won");
            }
            if (pictureBox2.Left + horceWidth > finishBoardLocation)
            {
                timer1.Stop();
                MessageBox.Show("Horce 2 is won");
            }
            if (pictureBox3.Left + horceWidth > finishBoardLocation)
            {
                timer1.Stop();
                MessageBox.Show("Horce 3 is won");
            }



            if (pictureBox1.Left> pictureBox2.Left && pictureBox1.Left > pictureBox3.Left)
            {
                label3.Text = "Horce 1 is ahead ";
            }
            if (pictureBox2.Left > pictureBox1.Left && pictureBox2.Left > pictureBox3.Left)
            {
                label3.Text = "Horce 2 is ahead ";
            }
            if (pictureBox3.Left > pictureBox2.Left && pictureBox3.Left > pictureBox1.Left)
            {
                label3.Text = "Horce 3 is ahead ";
            }

        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
