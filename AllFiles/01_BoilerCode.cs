// Import the System namespace, which contains fundamental classes and base classes 
// that define commonly-used value and reference data types, events and event handlers, 
// interfaces, attributes, and processing exceptions.

// Define a namespace called MyNamespace. Namespaces are used to organize code into a 
// hierarchical structure and to control the scope of class and method names in larger 
// programming projects.

// Define a public class called Basics. A class is a blueprint for creating objects, 
// providing initial values for state (member variables or fields), and implementations 
// of behavior (member functions or methods).

// The Main method is the entry point of a C# application. It is the method that 
// is called when the application starts. The 'string[] args' parameter is an array 
// of strings that can contain command-line arguments provided when the application 
// is started.


using System;
namespace MyNamespace
{
    public class Basics
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("\n");
            Console.Write("====== Basic Print ======");
            Console.WriteLine("\n");

            Console.Write("Hello World 1!"); // this will not break the line after printing
            Console.WriteLine("Hello World, 2"); // this will go to next line after printing
            Console.WriteLine("Hello World, 3"); // this will go to next line after printing too



            Console.WriteLine("\n");
            Console.Write("====== Escaping Sequence ======");
            Console.WriteLine("\n");

            // Newline escape sequence
            Console.WriteLine("Hello\nWorld");

            // Tab escape sequence
            Console.WriteLine("Hello\tWorld");

            // Backslash escape sequence
            Console.WriteLine("Hello\\World");

            // Double quote escape sequence
            Console.WriteLine("Hello\"World");

            // Single quote escape sequence
            Console.WriteLine("Hello\'World");

            // Unicode escape sequence
            Console.WriteLine("Hello\u0020World");


            Console.WriteLine("\n");
            Console.Write("====== DataTypes ======");
            Console.WriteLine("\n");

            // Integer
            int age = 25;
            Console.WriteLine("Your age is = " + age);
            int x = 10;
            Console.WriteLine("Value of int is = " + x);

            // Float
            float y = 10.5f;
            Console.WriteLine("Value of float is = " + y);

            // Double
            double z = 10.5;
            Console.WriteLine("Value of double is = " + z);

            // Boolean
            bool isAlive = true;
            Console.WriteLine("Value of isAlive is = " + isAlive);

            // Char
            char c = 'A';
            Console.WriteLine("Value of char is = " + c);

            // String   
            string s = "Hello World";
            Console.WriteLine("Value of string is = " + s);
            string Username = "Waqar Ul Hassan";
            Console.WriteLine("User's name is = " + Username);

            // Arithmetic Operators

            int a = 10;
            int b = 20;


            Console.WriteLine("Sum of x and y is = ", a + b);
            Console.WriteLine("Subtraction of a and b is = ", a - b);
            Console.WriteLine("Multiplication of a and b is = ", a * b);
            Console.WriteLine("Division of a and b is = ", a / b);
            Console.WriteLine("Modulus of a and b is = ", x % b);

        }
    }
}