using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    public class Circle : Shape
    {
        public const double PI = 3.14;
        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius { get; set; }

        public override double GetArea()
        {
            return PI * (Radius * Radius);
        }
    }
}
