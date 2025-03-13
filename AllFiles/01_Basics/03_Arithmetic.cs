using System;
namespace AllFiles
{
    public class Arithmetic
    {

        public static void Main(string[] args)
        {

            int a = 10;
            int b = 5;

            // Addition
            int sum = a + b;
            Console.WriteLine("Sum: " + sum);

            // Subtraction
            int difference = a - b;
            Console.WriteLine("Difference: " + difference);

            // Multiplication
            int product = a * b;
            Console.WriteLine("Product: " + product);

            // Division
            int quotient = a / b;
            Console.WriteLine("Quotient: " + quotient);

            // Modulus
            int remainder = a % b;
            Console.WriteLine("Remainder: " + remainder);

            // Increment
            a++;
            Console.WriteLine("Incremented a: " + a);

            // Decrement
            b--;
            Console.WriteLine("Decremented b: " + b);

            // Compound Incremental Operations
            a += 5; // Equivalent to a = a + 5
            Console.WriteLine("a after a += 5: " + a);

            a -= 3; // Equivalent to a = a - 3
            Console.WriteLine("a after a -= 3: " + a);

            a *= 2; // Equivalent to a = a * 2
            Console.WriteLine("a after a *= 2: " + a);

            a /= 4; // Equivalent to a = a / 4
            Console.WriteLine("a after a /= 4: " + a);

            a %= 3; // Equivalent to a = a % 3
            Console.WriteLine("a after a %= 3: " + a);


        }
    }
}
