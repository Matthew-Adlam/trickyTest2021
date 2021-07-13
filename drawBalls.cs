using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace trickyTest2021
{
    public partial class Form1
    {
        public int pinkBalls = 0;

        public void drawBalls()
        {
            scoreTimer.Enabled = false;
            instructBtn.Text = "How many pink circles were there?";
            submitBtn.Visible = false;
            textBox1.Visible = false;

            livesLbl.Visible = false;
            livesText.Visible = false;
            scoreLbl.Visible = false;
            scoreText.Visible = false;
            levelLabel.Visible = false;
            levelText.Visible = false;
            hintsText.Visible = false;
            hintsLbl.Visible = false;

            const int BALL_SIZE = 50;
            const int GAP_SIZE = 10;

            int ycounter = 1; 
            int counter = 1;
            int x = 20;
            int y = 50;
            int rows = panelGame.Height / (BALL_SIZE + GAP_SIZE);
            int columns = (panelGame.Width / (BALL_SIZE + GAP_SIZE));

            Random randColour = new Random();
            int colour = 0;

            pinkBalls = 0;

            Graphics paper = panelGame.CreateGraphics();
            while (counter <= rows)
            {
                while (ycounter < columns)
                {
                    colour = randColour.Next(0, 31); // returns a number from 0-30
                    Pen pen1 = new Pen(Color.Red, 2);
                    SolidBrush br = new SolidBrush(Color.Blue);
                    if (colour < 5) // if its 0-4
                    {
                        pen1.Color = Color.Blue;
                        br.Color = Color.Blue;
                    }
                    else if (colour < 10) // if its 5-9
                    {
                        pen1.Color = Color.Orange;
                        br.Color = Color.Orange;
                    }
                    else if (colour < 15) // if its 10-14
                    {
                        pen1.Color = Color.Green;
                        br.Color = Color.Green;
                    }
                    else if (colour < 20)// if its 15-19
                    {
                        pen1.Color = Color.Red;
                        br.Color = Color.Red;
                    }
                    else if (colour < 25)// if its 20-24
                    {
                        pen1.Color = Color.Yellow;
                        br.Color = Color.Yellow;
                    }
                    else if (colour < 30)// if its 25-29
                    {
                        pen1.Color = Color.Brown;
                        br.Color = Color.Brown;
                    }
                    else if (colour == 30)// if it is 30
                    {
                        pen1.Color = Color.Pink;
                        br.Color = Color.Pink;
                        pinkBalls++;                       
                    }

                    paper.FillEllipse(br, x, y, BALL_SIZE, BALL_SIZE);
                    paper.DrawEllipse(pen1, x, y, BALL_SIZE, BALL_SIZE);
                    x += BALL_SIZE + GAP_SIZE;
                    ycounter++;
                }
                ycounter = 1;
                counter++;
                y += BALL_SIZE + GAP_SIZE;
                x = 20;
            }
            Console.WriteLine(pinkBalls); // for debug

            int wait = 0;

            if (easy == true)
            {
                wait = 4000;
            }
            else if(medium == true)
            {
                wait = 3000;
            }
            else if(hard == true)
            {
                wait = 2000;
            }
            Thread.Sleep(wait);

            clearPanel();

            livesLbl.Visible = true;
            livesText.Visible = true;
            scoreLbl.Visible = true;
            scoreText.Visible = true;
            levelLabel.Visible = true;
            levelText.Visible = true;
            hintsText.Visible = true;
            hintsLbl.Visible = true;

            submitBtn.Visible = true;
            textBox1.Visible = true;
            instructLbl.Text = "How many pink circles were there?";

            scoreTimer.Interval = 20; // quick interval
            scoreTimer.Enabled = true;


        }
    }
}
