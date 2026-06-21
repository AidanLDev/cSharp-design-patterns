using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Principles.SOLID.OpenClosed
{
    internal class SizeSpecification : ISpecification<Product>
    {
        private Size size;
        public SizeSpecification(Size size)
        {
            this.size = size;
        }
        public bool IsSatisified(Product product)
        {
            return product.Size == size;
        }
    }
}
