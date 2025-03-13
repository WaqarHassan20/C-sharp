using System;

namespace AllFiles
{
    public class MathExamples
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(); // its arguments is optional ,here between 0 and 6 else some big random number
            Console.WriteLine("Random Next number is : " + number);
            double number2 = random.NextDouble(); // this does not take any arguments
            Console.WriteLine("Random NextDouble number is : " + number2);


            // Program to find the hypotenuse of a triangle //
            Console.Write("Enter the base value of triangle :");
            double BaseValue = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Perpendicular Value of triangle :");
            double PerpendicularValue = Convert.ToDouble(Console.ReadLine());

            double hypotenuse = Math.Sqrt(Math.Pow(BaseValue, 2) + Math.Pow(PerpendicularValue, 2));
            Console.WriteLine("Hypotenuse of triangle is = " + hypotenuse);

        }
    }
}