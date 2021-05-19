using System;

namespace Lab_13
{
    class Program
    {
        static void Main(string[] args)
        {

            HumanPlayer player = new HumanPlayer();
            player = RPSApp.NamePlayer();




            IPlayer oppoent = RPSApp.DisplayandPickOpponent(player);

            RPS userMove;
            RPS opponentMove;

            int userTotal = 0;
            int oppTotal = 0;
            bool repeat = true;
            string goAgain = "";
            while (repeat)
            {
                userMove = RPSApp.ChooseRPS();
                opponentMove = oppoent.GenerateRPS();


                if (userMove == opponentMove)
                {
                    Console.WriteLine("It's a draw!");
                    Console.WriteLine("Would you like to go again? (y|n)");
                    goAgain = Console.ReadLine();
                    if (goAgain.ToLower() == "y")
                    {
                        repeat = true;
                    }
                    else if (goAgain.ToLower() == "n")
                    {
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("Error! Please enter: y|n");
                        goAgain = Console.ReadLine();
                    }

                }
                else if ((userMove == RPS.Paper) & (opponentMove == RPS.Rock))
                {
                    Console.WriteLine("You Win!");
                    Console.WriteLine("Would you like to go again? (y|n)");
                    goAgain = Console.ReadLine();
                    userTotal = userTotal + 1;
                    if (goAgain.ToLower() == "y")
                    {
                        repeat = true;
                    }
                    else if (goAgain.ToLower() == "n")
                    {
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("Error! Please enter: y|n");
                        goAgain = Console.ReadLine();
                    }
                }
                else if ((userMove == RPS.Paper) & (opponentMove == RPS.Scissors))
                {
                    Console.WriteLine("You Lose!");
                    Console.WriteLine("Would you like to go again? (y|n)");
                    goAgain = Console.ReadLine();
                    oppTotal = oppTotal + 1;
                    if (goAgain.ToLower() == "y")
                    {
                        repeat = true;
                    }
                    else if (goAgain.ToLower() == "n")
                    {
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("Error! Please enter: y|n");
                        goAgain = Console.ReadLine();
                    }
                }
                else if ((userMove == RPS.Rock) & (opponentMove == RPS.Paper))
                {
                    Console.WriteLine("You Lose!");
                    Console.WriteLine("Would you like to go again? (y|n)");
                    goAgain = Console.ReadLine();
                    oppTotal = oppTotal + 1;
                    if (goAgain.ToLower() == "y")
                    {
                        repeat = true;
                    }
                    else if (goAgain.ToLower() == "n")
                    {
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("Error! Please enter: y|n");
                        goAgain = Console.ReadLine();
                    }
                }
                else if ((userMove == RPS.Rock) & (opponentMove == RPS.Scissors))
                {
                    Console.WriteLine("You Win!");
                    Console.WriteLine("Would you like to go again? (y|n)");
                    goAgain = Console.ReadLine();
                    userTotal = userTotal + 1;
                    if (goAgain.ToLower() == "y")
                    {
                        repeat = true;
                    }
                    else if (goAgain.ToLower() == "n")
                    {
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("Error! Please enter: y|n");
                        goAgain = Console.ReadLine();
                    }
                }
                else if ((userMove == RPS.Scissors) & (opponentMove == RPS.Rock))
                {
                    Console.WriteLine("You Lose!");
                    Console.WriteLine("Would you like to go again? (y|n)");
                    goAgain = Console.ReadLine();
                    oppTotal = oppTotal + 1;
                    if (goAgain.ToLower() == "y")
                    {
                        repeat = true;
                    }
                    else if (goAgain.ToLower() == "n")
                    {
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("Error! Please enter: y|n");
                        goAgain = Console.ReadLine();
                    }
                }
                else if ((userMove == RPS.Scissors) & (userMove == RPS.Paper))
                {
                    Console.WriteLine("You Win!");
                    Console.WriteLine("Would you like to go again? (y|n)");
                    goAgain = Console.ReadLine();
                    userTotal = userTotal + 1;
                    if (goAgain.ToLower() == "y")
                    {
                        repeat = true;
                    }
                    else if (goAgain.ToLower() == "n")
                    {
                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("Error! Please enter: y|n");
                        goAgain = Console.ReadLine();
                    }


                }


                Console.WriteLine($"Score: {oppoent.Name} {oppTotal} | {player.Name} {userTotal}");

            }

        }
    }
}