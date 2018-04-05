using System;

namespace arrayandfunctions
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /**string[] friendNames = {"Robert Haskwel", "Tobirama Senju", "Amadioha Togbamiaye"};
            int i;
            Console.WriteLine("Here are {0} of my friends", friendNames.Length);
            for (i = 0; i < friendNames.Length; i++)
            {
                Console.Write(friendNames[i] + ", ");
            }
            Console.WriteLine();
            **/
            int[] myIntarray = {5, 6, 7, 4, 3, 2, 6};
            int max = 0;
            foreach (int x in myIntarray)
            {
                if (x > max)
                {
                    max = x;
                }
            }
            Console.WriteLine(max);
        }
    }
}