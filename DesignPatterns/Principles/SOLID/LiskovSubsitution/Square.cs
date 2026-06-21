using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Principles.SOLID.LiskovSubsitution
{
    internal class Square : Shape
    {
        public int Side { get; set; }

        public Square(int side)
        {
            Side = side;
        }

        public override int Area() => Side * Side;

        public override string ToString()
        {
            return $"Square Side is: {this.Side}";
        }
    }
}
