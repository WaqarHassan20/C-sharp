using System;

namespace AllFiles
{
    public class MathFunctions
    {
        public static void Main(string[] args)
        {

            // Absolute value
            double absoluteValue = Math.Abs(-10.5);
            Console.WriteLine("Absolute value of -10.5: " + absoluteValue);

            // Ceiling
            double ceilingValue = Math.Ceiling(10.1);
            Console.WriteLine("Ceiling value of 10.1: " + ceilingValue);

            // Floor
            double floorValue = Math.Floor(10.9);
            Console.WriteLine("Floor value of 10.9: " + floorValue);

            // Round
            double roundedValue = Math.Round(10.5);
            Console.WriteLine("Rounded value of 10.5: " + roundedValue);

            // Max
            double maxValue = Math.Max(10, 20);
            Console.WriteLine("Max value between 10 and 20: " + maxValue);

            // Min
            double minValue = Math.Min(10, 20);
            Console.WriteLine("Min value between 10 and 20: " + minValue);

            // Power
            double powerValue = Math.Pow(2, 3);
            Console.WriteLine("2 raised to the power of 3: " + powerValue);

            // Square root
            double sqrtValue = Math.Sqrt(16);
            Console.WriteLine("Square root of 16: " + sqrtValue);

            // Trigonometric functions
            double sinValue = Math.Sin(Math.PI / 2); // Sin of 90 degrees
            Console.WriteLine("Sin of 90 degrees: " + sinValue);

            double cosValue = Math.Cos(0); // Cos of 0 degrees
            Console.WriteLine("Cos of 0 degrees: " + cosValue);

            double tanValue = Math.Tan(Math.PI / 4); // Tan of 45 degrees
            Console.WriteLine("Tan of 45 degrees: " + tanValue);

            // Logarithm
            double logValue = Math.Log(10); // Natural logarithm of 10
            Console.WriteLine("Natural logarithm of 10: " + logValue);

            double log10Value = Math.Log10(100); // Base 10 logarithm of 100
            Console.WriteLine("Base 10 logarithm of 100: " + log10Value);

            // Exponential
            double expValue = Math.Exp(2); // e raised to the power of 2
            Console.WriteLine("e raised to the power of 2: " + expValue);

            // Constants
            Console.WriteLine("Value of PI: " + Math.PI);
            Console.WriteLine("Value of E: " + Math.E);
        }
    }
}