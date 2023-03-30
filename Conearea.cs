using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class Conearea
    {
        public double CalculateArea(double radius, double height)
        {
            double area = 0;
            area = Math.PI * radius * (radius + Math.Sqrt((height * height) + radius * radius));
            return area;
        }
        public static void Main()
        {
            double area = 0;
            double radius = 0;
            double height = 0;
            Conearea c = new Conearea();
            Console.WriteLine(" enter the radius of the cone:");
            radius = double.Parse(Console.ReadLine());
            Console.WriteLine(" enter the radius of the cone:");
            height = double.Parse(Console.ReadLine());

            area = c.CalculateArea(radius, height);
            Console.WriteLine("area of cone is :+area");

        }


    }
}
