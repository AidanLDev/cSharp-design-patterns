using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Principles.SOLID.LiskovSubsitution
{
    internal class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override int Area() => Width * Height;

        public override string ToString()
        {
            return $"Rectangle Width x Height is: {this.Width} x {this.Height}";
        }
    }
}
