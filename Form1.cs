using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        public bool easy = true;
        public bool medium = false;
        public bool hard = false;

        public string username = "";

        public int score = 0;

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
                this.Close();
            }
        }

        /// <summary>
        /// makes everything visible/invisible etc that is needed. this is called as a function to save space and time
        /// </summary>
        public void homeScreen()
        {
            animation = true;

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
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            animation = false;
            difficultyScreen = true;
            clearPanel();

            exitBtn.Visible = false;
            instructBtn.Visible = false;
            startBtn.Visible = false;
            highScoresBtn.Visible = false;
            homeLbl.Text = "Select a difficulty:";
            easyBtn.Visible = true;
            mediumBtn.Visible = true;
            hardBtn.Visible = true;
            backBtn.Visible = true;
        }

        public void clearPanel()
        {
            panelGame.Refresh();
        }

        public void back()
        {
            if(difficultyScreen == true)
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
            homeLbl.Text = "What is your username?";
        }

        private void easyBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Difficulty set to Easy");
            difficultyBtnPressed();
            easy = true;
            medium = false;
            hard = false;
        }

        private void mediumBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Difficulty set to Medium");
            difficultyBtnPressed();
            easy = false;
            medium = true;
            hard = false;
        }

        private void hardBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Difficulty set to Hard");
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
    }
}
