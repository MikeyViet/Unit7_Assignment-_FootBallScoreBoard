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

        }

        private void updateConfirm_Click(object sender, EventArgs e)
        {

            Form1 frm = new Form1();
            frm.updateConfirm_Click(homeTeamUpdateInput.Text, visitorTeamUpdateInput.Text, homeTeamUpdateTolInput.Text, visitorTeamUpdateTolInput.Text, ballPositionUpdateInput.Text, qtrUpdateInput.Text, ballPositionUpdateInput.Text, toGoUpdateInput.Text);


            frm.Show();
            this.Hide();


        }
    }
}
