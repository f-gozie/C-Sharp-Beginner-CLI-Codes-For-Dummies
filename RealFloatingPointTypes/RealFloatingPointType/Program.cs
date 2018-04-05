using System;

namespace RealFloatingPointType
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Just testing them out
            float floatPI = 3.14f;
            Console.WriteLine(floatPI);
            double doublePI = 3.14;
            Console.WriteLine(doublePI);
            double nan = Double.NaN;
            Console.WriteLine(nan);
            double infinity = Double.PositiveInfinity;
            Console.WriteLine(infinity);
            
            // Comparing precision of float and double
            float floatPII = 3.141592653589793238f;
            double doublePII = 3.141592653589793238;
            Console.WriteLine("Float PI is: " + floatPII);
            Console.WriteLine("Double PI is: " + doublePII);
            
            // Testing decimal out
            decimal decimalPI = 3.141592653589793238m;
            Console.WriteLine("Decimal PI is: " + decimalPI);
        }
    }
}