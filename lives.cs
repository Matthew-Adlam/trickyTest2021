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
        /// <summary>
        /// the checkLives function checks the lives that the player has, and then resets everything based on level on and difficulty. it will also update the highScores tables
        /// </summary>
        public void checkLives()
        {
            // decreases lives by 1
            lives--;
            livesLbl.Text = lives.ToString();

            if (lives <= 0)
            {
                endGameScreen();
            }
            else if (level == 5)
            {
                drawBalls();
            }
            else if (level == 6)
            {
                clickBtnClicked = 25;
                actualClickBtnClicked = 25;
                clickyBtn.Text = clickBtnClicked.ToString();
            }
        }

        public void endGameScreen()
        {
            MessageBox.Show("Sorry, you have run out of lives.");
            updateHighScores(score, username);
            homeScreen();
        }
    }
}
