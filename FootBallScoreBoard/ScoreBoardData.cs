using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBallScoreBoard
{
    internal class ScoreBoardData
    {
        // All the numbers needed to populate the Football ScoreBoard
        public static string ScoreHomeTeam { get; set; }
        public static string ScoreVisitorTeam { get; set; }
        public static string TimeOutLeftHomeTeam { get; set; }
        public static string TimeOutLeftVisitorTeam { get; set; }
        public static string PositionOfBallOnField { get; set; }
        public static string CurrentQuarterOfGame { get; set; }
        public static string CurrentNumberOfDown { get; set; }
        public static string NumberOfYardsForFirstDown { get; set; }

        public ScoreBoardData()
        {
            ScoreHomeTeam = "00";
            ScoreVisitorTeam = "99";
            TimeOutLeftHomeTeam = "3";
            TimeOutLeftVisitorTeam = "3";
            PositionOfBallOnField = "00";
            CurrentQuarterOfGame = "1";
            CurrentNumberOfDown = "1";
            NumberOfYardsForFirstDown = "10";

        }

        //public void takeTimeOut()
        //{
        //    if (TimeOutLeftHomeTeam)
        //    {

        //    }

        //}




    }
}
