namespace Basics
{
    public class DataTypes
    {

        public static void Main(string[] args)
        {

            Console.Write("\n======================================== Basic Print ========================================\n");

            Console.Write("Hello World 1!"); // this will not break the line aftera printing
            Console.WriteLine("Hello World, 2"); // this will go to next line after printing
            Console.WriteLine("Hello World, 3"); // this will go to next line after printing too


            Console.Write("\n======================================== Escaping Sequence ========================================\n");

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


            Console.Write("\n======================================== DataTypes ========================================\n");

            // Integer
            int age = 25;
            Console.WriteLine("Your age is = " + age);
            int ten = 10;
            Console.WriteLine("Value of int is = " + ten);

            // Float
            float floatValue = 10.5f;
            Console.WriteLine("Value of float is = " + floatValue);

            // Double
            double doubleValue = 10.5;
            Console.WriteLine("Value of double is = " + doubleValue);

            // Const
            int number = 10;
            number = 20; // This will not give an error because we can change the value of a number
            Console.WriteLine("Value of number is = " + number);
            // pi = 3.15; // This will give an error because we can't change the value of a constant variable
            const double pi = 3.14;
            Console.WriteLine("Value of pi is = " + pi);

            // Boolean
            bool isAlive = true;
            Console.WriteLine("Value of isAlive is = " + isAlive);

            // Char
            char letter = 'A';
            Console.WriteLine("Value of char is = " + letter);

            // String   
            string greeting = "Hello World";
            Console.WriteLine("Value of string is = " + greeting);
            string Username = "Waqar Ul Hassan";
            Console.WriteLine("User's name is = " + Username);



            Console.Write("\n======================================== TypeCasting ========================================\n");

            // TypeCasting : it means converting one data type to another data type without losing any data with the help of some predefined functions.
            double originalValue = 10.5;
            int convertedValue = (int)originalValue;
            Console.WriteLine("Converted value is now = " + convertedValue);

            int counting = 123;
            string countingStr = Convert.ToString(counting);
            Console.WriteLine("Converted Value is now = " + countingStr);

            string dollar = "true";
            bool booleanValue = Convert.ToBoolean(dollar);
            Console.WriteLine("Converted Value is now have type = " + booleanValue.GetType());

            double originalValue2 = 20.55;
            Console.WriteLine("Original value is = " + originalValue2);
            Console.WriteLine("Type of original value is = " + originalValue2.GetType());
            int convertedValue2 = Convert.ToInt32(originalValue2);
            Console.WriteLine("Converted value is = " + convertedValue2);
            Console.WriteLine("Type of converted value is = " + convertedValue2.GetType());

            int implicitX = 10;
            double implicitY = implicitX;  // Implicit conversion
            // IMPORTANT: Implicit conversions are allowed when no information is lost
            // (like int to double), but not when precision might be lost
            Console.WriteLine("Implicit conversion int to double: " + implicitY);

            double explicitX = 13.7;
            int explicitY = (int)explicitX;  // Explicit conversion
            // IMPORTANT: This is called casting - it can lead to data loss (the .7 is truncated, not rounded)
            Console.WriteLine("Explicit conversion double to int: " + explicitY);

        }
    }
}
