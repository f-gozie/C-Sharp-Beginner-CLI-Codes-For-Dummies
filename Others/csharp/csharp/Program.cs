using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
*/
namespace csharp
{
    class Console_structure
    {
        static void Main()
        {
            int myinteger;
            double length = 1.8, width = 2.8;
            decimal perimeter = 9.7m; //m suffix ensures the 9.7 literal is treated as a decimal number
            string mystring;
            myinteger = 17;
            mystring = "\"myinteger\"is: ";
            Console.WriteLine(mystring + myinteger); Console.WriteLine();
            Console.WriteLine("{0} {1} {2}", mystring, myinteger, length); Console.WriteLine();
            Console.WriteLine("Perimeter = " + perimeter);
            Console.WriteLine();
            Console.WriteLine("Area = " + length * width);
        }
    }
}