namespace Mentalmath_winforms
{
    partial class Mental_math_game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mental_math_game));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblDisplayQuestions = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnresult = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblDisplayQuestions
            // 
            this.lblDisplayQuestions.AutoSize = true;
            this.lblDisplayQuestions.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDisplayQuestions.Font = new System.Drawing.Font("Tektur", 30F);
            this.lblDisplayQuestions.ForeColor = System.Drawing.Color.Cyan;
            this.lblDisplayQuestions.Location = new System.Drawing.Point(288, 49);
            this.lblDisplayQuestions.Name = "lblDisplayQuestions";
            this.lblDisplayQuestions.Size = new System.Drawing.Size(226, 65);
            this.lblDisplayQuestions.TabIndex = 1;
            this.lblDisplayQuestions.Text = "15 x 12=";
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtAnswer.Enabled = false;
            this.txtAnswer.Font = new System.Drawing.Font("Tektur", 32F);
            this.txtAnswer.ForeColor = System.Drawing.Color.Black;
            this.txtAnswer.Location = new System.Drawing.Point(273, 116);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnswer.MaxLength = 100;
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(263, 75);
            this.txtAnswer.TabIndex = 2;
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnswer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Tektur", 17F);
            this.lblScore.ForeColor = System.Drawing.Color.Cyan;
            this.lblScore.Location = new System.Drawing.Point(571, 239);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(150, 38);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "SCORE : 0";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Tektur", 9F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(573, 303);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 4;
            // 
            // lblCounter
            // 
            this.lblCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblCounter.Font = new System.Drawing.Font("Tektur", 17F);
            this.lblCounter.ForeColor = System.Drawing.Color.Cyan;
            this.lblCounter.Location = new System.Drawing.Point(-4, 222);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(272, 65);
            this.lblCounter.TabIndex = 6;
            this.lblCounter.Text = "TIMER : 20";
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnresult
            // 
            this.btnresult.BackColor = System.Drawing.Color.Black;
            this.btnresult.Enabled = false;
            this.btnresult.Font = new System.Drawing.Font("Rockwell", 10F);
            this.btnresult.ForeColor = System.Drawing.Color.White;
            this.btnresult.Location = new System.Drawing.Point(627, 465);
            this.btnresult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnresult.Name = "btnresult";
            this.btnresult.Size = new System.Drawing.Size(123, 52);
            this.btnresult.TabIndex = 7;
            this.btnresult.Text = "View Results";
            this.btnresult.UseVisualStyleBackColor = false;
            this.btnresult.Visible = false;
            this.btnresult.Click += new System.EventHandler(this.btnresult_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(273, 196);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 321);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lbl1
            // 
            this.lbl1.Location = new System.Drawing.Point(296, 217);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(59, 54);
            this.lbl1.TabIndex = 10;
            this.lbl1.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.Location = new System.Drawing.Point(376, 217);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(59, 54);
            this.lbl2.TabIndex = 11;
            this.lbl2.Visible = false;
            // 
            // lbl3
            // 
            this.lbl3.Location = new System.Drawing.Point(456, 217);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(59, 54);
            this.lbl3.TabIndex = 12;
            this.lbl3.Visible = false;
            // 
            // lbl4
            // 
            this.lbl4.Location = new System.Drawing.Point(296, 289);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(59, 54);
            this.lbl4.TabIndex = 13;
            this.lbl4.Visible = false;
            // 
            // lbl5
            // 
            this.lbl5.Location = new System.Drawing.Point(376, 289);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(59, 54);
            this.lbl5.TabIndex = 14;
            this.lbl5.Visible = false;
            // 
            // lbl6
            // 
            this.lbl6.Location = new System.Drawing.Point(456, 289);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(59, 54);
            this.lbl6.TabIndex = 15;
            this.lbl6.Visible = false;
            // 
            // lbl7
            // 
            this.lbl7.Location = new System.Drawing.Point(296, 363);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(59, 54);
            this.lbl7.TabIndex = 16;
            this.lbl7.Visible = false;
            // 
            // lbl8
            // 
            this.lbl8.Location = new System.Drawing.Point(376, 363);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(59, 54);
            this.lbl8.TabIndex = 17;
            this.lbl8.Visible = false;
            // 
            // lbl9
            // 
            this.lbl9.Location = new System.Drawing.Point(456, 363);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(59, 54);
            this.lbl9.TabIndex = 18;
            this.lbl9.Visible = false;
            // 
            // lbl0
            // 
            this.lbl0.Location = new System.Drawing.Point(376, 437);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(59, 54);
            this.lbl0.TabIndex = 19;
            this.lbl0.Visible = false;
            // 
            // lblStart
            // 
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            this.lblStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStart.Font = new System.Drawing.Font("Tektur", 30F);
            this.lblStart.ForeColor = System.Drawing.Color.Cyan;
            this.lblStart.Location = new System.Drawing.Point(43, 34);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(733, 64);
            this.lblStart.TabIndex = 20;
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(432, 383);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(380, 1);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(467, 383);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 172);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(432, 383);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(361, 172);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(465, 383);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(187, 1);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(420, 63);
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // Mental_math_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(781, 553);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblDisplayQuestions);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lbl0);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnresult);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.Location = new System.Drawing.Point(233, 455);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Mental_math_game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mental_math_game_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblDisplayQuestions;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button btnresult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

