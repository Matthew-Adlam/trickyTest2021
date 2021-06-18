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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // variables decleration

        // home screen animation
        public bool animation = true;
        public bool difficultyScreen = false;
        public bool nameScreen = false;
        public bool easy = true;
        public bool medium = false;
        public bool hard = false;
        // the lvl(n) is for if that level is being played
        public bool lvl1 = false;
        public bool lvl1Played = false;
        public bool lvl2Played = false;
        public bool lvl3Played = false;

        public string username = "";

        public int score = 0;
        public int lives = 5;
        public int scoreTime = 1000;

        public Random randomLvl = new Random();
        public int randomLvlInt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            homeScreen();
        }

        private void panelGame_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// The home screen animations, only work if user is not in game, i.e. on home screen
        /// </summary>
        private void panelGame_MouseMove(object sender, MouseEventArgs e)
        {
            if(animation == true)
            {
                Random colorRnd = new Random();
                Random sizeRnd = new Random();
                int size = 50;
                size = sizeRnd.Next(5, 15);
                Color randColor = Color.FromArgb(colorRnd.Next(256), colorRnd.Next(256), colorRnd.Next(256));
                Graphics homeScreen = panelGame.CreateGraphics();
                Pen pen1 = new Pen(randColor, 2);
                SolidBrush br = new SolidBrush(randColor);
                homeScreen.FillEllipse(br, e.X + sizeRnd.Next(-10, 10), e.Y + sizeRnd.Next(-10, 10), size, size);
                homeScreen.DrawEllipse(pen1, e.X + sizeRnd.Next(-10, 10), e.Y + sizeRnd.Next(-10, 10), size, size);

            }
            // if playing 'don't touch blue' level
            else if(lvl1 == true)
            {
                // checks for mouse position - if it is in the same position as blue colour
                int x = e.X;
                int y = e.Y;
                if (x > 100 || x < (panelGame.Width-100))
                {
                    checkLives();
                }
            }
        }
        /// <summary>
        /// the code to exit the game, confirm that the user wants to
        /// </summary>
        private void exitBtn_Click(object sender, EventArgs e)
        {
            // confirms exit, if yes is pressed closes the form
            string question = "Do you want to exit this game?";
            string title = "Exit Program";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(question, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// makes everything visible/invisible etc that is needed. this is called as a function to save space and time
        /// </summary>
        public void homeScreen()
        {
            animation = true;
            difficultyScreen = false;
            nameScreen = false;

            exitBtn.Visible = true;
            instructBtn.Visible = true;
            startBtn.Visible = true;
            highScoresBtn.Visible = true;
            homeLbl.Visible = true;
            easyBtn.Visible = false;
            mediumBtn.Visible = false;
            hardBtn.Visible = false;
            backBtn.Visible = false;
            usernameInput.Visible = false;
            startGame.Visible = false;
            level1TextBox.Visible = false;
            livesLbl.Visible = false;
            livesText.Visible = false;
            scoreLbl.Visible = false;
            scoreText.Visible = false;
            levelLbl.Visible = false;
            goBtn.Visible = false;
            pauseMenu.Visible = false;
            listBoxHighScores.Visible = false;
            easyHighScoreBtn.Visible = false;
            mediumHighScoreBtn.Visible = false;
            hardHighScoreBtn.Visible = false;

            clearPanel();
            homeLbl.Text = "Tricky Test";
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            goToDifficultyScreen();
        }

        public void clearPanel()
        {
            panelGame.Refresh();
        }

        public void goToDifficultyScreen()
        {
            animation = false;
            difficultyScreen = true;
            nameScreen = false;
            clearPanel();

            exitBtn.Visible = false;
            instructBtn.Visible = false;
            startBtn.Visible = false;
            highScoresBtn.Visible = false;
            usernameInput.Visible = false;
            startGame.Visible = false;
            homeLbl.Text = "Select a difficulty:";
            easyBtn.Visible = true;
            mediumBtn.Visible = true;
            hardBtn.Visible = true;
            backBtn.Visible = true;
        }

        public void back()
        {
            if(difficultyScreen == true)
            {
                homeScreen();
            }
            else if(nameScreen == true)
            {
                goToDifficultyScreen();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            back();
        }

        public void difficultyBtnPressed()
        {
            easyBtn.Visible = false;
            mediumBtn.Visible = false;
            hardBtn.Visible = false;
            usernameInput.Visible = true;
            startGame.Visible = true;
            difficultyScreen = false;
            nameScreen = true;
            homeLbl.Text = "What is your username?";
        }

        private void easyBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Difficulty set to Easy");
            lives = 5;
            difficultyBtnPressed();
            easy = true;
            medium = false;
            hard = false;
        }

        private void mediumBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Difficulty set to Medium");
            lives = 3;
            difficultyBtnPressed();
            easy = false;
            medium = true;
            hard = false;
        }

        private void hardBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Difficulty set to Hard");
            lives = 1;
            difficultyBtnPressed();
            easy = false;
            medium = false;
            hard = true;
        }

        private void usernameInput_TextChanged(object sender, EventArgs e)
        {
            // sets string text to the bet text box
            string text = usernameInput.Text;
            // checks for null
            if (text.Trim() == "") return;
            for (int i = 0; i < text.Length; i++)
            {
                // if not a number, not let it through
                if (!char.IsLetter(text[i]))
                {
                    MessageBox.Show("Please enter a valid username, one with only letters");
                    usernameInput.Text = "";
                    return;
                }

            }
            username = usernameInput.Text;
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            if(usernameInput.Text != "")
            {
                usernameInput.Visible = false;
                startGame.Visible = false;
                levelLbl.Visible = true;
                homeLbl.Visible = false;
                backBtn.Visible = false;
                MessageBox.Show("Move your mouse to the left side of the screen, for the first level. You have been warned. You have two seconds.");


                Thread.Sleep(2000);

                scoreTimer.Enabled = true;
                pauseMenu.Visible = true;
                homeLbl.Visible = false;
                livesLbl.Visible = true;
                livesText.Visible = true;
                scoreLbl.Visible = true;
                scoreText.Visible = true;
                livesLbl.Text = lives.ToString();
                randomLvlInt = randomLvl.Next(1, 2);

                if (randomLvlInt == 1 && lvl1Played == false)
                {
                    level1();
                    lvl1 = true;

                }
                else if (randomLvlInt == 2 && lvl2Played == false)
                {

                }
                else if (randomLvlInt == 3 && lvl3Played == false)
                {

                }
            }
            else
            {
                MessageBox.Show("Please enter a username.");
            }
           
        }
        public void level1()
        {
            homeLbl.Text = "Don't touch blue!";
            goBtn.Visible = true;

            Graphics homeScreen = panelGame.CreateGraphics();
            Pen pen1 = new Pen(Color.Blue, 2);
            Pen pen2 = new Pen(Color.Green, 2);
            SolidBrush br = new SolidBrush(Color.Blue);
            SolidBrush br2 = new SolidBrush(Color.Green);
            homeScreen.FillRectangle(br2, 0, 0, 100, panelGame.Height);
            homeScreen.DrawRectangle(pen2, 0, 0, 100, panelGame.Height);
            homeScreen.FillRectangle(br2, panelGame.Width-100, 0, 100, panelGame.Height);
            homeScreen.DrawRectangle(pen2, panelGame.Width-100, 0, 100, panelGame.Height);
            homeScreen.FillRectangle(br, 100, 0, 800, panelGame.Height);
            homeScreen.DrawRectangle(pen1, 100, 0, 800, panelGame.Height);
        }

        /// <summary>
        /// the go button to complete level 1
        /// </summary>
        private void goBtn_Click(object sender, EventArgs e)
        {
            lvl1 = false;
            endLevel();
        }

        private void scoreTimer_Tick(object sender, EventArgs e)
        {
            scoreTime--;
            if(scoreTime <= 0)
            {
                scoreTime = 0;
            }
        }

        public void endLevel()
        {
            goBtn.Enabled = false;
            scoreTimer.Enabled = false;
            score += scoreTime;
            scoreLbl.Text = score.ToString();
            scoreTime = 1000;
        }

        private void exitGameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            scoreTimer.Enabled = false;
            // confirms exit, if yes is pressed closes the form
            string question = "Do you want to exit this game?";
            string title = "Exit Game";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(question, title, buttons);
            if (result == DialogResult.Yes)
            {
                homeScreen();
            }
            else if(result == DialogResult.No)
            {
                scoreTimer.Enabled = true;
            }
        }

        private void instructBtn_Click(object sender, EventArgs e)
        {
            // instructions here
        }

        private void highScoresBtn_Click(object sender, EventArgs e)
        {
            easyHighScoreBtn.Visible = true;
            mediumHighScoreBtn.Visible = true;
            hardHighScoreBtn.Visible = true;
            startBtn.Visible = false;
            highScoresBtn.Visible = false;
            instructBtn.Visible = false;
            exitBtn.Visible = false;
        }

        private void easyHighScoreBtn_Click(object sender, EventArgs e)
        {
            easyHighScoreBtn.Visible = false;
            mediumHighScoreBtn.Visible = false;
            hardHighScoreBtn.Visible = false;
            easy = true;
            medium = false;
            hard = false;
            updateHighScores(score, username);
        }

        private void mediumHighScoreBtn_Click(object sender, EventArgs e)
        {
            easyHighScoreBtn.Visible = false;
            mediumHighScoreBtn.Visible = false;
            hardHighScoreBtn.Visible = false;
            easy = false;
            medium = true;
            hard = false;
            updateHighScores(score, username);
        }

        private void hardHighScoreBtn_Click(object sender, EventArgs e)
        {
            easyHighScoreBtn.Visible = false;
            mediumHighScoreBtn.Visible = false;
            hardHighScoreBtn.Visible = false;
            easy = false;
            medium = false;
            hard = true;
            updateHighScores(score, username);
        }
    }
}
