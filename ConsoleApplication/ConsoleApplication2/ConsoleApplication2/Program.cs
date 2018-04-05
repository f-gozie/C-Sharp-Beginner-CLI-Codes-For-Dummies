using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter your value for X below: ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x > 32)
            {
                Console.WriteLine("{0}'C is above freezing point", x);
            }
            else if (x < 32)
            {
                Console.WriteLine("{0}'C is below freezing point", x);
            }
            else
            {
                Console.WriteLine("That was the freezing point");
            }
        }
    }
}