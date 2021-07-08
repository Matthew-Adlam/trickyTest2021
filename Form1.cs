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
        public bool highScoreScreen = false;
        public bool easy = false;
        public bool medium = false;
        public bool hard = false;
        // current level
        public int level = 0;
        public int hints = 3;

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
            else if(level == 1)
            {

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
            levelLabel.Visible = false;
            levelText.Visible = false;
            levelLbl.Visible = false;
            hintsText.Visible = false;
            hintsLbl.Visible = false;
            pauseMenu.Visible = false;
            listBoxHighScores.Visible = false;
            easyHighScoreBtn.Visible = false;
            mediumHighScoreBtn.Visible = false;
            hardHighScoreBtn.Visible = false;
            picBox1.Visible = false;
            picBox2.Visible = false;
            picBox3.Visible = false;
            instructLbl.Visible = false;
            textBox1.Visible = false;
            submitBtn.Visible = false;

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
            else if(highScoreScreen == true)
            {
                homeScreen();
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
            hints = 3;
            difficultyBtnPressed();
            easy = true;
            medium = false;
            hard = false;
        }

        private void mediumBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Difficulty set to Medium");
            lives = 3;
            hints = 2;
            difficultyBtnPressed();
            easy = false;
            medium = true;
            hard = false;
        }

        private void hardBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Difficulty set to Hard");
            lives = 1;
            hints = 1;
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
                level = 1;
                usernameInput.Visible = false;
                startGame.Visible = false;
                backBtn.Visible = false;
                levelLbl.Visible = true;
                homeLbl.Visible = false;

                Thread.Sleep(500);

                levelLbl.Visible = false;
                scoreTimer.Enabled = true;
                pauseMenu.Visible = true;
                livesLbl.Visible = true;
                livesText.Visible = true;
                scoreLbl.Visible = true;
                scoreText.Visible = true;
                levelLabel.Visible = true;
                levelText.Visible = true;
                hintsLbl.Visible = true;
                hintsText.Visible = true;
                instructLbl.Visible = true;
                livesLbl.Text = lives.ToString();
                scoreLbl.Text = score.ToString();
                levelLabel.Text = level.ToString();
                hintsLbl.Text = hints.ToString();

                if (level == 1)
                {
                    level1();
                }
            }
            else
            {
                MessageBox.Show("Please enter a username.");
            }
           
        }
        /// <summary>
        /// this is the first brain teaser - 'furtherest away from us'. the base code to set it up
        /// </summary>
        public void level1()
        {
            level = 1;
            scoreTimer.Interval = 25;
            instructLbl.Text = "Which is the furtherest away from us?";
            picBox1.Visible = true;
            picBox1.Image = Properties.Resources.sun;
            picBox2.Visible = true;
            picBox2.Image = Properties.Resources.moon;
            picBox3.Visible = true;
            picBox3.Image = Properties.Resources.cloud;
        }

        /// <summary>
        /// upon every tick of the score timer, decrease the potential score by 1, and if it reaches 0 or lower, set it to 0 to ensure no negative scores
        /// </summary>
        private void scoreTimer_Tick(object sender, EventArgs e)
        {
            scoreTime--;
            if(scoreTime <= 0)
            {
                scoreTime = 0;
            }
        }

        /// <summary>
        /// ends the level by stopping the timer
        /// </summary>
        public void endLevel()
        {
            scoreTimer.Enabled = false;
            clearPanel();
            score += scoreTime;
            scoreLbl.Text = score.ToString();
            scoreTime = 1000;
            level++;
            levelLabel.Text = level.ToString();

            if (level == 2)
            {
                level2();
            }
            else if(level == 3)
            {
                level3();
            }
            else if(level == 4)
            {
                level4();
            }
        }

        /// <summary>
        /// the exit menu strip item
        /// </summary>
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

        /// <summary>
        /// the instructions given to the user on click of the button
        /// </summary>
        private void instructBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Tricky Test. This game will challenge all aspects of your thinking, strategy and skill.");
            MessageBox.Show("Some of the levels require lateral thinking, and thinking outside the box. \n Note: The obvious answer might not be the correct one. \n Watch out for this in level 1. \n The levels get longer as they go. Be ready.");
            MessageBox.Show("Click the High Scores button to display high scores, or click Start Game to play. \n Note: Your score is determined by how many levels you complete and how fast you complete them.");
            MessageBox.Show("Click the ingame menu to access hints, pause the game or exit.");
        }

        /// <summary>
        /// upon high score button being clicked on home menu
        /// </summary>
        private void highScoresBtn_Click(object sender, EventArgs e)
        {
            easyHighScoreBtn.Visible = true;
            mediumHighScoreBtn.Visible = true;
            hardHighScoreBtn.Visible = true;
            startBtn.Visible = false;
            highScoresBtn.Visible = false;
            instructBtn.Visible = false;
            exitBtn.Visible = false;
            backBtn.Visible = true;
            highScoreScreen = true;
        }

        /// <summary>
        /// when user selects option to view easy scores
        /// </summary>
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

        /// <summary>
        /// when user selects option to view medium scores
        /// </summary>
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

        /// <summary>
        /// when user selects option to view hard scores
        /// </summary>
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
        /// <summary>
        /// the base code to set up level 2
        /// </summary>
        public void level2()
        {
            instructLbl.Text = "What comes directly after 2?";
            picBox1.Visible = false;
            picBox2.Visible = false;
            picBox3.Visible = false;
            textBox1.Visible = true;
            submitBtn.Visible = true;
            scoreTimer.Enabled = true;
            scoreTimer.Interval = 24;
        }

        /// <summary>
        /// if the sun is selected, return wrong
        /// </summary>
        private void picBox1_Click(object sender, EventArgs e)
        {
            if(level == 1)
            {
                MessageBox.Show("Sorry, that is wrong.");
                checkLives();
            }
        }

        /// <summary>
        /// if the moon is selected, return wrong
        /// </summary>
        private void picBox2_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                MessageBox.Show("Sorry, that is wrong.");
                checkLives();
            }
        }

        /// <summary>
        /// if the cloud is selected, return correct
        /// </summary>
        private void picBox3_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                MessageBox.Show("Congratulations! The cloud is furtherest away from the word us.");
                endLevel();
            }
        }

        /// <summary>
        /// the submit button for level 2 and 3
        /// </summary>
        private void submitBtn_Click(object sender, EventArgs e)
        {
            // if level 2
            if(level == 2)
            {
                if(textBox1.Text == "?")
                {
                    MessageBox.Show("Congratulations! ? comes DIRECTLY after 2.");
                    endLevel();
                }
                else
                {
                    MessageBox.Show("Sorry, that is wrong.");
                    checkLives();
                }
            }
            
            else if(level == 3)
            {
                if(textBox1.Text == "91" || textBox1.Text == "91st")
                {
                    MessageBox.Show("Congratulations! You will be in 91st place if you overtake 91st place.");
                    endLevel();
                }
                else
                {
                    MessageBox.Show("Sorry, that is wrong.");
                    checkLives();
                }
            }
        }

        /// <summary>
        /// the base code to set up level 3
        /// </summary>
        public void level3()
        {
            instructLbl.Text = "If you overtake the 91st person in a race, \n which place are you in?";
            textBox1.Visible = true;
            textBox1.Text = "";
            submitBtn.Visible = true;
            scoreTimer.Enabled = true;
        }

        /// <summary>
        /// give players hints. Hint number is determined by difficulty - 3 for easy, 2 for medium and 1 for hard.
        /// </summary>
        private void hintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(hints > 0)
            {
                if (level == 1)
                {
                    MessageBox.Show("What do you think I mean by us?");
                    hints--;
                    hintsLbl.Text = hints.ToString();
                }
                else if (level == 2)
                {
                    MessageBox.Show("Look at the sentence involving 2.");
                    hints--;
                    hintsLbl.Text = hints.ToString();
                }
                else if (level == 3)
                {
                    MessageBox.Show("If you overtake first place, what place are you then? Same deal.");
                    hints--;
                    hintsLbl.Text = hints.ToString();
                }
            }
            else
            {
                MessageBox.Show("Sorry, no hints remaining.");
            }

        }

        /// <summary>
        /// the base code to start level 4
        /// </summary>
        public void level4()
        {

        }
    }
}
