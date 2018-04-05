using System;

namespace ComparisonOperators
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int weight = 700;
            Console.WriteLine(weight >= 500);
            
            // Logical Operators
            Console.WriteLine("Exclusive OR: " + ((2 < 3) ^ (4 > 3)));
        }
    }
}