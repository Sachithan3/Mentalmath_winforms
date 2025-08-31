namespace Mentalmath_winforms
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.lblheader = new System.Windows.Forms.Label();
            this.lblheader2 = new System.Windows.Forms.Label();
            this.lblpresskey = new System.Windows.Forms.Label();
            this.lblhighscore = new System.Windows.Forms.Label();
            this.btnrules = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblvol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblheader
            // 
            this.lblheader.AutoEllipsis = true;
            this.lblheader.Font = new System.Drawing.Font("Tektur", 35F);
            this.lblheader.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblheader.Location = new System.Drawing.Point(-49, 173);
            this.lblheader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(682, 80);
            this.lblheader.TabIndex = 0;
            this.lblheader.Text = "MENTAL MATH GAME";
            this.lblheader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblheader2
            // 
            this.lblheader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblheader2.ForeColor = System.Drawing.Color.White;
            this.lblheader2.Location = new System.Drawing.Point(268, 98);
            this.lblheader2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblheader2.Name = "lblheader2";
            this.lblheader2.Size = new System.Drawing.Size(75, 19);
            this.lblheader2.TabIndex = 1;
            // 
            // lblpresskey
            // 
            this.lblpresskey.AutoSize = true;
            this.lblpresskey.BackColor = System.Drawing.Color.Black;
            this.lblpresskey.Font = new System.Drawing.Font("Tektur", 12F);
            this.lblpresskey.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblpresskey.Location = new System.Drawing.Point(11, 419);
            this.lblpresskey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpresskey.Name = "lblpresskey";
            this.lblpresskey.Size = new System.Drawing.Size(262, 26);
            this.lblpresskey.TabIndex = 4;
            this.lblpresskey.Text = "PRESS ENTER TO START     ";
            // 
            // lblhighscore
            // 
            this.lblhighscore.Font = new System.Drawing.Font("Tektur", 17F);
            this.lblhighscore.ForeColor = System.Drawing.Color.Turquoise;
            this.lblhighscore.Location = new System.Drawing.Point(209, 62);
            this.lblhighscore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhighscore.Name = "lblhighscore";
            this.lblhighscore.Size = new System.Drawing.Size(335, 53);
            this.lblhighscore.TabIndex = 6;
            this.lblhighscore.Text = "Current High score: ";
            this.lblhighscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblhighscore.Click += new System.EventHandler(this.lblhighscore_Click);
            // 
            // btnrules
            // 
            this.btnrules.BackColor = System.Drawing.Color.Black;
            this.btnrules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrules.Font = new System.Drawing.Font("Tektur", 17F);
            this.btnrules.ForeColor = System.Drawing.Color.Turquoise;
            this.btnrules.Location = new System.Drawing.Point(52, 59);
            this.btnrules.Margin = new System.Windows.Forms.Padding(2);
            this.btnrules.Name = "btnrules";
            this.btnrules.Size = new System.Drawing.Size(131, 58);
            this.btnrules.TabIndex = 7;
            this.btnrules.TabStop = false;
            this.btnrules.Text = "RULES";
            this.btnrules.UseVisualStyleBackColor = false;
            this.btnrules.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tektur", 12F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(289, 419);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "PRESS BACKSPACE TO EXIT   ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tektur", 14F);
            this.label2.Location = new System.Drawing.Point(270, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "|";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblvol
            // 
            this.lblvol.AutoSize = true;
            this.lblvol.Font = new System.Drawing.Font("Tektur", 10F);
            this.lblvol.ForeColor = System.Drawing.Color.Cyan;
            this.lblvol.Location = new System.Drawing.Point(11, 9);
            this.lblvol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvol.Name = "lblvol";
            this.lblvol.Size = new System.Drawing.Size(137, 22);
            this.lblvol.TabIndex = 10;
            this.lblvol.Text = "TURN ON MUSIC";
            this.lblvol.Click += new System.EventHandler(this.lblvol_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.lblvol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnrules);
            this.Controls.Add(this.lblhighscore);
            this.Controls.Add(this.lblpresskey);
            this.Controls.Add(this.lblheader2);
            this.Controls.Add(this.lblheader);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainMenu_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Label lblheader2;
        private System.Windows.Forms.Label lblpresskey;
        private System.Windows.Forms.Label lblhighscore;
        private System.Windows.Forms.Button btnrules;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblvol;
    }
}