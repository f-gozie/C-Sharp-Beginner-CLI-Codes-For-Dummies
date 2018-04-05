using System;

namespace revision
{
    internal class Program
    {
        /**
        static int MaxValue(int[] intArray)
        {
            int maxVal = intArray[0];
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > maxVal)
                {
                    maxVal = intArray[i];
                }
            }
            return maxVal;
        }
        
        public static void Main(string[] args)
        {
            int[] myarray = {1, 8, 3, 6, 2, 5, 9, 3, 0, 2};
            int maxVal = MaxValue(myarray);
            Console.WriteLine("The max value in My Array is {0}", maxVal);
            Console.ReadKey();
        }
        */
        static void PrintTotalAmountForBooks(decimal[] prices)
        {
            decimal TotalAmount = 0;
            foreach (decimal onebook in prices)
            {
                TotalAmount += onebook;
            }
            Console.WriteLine("The total amount for all books is: " + TotalAmount);
        }
    }
}