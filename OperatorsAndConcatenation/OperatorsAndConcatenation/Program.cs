using System;

namespace OperatorsAndConcatenation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Operator Example
            int a = 7 + 9;
            Console.WriteLine(a);

            string fName = "John";
            string lName = "Buskow";
            string fullName = fName + " " + lName;
            
            Console.WriteLine(fullName);
        }
    }
}