/*
    Author: Semee Kang, Mohawk College
 */

using System;


namespace InsightGroup
{
    class SupplierPoint : IComparable
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Length { get; set; }
        public int Index { get; set; }

        public SupplierPoint(int index,  double x, double y)
        {
            this.X = x;
            this.Y = y;
            this.Index = index;
        }

        public int CompareTo(object obj)
        {
            SupplierPoint value = obj as SupplierPoint;
            if (value == null)
                throw new Exception("This is not SupplierPoint object");

            return Length.CompareTo(value.Length);
        }
    }
}
