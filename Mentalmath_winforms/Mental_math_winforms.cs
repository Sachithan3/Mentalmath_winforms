using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mentalmath_winforms
{
    public partial class Mental_math_game : Form
    {
        int count = 20;
        int count2 = 3;
        public static int correct = 0;
        Stopwatch stopwatch = new Stopwatch();
        public static List<double> times = new List<double>();
        Random x = new Random();
        public static int skipped = 0;
        public static int highscore = 0;
        public static float score = 0;
        public static int streak;
        public static List<int> streaks = new List<int>();
        int answer = 0;
        public static float totalqns = -1;
        string Answer = "";
        int select = 0;
        public Mental_math_game()
        {
            InitializeComponent();
        }
        public void reset()
        {
            score = 0;
            streak = 0;
            totalqns = -1;
            streaks.Clear();
            times.Clear();
            skipped = 0;
            correct = 0;
            lblDisplayQuestions.Text = "";
            count = 20;    
            count2 = 3;
            lblDisplayQuestions.Text = "";
            lblScore.Text = "SCORE : 0";
            lblCounter.Text = "TIMER : 20";
            lblStart.Text = "Game starts in "+count2+" seconds";
            lblError.Text = "";
            txtAnswer.Clear();
            txtAnswer.Enabled = false;   
            btnresult.Visible = false;
            btnresult.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string c = (count-1).ToString();
            lblCounter.Text = "TIMER : " + c;
            if (count == 1)
            {
                txtAnswer.Visible = true;
                timer1.Stop();
                lblCounter.Text = "TIMES UP!!";
                txtAnswer.Clear();
                txtAnswer.Enabled = false;
                btnresult.Enabled = true;
                btnresult.Visible = true;
                btnresult.Focus();
            }
            count--;
        }

        public void startgame()
        {
            this.Show();
            if (!indicator) timer2.Start();
            else
            {
                lblDisplayQuestions.BringToFront();
                lblStart.Text = null;
                timer2.Stop();
                txtAnswer.Enabled = true;
                txtAnswer.Focus();
                generateQuestion();
                timer1.Start();
            }
        }
        public static Boolean indicator = false;
        private void timer2_Tick(object sender, EventArgs e)
        {
            lblStart.Text = "Game starts in " + (count2 - 1) + " seconds";
            count2--;
            if (count2 == 0)
            {
                lblDisplayQuestions.BringToFront();
                lblStart.Text = null;
                timer2.Stop();
                txtAnswer.Enabled = true;
                txtAnswer.Focus();
                generateQuestion();
                timer1.Start();
            }
        }
        public string generateQuestion()
        {

            stopwatch.Reset();
            stopwatch.Start();
            totalqns++;
            int num1 = x.Next(1, 21);
            int num2 = x.Next(1, 20);
            select = x.Next(0, 4);

            if (select == 3)
            {
                if (num1 > num2)
                {
                    answer = num1 / num2;
                    lblDisplayQuestions.Text = $"{num1}/{num2}=";
                }
                else
                {
                    answer = num2 / num1;
                    lblDisplayQuestions.Text = $"{num2} / {num1}=";
                }
            }
            else
            {
                switch (select)
                {
                    case 0:
                        answer = num1 + num2;
                        lblDisplayQuestions.Text = $"{num1} + {num2}=";
                        break;
                    case 1:
                        answer = num1 - num2;
                        lblDisplayQuestions.Text = $"{num1} - {num2}=";

                        break;
                    case 2:
                        answer = num1 * num2;
                        lblDisplayQuestions.Text = $"{num1} x {num2}=";
                        break;
                }
            }
            Answer = answer.ToString();
            return Answer;
        }

        public static int maxstreak()
        {
            try
            {
                int max = streaks[0];
                foreach (int i in streaks)
                {
                    if (i > max) max = i;
                }
                return max;
            }
            catch (Exception)
            {
                return 0;
            }

        }
        async void correctanimation()
        {
            lblScore.ForeColor = Color.Lime;
            lblCounter.ForeColor = Color.Lime;
            await Task.Delay(300);
            lblScore.ForeColor = Color.Cyan;
            lblCounter.ForeColor = Color.Cyan;
        }
        async void wronganimation()
        {
            lblScore.ForeColor = Color.Red;
            lblCounter.ForeColor = Color.Red;
            await Task.Delay(300);
            lblScore.ForeColor = Color.Cyan;
            lblCounter.ForeColor = Color.Cyan;
        }
        void submit(string x)
        {
            if (x == Answer)
            {
                correct++;
                stopwatch.Stop();
                float a = Convert.ToSingle(stopwatch.ElapsedMilliseconds);
                a = a / 1000;
                double z = Math.Round(a, 2);
                times.Add(z);
                streak++;
                stopwatch.Restart();
                streaks.Add(streak);
                score++;
                correctanimation();
                lblScore.Text = "SCORE : " + score;
                generateQuestion();
            }
            else
            {
                skipped++;
                streak = 0;
                score--;
                lblScore.Text = "SCORE : " + score;
                wronganimation();
                generateQuestion();
            }
            txtAnswer.Clear();
        }
        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
            string input = txtAnswer.Text;
            try
            {
                switch (input[input.Length - 1])
                {
                    case '1':
                        await animation(lbl1);
                        break;
                    case '2':
                        await animation(lbl2);
                        break;
                    case '3':
                        await animation(lbl3);
                        break;
                    case '4':
                        await animation(lbl4);
                        break;
                    case '5':
                        await animation(lbl5);
                        break;
                    case '6':
                        await animation(lbl6);
                        break;
                    case '7':
                        await animation(lbl7);
                        break;
                    case '8':
                        await animation(lbl8);
                        break;
                    case '9':
                        await animation(lbl9);
                        break;
                    case '0':
                        await animation(lbl0);
                        break;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
            int len = input.Length;
            bool isvalid = int.TryParse(input.TrimEnd(), out int test);
            if (isvalid)
            {
                lblScore.Text = "SCORE : " + score;
                if (input == Answer)
                {
                    submit(input);
                }
                else if (input[len - 1] == ' ' || input[0] == ' ')
                {
                    submit(input);
                }
            }
            else if (input.Length > 0 && (input[0] == ' ' || input.EndsWith(" ") == true))
            {
                submit(input);
            }
            else if (input.Length > 0)
            {
                lblError.Text = "INPUT A VALID INTEGER";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;        
        }
        private void btnresult_Click(object sender, EventArgs e)
        {
            Resultsform result = new Resultsform(this);
            this.Hide();
            result.Show();
        }

        private void Mental_math_game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private async Task animation(System.Windows.Forms.Label a)
        {
            a.Visible = true;
            await Task.Delay(100);
            a.Visible = false;
        }
    }
}
