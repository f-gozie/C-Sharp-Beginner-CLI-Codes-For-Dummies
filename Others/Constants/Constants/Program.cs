﻿using System;

namespace Constants
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const double pi = 3.14159; //Constant declaration
            double r;
            Console.WriteLine("Enter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
            Console.ReadLine();
            
        }
    }
}