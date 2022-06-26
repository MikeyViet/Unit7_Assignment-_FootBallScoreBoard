using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBallScoreBoard
{
    internal class FootBallScoreBoard
    {
        // All the numbers needed to populate the Football ScoreBoard
        public static int ScoreHomeTeam { get; set; }
        public static int ScoreVisitorTeam { get; set; }
        public static int TimeOutLeftHomeTeam { get; set; }
        public static int TimeOutLeftVisitorTeam { get; set; }
        public static int PositionOfBallOnField { get; set; }
        public static int CurrentQuarterOfGame { get; set; }
        public static int CurrentNumberOfDown { get; set; }
        public static int NumberOfYardsForFirstDown { get; set; }

        FootBallScoreBoard()
        {
            ScoreHomeTeam = 00;
            ScoreVisitorTeam = 00;
            TimeOutLeftHomeTeam = 3;
            TimeOutLeftVisitorTeam = 3;
            PositionOfBallOnField = 00;
            CurrentQuarterOfGame = 1;
            CurrentNumberOfDown = 1;
            NumberOfYardsForFirstDown = 0;

        }

        //public void takeTimeOut()
        //{
        //    if (TimeOutLeftHomeTeam)
        //    {

        //    }

        //}




    }
}
