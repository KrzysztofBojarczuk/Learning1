using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    public class Shape
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public virtual double GetArea()
        {
            return Width * Height;
        }
    }
}
