using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dice1, dice2;
        private void button1_Click(object sender, EventArgs e)
        {
            var random = new Random();

            dice1 = random.Next(1, 7);
            dice2 = random.Next(1, 7);

            switch (dice1)
            {
                case 1:
                    pictureBox1.ImageLocation = @"D:\learn-c-from-scratch-with-real-applications\01 Getting Started\attached_files\011 Dice Game in C  Create random numbers and images in c\Dices\1.png";
                    break;
                case 2:
                    pictureBox1.ImageLocation = @"D:\learn-c-from-scratch-with-real-applications\01 Getting Started\attached_files\011 Dice Game in C  Create random numbers and images in c\Dices\2.png";
                    break;
                case 3:
                    pictureBox1.ImageLocation = @"D:\learn-c-from-scratch-with-real-applications\01 Getting Started\attached_files\011 Dice Game in C  Create random numbers and images in c\Dices\3.png";
                    break;
                case 4:
                    pictureBox1.ImageLocation = @"D:\learn-c-from-scratch-with-real-applications\01 Getting Started\attached_files\011 Dice Game in C  Create random numbers and images in c\Dices\4.png";
                    break;
                case 5:
                    pictureBox1.ImageLocation = @"D:\learn-c-from-scratch-with-real-applications\01 Getting Started\attached_files\011 Dice Game in C  Create random numbers and images in c\Dices\5.png";
                    break;
                case 6:
                    pictureBox1.ImageLocation = @"D:\learn-c-from-scratch-with-real-applications\01 Getting Started\attached_files\011 Dice Game in C  Create random numbers and images in c\Dices\6.png";
                    break;

            }

            switch (dice2)
            {
                case 1:
                    pictureBox2.ImageLocation = @"D:\learn-c-from-scratch-with-real-applications\01 Getting Started\attached_files\011 Dice Game in C  Create random numbers and images in c\Dices\1.png";
                    break;
                case 2:
                    pictureBox2.ImageLocation = @"D:\learn-c-from-scratch-with-real-applications\01 Getting Started\attached_files\011 Dice Game in C  Create random numbers and images in c\Dices\2.png";
                    break;
                case 3:
                    pictureBox2.ImageLocation = @"D:\learn-c-from-scratch-with-real-applications\01 Getting Started\attached_files\011 Dice Game in C  Create random numbers and images in c\Dices\3.png";
                    break;
                case 4:
                    pictureBox2.ImageLocation = @"D:\learn-c-from-scratch-with-real-applications\01 Getting Started\attached_files\011 Dice Game in C  Create random numbers and images in c\Dices\4.png";
                    break;
                case 5:
                    pictureBox2.ImageLocation = @"D:\learn-c-from-scratch-with-real-applications\01 Getting Started\attached_files\011 Dice Game in C  Create random numbers and images in c\Dices\5.png";
                    break;
                case 6:
                    pictureBox2.ImageLocation = @"D:\learn-c-from-scratch-with-real-applications\01 Getting Started\attached_files\011 Dice Game in C  Create random numbers and images in c\Dices\6.png";
                    break;

            }
        }
    }
}
