using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Principles.SOLID.OpenClosed
{
    internal interface ISpecification<T>
    {
        bool IsSatisified(T value);
    }
}
