using System;
using System.Windows.Forms;

namespace FootBallScoreBoard
{
    public partial class Form2 : Form
    {
        public Form1 ScoreBoard;

        public Form2()
        {
            InitializeComponent();



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*            for (int i = 0; i < 60; i++)
                        {
                            this.comboBox2.Items.Add(i.ToString());
                            this.comboBox2.SelectedIndex = int.Parse(ScoreBoardData.Seconds);


                        }

                        for (int i = 0; i < 15; i++)
                        {
                            this.comboBox1.Items.Add(i.ToString());
                            this.comboBox1.SelectedIndex = int.Parse(ScoreBoardData.Minutes);
                        }*/


        }

        private void updateConfirm_Click(object sender, EventArgs e)
        {

            ScoreBoard = new Form1();

            ScoreBoardData.ScoreHomeTeam = this.homeTeamUpdateInput.Text;
            ScoreBoard.homeTeamScore.Text = ScoreBoardData.ScoreHomeTeam;

            ScoreBoardData.ScoreVisitorTeam = this.visitorTeamUpdateInput.Text;
            ScoreBoard.visitorTeamScore.Text = ScoreBoardData.ScoreVisitorTeam;

            ScoreBoardData.TimeOutLeftHomeTeam = this.homeTeamUpdateTolInput.Text;
            ScoreBoard.homeTimeOutNum.Text = ScoreBoardData.TimeOutLeftHomeTeam;

            ScoreBoardData.TimeOutLeftVisitorTeam = this.visitorTeamUpdateTolInput.Text;
            ScoreBoard.visitorTimeOutNum.Text = ScoreBoardData.TimeOutLeftVisitorTeam;

            ScoreBoardData.PositionOfBallOnField = this.ballPositionUpdateInput.Text;
            ScoreBoard.numBallPosition.Text = ScoreBoardData.PositionOfBallOnField;

            ScoreBoardData.CurrentQuarterOfGame = this.qtrUpdateInput.Text;
            ScoreBoard.numQuarter.Text = ScoreBoardData.CurrentQuarterOfGame;

            ScoreBoardData.CurrentNumberOfDown = this.downUpdateInput.Text;
            ScoreBoard.numDown.Text = ScoreBoardData.CurrentNumberOfDown;

            ScoreBoardData.NumberOfYardsForFirstDown = this.toGoUpdateInput.Text;
            ScoreBoard.numYardsToGo.Text = ScoreBoardData.NumberOfYardsForFirstDown;

            ScoreBoardData.Minutes = comboBox1.Text;
            ScoreBoardData.Seconds = comboBox2.Text;

            ScoreBoard.timerLabel.Text = ScoreBoardData.Minutes + ":" + ScoreBoardData.Seconds;



            ScoreBoard.Show();
            this.Hide();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
