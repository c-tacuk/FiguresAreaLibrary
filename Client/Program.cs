using System;
using FiguresArea;

namespace Client
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter three sides:");
            double first = Convert.ToDouble(Console.ReadLine());
            double second = Convert.ToDouble(Console.ReadLine());
            double third = Convert.ToDouble(Console.ReadLine());

            var triangle = new Triangle(first, second, third);
            triangle.DisplayArea();

            Console.WriteLine("\nEnter radius:");
            double r = Convert.ToDouble(Console.ReadLine());
            var circumference = new Circle(r);
            circumference.DisplayArea();
        }
    }
}