using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Principles.SOLID.OpenClosed
{
    internal class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> first, second;
        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first;
            this.second = second;
        }
        public bool IsSatisified(T value)
        {
            return first.IsSatisified(value) && second.IsSatisified(value);
        }
    }
}
