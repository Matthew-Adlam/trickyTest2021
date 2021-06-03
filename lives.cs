﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trickyTest2021
{
    partial class Form1
    {
        /// <summary>
        /// the checkLives function checks the lives that the player has, and then resets everything based on level on and difficulty. it will also update the highScores tables
        /// </summary>
        public void checkLives()
        {
            // decreases lives by 1
            lives--;
            livesLbl.Text = lives.ToString();

            if(lives <= 0)
            {
                endGameScreen();
            }
            else if (lvl1 == true)
            {
                // reset for special conditions for level 1
                MessageBox.Show("Move your mouse to the left side of the screen. You have been warned. You have two seconds.");

                Thread.Sleep(2000);
            }
        }

        public void endGameScreen()
        {
            // update high scores
            // reset back to main page
        }
    }
}
