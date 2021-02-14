using System;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape();
            s1.Height = 5;
            s1.Width = 10;
            Console.WriteLine($"The shape area is: {s1.GetArea()}");
            Rectangle r1 = new Rectangle(6, 12);
            Console.WriteLine($"The rectangle area is: {r1.GetArea()}");
            Square sq1 = new Square(7);
            Console.WriteLine($"The square area is: {sq1.GetArea()}");
            Triangle t1 = new Triangle(10, 7);
            Console.WriteLine($"The triangle area is: {t1.GetArea()}");
            Circle c1 = new Circle(8);
            Console.WriteLine($"The circle area list: {c1.GetArea()}");


            Console.ReadLine();

        }
    }
}
