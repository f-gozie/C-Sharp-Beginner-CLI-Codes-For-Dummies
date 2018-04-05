using System;

namespace sequenceshii
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /**int x=3, sum;
            int count = 0;
            while (count < 21)
            {
                x = x * 2 - 1;
                Console.WriteLine(x);
                ++count;
            }**/
            int x = 7;
            int count = 0;
            Console.WriteLine(x);
            while (count < 21)
            {
                x = x + 5;
                Console.WriteLine(x);
                ++count;
            }
        }
    }
}