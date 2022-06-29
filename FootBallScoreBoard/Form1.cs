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

            this.homeTeamScore.Text = ScoreBoardData.ScoreHomeTeam;
            this.visitorTeamScore.Text = ScoreBoardData.ScoreVisitorTeam;
            this.homeTimeOutNum.Text = ScoreBoardData.TimeOutLeftHomeTeam;
            this.visitorTimeOutNum.Text = ScoreBoardData.TimeOutLeftVisitorTeam;
            this.numBallPosition.Text = ScoreBoardData.PositionOfBallOnField;
            this.numQuarter.Text = ScoreBoardData.CurrentQuarterOfGame;
            this.numDown.Text = ScoreBoardData.CurrentNumberOfDown;
            this.numYardsToGo.Text = ScoreBoardData.NumberOfYardsForFirstDown;
            this.timerLabel.Text = ScoreBoardData.Minutes + ":" + ScoreBoardData.Seconds;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button2.Enabled = false;
        }
        public string appendZero(double str)
        {
            if (str <= 9)
                return "0" + str;
            else
                return str.ToString();
        }

        private void updateControllerButton_Click(object sender, EventArgs e)
        {

            ScoreBoardUpdateController = new Form2();

            ScoreBoardUpdateController.homeTeamUpdateInput.Text = ScoreBoardData.ScoreHomeTeam;
            ScoreBoardUpdateController.visitorTeamUpdateInput.Text = ScoreBoardData.ScoreVisitorTeam;
            ScoreBoardUpdateController.homeTeamUpdateTolInput.Text = ScoreBoardData.TimeOutLeftHomeTeam;
            ScoreBoardUpdateController.visitorTeamUpdateTolInput.Text = ScoreBoardData.TimeOutLeftVisitorTeam;
            ScoreBoardUpdateController.ballPositionUpdateInput.Text = ScoreBoardData.PositionOfBallOnField;
            ScoreBoardUpdateController.qtrUpdateInput.Text = ScoreBoardData.CurrentQuarterOfGame;
            ScoreBoardUpdateController.downUpdateInput.Text = ScoreBoardData.CurrentNumberOfDown;
            ScoreBoardUpdateController.toGoUpdateInput.Text = ScoreBoardData.NumberOfYardsForFirstDown;

            string[] timerNumbers = this.timerLabel.Text.Split(':');

            ScoreBoardData.Minutes = timerNumbers[0];
            ScoreBoardData.Seconds = timerNumbers[1];

            for (int i = 0; i < 60; i++)
            {
                ScoreBoardUpdateController.comboBox2.Items.Add(i.ToString());
            }
            ScoreBoardUpdateController.comboBox2.SelectedIndex = int.Parse(timerNumbers[1]);

            for (int i = 0; i <= 15; i++)
            {
                ScoreBoardUpdateController.comboBox1.Items.Add(i.ToString());
            }
            ScoreBoardUpdateController.comboBox1.SelectedIndex = int.Parse(timerNumbers[0]);

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


                newMinute = this.appendZero(minutes);
                newSecond = this.appendZero(seconds);
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
    }

}

