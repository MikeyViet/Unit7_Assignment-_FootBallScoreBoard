using System;
using System.Windows.Forms;

namespace FootBallScoreBoard
{
    public partial class Form1 : Form
    {
        private string HomeTeamScore { get; set; }
        private string VisitorTeamScore { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        public void updateConfirm_Click(string score, string score2, string homeTol, string visitorTol, string ballPosition, string numQtr, string numDowns, string yardsToGo)

        {
            this.homeTeamScore.Text = score;
            this.visitorTeamScore.Text = score2;
            this.homeTimeOutNum.Text = homeTol;
            this.visitorTimeOutNum.Text = visitorTol;
            this.numBallPosition.Text = ballPosition;
            this.numQuarter.Text = numQtr;
            this.numDown.Text = numDowns;
            this.numYardsToGo.Text = yardsToGo;


        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void updateControllerButton_Click(object sender, EventArgs e)
        {
            Form2 controllerForScoreBoard = new Form2();

            controllerForScoreBoard.Show();
            this.Hide();





        }
    }

}

