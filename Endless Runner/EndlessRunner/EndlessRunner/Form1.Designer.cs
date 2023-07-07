namespace EndlessRunner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.floor = new System.Windows.Forms.PictureBox();
            this.playerCharacterBox = new System.Windows.Forms.PictureBox();
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.scoreLBL = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.leaderBoardLBL = new System.Windows.Forms.Label();
            this.highscoreBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCharacterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.RosyBrown;
            this.floor.Location = new System.Drawing.Point(-18, 444);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(652, 50);
            this.floor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.floor.TabIndex = 0;
            this.floor.TabStop = false;
            // 
            // playerCharacterBox
            // 
            this.playerCharacterBox.Location = new System.Drawing.Point(67, 388);
            this.playerCharacterBox.Name = "playerCharacterBox";
            this.playerCharacterBox.Size = new System.Drawing.Size(44, 60);
            this.playerCharacterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.playerCharacterBox.TabIndex = 1;
            this.playerCharacterBox.TabStop = false;
            // 
            // obstacle1
            // 
            this.obstacle1.Location = new System.Drawing.Point(364, 398);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(100, 50);
            this.obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle1.TabIndex = 2;
            this.obstacle1.TabStop = false;
            this.obstacle1.Tag = "obstacle";
            // 
            // obstacle2
            // 
            this.obstacle2.Location = new System.Drawing.Point(541, 398);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(50, 50);
            this.obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacle2.TabIndex = 3;
            this.obstacle2.TabStop = false;
            this.obstacle2.Tag = "obstacle";
            // 
            // scoreLBL
            // 
            this.scoreLBL.AutoSize = true;
            this.scoreLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLBL.Location = new System.Drawing.Point(13, 13);
            this.scoreLBL.Name = "scoreLBL";
            this.scoreLBL.Size = new System.Drawing.Size(70, 24);
            this.scoreLBL.TabIndex = 4;
            this.scoreLBL.Text = "Score: ";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameEvent);
            // 
            // leaderBoardLBL
            // 
            this.leaderBoardLBL.AutoSize = true;
            this.leaderBoardLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderBoardLBL.Location = new System.Drawing.Point(360, 13);
            this.leaderBoardLBL.Name = "leaderBoardLBL";
            this.leaderBoardLBL.Size = new System.Drawing.Size(129, 24);
            this.leaderBoardLBL.TabIndex = 5;
            this.leaderBoardLBL.Text = "Leader Board:";
            // 
            // highscoreBox
            // 
            this.highscoreBox.Enabled = false;
            this.highscoreBox.Location = new System.Drawing.Point(364, 60);
            this.highscoreBox.Multiline = true;
            this.highscoreBox.Name = "highscoreBox";
            this.highscoreBox.Size = new System.Drawing.Size(227, 248);
            this.highscoreBox.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(618, 475);
            this.Controls.Add(this.highscoreBox);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.leaderBoardLBL);
            this.Controls.Add(this.scoreLBL);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.obstacle1);
            this.Controls.Add(this.playerCharacterBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "BMET Endless Runner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCharacterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox playerCharacterBox;
        private System.Windows.Forms.PictureBox obstacle1;
        private System.Windows.Forms.PictureBox obstacle2;
        private System.Windows.Forms.Label scoreLBL;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label leaderBoardLBL;
        private System.Windows.Forms.TextBox highscoreBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

