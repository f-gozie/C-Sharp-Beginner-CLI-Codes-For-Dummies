using System;

namespace practice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0, count = 0;
            while (count < 101)
            {
                sum += count;
                count += 2;
            }
            Console.WriteLine(sum);
        }
    }
}