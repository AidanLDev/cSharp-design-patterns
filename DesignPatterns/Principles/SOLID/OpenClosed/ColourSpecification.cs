using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Principles.SOLID.OpenClosed
{
    internal class ColourSpecification : ISpecification<Product>
    {
        private Colour colour;

        public ColourSpecification(Colour colour)
        {
            this.colour = colour;
        }

        public bool IsSatisfied(Product product)
        {
            return product.Colour == this.colour;
        }

        bool ISpecification<Product>.IsSatisified(Product product)
        {
            return IsSatisfied(product);
        }
    }
}
