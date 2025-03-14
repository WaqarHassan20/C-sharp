using System;
using System.Net;

namespace PracticeGame
{
    class GuessRandomNumber
    {
        public static void Main(string[] args)
        {

            Random random = new Random();
            bool playAgain = true;
            int min = 0;
            int max = 100;
            int number, guess, guessess;
            string response = "";

            while (playAgain)
            {
                guess = guessess = 0;
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.Write($"\nEnter the number between {min} and {max} : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");

                    if (guess > number)
                    {
                        System.Console.WriteLine("Your guess is higher than number");
                    }
                    else if (guess < number)
                    {
                        System.Console.WriteLine("Your guess is lower than number");
                    }
                    guessess++;

                }

                Console.WriteLine("");
                System.Console.WriteLine("YOU WON !!!");
                System.Console.WriteLine("The number was " + number);
                System.Console.WriteLine("You guessed the number in " + guessess + " attempts \n");
                System.Console.Write("Would you like to play again ? (Y/N) : ");
                response = Console.ReadLine() ?? "".ToUpper();
                if (response == "Y")
                {
                    playAgain = true;
                }
                else if (response == "N")
                {
                    playAgain = false;
                }

            }

            System.Console.WriteLine("\nThank you so much for playing !");
        }
    }
}