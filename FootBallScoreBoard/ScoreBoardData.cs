using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBallScoreBoard
{
    internal static class ScoreBoardData
    {
        // All the numbers needed to populate the Football ScoreBoard
        public static string ScoreHomeTeam { get; set; } = "00";
        public static string ScoreVisitorTeam { get; set; } = "00";
        public static string TimeOutLeftHomeTeam { get; set; } = "3";
        public static string TimeOutLeftVisitorTeam { get; set; } = "3";
        public static string PositionOfBallOnField { get; set; } = "00";
        public static string CurrentQuarterOfGame { get; set; } = "1";
        public static string CurrentNumberOfDown { get; set; } = "1";
        public static string NumberOfYardsForFirstDown { get; set; } = "10";
        public static string Minutes { get; set; } = "15";
        public static string Seconds { get; set; } = "00";

        /// <summary>
        /// Loads the data from the ScoreboardData class into the controller for the scoreboard
        /// except for the minutes and seconds
        /// </summary>
        /// <param name="controllerBoard">This is the controller for the scoreboard</param>
        public static void loadDataToScoreBoard(Form2 controllerBoard)
        {
            controllerBoard.homeTeamUpdateInput.Text = ScoreBoardData.ScoreHomeTeam;
            controllerBoard.visitorTeamUpdateInput.Text = ScoreBoardData.ScoreVisitorTeam;
            controllerBoard.homeTeamUpdateTolInput.Text = ScoreBoardData.TimeOutLeftHomeTeam;
            controllerBoard.visitorTeamUpdateTolInput.Text = ScoreBoardData.TimeOutLeftVisitorTeam;
            controllerBoard.ballPositionUpdateInput.Text = ScoreBoardData.PositionOfBallOnField;
            controllerBoard.qtrUpdateInput.Text = ScoreBoardData.CurrentQuarterOfGame;
            controllerBoard.downUpdateInput.Text = ScoreBoardData.CurrentNumberOfDown;
            controllerBoard.toGoUpdateInput.Text = ScoreBoardData.NumberOfYardsForFirstDown;
        }

        /// <summary>
        /// Overloaded function that will load the data from the ScoreBoardData class into the
        /// initial scoreboard except for minutes and seconds
        /// </summary>
        /// <param name="OGScoreBoard">This is the original scoreboard</param>
        public static void loadDataToScoreBoard(Form1 OGScoreBoard)
        {
            OGScoreBoard.homeTeamScore.Text = ScoreBoardData.ScoreHomeTeam;
            OGScoreBoard.visitorTeamScore.Text = ScoreBoardData.ScoreVisitorTeam;
            OGScoreBoard.homeTimeOutNum.Text = ScoreBoardData.TimeOutLeftHomeTeam;
            OGScoreBoard.visitorTimeOutNum.Text = ScoreBoardData.TimeOutLeftVisitorTeam;
            OGScoreBoard.numBallPosition.Text = ScoreBoardData.PositionOfBallOnField;
            OGScoreBoard.numQuarter.Text = ScoreBoardData.CurrentQuarterOfGame;
            OGScoreBoard.numDown.Text = ScoreBoardData.CurrentNumberOfDown;
            OGScoreBoard.numYardsToGo.Text = ScoreBoardData.NumberOfYardsForFirstDown;
        }

        /// <summary>
        /// Loads the time to the scoreboard by copying the minutes and seconds into the label
        /// </summary>
        /// <param name="OGScoreBoard">This is the original Scoreboard</param>
        public static void loadTimeToScoreBoard(Form1 OGScoreBoard)
        {
            OGScoreBoard.timerLabel.Text = ScoreBoardData.Minutes + ":" + ScoreBoardData.Seconds;
        }

        /// <summary>
        /// Overloaded function to load the time into the scoreboard controller by splitting up the minutes
        /// and seconds from the timer label and storing them in an array that is passed to each member of 
        /// the ScoreBoardData Class
        /// </summary>
        /// <param name="Controller">The update controller Form</param>
        public static void loadTimeToScoreBoard(Form1 OGScoreBoard, Form2 Controller)
        {
            // Split the timer label with format of 00:00 into minutes and second and store into number array
            string[] timerNumbers = OGScoreBoard.timerLabel.Text.Split(':');

            // store the numbers into the data class
            ScoreBoardData.Minutes = timerNumbers[0];
            ScoreBoardData.Seconds = timerNumbers[1];

            // populate the drop down list with seconds
            for (int i = 0; i < 60; i++)
            {
                Controller.comboBox2.Items.Add(i.ToString());
            }

            // set the selected index to the current second
            Controller.comboBox2.SelectedIndex = int.Parse(timerNumbers[1]);

            // populate the drop down list with minutes
            for (int i = 0; i <= 15; i++)
            {
                Controller.comboBox1.Items.Add(i.ToString());
            }

            // set the selected index to the current minute
            Controller.comboBox1.SelectedIndex = int.Parse(timerNumbers[0]);
        }

        /// <summary>
        /// The function adds a zero before the number if it is only  1 digit
        /// </summary>
        /// <param name="str">The number that is in the clock label</param>
        /// <returns>The number with a zero preceding it</returns>
        public static string appendZero(double str)
        {
            if (str <= 9)
                return "0" + str;
            else
                return str.ToString();
        }

    }
}
