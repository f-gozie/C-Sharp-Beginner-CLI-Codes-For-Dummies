using System;

namespace fibonacci
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // C# Program To Generate Fibonacci Seriec
            int i, count, a = 0, b = 1, c = 0;
            int sum = 0;
            count = 10;
            for (i = 0; i <= count; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
                //sum = sum + c;
            }

            //Console.WriteLine(sum);
        }
    }
}