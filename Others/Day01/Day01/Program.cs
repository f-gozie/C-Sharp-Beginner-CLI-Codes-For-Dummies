using System;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Current date: ");
            Console.WriteLine(DateTime.Now);

            byte centuries = 20;
            ushort years = 2000;
            uint days = 730480;
            ulong hours = 17531520;
            
            // Print the result on the console
            Console.WriteLine(centuries + " centuries are " + years + " years, or " + days + 
                              " days, or " + hours + " hours.");
            ulong maxIntValue = UInt64.MaxValue;
            Console.WriteLine(maxIntValue);
        }
    }
}