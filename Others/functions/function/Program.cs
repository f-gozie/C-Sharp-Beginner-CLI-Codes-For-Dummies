using System;

namespace function
{
    internal class Program
    {
        static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
        
        public static void Main(string[] args)
        {
            Console.Write("Enter your temperature: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double a;
            a = ConvertFahrenheitToCelsius(x);
            Console.WriteLine(a);
            if (a > 37)
            {
                Console.WriteLine("You're sick FAM!!!");
            }
            else
            {
                Console.WriteLine("It's all good!");
            }
        }
    }
}