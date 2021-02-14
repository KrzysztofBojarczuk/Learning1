using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    public class Square : Shape
    {
        public Square(int width)
        {
            Width = width;
        }

        public override double GetArea()
        {
            return Width * Width;
        }
    }
}
