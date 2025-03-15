using System;

namespace PracticeGame
{
    class RockPaperScissors
    {
        public static void Main(string[] args)
        {

            Random random = new Random();
            bool playAgain = true;
            string username;
            string response;
            string computer;
            string player;
            Console.Write("Enter your name : ");
            username = Console.ReadLine() ?? "".ToUpper();
            Console.Write("\n");



            while (playAgain)
            {
                player = "";
                computer = "";


                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER, SCISSORS : ");
                    player = Console.ReadLine() ?? "".ToUpper();
                    Console.Write("\n");

                }

                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                switch (player)
                {
                    case "ROCK":

                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a DRAW\n");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("Computer WON !\n");
                        }
                        if (computer == "SCISSORS")
                        {
                            Console.WriteLine($"{username} WON !\n");
                        }
                        break;
                    case "PAPER":

                        if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a DRAW\n");
                        }
                        else if (computer == "ROCK")
                        {
                            Console.WriteLine($"{username} WON !\n");
                        }
                        if (computer == "SCISSORS")
                        {
                            Console.WriteLine("Computer WON !\n");
                        }
                        break;
                    case "SCISSORS":

                        if (computer == "SCISSORS")
                        {
                            Console.WriteLine("It's a DRAW\n");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine($"{username} WON !\n");
                        }
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("Computer WON !\n");
                        }
                        break;

                }
                Console.Write("Would you like to play again ? (Y/N) : ");
                response = Console.ReadLine() ?? "".ToUpper();
                Console.Write("\n");
                if (response == "Y")
                {
                    playAgain = true;
                }
                else if (response == "N")
                {
                    playAgain = false;
                }

            }

            Console.WriteLine("THANK YOU SO MUCH FOR PLAYING " + username + " !");


        }
    }
}