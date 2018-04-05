using System;

namespace LogicalOperators
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            Console.WriteLine(a && b);
            Console.WriteLine(a || b);
            Console.WriteLine(!b);
            Console.WriteLine(b || true);
            Console.WriteLine((5 > 7) ^(a == b));
        }
    }
}