using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CarRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Visible = false;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            feninzi(gamespeed);
            kolicinafeninga();
        }
        Random r = new Random();
        int x, y;

        void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(0,200);
                enemy1.Top = 0;
                enemy1.Location = new Point(x, 0);
            }
            else
            {
                enemy1.Top += speed;
            }
           
            if (enemy2.Top >= 500)
            {
                x = r.Next(0, 400);
                enemy2.Top = 0;
                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }
            
            if (enemy3.Top >= 500)
            {
                x = r.Next(200, 350);
                enemy3.Top = 0;
                enemy3.Location = new Point(x, 0);
            }
            else
            {
                enemy3.Top += speed;
            }
            
        }

        void Moveline( int speed) 
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = speed;
            }
            else
            {
                pictureBox1.Top += speed;
            }
            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            
           

            pictureBox1.Top += speed;
            pictureBox2.Top += speed;
            pictureBox3.Top += speed;
            

        }
        void feninzi(int speed)
        {
            if (dvajs1.Top >= 500)
            {
                x = r.Next(0, 200);
                dvajs1.Top = 0;
                dvajs1.Location = new Point(x, 0);
            }
            else
            {
                dvajs1.Top += speed;
            }

            if (dvajs2.Top >= 500)
            {
                x = r.Next(0, 400);
                dvajs2.Top = 0;
                dvajs2.Location = new Point(x, 0);
            }
            else
            {
                dvajs2.Top += speed;
            }

            if (dvajs3.Top >= 500)
            {
                x = r.Next(200, 350);
                dvajs3.Top = 0;
                dvajs3.Location = new Point(x, 0);
            }
            else
            {
                dvajs3.Top += speed;
            }
            if (dvajs3.Top >= 500)
            {
                x = r.Next(200, 350);
                dvajs4.Top = 0;
                dvajs4.Location = new Point(x, 0);
            }
            else
            {
                dvajs4.Top += speed;
            }

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        int gamespeed = 0;
        int skupljenifeninzi = 0;
        void kolicinafeninga()
        {
            if (car.Bounds.IntersectsWith(dvajs1.Bounds)) 
            {
                skupljenifeninzi+=20;
                label2.Text = "Feninzi=" + skupljenifeninzi.ToString();
                x = r.Next(50, 300);
                dvajs1.Location = new Point(x, 0);
                (new SoundPlayer(@"c:\Users\User\Desktop\coin.wav")).Play();

            }

            if (car.Bounds.IntersectsWith(dvajs2.Bounds))
            {
                skupljenifeninzi += 20;
                label2.Text = "Feninzi=" + skupljenifeninzi.ToString();
                x = r.Next(50, 300);
                dvajs2.Location = new Point(x,0);
                (new SoundPlayer(@"c:\Users\User\Desktop\coin.wav")).Play();


            }
            if (car.Bounds.IntersectsWith(dvajs3.Bounds))
            {
                skupljenifeninzi += 20;
                label2.Text = "Feninzi=" + skupljenifeninzi.ToString();
                x = r.Next(50, 300);
                dvajs3.Location = new Point(x, 0);
                (new SoundPlayer(@"c:\Users\User\Desktop\coin.wav")).Play();

            }
            if (car.Bounds.IntersectsWith(dvajs4.Bounds))
            {
                skupljenifeninzi += 20;
                label2.Text = "Feninzi=" + skupljenifeninzi.ToString();
                x = r.Next(50, 300);
                dvajs4.Location = new Point(x, 0);
                (new SoundPlayer(@"c:\Users\User\Desktop\coin.wav")).Play();

            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        void gameover() 
        {
            if (car.Bounds.IntersectsWith (enemy1.Bounds) || car.Bounds.IntersectsWith(enemy2.Bounds)||car.Bounds.IntersectsWith(enemy3.Bounds)) 
            {
                timer1.Enabled = false;
                label1.Visible = true;
                (new SoundPlayer(@"c:\Users\User\Desktop\gameoverr.wav")).Play();
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode==Keys.Left)
            {
                if (car.Left>0) 
                    car.Left += -16;
                
            }
            if (e.KeyCode==Keys.Right) 
            {
                if (car.Right < 380)
                    car.Left += 16;
            }
            if (e.KeyCode==Keys.Up) 
            {
                if (gamespeed < 21)
                    gamespeed++;
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                 gamespeed--; 
            }            
        }
    }
}
