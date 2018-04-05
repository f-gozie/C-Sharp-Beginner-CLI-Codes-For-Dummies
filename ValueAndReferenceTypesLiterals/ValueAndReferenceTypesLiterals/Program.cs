using System;

namespace ValueAndReferenceTypesLiterals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Gingerly
            int i = 42;
            char ch = 'A';
            bool result = true;
            object obj = 32;
            string str = "Hello";
            byte[] bytes = {1, 2, 3};
            
            // Literals
            bool isAuthenticated = true;
            char capitalC = 'C';
            byte b = 100;
            short s = 20000;
            int x = 300000;
            
            // Float Literals
            float realNumber = 12.5f;
            realNumber = 12.5e+1f; // Exponential version of float version
            
            /* Escaping Characters */
            
            // Ordinary Character
            char character = 'a';
            Console.WriteLine(character);
            
            // Unicode character code in hexadecimal format
            character = '\u003A';
            Console.WriteLine(character);
            
            // Assigning an audio sound (escaped as \')
            character = '\a';
            Console.WriteLine(character);
            
            // Assigning the backslash character escaped as \\
            character = '\\';
            Console.WriteLine(character);
        }
    }
}