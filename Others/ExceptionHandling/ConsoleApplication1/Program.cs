using System;
using System.IO;

namespace ConsoleApplication1
{
    internal class Program
    {
        static void ReadFile(string fileName)
        {
            // Exceptions could be thrown in the code below
            try
            {
                TextReader reader = new StreamReader(fileName);
                string line = reader.ReadLine();
                Console.WriteLine(line);
                reader.Close();
            }
            catch (FileNotFoundException fnfe)
            {
                // Exception handler for FileNotFoundException
                // Let's just inform the user that there is no such file
                Console.WriteLine("The file {0} is not found", fileName);
            }
            catch (IOException ioe)
            {
                // Exception handler for other input/output exceptions
            }
        }
        
        public static void Main(string[] args)
        {
            string filename = "gobbyblob.txt";
            ReadFile(filename);
        }
    }
}