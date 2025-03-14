using System;

namespace BasicsPart2
{
    class StringMethods
    {
        public static void Main(string[] args)
        {
            string myName = " Waqar Ul Hassan ";

            // Clone
            string clonedName = (string)myName.Clone();
            Console.WriteLine("Clone: " + clonedName);

            // CompareTo
            Console.WriteLine("CompareTo 'Waqar': " + myName.CompareTo("Waqar"));

            // Contains
            Console.WriteLine("Contains 'Ul': " + myName.Contains("Ul"));

            // EndsWith
            Console.WriteLine("EndsWith 'Hassan': " + myName.EndsWith("Hassan "));

            // Equals
            Console.WriteLine("Equals 'Waqar Ul Hassan': " + myName.Equals("Waqar Ul Hassan"));

            // IndexOf
            Console.WriteLine("IndexOf 'Hassan': " + myName.IndexOf("Hassan"));

            // Insert
            Console.WriteLine("Insert: " + myName.Insert(0, "Mr."));

            // PadLeft
            Console.WriteLine("PadLeft: '" + myName.PadLeft(20) + "'");

            // PadRight
            Console.WriteLine("PadRight: '" + myName.PadRight(20) + "'");

            // Remove
            Console.WriteLine("Remove: " + myName.Remove(0, 6));

            // Replace
            Console.WriteLine("Replace: " + myName.Replace("Ul", ""));

            // Split
            string[] splitName = myName.Split(' ');
            Console.WriteLine(splitName); // This will give the dataType which will be System.String[]
            Console.WriteLine("Split: " + string.Join(", ", splitName)); // Join all splitted strings and then print them

            // StartsWith
            Console.WriteLine("StartsWith 'Waqar': " + myName.StartsWith(" Waqar"));

            // Substring
            Console.WriteLine("Substring: " + myName.Substring(6));

            // ToLower
            Console.WriteLine("ToLower: " + myName.ToLower());

            // ToUpper
            Console.WriteLine("ToUpper: " + myName.ToUpper());

            // Trim
            Console.WriteLine("Trim: '" + myName.Trim() + "'");

            // TrimEnd
            Console.WriteLine("TrimEnd: '" + myName.TrimEnd() + "'");

            // TrimStart
            Console.WriteLine("TrimStart: '" + myName.TrimStart() + "'");
        }
    }
}