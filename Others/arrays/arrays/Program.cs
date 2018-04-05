using System;

namespace arrays
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] friendNames = {"Robert Haskwell", "Elon Musk", "Hewlett Packard"};
            int i;
            Console.WriteLine("Here are {0} of my friends: ", friendNames.Length);
            for (i = 0; i < friendNames.Length; i++)
            {
                Console.WriteLine(friendNames[i]);
            }
            Console.WriteLine();

            foreach (string friend in friendNames)
            {
                Console.WriteLine(friend);
            }
        }
    }
}