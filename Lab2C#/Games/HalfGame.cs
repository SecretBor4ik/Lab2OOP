using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2C_.Games
{
    class HalfGame : Game
    {
        public HalfGame(GameAccount player1, GameAccount player2) : base(player1, player2)
        {

        }
        public override int getPlayRating(GameAccount player)
        {
            if (player.UserName == player1.UserName)
            { return playRating / 2; }
            if (player.UserName == player2.UserName)
            { return playRating / 2; }
            return 0;
        }
    }
}
