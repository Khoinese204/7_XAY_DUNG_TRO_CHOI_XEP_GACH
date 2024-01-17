using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Entities.DataBase
{
    public class ScoreBoardItems
    {
        public string TotalTime { get; set; }
        public string PlayerName { get; set; }
        public int Score { get; set; }

        public string Initial { get; set; }

        public int Level { get; set; }

        public int Rank { get; set; } 
        public string AccountId {  get; set; }
        public ScoreBoardItems()
        {
            Rank = 1;
            PlayerName = "";
            Score = 0;
            TotalTime = "";  
            Initial = "";
            Level = 1;
        }

        public ScoreBoardItems(int rank, string playerName, int score, int level)
        {
            Rank = rank;
            PlayerName = playerName;
            Score = score;  
            Level = level;

        }
        public ScoreBoardItems(string initial, int score, string totalTime)
        {
            Initial = initial;
            Score = score;
            TotalTime = totalTime;
        }
    }
}
