using System;

namespace AssignmentOperators
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Simple Assignment
            int x = 6;
            string helloString = "Hello World";
            int y = x;
            
            // Cascade Assignment
            int a, b, c;
            a = b = c = 25;
            
            // Compound Assignment
            int m = 6;
            int n = 4;
            
            Console.WriteLine(n *= 2);
            int o = n = 3;
            
            Console.WriteLine(o);
            Console.WriteLine(m |= 1);
            Console.WriteLine(m += 3);
            Console.WriteLine(n /= 2);
        }
    }
}