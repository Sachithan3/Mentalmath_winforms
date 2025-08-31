namespace Mentalmath_winforms
{
    partial class Resultsform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultsform));
            this.lblheader = new System.Windows.Forms.Label();
            this.lblaccuracy = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblhighscore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.BackColor = System.Drawing.Color.Transparent;
            this.lblheader.Font = new System.Drawing.Font("Tektur", 30F);
            this.lblheader.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblheader.Location = new System.Drawing.Point(161, 36);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(466, 65);
            this.lblheader.TabIndex = 0;
            this.lblheader.Text = "RESULT ANALYSIS";
            // 
            // lblaccuracy
            // 
            this.lblaccuracy.BackColor = System.Drawing.Color.Black;
            this.lblaccuracy.Font = new System.Drawing.Font("Tektur", 13.8F);
            this.lblaccuracy.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblaccuracy.Location = new System.Drawing.Point(101, 119);
            this.lblaccuracy.Name = "lblaccuracy";
            this.lblaccuracy.Size = new System.Drawing.Size(435, 356);
            this.lblaccuracy.TabIndex = 1;
            this.lblaccuracy.Text = "Total Questions: {Mental_math_game.totalqns}\\nFinal Score: {Mental_math_game.scor" +
    "e}\\nQuestions Skipped: {Mental_math_game.totalqns-Mental_math_game.score";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Black;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Exit.FlatAppearance.BorderSize = 2;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Tektur", 14F);
            this.Exit.ForeColor = System.Drawing.Color.DeepPink;
            this.Exit.Location = new System.Drawing.Point(587, 366);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(109, 110);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Main Menu";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.Enter += new System.EventHandler(this.Exit_Enter);
            this.Exit.Leave += new System.EventHandler(this.Exit_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tektur", 14F);
            this.button2.ForeColor = System.Drawing.Color.DeepPink;
            this.button2.Location = new System.Drawing.Point(587, 119);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 110);
            this.button2.TabIndex = 2;
            this.button2.Text = "Play Again";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.Enter += new System.EventHandler(this.button2_Enter);
            this.button2.Leave += new System.EventHandler(this.button2_Leave);
            // 
            // lblhighscore
            // 
            this.lblhighscore.AutoSize = true;
            this.lblhighscore.BackColor = System.Drawing.Color.Black;
            this.lblhighscore.Font = new System.Drawing.Font("Tektur", 14F);
            this.lblhighscore.ForeColor = System.Drawing.Color.Turquoise;
            this.lblhighscore.Location = new System.Drawing.Point(101, 495);
            this.lblhighscore.Name = "lblhighscore";
            this.lblhighscore.Size = new System.Drawing.Size(0, 31);
            this.lblhighscore.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 394);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(412, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(377, 394);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 162);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(419, 394);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(371, 162);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(419, 394);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // Resultsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(781, 553);
            this.Controls.Add(this.lblhighscore);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.lblaccuracy);
            this.Controls.Add(this.lblheader);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Resultsform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "*";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Resultsform_FormClosed);
            this.Load += new System.EventHandler(this.Resultsform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Label lblaccuracy;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblhighscore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}