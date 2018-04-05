using System;

namespace Loopsandshii
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int n, count=0;
            int sum = 0;
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                int user;
                Console.Write("Enter another value: ");
                user = Convert.ToInt32(Console.ReadLine());
                sum += user;
                ++count;
            } while (count < n);
            Console.WriteLine("Total sum is {0}", sum);
        }
    }
}