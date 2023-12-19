using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2C_
{
    internal class GameResult
    {
        public string Opponent { get; }
        public string Winner { get; }
        public int Rating { get; }
        public int GameIndex { get; }
        public int CurrentRating { get; }

        public GameResult(string opponent, string winner, int rating, int gameIndex, int currentRating)
        {
            Opponent = opponent;
            Winner = winner;
            Rating = rating;
            GameIndex = gameIndex;
            CurrentRating = currentRating;
        }
    }
}
