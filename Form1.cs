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

        // variables decleration. These are all the necessary variables that need to be declared here

        // home screen animation
        public bool animation = true;
        // the different screens - correspond with the method
        public bool difficultyScreen = false;
        public bool nameScreen = false;
        public bool highScoreScreen = false;
        // the difficulties
        public bool easy = false;
        public bool medium = false;
        public bool hard = false;
        // current level, and hints
        public int level = 0;
        public int hints = 3;
        // users name
        public string username = "";
        // score, lives and the score gained per level(runs off timer)
        public int score = 0;
        public int lives = 5;
        public int scoreTime = 1000;
        // not relevant at the moment
        public Random randomLvl = new Random();
        public int randomLvlInt = 0;
        // both of these are for lvl 6
        public int clickBtnClicked = 25; 
        public int actualClickBtnClicked = 25;

        /// <summary>
        /// upon load of the form
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            homeScreen(); // call homeScreen method

        }

        /// <summary>
        /// nothing yet
        /// </summary>
        private void panelGame_Paint(object sender, PaintEventArgs e)
        {
        }
        /// <summary>
        /// The home screen animations, only work if user is not in game, i.e. on home screen
        /// </summary>
        private void panelGame_MouseMove(object sender, MouseEventArgs e)
        {
            if(animation == true) // if the current screen allows animation
            {
                // declares two random variables, one for colour and one for size
                Random colorRnd = new Random();
                Random sizeRnd = new Random();
                int size = sizeRnd.Next(5, 15); // declares size as the random output
                Color randColor = Color.FromArgb(colorRnd.Next(256), colorRnd.Next(256), colorRnd.Next(256)); // makes the random colour based off colorRnd
                Graphics homeScreen = panelGame.CreateGraphics(); // declare graphics
                Pen pen1 = new Pen(randColor, 2); // make pen
                SolidBrush br = new SolidBrush(randColor); // make brush
                // draw the ellipse off the parameters: brush/pen, mouse position give or take sizeRnd, and the size
                homeScreen.FillEllipse(br, e.X + sizeRnd.Next(-10, 10), e.Y + sizeRnd.Next(-10, 10), size, size); 
                homeScreen.DrawEllipse(pen1, e.X + sizeRnd.Next(-10, 10), e.Y + sizeRnd.Next(-10, 10), size, size);

            }
        }
        /// <summary>
        /// the code to exit the game, confirm that the user wants to
        /// </summary>
        private void exitBtn_Click(object sender, EventArgs e)
        {
            // confirms exit, if yes is pressed closes the form
            string question = "Do you want to exit this game?"; // make a string
            string title = "Exit Program"; // make another string
            MessageBoxButtons buttons = MessageBoxButtons.YesNo; // declare messagebox buttons as yes/no
            DialogResult result = MessageBox.Show(question, title, buttons, MessageBoxIcon.Question); // show the result with the buttons, the title and the question
            if (result == DialogResult.Yes) // if user types yes, exit the application
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// makes everything visible/invisible etc that is needed. this is called as a function to save space and time
        /// </summary>
        public void homeScreen()
        {
            clearPanel();
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
            picBox4.Visible = false;
            instructLbl.Visible = false;
            textBox1.Visible = false;
            submitBtn.Visible = false;
            findXLbl.Visible = false;
            clickyBtn.Visible = false;
            picBox1Lbl.Visible = false;
            picBox2Lbl.Visible = false;
            picBox3Lbl.Visible = false;

            clearPanel(); // clear panel
            homeLbl.Text = "Tricky Test"; // set the text
            this.ActiveControl = startBtn; // set active control to startBtn
        }

        /// <summary>
        /// when start button is clicked
        /// </summary>
        private void startBtn_Click(object sender, EventArgs e)
        {
            goToDifficultyScreen(); // call the method for displaying the difficulty menu
        }

        /// <summary>
        /// when clearPanel is called, refresh the panel
        /// </summary>
        public void clearPanel()
        {
            panelGame.Refresh();
        }

        /// <summary>
        /// the method called at the difficulty screen. this makes everything visible/invisible that needs to be
        /// </summary>
        public void goToDifficultyScreen()
        {
            animation = false; // disables the animation 
            difficultyScreen = true; // difficulty screen is set to true
            nameScreen = false; // but its not name screen
            clearPanel(); // clear panel

            exitBtn.Visible = false;
            instructBtn.Visible = false;
            startBtn.Visible = false;
            highScoresBtn.Visible = false;
            usernameInput.Visible = false;
            startGame.Visible = false;
            homeLbl.Text = "Select a \n difficulty:";
            easyBtn.Visible = true;
            mediumBtn.Visible = true;
            hardBtn.Visible = true;
            backBtn.Visible = true;
        }

        /// <summary>
        /// upon click of back button, checks what screen it is on, and then go back to the correct previous screen
        /// </summary>
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

        /// <summary>
        /// call the back method upon click of back button
        /// </summary>
        private void backBtn_Click(object sender, EventArgs e)
        {
            back();
        }

        /// <summary>
        /// upon a difficulty button being pressed, go to the username input screen - makes elements visible/invisible
        /// </summary>
        public void difficultyBtnPressed()
        {
            easyBtn.Visible = false;
            mediumBtn.Visible = false;
            hardBtn.Visible = false;
            usernameInput.Visible = true;
            startGame.Visible = true;
            difficultyScreen = false;
            nameScreen = true;
            homeLbl.Text = "What is your \n username?";
        }

        /// <summary>
        /// upon the easy difficulty button being clicked
        /// </summary>
        private void easyBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Difficulty set to Easy"); // display message to user
            lives = 5; // set lives to 5 because its easy
            hints = 3; // give user 3 hints
            difficultyBtnPressed(); // call above method
            // set easy to true and others to false
            easy = true;
            medium = false;
            hard = false;
        }

        /// <summary>
        /// upon the medium difficulty button being clicked
        /// </summary>
        private void mediumBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Difficulty set to Medium"); // display message to user
            lives = 3; // set lives to 3 because its medium
            hints = 2; // give user 2 hints
            difficultyBtnPressed(); // call above method
            // set medium to true and others to false
            easy = false;
            medium = true;
            hard = false;
        }

        /// <summary>
        /// upon the hard difficulty button being clicked
        /// </summary>
        private void hardBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Difficulty set to Hard"); // display message to user
            lives = 1; // set lives to 1 because its hard
            hints = 1; // give user 1 hint
            difficultyBtnPressed(); // call above method
            // set hard to true and others to false
            easy = false;
            medium = false;
            hard = true;
        }

        /// <summary>
        /// when the text in the username is changed
        /// </summary>
        private void usernameInput_TextChanged(object sender, EventArgs e)
        {
            // sets string text to the bet text box
            string text = usernameInput.Text;
            // checks for null
            if (text.Trim() == "") return;
            for (int i = 0; i < text.Length; i++)
            {
                // if not a letter, not let it through
                if (!char.IsLetter(text[i]))
                {
                    MessageBox.Show("Please enter a valid username, one with only letters");
                    usernameInput.Text = "";
                    return;
                }

            }
            username = usernameInput.Text; // set username to the text box's text
        }


        /// <summary>
        /// when the game starts, and the user has a valid username, start the game
        /// </summary>
        private void startGame_Click(object sender, EventArgs e)
        {
            if(usernameInput.Text != "") // if username is not null,
            {
                level = 1; // make the level 1
                score = 0; // set score to 0

                // make these controls invisible
                usernameInput.Visible = false;
                startGame.Visible = false;
                backBtn.Visible = false;
                homeLbl.Visible = false;

                Thread.Sleep(250); // wait 1/4 of a second, give user time to get ready

                // make these controls visible
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
                // update the lives, score, level and hints and display them
                livesLbl.Text = lives.ToString();
                scoreLbl.Text = score.ToString();
                levelLabel.Text = level.ToString();
                hintsLbl.Text = hints.ToString();

                // start level 1 if it is level 1
                if (level == 1)
                {
                    level1();
                }
            }
            else
            {
                MessageBox.Show("Please enter a username."); // if username is null
            }
           
        }
        /// <summary>
        /// this is the first brain teaser - 'furtherest away from us'. the base code to set it up
        /// </summary>
        public void level1()
        {
            level = 1; // set level to 1
            scoreTimer.Interval = 35; // timer interval 35 ms
            instructLbl.Text = "Which is the furtherest away from us?"; // set text
            // make the picture boxes visible and displaying their respective images
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
        /// ends the level by stopping the timer, moves on to the next level, displays new score and level, resets timer
        /// </summary>
        public void endLevel()
        {
            scoreTimer.Enabled = false; // stop timer
            clearPanel(); // clear panel
            score += scoreTime; // add new score to total
            scoreLbl.Text = score.ToString(); // display score
            scoreTime = 1000; // reset scoreTime
            level++; // next level
            levelLabel.Text = level.ToString(); // display level

            // move on to next level, call corresponding method
            if (level == 2)
            {
                level2();
            }
            else if (level == 3)
            {
                level3();
            }
            else if (level == 4)
            {
                level4();
            }
            else if (level == 5)
            {
                MessageBox.Show("Count the number of pink circles. You have a few seconds.");
                level5();
            }
            else if(level == 6)
            {
                level6();
            }
            else if(level == 7)
            {
                level7();
            }
            else if(level == 8)
            {
                level8();
            }
            else if(level == 9)
            {
                MessageBox.Show("Count the number of blue squares. You have a few seconds.");
                level9();
            }
        }

        /// <summary>
        /// the exit menu strip item
        /// </summary>
        private void exitGameToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            scoreTimer.Enabled = false; // disables the timer
            // confirms exit, if yes is pressed closes the form
            string question = "Do you want to exit this game?";
            string title = "Exit Game";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(question, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                highScoreScreen = false;
                homeScreen();
                updateHighScores(score, username);
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
            MessageBox.Show("Click the ingame menu to access hints, pause the game or exit. \n Number of hints will be determined based on difficulty. \n Feel free to post an issue in the repository if you think the hints make it too easy or are not good enough, or if you have any other suggestions/feedback regarding this.");
        }

        /// <summary>
        /// upon high score button being clicked on home menu
        /// </summary>
        private void highScoresBtn_Click(object sender, EventArgs e)
        {
            clearPanel();
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
            updateHighScores(score, username); // call method
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
            updateHighScores(score, username); // call method
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
            updateHighScores(score, username); // call method
        }
        /// <summary>
        /// the base code to set up level 2, i.e. displaying the right elements, giving the user instructions and changing the timer interval
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
            scoreTimer.Interval = 35; // set the timer interval 
        }

        /// <summary>
        /// upon click of the picture box, it acts differently based on level, in this case picBox1 is incorrect for levels 1 and 7
        /// </summary>
        private void picBox1_Click(object sender, EventArgs e)
        {
            if(level == 1 || level == 7)
            {
                MessageBox.Show("Sorry, that is wrong.");
                checkLives();
            }
        }

        /// <summary>
        /// upon click of the picture box, it acts differently based on level, in this case picBox2 is incorrect for level 1, but correct for level 7
        /// </summary>
        private void picBox2_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                MessageBox.Show("Sorry, that is wrong.");
                checkLives();
            }
            else if (level == 7)
            {
                MessageBox.Show("Congratulations. You possess logic!");
                endLevel();
            }
        }

        /// <summary>
        /// upon click of the picture box, it acts differently based on level, in this case picBox3 is correct for level 1, but incorrect for level 7
        /// </summary>
        private void picBox3_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {
                MessageBox.Show("Congratulations! The cloud is furtherest away from the word us.");
                endLevel();
            }
            else if (level == 7)
            {
                MessageBox.Show("Sorry, that is wrong.");
                checkLives();
            }
        }

        /// <summary>
        /// the submit button for several levels. If the text in the text box matches what it is supposed to, return correct and move on the levels. If it doesn't match, return incorrect and lose a life
        /// </summary>
        private void submitBtn_Click(object sender, EventArgs e)
        {
            // if level 2, check for the ? symbol
            if (level == 2)
            {
                if (textBox1.Text == "?")
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
            // if level 3, check for the user putting 91 or any sensible variation
            else if (level == 3)
            {
                if (textBox1.Text == "91" || textBox1.Text == "91st")
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
            // if level 4, return incorrect as the user has to click on the x
            else if (level == 4)
            {
                MessageBox.Show("Sorry, that is wrong.");
            }
            // if it matches the correct amount of pink balls
            else if (level == 5)
            {
                if(textBox1.Text == pinkBalls.ToString())
                {
                    MessageBox.Show("You have a good memory. Nice!");
                    endLevel();
                }
                else
                {
                    MessageBox.Show("Sorry, that is wrong.");
                    checkLives();
                }
            }
            // if the user has actually clicked on the button 25 times, regardless of what the button displays
            else if(level == 6)
            {
                if(actualClickBtnClicked == 0)
                {
                    MessageBox.Show("I didn't fool you? Great work!");
                    endLevel();
                }
                else
                {
                    MessageBox.Show("Sorry, that is wrong. The clicks have been reset.");
                    checkLives();
                }
            }
            else if(level == 8)
            {
                if(textBox1.Text == "6")
                {
                    MessageBox.Show("Well done! Two sleves, the neck hole, the bottom, and TWO in the center hole.");
                    endLevel();
                }
                else
                {
                    MessageBox.Show("Sorry, that is wrong.");
                    checkLives();
                }
            }
            else if (level == 9)
            {
                if (textBox1.Text == blueSquares.ToString())
                {
                    MessageBox.Show("You have a good memory. Nice!");
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
            scoreTimer.Interval = 35; // set the timer interval 
        }

        /// <summary>
        /// give players hints. Hint number is determined by difficulty - 3 for easy, 2 for medium and 1 for hard.
        /// </summary>
        private void hintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(hints > 0) // if user has hints remaining
            {
                // same format for most levels(displayed by level 1)
                if (level == 1)
                {
                    MessageBox.Show("What do you think I mean by us?"); // give the hint
                    hints--; // take 1 hint away
                    hintsLbl.Text = hints.ToString(); // display new number of hints
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
                else if (level == 4)
                {
                    MessageBox.Show("Who said you had to do math?");
                    hints--;
                    hintsLbl.Text = hints.ToString();
                }
                else if (level == 5 || level == 6 || level == 8 || level == 9) // doesnt take hints away, as hints are kind of useless or spoil these levels
                {
                    MessageBox.Show("No hint allowed for this level.");
                }
                else if(level == 7)
                {
                    MessageBox.Show("Try the first statement being true, and seeing if that works.");
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
            instructLbl.Text = "Quick, find x";
            submitBtn.Visible = true;
            scoreTimer.Enabled = true;
            scoreTimer.Interval = 38; // make the interval higher
            textBox1.Visible = true;
            textBox1.Text = "";

            findXLbl.Visible = true;
            findXLbl.Text = "x^6 + 8x^4 - 2x^2 + 4x - (123*8x)-5x = 0"; // set it to such a ridiculous equation
        }

        /// <summary>
        /// if the instruction label, which displays "Quick, find x" at the time, is clicked on, the user found x, so move on to level 5
        /// </summary>
        private void instructLbl_Click(object sender, EventArgs e)
        {
            if (level == 4)
            {
                MessageBox.Show("Nice! You found x!");
                endLevel();
                // instructLbl.Text = "How many pink circles were there?";

            }
        }

        /// <summary>
        /// the base code to start level 5
        /// </summary>
        public void level5()
        {
            instructLbl.Text = "";
            livesLbl.Visible = false;
            livesText.Visible = false;
            scoreLbl.Visible = false;
            scoreText.Visible = false;
            levelLabel.Visible = false;
            levelText.Visible = false;
            hintsText.Visible = false;
            hintsLbl.Visible = false;

            Thread.Sleep(400); // pause the screen for 400ms

            submitBtn.Visible = false;
            textBox1.Text = "";
            textBox1.Visible = false;
            findXLbl.Visible = false;
            drawBalls(); // call drawBalls method in the drawBalls.cs class
        }

        /// <summary>
        /// the base code to start level 6
        /// </summary>
        public void level6()
        {
            submitBtn.Visible = true;
            textBox1.Text = "";
            textBox1.Visible = false;
            instructLbl.Visible = true;
            instructLbl.Text = "Click the pink button 25 times.";
            scoreTimer.Enabled = true;
            clickyBtn.Visible = true;

            scoreTimer.Interval = 34; // make it a little harder to earn points
        }

        /// <summary>
        /// code to pause the game, stopping the timer and giving the user the choice of when they resume
        /// </summary>
        private void pauseGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scoreTimer.Enabled = false; // pause timer

            MessageBoxButtons buttons = MessageBoxButtons.OK; // set buttons to OK
            string msg = "The game is paused. Press OK to unpause the game."; // declare msg string
            string title = "Paused"; // declare title
            DialogResult result = MessageBox.Show(msg, title, buttons); // display msg box

            if(result == DialogResult.OK) // if OK pressed, resume
            {
                scoreTimer.Enabled = true;
            }

        }

        /// <summary>
        /// the click button for level 6, upon click each time it has a slight chance to offset the number that the button displays, which is how the user is tested
        /// </summary>
        private void clickyBtn_Click(object sender, EventArgs e)
        {
            Random rand = new Random(); // make a random
            int offset = rand.Next(-2, 3); // the offset to the buttons number
            int chance = rand.Next(1, 11); // the chance for offset to happen

            if(chance == 1) // a 1/10 chance, as .Next works that maxValue is exclusive, but minValue is inclusive
            {
                clickBtnClicked += offset; // offset the fake number of clicks
            }
            else
            {
                clickBtnClicked--; // decrease fake number normally
            }

            clickyBtn.Text = clickBtnClicked.ToString(); // display FAKE number
            actualClickBtnClicked--; // regardless of offset, decrease actual number normally
        }

        /// <summary>
        /// the base code necessary to start level 7
        /// </summary>
        public void level7()
        {
            scoreTimer.Interval = 28; // set the timer interval 
            clickyBtn.Visible = false;
            submitBtn.Visible = false;
            instructLbl.Visible = true;
            instructLbl.Text = "There is a reward in one of the three boxes. \n If only one statement is true, where is the reward?";
            picBox1.Image = Properties.Resources.box1; // set the image
            picBox1.Visible = true; // make it visible
            picBox1Lbl.Visible = true; // make the message visible
            picBox1Lbl.Text = "The reward is in this box."; // set the associated message
            picBox2.Image = Properties.Resources.box2;
            picBox2.Visible = true;
            picBox2Lbl.Visible = true;
            picBox2Lbl.Text = "The reward is not in this box.";
            picBox3.Image = Properties.Resources.box3;
            picBox3.Visible = true;
            picBox3Lbl.Visible = true;
            picBox3Lbl.Text = "The reward is not in box 1 (the top box).";

            scoreTimer.Enabled = true;
        }

        /// <summary>
        /// the base code necessary to start level 8
        /// </summary>
        public void level8()
        {
            picBox1.Visible = false;
            picBox2.Visible = false;
            picBox3.Visible = false;
            picBox4.Visible = true;
            picBox1Lbl.Visible = false;
            picBox2Lbl.Visible = false;
            picBox3Lbl.Visible = false;
            submitBtn.Visible = true;
            textBox1.Visible = true;
            textBox1.Text = "";
            instructLbl.Visible = true;
            instructLbl.Text = "How many holes in this shirt?";
            scoreTimer.Interval = 24; // super fast
            scoreTimer.Enabled = true;
            picBox4.BackgroundImage = Properties.Resources.shirt;
        }

        public void level9()
        { 
            picBox4.Visible = false;
            instructLbl.Text = "";
            livesLbl.Visible = false;
            livesText.Visible = false;
            scoreLbl.Visible = false;
            scoreText.Visible = false;
            levelLabel.Visible = false;
            levelText.Visible = false;
            hintsText.Visible = false;
            hintsLbl.Visible = false;

            Thread.Sleep(400); // pause the screen for 400ms

            submitBtn.Visible = false;
            textBox1.Text = "";
            textBox1.Visible = false;
            findXLbl.Visible = false;
            drawShapes(); // call drawBalls method in the drawBalls.cs class
        }
    }
}
