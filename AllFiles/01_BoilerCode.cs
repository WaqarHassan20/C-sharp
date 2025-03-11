// Import the System namespace, which contains fundamental classes and base classes 
// that define commonly-used value and reference data types, events and event handlers, 
// interfaces, attributes, and processing exceptions.
using System;

// Define a namespace called MyNamespace. Namespaces are used to organize code into a 
// hierarchical structure and to control the scope of class and method names in larger 
// programming projects.
namespace MyNamespace
{
    // Define a public class called Basics. A class is a blueprint for creating objects, 
    // providing initial values for state (member variables or fields), and implementations 
    // of behavior (member functions or methods).
    public class Basics
    {
        // The Main method is the entry point of a C# application. It is the method that 
        // is called when the application starts. The 'string[] args' parameter is an array 
        // of strings that can contain command-line arguments provided when the application 
        // is started.
        public static void Main(string[] args)
        {

            // Print a message to the console. The Console class provides basic support for 
            // applications that read and write characters to and from the console.
            Console.WriteLine("Hello World, The First C sharp code");
        }
    }
}