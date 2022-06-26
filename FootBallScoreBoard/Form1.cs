using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootBallScoreBoard
{
    public partial class Form1 : Form
    {
        private string HomeTeamScore { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void updateScoreBoard(string score)
        {
            this.homeTeamScore.Text = score;
        }
        private void updateControllerButton_Click(object sender, EventArgs e)
        {
            Form2 controllerForScoreBoard = new Form2();

            controllerForScoreBoard.Show();
            this.Hide();



        }
    }
}
