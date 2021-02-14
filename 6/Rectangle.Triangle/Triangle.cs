using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    public class Triangle : Shape
    {
        public Triangle(int height, int triangleBase)
        {
            Height = height;
            TriangleBase = triangleBase;
        
        }
        public int TriangleBase { get; set; }

        public override double GetArea()
        {
            return 0.5 * (TriangleBase * Height);
        }

    }
}
