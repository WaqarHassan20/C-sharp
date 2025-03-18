using System;

namespace BasicsPart2
{
    class Functions
    {
        public static void Main(string[] args)
        {
            // Non-parameterized function with no return value
            PrintMessage();

            // Parameterized function with a return value
            int sum = AddNumbers(5, 10);
            Console.WriteLine("Sum: " + sum);

            // Parameterized function with no return value
            GreetUser("Waqar");

            // Function with optional parameters
            DisplayInfo("Waqar", 25);
            DisplayInfo("Hassan");

            // Function with default parameters
            DisplayDefaultInfo();

            // Function with ref parameters
            int number = 10;
            IncrementNumber(ref number);
            Console.WriteLine("Incremented Number: " + number);

            // Overloaded functions
            Console.WriteLine("Overloaded Function (int): " + Multiply(5, 6));
            Console.WriteLine("Overloaded Function (double): " + Multiply(5.5, 6.5));

            // Recursive function
            int factorial = CalculateFactorial(5);
            Console.WriteLine("Factorial: " + factorial);

            // Function with variable number of arguments (params)
            int total = AddMultipleNumbers(1, 2, 3, 4, 5);
            Console.WriteLine("Sum of Multiple Numbers: " + total);
        }

        // Non-parameterized function with no return value
        public static void PrintMessage()
        {
            Console.WriteLine("Hello, Welcome to the tutorial of C Sharp!");
        }

        // Parameterized function with a return value
        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        // Parameterized function with no return value
        public static void GreetUser(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }

        // Function with optional parameters
        public static void DisplayInfo(string name, int age = 0)
        {
            if (age > 0)
            {
                Console.WriteLine("Name: " + name + ", Age: " + age);
            }
            else
            {
                Console.WriteLine("Name: " + name);
            }
        }

        // Function with default parameters
        public static void DisplayDefaultInfo()
        {
            Console.WriteLine("Default Info: Name = Waqar Ul Hassan, Age = 24");
        }

        // Function with ref parameters
        public static void IncrementNumber(ref int number)
        {
            number++;
        }

        // Overloaded functions
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        // Recursive function
        public static int CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;
            return n * CalculateFactorial(n - 1);
        }

        // Function with variable number of arguments (params)
        public static int AddMultipleNumbers(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}