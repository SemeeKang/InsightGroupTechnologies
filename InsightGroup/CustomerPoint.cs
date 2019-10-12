/*
    Author: Semee Kang, Mohawk College
*/
namespace InsightGroup
{
    class CustomerPoint
    {
        public double X { get; set; }
        public double Y { get; set; }

        public int SupplierIdex { get; set; }

        public CustomerPoint(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
