using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Principles.SOLID.OpenClosed
{
    public enum Colour
    {
        Red, Blue, Green
    }
    public enum Size
    {
        Small,
        Medium,
        Large
    }
    internal class Product
    {
        public string Name;
        public Colour Colour;
        public Size Size;

        public Product(string name, Colour colour, Size size)
        {
            Name = name;
            Colour = colour;
            Size = size;
        }
    }
}
