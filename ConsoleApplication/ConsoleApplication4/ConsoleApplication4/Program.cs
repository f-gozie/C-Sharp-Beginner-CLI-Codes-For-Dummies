using System;

namespace ConsoleApplication4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int yr;
            Console.WriteLine("Enter a year");
            yr = Convert.ToInt32(Console.ReadLine());
            
            if (yr % 4 == 0)
            {
                if (yr % 100 != 0)
                {
                    Console.WriteLine("{0} is a leap year", yr);
                }
                else
                {
                    Console.WriteLine("{0} is a regular year", yr);
                }
            }
            else if (yr % 100 == 0)
            {
                if (yr % 400 == 0)
                {
                    Console.WriteLine("{0} is a leap year", yr);
                }
                else
                {
                    Console.WriteLine("{0} is a regular year", yr);
                }
            }
            else
            {
                Console.WriteLine("{0} is probably a regular year ;)", yr);
            }
        }
    }
}