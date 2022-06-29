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

    }
}
