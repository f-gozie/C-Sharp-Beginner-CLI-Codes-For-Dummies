using System;

namespace RectangleApplication
{
    internal class Rectangle
    {
        //member variables
        double length;
        double width;

        public void acceptDetails(){ length = 4.5;width = 3.5;}

        public double getArea(){ return length * width; }

        public void display(){
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", getArea());
        }
    }

    class executeRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.acceptDetails();
            r.display();
            Console.ReadLine();
        }
    }
}