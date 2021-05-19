using System;
using System.Collections.Generic;
using System.Text;


namespace Lab_13
{
    public class RPSApp
    {
        public static HumanPlayer NamePlayer()
        {
            string _name = "";
            HumanPlayer player = new HumanPlayer(_name);
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine($"Enter your name:");
            player.Name = Console.ReadLine();
            return player;
        }




        public static IPlayer DisplayandPickOpponent(HumanPlayer player)
        {
            RockPlayer Korg = new RockPlayer("Korg");
            RandomPlayer Edward = new RandomPlayer("Edward Scissorhands");
            bool repeat = true;
            IPlayer SelectedPlayer = Edward;
            while (repeat)
            {
                Console.WriteLine($"{player.Name}, choose your opponent: \n1.{Edward.Name}\n2.{Korg.Name}");
                string playerSelect = Console.ReadLine();

                if (playerSelect == "1")
                {
                    SelectedPlayer = Edward;
                    repeat = false;
                }
                else if (playerSelect == "2")
                {
                    SelectedPlayer = Korg;
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Error! Please enter 1 or 2");
                    repeat = true;
                }
            }
            return SelectedPlayer;
        }

        public static RPS ChooseRPS()
        {
            bool repeat = true;
            RPS playerMove = RPS.Rock;
            while (repeat)
            {

                Console.WriteLine("Rock, Paper, or Scissors? (R|P|S):");
                string selection = Console.ReadLine();

                if (selection.ToLower() == "r")
                {
                    playerMove = RPS.Rock;
                    Console.WriteLine($"You: {playerMove}");
                    repeat = false;


                }
                else if (selection.ToLower() == "p")
                {
                    playerMove = RPS.Paper;
                    Console.WriteLine($"You: {playerMove}");
                    repeat = false;

                }
                else if (selection.ToLower() == "s")
                {
                    playerMove = RPS.Scissors;
                    Console.WriteLine($"You: {playerMove}");
                    repeat = false;

                }
                else
                {
                    Console.WriteLine("Error! please use one of the following choices - r|p|s");
                    repeat = true;
                }

            }
            //Console.WriteLine(playerMove);
            return playerMove;
        }






    }
}