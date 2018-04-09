using System;

namespace IzzyJacks
{
    internal class Program
    {

        static int evenSum()
        {
            int sum = 0;
            int x = 0;
            while (x <= 100)
            {
                sum = sum + x;
                x += 2;
            }

            return sum;
        }
        
        static int oddSum()
        {
            int sum = 0;
            int x = 1;
            while (x < 101)
            {
                sum = sum + x;
                x += 2;
            }

            return sum;
        }
        
        public static void Main(string[] args)
        {
            int totalSum, even, odd;
            even = evenSum();
            odd = oddSum();
            totalSum = even + odd;
            
            Console.WriteLine(even);
            Console.WriteLine(odd);
            Console.WriteLine("Total sum of odd and even numbers between 1 and 100 is: {0}", totalSum);
        }
    }
}