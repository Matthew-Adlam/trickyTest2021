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
        public int blueSquares = 0;

        public void drawShapes()
        {
            // makes certain elements not visible so the shapes are shown clearly
            scoreTimer.Enabled = false;
            submitBtn.Visible = false;
            textBox1.Visible = false;
            instructLbl.Visible = false;

            livesLbl.Visible = false;
            livesText.Visible = false;
            scoreLbl.Visible = false;
            scoreText.Visible = false;
            levelLabel.Visible = false;
            levelText.Visible = false;
            hintsText.Visible = false;
            hintsLbl.Visible = false;

            // declares two counter variables, so the loop works
            int ycounter = 1;
            int counter = 1;
            int x = 20; // x position of first ball in a row
            int y = 50; // y position of first row

            // declares constants

            const int OBJECT_WIDTH = 50;
            const int GAP_SIZE = 10;
            // declares rows and columns to fit inside the panel, but with the maximum possible
            int rows = panelGame.Height / (OBJECT_WIDTH + GAP_SIZE);
            int columns = (panelGame.Width / (OBJECT_WIDTH + GAP_SIZE));

            blueSquares = 0; // set blue squares to 0

            Graphics paper = panelGame.CreateGraphics(); // create graphics

            Random rand = new Random(); // declares a random
            int shapeNum = 0; // variable to store the random


            while (counter <= rows) // while the counter has not exceeded the number of rows
            {
                while (ycounter <= columns)// while the counter has not exceeded the number of columns
                {
                    Pen pen1 = new Pen(Color.Red, 2); // makes a pen
                    SolidBrush br = new SolidBrush(Color.Red); // makes a brush

                    shapeNum = rand.Next(1, 9); // sets the random to between 1 and 8

                    if (shapeNum == 1) // if random variable generates 1, change colour to blue and draw ellipses, and add one to counter
                    {
                        pen1.Color = Color.Blue;
                        br.Color = Color.Blue;
                        paper.FillEllipse(br, x, y, OBJECT_WIDTH, OBJECT_WIDTH);
                        paper.DrawEllipse(pen1, x, y, OBJECT_WIDTH, OBJECT_WIDTH);
                        x += OBJECT_WIDTH + GAP_SIZE; // increases the x by one ball width and gap width
                        ycounter++; // add one to ycounter
                    }
                    else if(shapeNum == 2) // if random variable generates 2, change colour to blue and draw rectangles, and add one to counter
                    {
                        pen1.Color = Color.Blue;
                        br.Color = Color.Blue;
                        paper.FillRectangle(br, x, y, OBJECT_WIDTH, OBJECT_WIDTH);
                        paper.DrawRectangle(pen1, x, y, OBJECT_WIDTH, OBJECT_WIDTH);
                        x += OBJECT_WIDTH + GAP_SIZE; // increases the x by one ball width and gap width
                        ycounter++; // add one to ycounter
                        blueSquares++; // add one to blue squares
                    }
                    else if (shapeNum == 3) // if random variable generates 3, change colour to red and draw ellipses, and add one to counter
                    {
                        pen1.Color = Color.Red;
                        br.Color = Color.Red;
                        paper.FillEllipse(br, x, y, OBJECT_WIDTH, OBJECT_WIDTH);
                        paper.DrawEllipse(pen1, x, y, OBJECT_WIDTH, OBJECT_WIDTH);
                        x += OBJECT_WIDTH + GAP_SIZE; // increases the x by one ball width and gap width
                        ycounter++; // add one to ycounter
                    }
                    else if (shapeNum == 4) // if random variable generates 4, change colour to red and draw rectangles, and add one to counter
                    {
                        pen1.Color = Color.Red;
                        br.Color = Color.Red;
                        paper.FillRectangle(br, x, y, OBJECT_WIDTH, OBJECT_WIDTH);
                        paper.DrawRectangle(pen1, x, y, OBJECT_WIDTH, OBJECT_WIDTH);
                        x += OBJECT_WIDTH + GAP_SIZE; // increases the x by one ball width and gap width
                        ycounter++; // add one to ycounter
                    }
                    else if (shapeNum == 5) // if random variable generates 5, change colour to green and draw ellipses, and add one to counter
                    {
                        pen1.Color = Color.Green;
                        br.Color = Color.Green;
                        paper.FillEllipse(br, x, y, OBJECT_WIDTH, OBJECT_WIDTH);
                        paper.DrawEllipse(pen1, x, y, OBJECT_WIDTH, OBJECT_WIDTH);
                        x += OBJECT_WIDTH + GAP_SIZE; // increases the x by one ball width and gap width
                        ycounter++; // add one to ycounter               
                    }
                    else if (shapeNum == 6) // if random variable generates 6, change colour to green and draw rectangles, and add one to counter
                    {
                        pen1.Color = Color.Green;
                        br.Color = Color.Green;
                        paper.FillRectangle(br, x, y, OBJECT_WIDTH, OBJECT_WIDTH);
                        paper.DrawRectangle(pen1, x, y, OBJECT_WIDTH, OBJECT_WIDTH);
                        x += OBJECT_WIDTH + GAP_SIZE; // increases the x by one ball width and gap width
                        ycounter++; // add one to ycounter
                    }
                    else if (shapeNum == 7) // if random variable generates 7, change colour to purple and draw ellipses, and add one to counter
                    {
                        pen1.Color = Color.Purple;
                        br.Color = Color.Purple;
                        paper.FillEllipse(br, x, y, OBJECT_WIDTH, OBJECT_WIDTH);
                        paper.DrawEllipse(pen1, x, y, OBJECT_WIDTH, OBJECT_WIDTH);
                        x += OBJECT_WIDTH + GAP_SIZE; // increases the x by one ball width and gap width
                        ycounter++; // add one to ycounter               
                    }
                    else if (shapeNum == 8) // if random variable generates 8, change colour to purple and draw rectangles, and add one to counter
                    {
                        pen1.Color = Color.Purple;
                        br.Color = Color.Purple;
                        paper.FillRectangle(br, x, y, OBJECT_WIDTH, OBJECT_WIDTH);
                        paper.DrawRectangle(pen1, x, y, OBJECT_WIDTH, OBJECT_WIDTH);
                        x += OBJECT_WIDTH + GAP_SIZE; // increases the x by one ball width and gap width
                        ycounter++; // add one to ycounter
                    }
                }
                ycounter = 1; // set ycounter back to 1, so it loops properly
                counter++; // add one to counter
                y += OBJECT_WIDTH + GAP_SIZE; // increases the y by one ball width and gap width
                x = 20; // set x to 20, so next row draws properly
            }

            int wait = 0; // the time that it waits (so the user can count the pink balls)

            if (easy == true)
            {
                wait = 10000; // make it easier if easy difficulty
            }
            else if (medium == true)
            {
                wait = 8000; // make it a bit harder if medium difficulty
            }
            else if (hard == true)
            {
                wait = 6000; // make it harder if hard difficulty
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
            instructLbl.Visible = true;
            instructLbl.Text = "How many blue squares were there?";

            scoreTimer.Interval = 20; // quick interval
            scoreTimer.Enabled = true; // enable the timer

            // Note: the checking occurs in the submitBtn click event on Form1.cs
        }
    }
}
