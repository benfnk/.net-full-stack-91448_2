using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClassMethod
{
    public class Point : IEquatable<Point> ,IComparable<Point>
    {
        public int CompareTo(Point other)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public bool Equals(Point other)
        {
            throw new NotImplementedException();
        }
    }
}
