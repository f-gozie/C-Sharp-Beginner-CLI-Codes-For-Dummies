using System;

namespace OtherOperator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // The . Operator
            Console.WriteLine(DateTime.Now);
            
            // The Square Brackets [] Operator
            int[] arr = {1, 2, 3, 4, 5};
            Console.WriteLine(arr[0]);
            string str = "Hello";
            Console.WriteLine(str[1]);
            
            // The ?? Operator
            // It returns the left operand if not null else returns the right operand
            int? a = 5;
            Console.WriteLine(a ?? -1);
            string name = null;
            Console.WriteLine(name ?? "(no name)");
            
            // Other Operators
            string s = "Beer";
            Console.WriteLine(s is String);

            string notNullString = s;
            string nullString = null;
            Console.WriteLine(nullString ?? "Unspecified");
            Console.WriteLine(notNullString ?? "Specified");

        }
    }
}