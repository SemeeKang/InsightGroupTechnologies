using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsightGroup
{
    class CustomerPoint
    {
        public double X { get; set; }
        public double Y { get; set; }

        public int Index = 0;

        public CustomerPoint(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
