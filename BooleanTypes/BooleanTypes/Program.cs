using System;

namespace BooleanTypes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Just testing out Boolean Values
            
            int a = 1;
            int b = 2;
            /* Which is greater */
            bool greaterAB = a > b;
            /* Check for equality between A & B */
            bool equalA1 = a == 1;
            /* Display the result */
            if (greaterAB)
            {
                Console.WriteLine("A > B");
            }
            else
            {
                Console.WriteLine("A <= B");
            }
            Console.WriteLine("greaterAB = " + greaterAB);
            Console.WriteLine("equalA1 = " + equalA1);
        }
    }
}