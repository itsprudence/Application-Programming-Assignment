using System;

namespace ShapeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int attempts = 0;
            while (attempts < 3)
            {
                Console.WriteLine("Choose a shape to find the area:");
                Console.WriteLine("'t' for Triangle");
                Console.WriteLine("'r' for Rectangle");
                Console.WriteLine("'c' for Circle");
                Console.Write("Enter your choice: ");

                string answer = Console.ReadLine().ToLower();

                switch (answer)
                {
                    case "t":
                        AreaOfTriangle();
                        return;

                    case "r":
                        AreaOfRectangle();
                        return;

                    case "c":
                        AreaOfCircle();
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        attempts++;
                        break;
                }
            }

            Console.WriteLine("Too many invalid attempts. Exiting program.");
        }

        static void AreaOfTriangle()
        {
            Console.Write("Enter base of triangle: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter height of triangle: ");
            double h = double.Parse(Console.ReadLine());

            double A = (b * h) / 2;
            Console.WriteLine($"Area of Triangle is: {A}");
        }

        static void AreaOfRectangle()
        {
            Console.Write("Enter length of rectangle: ");
            double l = double.Parse(Console.ReadLine());

            Console.Write("Enter width of rectangle: ");
            double w = double.Parse(Console.ReadLine());

            double A = l * w;
            Console.WriteLine($"Area of Rectangle is: {A}");
        }

        static void AreaOfCircle()
        {
            Console.Write("Enter radius of circle: ");
            double r = double.Parse(Console.ReadLine());

            double A = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Area of Circle is: {A}");
        }
    }
}
