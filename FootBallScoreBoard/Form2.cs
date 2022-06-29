using System;
using System.Windows.Forms;

namespace FootBallScoreBoard
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                this.comboBox1.Items.Add(i.ToString());
                this.comboBox2.Items.Add(i.ToString());

            }

            this.comboBox1.SelectedIndex = 59;
            this.comboBox2.SelectedIndex = 59;

        }

        private void updateConfirm_Click(object sender, EventArgs e)
        {

            Form1 frm = new Form1();

            ScoreBoardData.ScoreHomeTeam = this.homeTeamUpdateInput.Text;
            frm.homeTeamScore.Text = ScoreBoardData.ScoreHomeTeam;

            ScoreBoardData.ScoreVisitorTeam = this.visitorTeamUpdateInput.Text;
            frm.visitorTeamScore.Text = ScoreBoardData.ScoreVisitorTeam;

            ScoreBoardData.TimeOutLeftHomeTeam = this.homeTeamUpdateTolInput.Text;
            frm.homeTimeOutNum.Text = ScoreBoardData.TimeOutLeftHomeTeam;

            ScoreBoardData.TimeOutLeftVisitorTeam = this.visitorTeamUpdateTolInput.Text;
            frm.visitorTimeOutNum.Text = ScoreBoardData.TimeOutLeftVisitorTeam;

            ScoreBoardData.PositionOfBallOnField = this.ballPositionUpdateInput.Text;
            frm.numBallPosition.Text = ScoreBoardData.PositionOfBallOnField;

            ScoreBoardData.CurrentQuarterOfGame = this.qtrUpdateInput.Text;
            frm.numQuarter.Text = ScoreBoardData.CurrentQuarterOfGame;

            ScoreBoardData.CurrentNumberOfDown = this.downUpdateInput.Text;
            frm.numDown.Text = ScoreBoardData.CurrentNumberOfDown;

            ScoreBoardData.NumberOfYardsForFirstDown = this.toGoUpdateInput.Text;
            frm.numYardsToGo.Text = ScoreBoardData.NumberOfYardsForFirstDown;

            frm.Show();
            this.Hide();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
