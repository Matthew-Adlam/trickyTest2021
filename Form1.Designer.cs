
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
            this.panelGame = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.hardBtn = new System.Windows.Forms.Button();
            this.mediumBtn = new System.Windows.Forms.Button();
            this.easyBtn = new System.Windows.Forms.Button();
            this.homeLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.instructBtn = new System.Windows.Forms.Button();
            this.highScoresBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.panelGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.White;
            this.panelGame.Controls.Add(this.backBtn);
            this.panelGame.Controls.Add(this.hardBtn);
            this.panelGame.Controls.Add(this.mediumBtn);
            this.panelGame.Controls.Add(this.easyBtn);
            this.panelGame.Controls.Add(this.homeLbl);
            this.panelGame.Controls.Add(this.exitBtn);
            this.panelGame.Controls.Add(this.instructBtn);
            this.panelGame.Controls.Add(this.highScoresBtn);
            this.panelGame.Controls.Add(this.startBtn);
            this.panelGame.Location = new System.Drawing.Point(0, 1);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(1332, 703);
            this.panelGame.TabIndex = 0;
            this.panelGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGame_Paint);
            this.panelGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelGame_MouseMove);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 703);
            this.Controls.Add(this.panelGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

