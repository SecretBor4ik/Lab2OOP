using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lab2C_
{
    internal class GameAccount
    {
        public string UserName { get; set; }
        public int CurrentRating { get; set; }
        public int GamesCount { get; set; }
        public List<GameResult> GameResults { get; set; } = new List<GameResult>();

        public GameAccount(string userName)
        {
            UserName = userName;
            CurrentRating = 100;
            GamesCount = 0;
        }
        public void WinGame(Game game, string player, int gameIndex)
        {
            int rating = RatingCalc(game.getPlayRating(this));
            string winner = "Win";
            CurrentRating += rating;
            GamesCount++;
            GameResults.Add(new GameResult(player, winner, rating, gameIndex, CurrentRating));
        }
        public void LoseGame(Game game, string player, int gameIndex)
        {
            int rating = RatingCalc(game.getPlayRating(this));
            string winner = "Lose";
            if (CurrentRating > 1)
            {
                CurrentRating -= rating;
                if (CurrentRating < 1)
                {
                    CurrentRating = 1;
                }
            }
            GamesCount++;
            GameResults.Add(new GameResult(player, winner, rating, gameIndex, CurrentRating));
        }
        public void DrawGame(Game game, string player, int gameIndex, int currentRating)
        {
            GamesCount++;
            string winner = "Draw";
            int rating = RatingCalc(game.getPlayRating(this));
            GameResults.Add(new GameResult(player, winner, rating, gameIndex, currentRating));
        }
        public void GetStats()
        {
            foreach (GameResult result in GameResults)
            {
                Console.WriteLine($"Against {result.Opponent}, {result.Winner}, Rating: {result.CurrentRating}, Game number #{result.GameIndex}");
            }
        }
        public virtual int RatingCalc(int rating)
        {
            return rating;
        }
    }
}
