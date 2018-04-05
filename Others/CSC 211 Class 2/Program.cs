using System;

namespace CSC_211_Class_2
{
    class boolean_logic
    {
        static void Main()
        {
            int value = 16;
            string name = "Agozie Favour";

            bool isLessthan10;

            isLessthan10 = value < 10;
            Console.WriteLine("isLessthan is {0}", isLessthan10); Console.WriteLine();
            bool isMyname, isTrue;

            isMyname = name == "AgozieFavour";
            isTrue = isMyname == true;
            Console.WriteLine("isMyname is {0} therefore isTrue is {1}", isMyname, isTrue);
            Console.WriteLine();
        }
    }
}