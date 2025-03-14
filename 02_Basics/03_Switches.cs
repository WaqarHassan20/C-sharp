using System;

namespace BasicsPart2
{
    class Switches
    {
        public static void Main(string[] args)
        {

            // Example of switch statement using the day of week
            Console.Write("Enter the day of week : ");
            string? day = Console.ReadLine()?.ToLower();
            // this ?. is called as null conditional operator
            switch (day)
            {
                case "monday":
                    Console.WriteLine("It's Monday today!");
                    break;
                case "tuesday":
                    Console.WriteLine("It's Tuesday today!");
                    break;
                case "wednesday":
                    Console.WriteLine("It's wednesday today!");
                    break;
                case "thursday":
                    Console.WriteLine("It's thursday today!");
                    break;
                case "friday":
                    Console.WriteLine("It's friday today!");
                    break;
                case "saturday":
                    Console.WriteLine("It's saturday today!");
                    break;
                case "sunday":
                    Console.WriteLine("It's sunday today!");
                    break;
                default:
                    Console.WriteLine("It's Monday today!");
                    break;
            }



            // Example of switch statement using the grades
            Console.Write("Enter a grade (A, B, C, D, F): ");
            char grade = Convert.ToChar(Console.ReadLine() ?? "".ToUpper());
            // if input is null then set it to empty string and then convert it to upper case

            switch (grade)
            {
                case 'A':
                case 'B':
                    Console.WriteLine("Good job!");
                    break;
                case 'C':
                    Console.WriteLine("You passed.");
                    break;
                case 'D':
                case 'F':
                    Console.WriteLine("You failed.");
                    break;
                default:
                    Console.WriteLine("Invalid grade entered.");
                    break;
            }


            // Example of switch statement using the numbers as input
            Console.Write("Enter a number between 1 and 3: ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("You entered one.");
                    goto case 3;
                case 2:
                    Console.WriteLine("You entered two.");
                    break;
                case 3:
                    Console.WriteLine("You entered three.");
                    break;
                default:
                    Console.WriteLine("You entered a number outside the range of 1 to 3.");
                    break;
            }

        }
    }
}