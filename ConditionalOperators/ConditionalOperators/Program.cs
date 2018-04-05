using System;

namespace ConditionalOperators
{
    internal class Program
    {
        public static void Main()
        {
            // Conditional Operator ?
            int a = 6;
            int b = 4;
            Console.WriteLine(a > b ? "a > b" : "a < b");
            
            // Using Conditional Operator ? with Assignment Operator
            int num = a == b ? 1 : -1;
        }
    }
}