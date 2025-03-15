using System;
using System.Security.Cryptography;

namespace PracticeGame
{
    class CalculatorProgram
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("----------------------");
            Console.WriteLine("- Calculator Program -");
            Console.WriteLine("----------------------");

            do
            {
                Console.Write("Enter num1 : ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter num2 : ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                double result = 0;

                Console.WriteLine("\t Add : + ");
                Console.WriteLine("\t Sub : - ");
                Console.WriteLine("\t Mul : * ");
                Console.WriteLine("\t Div : / ");
                Console.WriteLine("\t Mod : % ");
                Console.Write("Enter an operation : ");
                string operation = Console.ReadLine() ?? "";
                while (operation != "+" && operation != "-" && operation != "*" && operation != "/" && operation != "%")
                {
                    Console.Write("Enter a valid operation : ");
                }

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Sum of {num1} and {num2} is {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Subtraction of {num1} and {num2} is {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Product of {num1} and {num2} is {result}");
                        break;
                    case "/":
                        if (num2 == 0)
                            Console.WriteLine("Dividing by 0");
                        result = num1 / num2;
                        Console.WriteLine($"Division of {num1} and {num2} is {result}");
                        break;
                    case "%":
                        if (num2 == 0)
                            Console.WriteLine("Dividing by 0");
                        result = num1 % num2;
                        Console.WriteLine($"Remainder of {num1} with {num2} is {result}");
                        break;
                }

                Console.Write("\nWould you like to continue or quit : (Y/N) : ");

            } while (Console.ReadLine()?.ToUpper() == "Y");

            Console.Write("/nThank you for using our service !");


        }
    }
}