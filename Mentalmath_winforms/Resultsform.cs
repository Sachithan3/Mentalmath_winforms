using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Mentalmath_winforms
{
    public partial class Resultsform : Form
    {
        Mental_math_game test;
        MainMenu y = new MainMenu();
        int higheststreak = 0;
        double fastest, slowest = 0;
        float accuracy = 0;
        float avgspeed = 0;

        public void resetresults()
        {
            higheststreak = 0;
            accuracy = 0;
            fastest = 0;
            slowest = 0;
            avgspeed = 0;
        }
        public Resultsform(Mental_math_game game)
        {
            test = game;
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Mental_math_game.indicator = false;
            test. reset();
            resetresults();
            this.Hide();
            y.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mental_math_game.indicator = true;
            resetresults();
            test.reset();
            test.startgame();
            this.Hide();
            test.Show();
        }
       public static string updatehs()
{
    string path = "highscores.txt";
    if (!File.Exists(path))
        File.WriteAllText(path, "0");
    int highscore = int.Parse(File.ReadAllText(path));
    if (Mental_math_game.score > highscore)
    {
        File.WriteAllText(path, Mental_math_game.score.ToString());
    }

    return "Current High score: " + File.ReadAllText(path);
}

        public static bool checkfornewhighscore()
        {
            int hs = int.Parse(File.ReadAllText("highscores.txt"));
            if (Mental_math_game.score > hs)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Resultsform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Enter(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderColor = Color.Cyan;
        }

        private void Exit_Enter(object sender, EventArgs e)
        {
            Exit.FlatAppearance.BorderColor = Color.Cyan;
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderColor = Color.Black;
        }
        private void Exit_Leave(object sender, EventArgs e)
        {
            Exit.FlatAppearance.BorderColor = Color.Black;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Resultsform_Load(object sender, EventArgs e)
        {
            button2.Focus();
            this.MaximizeBox = false;
            if (Mental_math_game.times.Count == 0 || Mental_math_game.correct == 0)
            {
                fastest = 0;
                slowest = 0;
                avgspeed = 0;
            }
            else
            {
                avgspeed = (float)Mental_math_game.times.Average();
                slowest = Mental_math_game.times.Max();
                fastest = Mental_math_game.times.Min();
                higheststreak = Mental_math_game.streaks.Max();
                accuracy = (Mental_math_game.correct) * 100 / Mental_math_game.totalqns;
            }

            string message =
                $"Total Questions: {Mental_math_game.totalqns}\n" +
                $"Final Score: {Mental_math_game.score}\n" +
                $"Accuracy: {Math.Round(accuracy, 2)}%\n\n" +
                $"Questions Answered: {Mental_math_game.correct}\n" +
                $"Questions Skipped: {Mental_math_game.skipped}\n" +
                $"Highest Streak: {higheststreak}\n\n" +
                $"Average Speed: {Math.Round(avgspeed, 2)} seconds/qn\n" +
                $"Fastest Answer: {fastest} seconds\n" +
                $"Slowest Answer : {slowest} seconds";
            lblaccuracy.Text = message;
            if (checkfornewhighscore() == true)
            {
                lblhighscore.Text = "NEW HIGH SCORE !!!!";
            }
            updatehs();
        }
    }

}

