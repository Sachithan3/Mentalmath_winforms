using System;
using System.IO;
using System.Media;
using System.Windows.Forms;
namespace Mentalmath_winforms
{
    public partial class MainMenu : Form
    {
        Mental_math_game x = new Mental_math_game();
        public static SoundPlayer Player;
        public static bool isplaying = false;
        void volume()
        {
            if (isplaying == true)
            {
                Player.Stop();
                isplaying = false;
                lblvol.Text = "TURN ON MUSIC";
            }
            else
            {
                Player.Play();
                isplaying = true;
                lblvol.Text = "TURN OFF MUSIC";
                Player.PlayLooping();
            }
        }
        private void playsong()
        {
            MemoryStream test = new MemoryStream(Properties.Resources.Bgm_audio);
            Player = new SoundPlayer(test);
        }
        public MainMenu()
        {
            InitializeComponent();
        }
        string message = "◈ Start the game and start answering questions\n\n◈ If you enter the correct a" +
                "nswer, the game automatically\n   detects it and gives you the next question\n\n◈ To skip a question, " +
                "simply press the space bar once\n\n◈ Each correct question increases your score by one\n\n◈ Each skipped question " +
                "decreases your score by one\n\n◈ For division, Answer in integer with no decimal points\n\n◈ Answer as many questions as you can in 20 seconds !";
        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Hide();
                x.reset();
                x.startgame();
            }
            else if (e.KeyCode == Keys.Back)
            {
                Application.Exit();
            }
        }
        void setlabeltext()
        {
            if (isplaying == true)
            {
                lblvol.Text = "TURN OFF MUSIC";
            }
            else
            {
                lblvol.Text = "TURN ON MUSIC";
            }
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            setlabeltext();
            this.MaximizeBox = false;
            lblhighscore.Text = Resultsform.updatehs();
            playsong();
        }        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(message);
            lblhighscore.Focus();
        }
        private void lblhighscore_Click(object sender, EventArgs e)
        {
            lblhighscore.Focus();
        }
        private void lblvol_Click(object sender, EventArgs e)
        {
            volume();
        }
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
