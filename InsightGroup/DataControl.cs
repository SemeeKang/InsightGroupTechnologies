/*
 * Author:  Semee Kang, Mohawk College
*/
using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace InsightGroup
{
    class DataControl
    {
        // Data List
        private List<SupplierPoint> supplierPoints;
        private List<CustomerPoint> customerPoints;

        public DataControl()
        {
            this.supplierPoints = new List<SupplierPoint>();
            this.customerPoints = new List<CustomerPoint>();
        }

        // Create Data Point for Supplier
        public void SetRandomSupplier(int number)
        {
            Random rand = new Random();
            for (int i = 0; i < number; i++)
            {
                double x = rand.NextDouble() * 1000;
                double y = rand.NextDouble() * 1000;
                supplierPoints.Add(new SupplierPoint(i, x, y));
            }
        }

        // Create Data Point for Customer
        public void SetRandomCustomer(int number)
        {
            Random rand = new Random();

            for (int i = 0; i < number; i++)
            {
                double x = rand.NextDouble() * 1000;
                double y = rand.NextDouble() * 1000;

                customerPoints.Add(new CustomerPoint(x, y));
            }
        }

        // Find Closest Point
        public void FindClosestPoint()
        {
            for (int i = 0; i < customerPoints.Count; i++)
            {
                for (int j = 0; j < supplierPoints.Count; j++)
                {
                    double x = customerPoints[i].X - supplierPoints[j].X;
                    double y = customerPoints[i].Y - supplierPoints[j].Y;

                    // Calculate length between two point
                    supplierPoints[j].Length = Math.Sqrt(x * x + y * y);
                }

                supplierPoints.Sort();
                customerPoints[i].SupplierIdex = supplierPoints[0].Index;
            }
        }

        // Return Data Point List
        public List<Series> GetSeries()
        {
            List<Series> list = new List<Series>();

            // point data
            list.Add(GetCustomerPoint());
            list.Add(GetSupplierPoint());

            // line data
            list.AddRange(GetLines());

            return list;
        }

        // Make list to draw line point
        public List<Series> GetLines()
        {
            List<Series> list = new List<Series>();
            List<Color> listColor = new List<Color>();

            Random rand = new Random();

            for (int i = 0; i < supplierPoints.Count; i++)
            {
                // Create Color list
                Color color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

                if (!listColor.Contains(color))
                {
                    listColor.Add(color);
                    Series s = new Series();
                    s.Color = color;
                    s.ChartType = SeriesChartType.Line;

                    list.Add(s);
                }
                else
                    i--;
            }

            foreach(CustomerPoint point in this.customerPoints)
            {
                // find supplier point which has same index of customer point
                SupplierPoint points = supplierPoints.Find(v => v.Index == point.SupplierIdex);

                list[point.SupplierIdex].Points.Add(new DataPoint(point.X, point.Y));
                list[point.SupplierIdex].Points.Add(new DataPoint(points.X, points.Y));
            }

            return list;
        }

        // Make point list for customer
        public Series GetCustomerPoint()
        {
            Series series = new Series();
            series.ChartType = SeriesChartType.Point;
            series.Color = Color.Red;

            foreach (CustomerPoint point in this.customerPoints)
                series.Points.Add(new DataPoint(point.X, point.Y));

            return series;
        }

        // Make point list Customer
        public Series GetSupplierPoint()
        {
            Series series = new Series();
            series.ChartType = SeriesChartType.Point;
            series.Color = Color.Blue;

            foreach (SupplierPoint point in this.supplierPoints)
                series.Points.Add(new DataPoint(point.X, point.Y));

            return series;
        }
    }
}
