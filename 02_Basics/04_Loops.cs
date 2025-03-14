using System;

namespace BasicsPart2
{
    class AllLoops
    {
        public static void Main(string[] args)
        {


            // while loop in c#
            Console.Write("Enter you name : ");
            string? name = Console.ReadLine();
            while (name == "")
            {
                Console.Write("Please enter a valid name");
                name = Console.ReadLine();
            }
            Console.WriteLine($"Hello {name}! Welcome to world of C#");

            // Additional while loop example
            int counter = 0;
            while (counter < 3)
            {
                Console.Write($"Counter is at: {counter} \t");
                counter++;
            }
            Console.Write("\n");

            // for loop in c#
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"i = {i} \t");
            }
            Console.Write("\n");

            // Additional for loop example
            for (int i = 10; i > 5; i--)
            {
                Console.Write($"Countdown: {i}\t");
            }
            Console.Write("\n");


            // do while loop in c#
            int j = 0;
            do
            {
                Console.Write($"j = {j}\t");
                j++;
            } while (j < 5);
            Console.Write("\n");

            // Additional do while loop example
            int m = 10;
            do
            {
                Console.Write($"Value of m: {m}\t");
                m--;
            } while (m > 5);
            Console.Write("\n");


            // Nested loop in c#
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 5; k++)
                {
                    Console.Write($"({i},{k}) ");
                }
                Console.Write("\n");
            }

        }
    }
}