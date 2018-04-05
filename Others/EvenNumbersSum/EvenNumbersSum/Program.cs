using System;

/*
namespace EvenNumbersSum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = 0;
            int sum = 0;
            do
            {
                n += 2;
                sum += n;
            } while (n <= 100);
            Console.WriteLine(sum);
        }
    }
}
*/

/*
namespace EvenNumbersSum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = 0;
            int sum = 0;
            while (n <= 100)
            {
                n += 2;
                sum += n;
            }
            Console.WriteLine(sum);
        }
    }
}
*/


namespace EvenNumbersSum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            for (int n=0; n <= 100; n+=2)
            {
                sum += n;
            }
            Console.WriteLine(sum);
        }
    }
}
