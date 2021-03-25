using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oster_Hase
{
    public partial class Form1 : Form
        
    {
        Form1 mainForm;
        Random r = new Random();
        int missed = 0;
        int speed = 8;
        int score = 0;
        PictureBox splattered = new PictureBox();


        public Form1()
        {
            InitializeComponent();
            
            
        }

        public Form1(Form1 mainForm, Random r, int missed, int speed, int score, PictureBox splattered, PictureBox player)
        {
            this.mainForm = mainForm;
            this.r = r;
            this.missed = missed;
            this.speed = speed;
            this.score = score;
            this.splattered = splattered;
            this.player = player;
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            
            
        }
        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (player.Left >= 0)
                {
                    player.Left -= 10;
                    player.Image = Properties.Resources.Hase2;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (player.Left <= this.Width - 150)
                {
                    player.Left += 10;
                    player.Image = Properties.Resources.Hase2___GoesRight;
                   
                }
            }
        }

        

        public PictureBox Rplayer
        {
            get
            {
                return player;
            }
        }
       

       /* private void FallingEggs()
        {
            foreach (Control X in this.Controls)
            {

                if (X is PictureBox && X.Top <= this.Height)

                {
                    X.Top += 8;
                }

                if (X is PictureBox && X.Top >= this.Height)
                {
                    X.Top =7;
                }
                if (X.Top + X.Height >= this.Height)
                {
                    splattered.Image = Properties.Resources.splattered_egg;
                    splattered.Location = X.Location;
                    splattered.BackColor = System.Drawing.Color.Transparent;
                    this.Controls.Add(splattered);

                    if (X.Height >= 120)
                    {
                        X.Location = new Point((r.Next(100, this.Width - 100)), 0);
                    }
                    missed++;
                }
                if (X.Bounds.IntersectsWith(this.Rplayer.Bounds))
                {
                    X.Top = r.Next(100, 300);
                    X.Left = r.Next(5, this.Width - X.Width);
                    score++;
                }
                if (score >= 20)
                {
                    speed = 16;
                }


                if (missed > 5)
                {
                    MessageBox.Show("Game Over!! Try again" + "/n+" + "Press Ok to Start");

                }
            }
        }*/
    }
}
