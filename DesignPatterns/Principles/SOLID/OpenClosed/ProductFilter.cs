using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Principles.SOLID.OpenClosed
{
    internal class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (Product product in products)
            {
                if (size == product.Size)
                {
                    yield return product;
                }
            }
        }

        public IEnumerable<Product> FilterByColour(IEnumerable<Product> products, Colour colour)
        {
            foreach (Product product in products)
            {
                if (colour == product.Colour)
                {
                    yield return product;
                }
            }
        }

        public IEnumerable<Product> FilterBySizeAndColour(IEnumerable<Product> products, Colour colour, Size size)
        {
            foreach (Product product in products)
            {
                if (product.Size == size && product.Colour == colour)
                {
                    yield return product;
                }
            }
        }
    }
}
