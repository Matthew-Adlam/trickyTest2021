
namespace trickyTest2021
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelGame = new System.Windows.Forms.Panel();
            this.hardHighScoreBtn = new System.Windows.Forms.Button();
            this.mediumHighScoreBtn = new System.Windows.Forms.Button();
            this.easyHighScoreBtn = new System.Windows.Forms.Button();
            this.listBoxHighScores = new System.Windows.Forms.ListBox();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.scoreText = new System.Windows.Forms.Label();
            this.goBtn = new System.Windows.Forms.Button();
            this.levelLbl = new System.Windows.Forms.Label();
            this.livesLbl = new System.Windows.Forms.Label();
            this.livesText = new System.Windows.Forms.Label();
            this.level1TextBox = new System.Windows.Forms.TextBox();
            this.startGame = new System.Windows.Forms.Button();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.hardBtn = new System.Windows.Forms.Button();
            this.mediumBtn = new System.Windows.Forms.Button();
            this.easyBtn = new System.Windows.Forms.Button();
            this.homeLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.instructBtn = new System.Windows.Forms.Button();
            this.highScoresBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.scoreTimer = new System.Windows.Forms.Timer(this.components);
            this.pauseMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGame.SuspendLayout();
            this.pauseMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.White;
            this.panelGame.Controls.Add(this.hardHighScoreBtn);
            this.panelGame.Controls.Add(this.mediumHighScoreBtn);
            this.panelGame.Controls.Add(this.easyHighScoreBtn);
            this.panelGame.Controls.Add(this.listBoxHighScores);
            this.panelGame.Controls.Add(this.scoreLbl);
            this.panelGame.Controls.Add(this.scoreText);
            this.panelGame.Controls.Add(this.goBtn);
            this.panelGame.Controls.Add(this.levelLbl);
            this.panelGame.Controls.Add(this.livesLbl);
            this.panelGame.Controls.Add(this.livesText);
            this.panelGame.Controls.Add(this.level1TextBox);
            this.panelGame.Controls.Add(this.startGame);
            this.panelGame.Controls.Add(this.usernameInput);
            this.panelGame.Controls.Add(this.backBtn);
            this.panelGame.Controls.Add(this.hardBtn);
            this.panelGame.Controls.Add(this.mediumBtn);
            this.panelGame.Controls.Add(this.easyBtn);
            this.panelGame.Controls.Add(this.homeLbl);
            this.panelGame.Controls.Add(this.exitBtn);
            this.panelGame.Controls.Add(this.instructBtn);
            this.panelGame.Controls.Add(this.highScoresBtn);
            this.panelGame.Controls.Add(this.startBtn);
            this.panelGame.Location = new System.Drawing.Point(0, 31);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(1332, 708);
            this.panelGame.TabIndex = 0;
            this.panelGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGame_Paint);
            this.panelGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelGame_MouseMove);
            // 
            // hardHighScoreBtn
            // 
            this.hardHighScoreBtn.BackColor = System.Drawing.Color.Red;
            this.hardHighScoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardHighScoreBtn.Location = new System.Drawing.Point(876, 330);
            this.hardHighScoreBtn.Name = "hardHighScoreBtn";
            this.hardHighScoreBtn.Size = new System.Drawing.Size(269, 106);
            this.hardHighScoreBtn.TabIndex = 21;
            this.hardHighScoreBtn.Text = "Hard";
            this.hardHighScoreBtn.UseVisualStyleBackColor = false;
            this.hardHighScoreBtn.Click += new System.EventHandler(this.hardHighScoreBtn_Click);
            // 
            // mediumHighScoreBtn
            // 
            this.mediumHighScoreBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mediumHighScoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumHighScoreBtn.Location = new System.Drawing.Point(461, 330);
            this.mediumHighScoreBtn.Name = "mediumHighScoreBtn";
            this.mediumHighScoreBtn.Size = new System.Drawing.Size(269, 106);
            this.mediumHighScoreBtn.TabIndex = 20;
            this.mediumHighScoreBtn.Text = "Medium";
            this.mediumHighScoreBtn.UseVisualStyleBackColor = false;
            this.mediumHighScoreBtn.Click += new System.EventHandler(this.mediumHighScoreBtn_Click);
            // 
            // easyHighScoreBtn
            // 
            this.easyHighScoreBtn.BackColor = System.Drawing.Color.Yellow;
            this.easyHighScoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyHighScoreBtn.Location = new System.Drawing.Point(76, 330);
            this.easyHighScoreBtn.Name = "easyHighScoreBtn";
            this.easyHighScoreBtn.Size = new System.Drawing.Size(269, 106);
            this.easyHighScoreBtn.TabIndex = 19;
            this.easyHighScoreBtn.Text = "Easy";
            this.easyHighScoreBtn.UseVisualStyleBackColor = false;
            this.easyHighScoreBtn.Click += new System.EventHandler(this.easyHighScoreBtn_Click);
            // 
            // listBoxHighScores
            // 
            this.listBoxHighScores.BackColor = System.Drawing.Color.White;
            this.listBoxHighScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxHighScores.FormattingEnabled = true;
            this.listBoxHighScores.ItemHeight = 25;
            this.listBoxHighScores.Location = new System.Drawing.Point(374, 158);
            this.listBoxHighScores.Name = "listBoxHighScores";
            this.listBoxHighScores.Size = new System.Drawing.Size(485, 354);
            this.listBoxHighScores.TabIndex = 18;
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.BackColor = System.Drawing.Color.Transparent;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.Location = new System.Drawing.Point(502, 642);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(32, 36);
            this.scoreLbl.TabIndex = 17;
            this.scoreLbl.Text = "0";
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(368, 642);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(101, 36);
            this.scoreText.TabIndex = 16;
            this.scoreText.Text = "Score:";
            // 
            // goBtn
            // 
            this.goBtn.BackColor = System.Drawing.Color.Yellow;
            this.goBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBtn.Location = new System.Drawing.Point(1232, 298);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(100, 100);
            this.goBtn.TabIndex = 15;
            this.goBtn.Text = "Go!";
            this.goBtn.UseVisualStyleBackColor = false;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // levelLbl
            // 
            this.levelLbl.AutoSize = true;
            this.levelLbl.BackColor = System.Drawing.Color.Transparent;
            this.levelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLbl.Location = new System.Drawing.Point(458, 215);
            this.levelLbl.Name = "levelLbl";
            this.levelLbl.Size = new System.Drawing.Size(444, 135);
            this.levelLbl.TabIndex = 14;
            this.levelLbl.Text = "Level 1";
            this.levelLbl.Visible = false;
            // 
            // livesLbl
            // 
            this.livesLbl.AutoSize = true;
            this.livesLbl.BackColor = System.Drawing.Color.Transparent;
            this.livesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesLbl.Location = new System.Drawing.Point(870, 642);
            this.livesLbl.Name = "livesLbl";
            this.livesLbl.Size = new System.Drawing.Size(32, 36);
            this.livesLbl.TabIndex = 13;
            this.livesLbl.Text = "0";
            // 
            // livesText
            // 
            this.livesText.AutoSize = true;
            this.livesText.BackColor = System.Drawing.Color.Transparent;
            this.livesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesText.Location = new System.Drawing.Point(745, 642);
            this.livesText.Name = "livesText";
            this.livesText.Size = new System.Drawing.Size(93, 36);
            this.livesText.TabIndex = 12;
            this.livesText.Text = "Lives:";
            // 
            // level1TextBox
            // 
            this.level1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level1TextBox.Location = new System.Drawing.Point(425, 363);
            this.level1TextBox.Name = "level1TextBox";
            this.level1TextBox.Size = new System.Drawing.Size(351, 56);
            this.level1TextBox.TabIndex = 11;
            this.level1TextBox.Visible = false;
            // 
            // startGame
            // 
            this.startGame.BackColor = System.Drawing.Color.White;
            this.startGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.Location = new System.Drawing.Point(461, 387);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(269, 106);
            this.startGame.TabIndex = 10;
            this.startGame.Text = "Start Game";
            this.startGame.UseVisualStyleBackColor = false;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // usernameInput
            // 
            this.usernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.Location = new System.Drawing.Point(425, 265);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(351, 56);
            this.usernameInput.TabIndex = 9;
            this.usernameInput.Visible = false;
            this.usernameInput.TextChanged += new System.EventHandler(this.usernameInput_TextChanged);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.White;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(461, 518);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(269, 106);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // hardBtn
            // 
            this.hardBtn.BackColor = System.Drawing.Color.Red;
            this.hardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardBtn.Location = new System.Drawing.Point(461, 387);
            this.hardBtn.Name = "hardBtn";
            this.hardBtn.Size = new System.Drawing.Size(269, 106);
            this.hardBtn.TabIndex = 7;
            this.hardBtn.Text = "Hard";
            this.hardBtn.UseVisualStyleBackColor = false;
            this.hardBtn.Click += new System.EventHandler(this.hardBtn_Click);
            // 
            // mediumBtn
            // 
            this.mediumBtn.BackColor = System.Drawing.Color.Lime;
            this.mediumBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumBtn.Location = new System.Drawing.Point(461, 251);
            this.mediumBtn.Name = "mediumBtn";
            this.mediumBtn.Size = new System.Drawing.Size(269, 106);
            this.mediumBtn.TabIndex = 6;
            this.mediumBtn.Text = "Medium";
            this.mediumBtn.UseVisualStyleBackColor = false;
            this.mediumBtn.Click += new System.EventHandler(this.mediumBtn_Click);
            // 
            // easyBtn
            // 
            this.easyBtn.BackColor = System.Drawing.Color.Yellow;
            this.easyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyBtn.Location = new System.Drawing.Point(461, 113);
            this.easyBtn.Name = "easyBtn";
            this.easyBtn.Size = new System.Drawing.Size(269, 106);
            this.easyBtn.TabIndex = 5;
            this.easyBtn.Text = "Easy";
            this.easyBtn.UseVisualStyleBackColor = false;
            this.easyBtn.Click += new System.EventHandler(this.easyBtn_Click);
            // 
            // homeLbl
            // 
            this.homeLbl.AutoSize = true;
            this.homeLbl.BackColor = System.Drawing.Color.Transparent;
            this.homeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLbl.Location = new System.Drawing.Point(433, 19);
            this.homeLbl.Name = "homeLbl";
            this.homeLbl.Size = new System.Drawing.Size(324, 69);
            this.homeLbl.TabIndex = 4;
            this.homeLbl.Text = "Tricky Test";
            this.homeLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Blue;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(437, 532);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(320, 92);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // instructBtn
            // 
            this.instructBtn.BackColor = System.Drawing.Color.Lime;
            this.instructBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructBtn.Location = new System.Drawing.Point(437, 401);
            this.instructBtn.Name = "instructBtn";
            this.instructBtn.Size = new System.Drawing.Size(320, 92);
            this.instructBtn.TabIndex = 2;
            this.instructBtn.Text = "Instructions";
            this.instructBtn.UseVisualStyleBackColor = false;
            this.instructBtn.Click += new System.EventHandler(this.instructBtn_Click);
            // 
            // highScoresBtn
            // 
            this.highScoresBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.highScoresBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoresBtn.Location = new System.Drawing.Point(437, 265);
            this.highScoresBtn.Name = "highScoresBtn";
            this.highScoresBtn.Size = new System.Drawing.Size(320, 92);
            this.highScoresBtn.TabIndex = 1;
            this.highScoresBtn.Text = "High Scores";
            this.highScoresBtn.UseVisualStyleBackColor = false;
            this.highScoresBtn.Click += new System.EventHandler(this.highScoresBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Red;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(437, 127);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(320, 92);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // scoreTimer
            // 
            this.scoreTimer.Interval = 12;
            this.scoreTimer.Tick += new System.EventHandler(this.scoreTimer_Tick);
            // 
            // pauseMenu
            // 
            this.pauseMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pauseMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.pauseMenu.Location = new System.Drawing.Point(0, 0);
            this.pauseMenu.Name = "pauseMenu";
            this.pauseMenu.Size = new System.Drawing.Size(1332, 28);
            this.pauseMenu.TabIndex = 1;
            this.pauseMenu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseGameToolStripMenuItem,
            this.exitGameToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // pauseGameToolStripMenuItem
            // 
            this.pauseGameToolStripMenuItem.Name = "pauseGameToolStripMenuItem";
            this.pauseGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pauseGameToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.pauseGameToolStripMenuItem.Text = "Pause Game";
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.exitGameToolStripMenuItem.Text = "Exit Game";
            this.exitGameToolStripMenuItem.Click += new System.EventHandler(this.exitGameToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 738);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.pauseMenu);
            this.MainMenuStrip = this.pauseMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.pauseMenu.ResumeLayout(false);
            this.pauseMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button instructBtn;
        private System.Windows.Forms.Button highScoresBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label homeLbl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button hardBtn;
        private System.Windows.Forms.Button mediumBtn;
        private System.Windows.Forms.Button easyBtn;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.TextBox level1TextBox;
        private System.Windows.Forms.Label livesLbl;
        private System.Windows.Forms.Label livesText;
        private System.Windows.Forms.Label levelLbl;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.Timer scoreTimer;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.MenuStrip pauseMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitGameToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxHighScores;
        private System.Windows.Forms.Button hardHighScoreBtn;
        private System.Windows.Forms.Button mediumHighScoreBtn;
        private System.Windows.Forms.Button easyHighScoreBtn;
    }
}

