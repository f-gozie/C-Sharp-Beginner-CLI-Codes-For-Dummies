using System;

namespace ObjectTypeAndVariables
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Object Types
            object placeholder1 = 5;
            object placeholder2 = "Five";
            Console.WriteLine("The value for placeholder 1 is: " + placeholder1);
            Console.WriteLine("The value for placeholder 2 is: " + placeholder2);
            
            Console.WriteLine();
            
            // Nullable Types
            int i = 5;
            int? ni = i;
            Console.WriteLine(ni);
            
            Console.WriteLine(ni.HasValue);
            i = ni.Value;
            Console.WriteLine(i);

            ni = null;
            Console.WriteLine(ni.HasValue);

            i = ni.GetValueOrDefault();
            Console.WriteLine(i);
            
            // Variables
            bool indexDigit = true; // Good variable naming convention
            bool indexdigit = false; // Bad variable naming convention

            byte centuries = 20;
            ushort years = 2000;
            decimal decimalPI = 3.141592653589793238m;
            bool isEmpty = true;
            char ch = 'a';
            string firstName = "Bleh";

            ch = (char) 5;
            char secondChar;

            secondChar = ch;
        }
    }
}