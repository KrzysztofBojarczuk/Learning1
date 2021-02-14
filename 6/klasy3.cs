using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    public class Shape
    {
        public int Witdh { get; set; }

        public int Height { get; set; }

        public double GetArea()
        {
            return Witdh * Height;
        }
    }
}
