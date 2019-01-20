using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace WindowsFormsApplication1
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                MoveUp();
            }

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                MoveDown();
            }

            if (e.KeyCode == Keys.Space )
            {
                Fire();
            }
        }

        private void Fire()
        {
            var bullet = new PictureBox();
            bullet.Name = "bullet";
            bullet.Height = 15;
            bullet.Width = 25;
            bullet.ImageLocation = @"C:\Users\usama\Desktop\Shazada Kam Chkan laga\WindowsFormsApplication1\WindowsFormsApplication1\Resources\fire.png";
            bullet.Location = new Point(pictureBoxShip.Location.X + pictureBoxShip.Width, pictureBoxShip.Location.Y + pictureBoxShip.Height/2 -5 );

            panel1.Controls.Add(bullet);
        }

        private void MoveDown()
        {
            var positon = pictureBoxShip.Location;

            if (positon.Y < panel1.Height-pictureBoxShip.Height)
            {
                positon.Y += 20;
            }

            pictureBoxShip.ImageLocation = @"C:\Users\usama\Desktop\Shazada Kam Chkan laga\WindowsFormsApplication1\WindowsFormsApplication1\Resources\right.png";

            pictureBoxShip.Location = positon;
        }

        private void MoveUp()
        {
            var positon = pictureBoxShip.Location;
            if (positon.Y > 0)
            {
                positon.Y -= 20;
            }

            pictureBoxShip.ImageLocation = @"C:\Users\usama\Desktop\Shazada Kam Chkan laga\WindowsFormsApplication1\WindowsFormsApplication1\Resources\left.png";

            pictureBoxShip.Location = positon;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            pictureBoxShip.ImageLocation = @"C:\Users\usama\Desktop\Shazada Kam Chkan laga\WindowsFormsApplication1\WindowsFormsApplication1\Resources\ship.png";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelLife.Text = life.ToString();
            timer1.Start();

            var backgroundMusic = new WindowsMediaPlayer();
            backgroundMusic.URL = @"D:\learn-c-from-scratch-with-real-applications\05 Space War Arcade Game\attached_files\030 Space War Arcade Game Part 1\sounds\background.mp3";
            backgroundMusic.controls.play();

        }

        int counter = 0
           ,starsCounter = 0
           , life = 3
           , score;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            starsCounter++;

            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                var pictureBox = ((PictureBox)panel1.Controls[i]);

                if (pictureBox.Name == "bullet")
                {
                    if (pictureBox.Location.X + pictureBox.Width > panel1.Width)
                    {
                        panel1.Controls.RemoveAt(i);
                    }
                    else
                    {
                        pictureBox.Location = new Point(pictureBox.Location.X + 5,pictureBox.Location.Y);
                    }


                    for (int x = 0; x < panel1.Controls.Count; x++)
                    {
                        if (panel1.Controls[x].Name == "enemy")
                        {
                            if (pictureBox.Location.X + pictureBox.Width > panel1.Controls[x].Location.X && pictureBox.Location.X + pictureBox.Width < panel1.Controls[x].Location.X + panel1.Controls[x].Width)
                            {
                                if (pictureBox.Location.Y + pictureBox.Height > panel1.Controls[x].Location.Y && pictureBox.Location.Y + pictureBox.Height < panel1.Controls[x].Location.Y + panel1.Controls[x].Width)
                                {
                                    panel1.Controls.RemoveAt(x);
                                    panel1.Controls.Remove(pictureBox);

                                    score++;
                                    labelScore.Text = score.ToString();
                                }
                            }
                        }
                    }
                }

                if (pictureBox.Name == "enemy")
                {
                    if (pictureBox.Location.X  < 0)
                    {
                        panel1.Controls.RemoveAt(i);
                    }
                    else
                    {
                        pictureBox.Location = new Point(pictureBox.Location.X - 5, pictureBox.Location.Y);

                        if (pictureBox.Location.X  > pictureBoxShip.Location.X && pictureBox.Location.X < pictureBoxShip.Location.X + pictureBoxShip.Width )
                        {
                            if (pictureBox.Location.Y > pictureBoxShip.Location.Y && pictureBox.Location.Y < pictureBoxShip.Location.Y + pictureBoxShip.Height)
                            {
                                panel1.Controls.RemoveAt(i);
                                life--;

                                var explode = new WindowsMediaPlayer();
                                explode.URL = @"D:\learn-c-from-scratch-with-real-applications\05 Space War Arcade Game\attached_files\030 Space War Arcade Game Part 1\sounds\explode.mp3";
                                explode.controls.play();
                                
                                                               
                                labelLife.Text = life.ToString();
                                if (life==0)
                                {
                                    timer1.Stop();

                                    panel2.Visible = true;

                                }
                            }
                        }
                    }
                }

                if (pictureBox.Name == "stars")
                {
                    if (pictureBox.Location.X < 0)
                    {
                        panel1.Controls.RemoveAt(i);
                    }
                    else
                    {
                        pictureBox.Location = new Point(pictureBox.Location.X - 5, pictureBox.Location.Y);
                    }
                }
            }

            if (counter == 50)
            {
                CreateEnemies();
                counter = 0;
            }
            if (starsCounter == 20)
            {
                CreatStars();
                starsCounter = 0;
            }
        }


        Random random = new Random();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreatStars()
        {
            

            var stars = new PictureBox();
            stars.Name = "stars";
            stars.Width = 10;
            stars.Height = 10;
            stars.SizeMode = PictureBoxSizeMode.StretchImage;
            stars.BackColor = Color.Transparent;
            stars.ImageLocation = @"C:\Users\usama\Desktop\Shazada Kam Chkan laga\WindowsFormsApplication1\WindowsFormsApplication1\Resources\star.png";
            stars.Location = new Point(panel1.Width - stars.Width , random.Next(0,panel1.Height - stars.Height));
            panel1.Controls.Add(stars);
        }

        int kindOfEnemies = 4;
        private void CreateEnemies()
        {

            var kindOfEnemy = random.Next(1, kindOfEnemies + 1);

            var enemy = new PictureBox();
            var locationEnemy = random.Next(0, panel1.Height - enemy.Height);

            enemy.Name = "enemy";
            enemy.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy.ImageLocation = @"C:\Users\usama\Desktop\Shazada Kam Chkan laga\WindowsFormsApplication1\WindowsFormsApplication1\Resources\"+ kindOfEnemy + ".png";
            enemy.Location = new Point(panel1.Width , locationEnemy);
            panel1.Controls.Add(enemy);
        }
    }
}
