using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightGroup
{
    class SupplierPoint : IComparable
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double length;
        public int index;

        public SupplierPoint(int index,  double x, double y)
        {
            this.X = x;
            this.Y = y;
            this.index = index;
        }

        public int CompareTo(object obj)
        {
            SupplierPoint value = obj as SupplierPoint;
            if (value == null)
                throw new Exception("This is not SupplierPoint object");

            return length.CompareTo(value.length);
        }
    }
}
