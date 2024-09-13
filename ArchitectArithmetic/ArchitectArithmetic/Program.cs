using System;
using System.Globalization;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main()
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");

            CalculateTotalCost();
        }

        static void CalculateTotalCost()
        {
            double area = RectangleArea(1500, 2500) + CircleArea(375) / 2 + TriangleArea(500, 750);
            double cost = 180 * area;
            Console.WriteLine($"Cost of this architecture project is {cost:C}.");
        }

        static double RectangleArea(double length, double width)
        {
            return length * width;
        }

        static double CircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        static double TriangleArea(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }
    }
}
