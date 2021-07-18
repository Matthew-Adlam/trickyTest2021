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
        // declares a public int outside the method - so I can use it in Form1.cs
        public int pinkBalls = 0;

        /// <summary>
        /// draws the balls needed for level 5. this particular level requires users to count the pink balls that are shown, which are randomised each time
        /// </summary>
        public void drawBalls()
        {
            // makes certain elements not visible so the circles are shown clearly
            scoreTimer.Enabled = false;
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

            // sets two constants for the ball size and the size of the gap between balls
            const int BALL_SIZE = 50;
            const int GAP_SIZE = 10;

            // declares two counter variables, so the loop works
            int ycounter = 1; 
            int counter = 1;
            int x = 20; // x position of first ball in a row
            int y = 50; // y position of first row
            // makes the maximum amount of rows and columns that fit in the panel
            int rows = panelGame.Height / (BALL_SIZE + GAP_SIZE);
            int columns = (panelGame.Width / (BALL_SIZE + GAP_SIZE));

            // declares a random colour variable and random number
            Random randColour = new Random();
            int colour = 0;

            pinkBalls = 0; // sets pinkBalls to 0, as no pink balls have been drawn

            Graphics paper = panelGame.CreateGraphics(); // declares graphics

            while (counter <= rows) // while the counter has not exceeded the number of rows
            {
                while (ycounter < columns) // while the counter has not exceeded the number of columns
                {
                    colour = randColour.Next(0, 31); // returns a number from 0-30
                    Pen pen1 = new Pen(Color.Red, 2); // makes a pen 
                    SolidBrush br = new SolidBrush(Color.Blue); // makes a brush
                    if (colour < 5) // if the random number generates 0-4, change colour to blue
                    {
                        pen1.Color = Color.Blue;
                        br.Color = Color.Blue;
                    }
                    else if (colour < 10) // if the random number generates 5-9, change colour to orange
                    {
                        pen1.Color = Color.Orange;
                        br.Color = Color.Orange;
                    }
                    else if (colour < 15) // if the random number generates 10-14, change colour to green
                    {
                        pen1.Color = Color.Green;
                        br.Color = Color.Green;
                    }
                    else if (colour < 20) // if the random number generates 15-19, change colour to red
                    {
                        pen1.Color = Color.Red;
                        br.Color = Color.Red;
                    }
                    else if (colour < 25) // if the random number generates 20-24, change colour to yellow
                    {
                        pen1.Color = Color.Yellow;
                        br.Color = Color.Yellow;
                    }
                    else if (colour < 30) // if the random number generates 25-29, change colour to brown
                    {
                        pen1.Color = Color.Brown;
                        br.Color = Color.Brown;
                    }
                    else if (colour == 30) // if the random number generates 30, change colour to pink, and add one to pinkBalls
                    {
                        pen1.Color = Color.Pink;
                        br.Color = Color.Pink;
                        pinkBalls++;                       
                    }
                    // draw the ellipse with the given parameters: the pen/brush colour, the x and y positions, and the constants
                    paper.FillEllipse(br, x, y, BALL_SIZE, BALL_SIZE);
                    paper.DrawEllipse(pen1, x, y, BALL_SIZE, BALL_SIZE);
                    x += BALL_SIZE + GAP_SIZE; // increases the x by one ball width and gap width
                    ycounter++; // add one to ycounter
                }
                ycounter = 1; // set ycounter back to 1, so it loops properly
                counter++; // add one to counter
                y += BALL_SIZE + GAP_SIZE; // increases the y by one ball width and gap width
                x = 20; // set x to 20, so next row draws properly
            }
            Console.WriteLine(pinkBalls); // for debug

            int wait = 0; // the time that it waits (so the user can count the pink balls)

            if (easy == true)
            {
                wait = 4000; // make it easier if easy difficulty
            }
            else if(medium == true)
            {
                wait = 3000; // make it a bit harder if medium difficulty
            }
            else if(hard == true)
            {
                wait = 2000; // make it harder if hard difficulty
            }
            Thread.Sleep(wait); // gives the user time to count the number of pink balls

            clearPanel(); // clear the panel

            // make everything visible again, and ask the user how many pink balls there was
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
            scoreTimer.Enabled = true; // enable the timer

            // Note: the checking occurs in the submitBtn click event on Form1.cs
        }
    }
}
