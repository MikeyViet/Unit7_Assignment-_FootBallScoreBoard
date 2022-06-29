using System;
using System.Windows.Forms;

namespace FootBallScoreBoard
{
    public partial class Form1 : Form
    {
        public int totalSeconds;

        public Form1()
        {

            InitializeComponent();




        }





        private void Form1_Load(object sender, EventArgs e)
        {
            this.button2.Enabled = false;

        }



        private void updateControllerButton_Click(object sender, EventArgs e)
        {
            Form2 controllerForScoreBoard = new Form2();

            controllerForScoreBoard.homeTeamUpdateInput.Text = ScoreBoardData.ScoreHomeTeam;
            controllerForScoreBoard.visitorTeamUpdateInput.Text = ScoreBoardData.ScoreVisitorTeam;
            controllerForScoreBoard.homeTeamUpdateTolInput.Text = ScoreBoardData.TimeOutLeftHomeTeam;
            controllerForScoreBoard.visitorTeamUpdateTolInput.Text = ScoreBoardData.TimeOutLeftVisitorTeam;
            controllerForScoreBoard.ballPositionUpdateInput.Text = ScoreBoardData.PositionOfBallOnField;
            controllerForScoreBoard.qtrUpdateInput.Text = ScoreBoardData.CurrentQuarterOfGame;
            controllerForScoreBoard.downUpdateInput.Text = ScoreBoardData.CurrentNumberOfDown;
            controllerForScoreBoard.toGoUpdateInput.Text = ScoreBoardData.NumberOfYardsForFirstDown;
            controllerForScoreBoard.Show();
            this.Hide();





        }

        private void visitorTeamScore_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                int minutes = totalSeconds / 60;
                int seconds = totalSeconds - (minutes * 60);
                int mSeconds = (totalSeconds - (minutes * 60)) / 1000;

                Console.WriteLine(totalSeconds);

                this.timerLabel.Text = minutes.ToString() + ":" + seconds.ToString() + ":" + mSeconds.ToString();
            }
            else
            {
                this.timer1.Stop();
                MessageBox.Show("Time's Up");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();

            frm2.Show();

            this.button1.Enabled = false;
            this.button2.Enabled = true;




            int minutes = int.Parse(frm2.comboBox1.SelectedItem.ToString());
            int seconds = int.Parse(frm2.comboBox2.SelectedItem.ToString());

            totalSeconds = (minutes * 60) + seconds;

            this.timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Enabled = false;
            this.button1.Enabled = true;

        }
    }

}

