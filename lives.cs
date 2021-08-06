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
            // decreases lives by 1, and displays it
            lives--;
            livesLbl.Text = lives.ToString();

            if (lives <= 0) // if user runs out of lives
            {
                endGameScreen(); // call method
            }
            else if (level == 5) // if they lose a life on level 5, call the drawBalls method so the user can try again
            {
                drawBalls();
            }
            else if (level == 6) // if they lose a life on level 6, set the button actual and fake click variables to 25, and display the fake one
            {
                clickBtnClicked = 25;
                actualClickBtnClicked = 25;
                clickyBtn.Text = clickBtnClicked.ToString();
            }
            else if(level == 9) // if they lose a life on level 5, call the drawShapes method so the user can try again
            {
                drawShapes();
            }
        }


        /// <summary>
        /// when the user loses all their lives, this method is run
        /// </summary>
        public void endGameScreen()
        {
            MessageBox.Show("Sorry, you have run out of lives. \n Try again for a higher score! \n Check the high score board to see if you made it!"); // give user a message
            homeScreen(); // call the homeScreen method, which displays the starting screen again
        }

        /// <summary>
        /// when the user beats the final level
        /// </summary>
        public void level10Beaten()
        {
            MessageBox.Show("Congratulations! You have completed the final level of Tricky Test! \n You are really smart, and you should be proud of yourself! \n Check the high score board to see if you made it!");
            homeScreen(); // call the homeScreen method, which displays the starting screen again
        }
    }
}
