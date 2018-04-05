using System;

namespace multidimensionalarrays
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double[,] matrix = {{1, 5, 9}, {2, 6, 10}, {3, 7, 11}, {4, 8, 12}};
            foreach (int a in matrix)
            {
                Console.Write(" ");
                Console.Write(a);
                if (a == 9)
                {
                    Console.Write(" ");
                    Console.WriteLine();
                    continue;   
                }
                else if (a == 10)
                {
                    Console.Write(" ");
                    Console.WriteLine();
                    continue;   
                }
                else if (a == 11)
                {
                    Console.Write(" ");
                    Console.WriteLine();
                    continue;   
                }
                else if (a == 12)
                {
                    Console.Write(" ");
                    Console.WriteLine();
                    continue;   
                }
            }
            /*int i;
            for (i = 0; i < matrix.Length; i++)
            {
                Console.Write(matrix);
            }*/
        }
    }
}