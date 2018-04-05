using System;

namespace StringConcatenationOperator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string cSharp = "C#";
            string dotNet = ".NET";
            string cSharpdotNet = cSharp + dotNet;
            Console.WriteLine(cSharpdotNet);
            string withFive = cSharpdotNet + " " + 5;
            Console.WriteLine(withFive);
        }
    }
}