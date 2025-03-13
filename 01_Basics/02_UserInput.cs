using System;
namespace AllFiles
{
    public class UserInput
    {

        public static void Main(string[] args)
        {

            Console.Write("What's your name : ");
            string? name = Console.ReadLine(); // Takes input from the user
            Console.WriteLine("Hello, " + name + "!");

            Console.WriteLine("What's your age ?");
            int age = Convert.ToInt32(Console.ReadLine()); // Takes input from the user and converts it to integer
            Console.WriteLine("Age of " + name + "is " + age);

            // String input
            Console.Write("Enter your name : ");
            string? userName = Console.ReadLine();
            Console.WriteLine("Hello, " + userName + "!");

            // Integer input
            Console.Write("Enter your age : ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your userAge is: " + userAge);

            // Double input
            Console.Write("Enter your height in meters : ");
            double userHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your userHeight is: " + userHeight + " meters");

            // Boolean input
            Console.Write("Are you a student (true/false) : ");
            bool isStudent = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Student status: " + isStudent);

            // Char input
            Console.Write("Enter your grade (A, B, C, etc.) : ");
            string? userGrade = Console.ReadLine();
            if (userGrade != null)
            {
                char? grade = Convert.ToChar(userGrade);
                Console.WriteLine("Your userGrade is: " + userGrade);
            }


        }
    }
}
