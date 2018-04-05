using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            int max = 0;
            Console.WriteLine("enter a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter c");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > max)
            {
                max = a;
                if (b > max)
                {
                    max = b;
                    if (c > max)
                    {
                        max = c;
                    }
                }
            }
            Console.WriteLine("this is the max: {0}",max);
        }
    }
}