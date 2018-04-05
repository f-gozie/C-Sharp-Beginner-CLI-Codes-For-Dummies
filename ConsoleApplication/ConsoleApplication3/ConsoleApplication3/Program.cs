using System;

namespace ConsoleApplication3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int hours, rate;
            Console.WriteLine("Enter number of hours worked: ");
            hours = Convert.ToInt32(Console.ReadLine());
            if (hours <= 12)
            {
                rate = 50 * hours;
                Console.WriteLine("Your total money is: {0}", rate);
            }
            else if (hours > 12)
            {
                int hour, x, y;
                hour = hours - 12;
                x = 12 * 50;
                y = hour * 90;
                rate = x + y;
                Console.WriteLine("Your total money is: {0}", rate);
            }
        }
    }
}