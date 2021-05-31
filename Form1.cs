using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trickyTest2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // variables decleration

        public bool inGame = false;

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
            if(inGame == false)
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
            string question = "Do you want to exit this program?";
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
            inGame = false;

            exitBtn.Visible = true;
            instructBtn.Visible = true;
            startBtn.Visible = true;
            highScoresBtn.Visible = true;
            homeLbl.Visible = true;
        }
    }
}
