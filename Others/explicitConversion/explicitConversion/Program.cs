using System;

namespace explicitConversion
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double d = 5678.74;
            int i;
            
            //cast double to int
            i = (int) d;
            Console.WriteLine(i);

            int x = 75;
            float f = 53.005f;
            double l = 2345.7652;
            bool b = true;
            
            //Now lets convert these dudes to strings
            Console.WriteLine(x.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(l.ToString());
            Console.WriteLine(b.ToString());
        }
    }
}