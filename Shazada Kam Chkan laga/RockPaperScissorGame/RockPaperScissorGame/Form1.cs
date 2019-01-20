using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int pc, you;
        private void Button_Click(object sender, EventArgs e)
        {
            var random =  new Random().Next(0,3);
            var action = ((Button)sender).Text;

            pictureBox1.ImageLocation = @"D:\learn-c-from-scratch-with-real-applications\03 Rock Scissors Paper Game\attached_files\024 Rock Scissors Paper Game Part1\game\" + action + ".png";

                
            switch (random)
            {
                case 0:
                    pictureBox2.ImageLocation = @"D:\learn-c-from-scratch-with-real-applications\03 Rock Scissors Paper Game\attached_files\024 Rock Scissors Paper Game Part1\game\rock.png";

                    timer1.Stop();
                    if (action=="rock")
                    {
                        MessageBox.Show("Draw");
                        timer1.Start();
                    }
                    if (action == "paper")
                    {
                        MessageBox.Show("You Won");
                        ++you;
                       label9.Text= you.ToString();
                        timer1.Start();
                    }
                    if (action == "scissors")
                    {
                        MessageBox.Show("You Lose");
                        pc++;
                        label10.Text = pc.ToString();
                        timer1.Start();
                    }
                    break;


                case 1:
                    pictureBox2.ImageLocation = @"D:\learn-c-from-scratch-with-real-applications\03 Rock Scissors Paper Game\attached_files\024 Rock Scissors Paper Game Part1\game\paper.png";

                    timer1.Stop();
                    if (action == "paper")
                    {
                        MessageBox.Show("Draw");
                        timer1.Start();
                    }
                    if (action == "scissors")
                    {
                        MessageBox.Show("You Won");
                        ++you;
                        label9.Text = you.ToString();
                        timer1.Start();
                    }
                    if (action == "rock")
                    {
                        MessageBox.Show("You Lose");
                        pc++;
                        label10.Text=  pc.ToString() ;
                        timer1.Start();
                    }
                    break;


                case 2:
                    pictureBox2.ImageLocation = @"D:\learn-c-from-scratch-with-real-applications\03 Rock Scissors Paper Game\attached_files\024 Rock Scissors Paper Game Part1\game\scissors.png";

                    timer1.Stop();
                    if (action == "scissors")
                    {
                        MessageBox.Show("Draw");
                        timer1.Start();
                    }
                    if (action == "rock")
                    {
                        MessageBox.Show("You Won");
                        ++you;
                        label9.Text= you.ToString();
                        timer1.Start();
                    }
                    if (action == "paper")
                    {
                        MessageBox.Show("You Lose");
                        pc++;
                        label10.Text= pc.ToString();
                        timer1.Start();
                    }
                    break;


            }
        }

        int time;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time==10)
            {
                pictureBox1.ImageLocation =
                pictureBox2.ImageLocation = @"D:\learn-c-from-scratch-with-real-applications\03 Rock Scissors Paper Game\attached_files\024 Rock Scissors Paper Game Part1\game\rock.png";
            }
            if (time==20)
            {
                pictureBox1.ImageLocation =
                pictureBox2.ImageLocation = @"D:\learn-c-from-scratch-with-real-applications\03 Rock Scissors Paper Game\attached_files\024 Rock Scissors Paper Game Part1\game\paper.png";
            }
            if (time==30)
            {
                pictureBox1.ImageLocation =
                pictureBox2.ImageLocation = @"D:\learn-c-from-scratch-with-real-applications\03 Rock Scissors Paper Game\attached_files\024 Rock Scissors Paper Game Part1\game\scissors.png";

                time = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
