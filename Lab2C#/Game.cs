using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab2C_
{
    abstract class Game
    {
        public GameAccount player1 { get; set; }
        public GameAccount player2 { get; set; }
        public int playRating { get; set; } = 0;
        public string winner { get; set; }
        public int gameIndex { get; set; }
        public Game(GameAccount player1, GameAccount player2)
        {
            this.player1 = player1;
            this.player2 = player2; 
        }
        public virtual int getPlayRating(GameAccount player) { return playRating; }
        public void PlayGame(GameAccount Gamer1, GameAccount Gamer2)
        {
            Console.WriteLine("Write rating:");
            playRating = int.Parse(Console.ReadLine());
            while (playRating <= 0 || Gamer1.CurrentRating < playRating || Gamer2.CurrentRating < playRating)
            {
                Console.WriteLine("Rating cannot be less than 0, type an another rating: ");
                playRating = int.Parse(Console.ReadLine());
            }
            Random random = new Random();
            gameIndex += 1;
            int a = random.Next(1, 11);
            int b = random.Next(1, 11);
            if (a > b)
            {
                Console.WriteLine("Player 1 win");
                player1.WinGame(this, Gamer2.UserName, gameIndex);
                Console.WriteLine("Player 2 lose");
                player2.LoseGame(this, Gamer1.UserName, gameIndex);
            }
            if (a < b)
            {
                Console.WriteLine("Player 2 win");
                player2.WinGame(this, Gamer1.UserName, gameIndex);
                Console.WriteLine("Player 1 lose");
                player1.LoseGame(this, Gamer2.UserName, gameIndex);
            }
            if (a == b)
            {
                Console.WriteLine("Draw");
                player1.DrawGame(this, Gamer2.UserName, gameIndex, Gamer1.CurrentRating);
                player2.DrawGame(this, Gamer1.UserName, gameIndex, Gamer2.CurrentRating);
            }
        }
       
    }
}
