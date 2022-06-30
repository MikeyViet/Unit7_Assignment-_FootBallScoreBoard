using System;
using System.Windows.Forms;

namespace FootBallScoreBoard
{
    public partial class Form1 : Form
    {
        public int totalSeconds;

        public Form2 ScoreBoardUpdateController;

        public Form1()
        {
            InitializeComponent();

            // call to method to load data into the scoreboard
            ScoreBoardData.loadDataToScoreBoard(this);

            ScoreBoardData.loadTimeToScoreBoard(this);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button2.Enabled = false;
        }

        private void updateControllerButton_Click(object sender, EventArgs e)
        {

            ScoreBoardUpdateController = new Form2();

            ScoreBoardData.loadDataToScoreBoard(ScoreBoardUpdateController);

            ScoreBoardData.loadTimeToScoreBoard(this, ScoreBoardUpdateController);

            ScoreBoardUpdateController.Show();
            this.Hide();
        }

        private void visitorTeamScore_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string newMinute = "";
            string newSecond = "";
            if (totalSeconds > 0)
            {
                totalSeconds--;
                int minutes = totalSeconds / 60;
                int seconds = totalSeconds - (minutes * 60);


                newMinute = ScoreBoardData.appendZero(minutes);
                newSecond = ScoreBoardData.appendZero(seconds);

                this.timerLabel.Text = newMinute + ":" + newSecond;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {


            this.button1.Enabled = false;
            this.button2.Enabled = true;


            int minutes = int.Parse(ScoreBoardData.Minutes);
            int seconds = int.Parse(ScoreBoardData.Seconds);

            totalSeconds = (minutes * 60) + seconds;

            this.timer1.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Enabled = false;
            this.button1.Enabled = true;

            this.timer1.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}

