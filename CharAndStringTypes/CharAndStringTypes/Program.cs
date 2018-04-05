using System;

namespace CharAndStringTypes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Testing out Char Type
            char ch = 'a';
            Console.WriteLine("The code of " + ch + " is: " + (int)ch);
            ch = 'b';
            Console.WriteLine("The code of " + ch + " is: " + (int)ch);
            ch = 'A';
            Console.WriteLine("The code of " + ch + " is: " + (int)ch);
            
            // Testing out String Type
            string firstName = "John";
            string lastName = "Buskow";
            string fullName = firstName + " " + lastName;
            
            Console.WriteLine("Hello, " + firstName + "!");
            Console.WriteLine("Your full name is " + fullName + ".");
        }
    }
}