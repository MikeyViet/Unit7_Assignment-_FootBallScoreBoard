using System;
using System.Windows.Forms;

namespace FootBallScoreBoard
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();




        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void updateControllerButton_Click(object sender, EventArgs e)
        {
            Form2 controllerForScoreBoard = new Form2();

            controllerForScoreBoard.Show();
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
    }

}

