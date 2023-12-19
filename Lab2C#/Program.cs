using Lab2C_.Accounts;
using System.Security.AccessControl;

namespace Lab2C_
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Program program = new Program();
            program.Compile();
        }
        public void Compile()
        {
            string answer;
            Console.WriteLine("Write first name player: ");
            string firstUser = Console.ReadLine();
            GameAccount player1 = AccountChose(firstUser);
            Console.WriteLine("Write second name player: ");
            string secondUser = Console.ReadLine();
            GameAccount player2 = AccountChose(secondUser);

            Game game = GameType(player1, player2);
            do
            {
               game.PlayGame(player1, player2);
               Console.WriteLine("Play again? (Y/N)");
               answer = Console.ReadLine();
            } while (answer == "Y");
            player1.GetStats();
        }
        private GameAccount AccountChose(string userName)
        {
            Console.WriteLine("Choose account type: \n1.StandartAccount \n2.HalfAccount \n3.VIPAccount");
            int choose = int.Parse(Console.ReadLine());
            switch(choose)
            {
                case 1:
                    return new StandartAccount(userName);
                case 2:
                    return new UnrankedAccount(userName);
                case 3:
                    return new VIPAccount(userName);
                default:
                    Console.WriteLine("Incorrect. Write number between 1-3");
                    return AccountChose(userName);
            }
        }
        private Game GameType(GameAccount player1, GameAccount player2) 
        {
            Console.WriteLine("Choose game type: \n1.StandartGame \n2.HalfGame \n3.DoubleRatingGame");
            int choose = int.Parse(Console.ReadLine());
            GameFactory factory = new GameFactory();
            switch (choose)
            {
                case 1:
                    return factory.CreateStandartGame(player1,player2);
                case 2:
                    return factory.CreateHalfGame(player1, player2);
                case 3:
                    return factory.CreateDoubleRatingGame(player1, player2);
                default:
                    Console.WriteLine("Incorrect. Write number between 1-3");
                    return GameType(player1, player2);
            }
        }
    }   
}