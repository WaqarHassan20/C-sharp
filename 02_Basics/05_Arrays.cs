using System;

namespace BasicPart2
{
    class Arrays
    {
        public static void Main(string[] args)
        {
            // 1. Declaration and Initialization of Arrays
            int[] numbers = new int[5]; // Declaration with size
            numbers[0] = 10; // Assigning values
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            int[] predefinedNumbers = { 1, 2, 3, 4, 5 }; // Declaration and initialization in one step

            // 2. Traversing Arrays Using a For Loop
            Console.WriteLine("Traversing using for loop:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // 3. Traversing Arrays Using a Foreach Loop
            Console.WriteLine("\nTraversing using foreach loop:");
            foreach (int num in predefinedNumbers)
            {
                Console.WriteLine(num);
            }

            // 4. Multi-Dimensional Arrays
            Console.WriteLine("\nMulti-dimensional array:");
            int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } }; // 2x3 matrix
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // 5. Array Methods
            Console.WriteLine("\nArray methods:");
            Array.Sort(predefinedNumbers); // Sort the array
            Console.WriteLine("Sorted array: " + string.Join(", ", predefinedNumbers));

            Array.Reverse(predefinedNumbers); // Reverse the array
            Console.WriteLine("Reversed array: " + string.Join(", ", predefinedNumbers));

            int indexOfElement = Array.IndexOf(predefinedNumbers, 3); // Find index of an element
            Console.WriteLine("Index of 3: " + indexOfElement);

            bool containsElement = Array.Exists(predefinedNumbers, element => element == 4); // Check if an element exists
            Console.WriteLine("Contains 4: " + containsElement);
        }
    }
}