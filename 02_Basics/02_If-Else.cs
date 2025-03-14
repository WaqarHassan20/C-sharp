using System;

namespace BasicsPart2
{
    class IfElseStatements
    {
        public static void Main(string[] args)
        {

            // Age checking using the if else condition //
            Console.Write("Enter you age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is : " + age);

            if (age < 0)
            {
                Console.WriteLine("You are in liquid form and not born yet");
            }

            else if (age > 0 && age < 18)
            {
                Console.WriteLine("You are in teenage and cannot vote ");
            }

            else if (age >= 18 && age < 100)
            {
                Console.WriteLine("You are eligible to vote ");
            }

            else if (age >= 100)
            {
                Console.WriteLine("You are too old to vote");

            }
            else
            {
                Console.WriteLine("You are NOT eligible to vote ");
            }


            // Input name checking using the if else condition //
            Console.Write("Enter you name : ");
            string? name = Console.ReadLine();
            if (name == "")
            {
                Console.WriteLine("You did not entered the name.");
            }
            else
            {
                Console.WriteLine("Your name is = " + name);
            }


            // Example of nested if else statements
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is positive and even.");
                }
                else
                {
                    Console.WriteLine("The number is positive and odd.");
                }
            }
            else if (number < 0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is negative and even.");
                }
                else
                {
                    Console.WriteLine("The number is negative and odd.");
                }
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

        }
    }
}