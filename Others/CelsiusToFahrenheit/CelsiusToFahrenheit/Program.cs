using System;

namespace CelsiusToFahrenheit
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double temperatureInCelsius, temperatureInFahrenheit;
            
            Console.Write("Enter temperature in Celsius: ");
            temperatureInCelsius = Convert.ToInt32(Console.ReadLine());

            temperatureInFahrenheit = temperatureInCelsius * (9 / 5 + 32);
            Console.WriteLine(temperatureInFahrenheit);
        }
    }
}