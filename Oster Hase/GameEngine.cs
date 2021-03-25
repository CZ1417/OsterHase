using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace Oster_Hase
{
   /* class GameEngine
    {
          Random r = new Random();
          int missed = 0;
          int speed = 8;
          int score = 0;
          PictureBox splattered = new PictureBox();






          public void FallingEggs()
          {
              foreach (Control X in this.Controls)
              {

                  if( X is PictureBox && X.Top <= this.Height)

                          {
                              X.Top += 8;
                          }

                  if ( X is PictureBox && X.Top >= this.mainForm.Height)
                  {
                      X.Top += speed;
                  }
                  if (X.Top + X.Height >= this.mainForm.Height)
                  {
                      splattered.Image = Properties.Resources.splattered_egg;
                      splattered.Location = X.Location;
                      splattered.BackColor = System.Drawing.Color.Transparent;
                      mainForm.Controls.Add(splattered);

                      if (X.Height >= 120)
                      {
                          X.Location = new Point((r.Next(100, this.mainForm.Width - 100)), 0);
                      }
                      missed++;
                  }
                  if (X.Bounds.IntersectsWith(this.mainForm.Rplayer.Bounds))
                  {
                      X.Top = r.Next(100, 300);
                      X.Left = r.Next(5, this.mainForm.Width - X.Width);
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
          }




          private void Reset()
          {
              missed = 0;
              score = 0;


          }

      }
    
}*/