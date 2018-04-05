using System;

namespace TypeConversion
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Implicit Type Conversion
            int myInt = 5;
            Console.WriteLine(myInt);

            long myLong = myInt;
            Console.WriteLine(myLong);
            
            Console.WriteLine(myLong + myInt);
            
            // Explicit Type Conversion
            double myDouble = 5.1d;
            Console.WriteLine(myDouble);

            long myNewLong = (long) myDouble;
            Console.WriteLine(myNewLong);

            myDouble = 5e9d;
            Console.WriteLine(myDouble);

            int myNewInt = (int) myDouble;
            Console.WriteLine(myNewInt);
            Console.WriteLine(int.MinValue);
            
            // Experimenting Data Loss during Type Conversion
            long myNewestLong = long.MaxValue;
            int myNewestInt = (int) myNewestLong;
            
            Console.WriteLine(myNewestLong);
            Console.WriteLine(myNewestInt);
            
            // Type Conversion Examples
            float heightInMeters = 1.74f; // Explicit
            double maxHeight = heightInMeters; // Implicit
            double minHeight = (double) heightInMeters; // Explicit
            float actualHeight = (float) maxHeight;

            // float maxHeightFloat = maxHeight; --> Compilation Error
            
            // Forcing Overflow Exceptions during Casting
            double d = 5e9d;
            Console.WriteLine(d);
            int i = checked((int) d); // System.OverflowException
            Console.WriteLine(i);

            int a = 5;
            int b = ++a;
            
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}