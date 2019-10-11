/*
 * Author:  Semee Kang
 *  : Mohawk College

 *  Purpose: 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace InsightGroup
{
    public partial class Form1 : Form
    {
        private bool bSupplierRandom = false;
        private bool bCustomerRandom = false;
        private int numberSupplierPoint = 0;
        private int numberCustomerPoint = 0;


        public Form1(bool bSupplierRandom, int numberSupplierPoint, bool bCustomerRandom, int numberCustomerPoint)
        {
            InitializeComponent();

            this.bSupplierRandom = bSupplierRandom;
            this.bCustomerRandom = bCustomerRandom;

            this.numberSupplierPoint = numberSupplierPoint;
            this.numberCustomerPoint = numberCustomerPoint;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();

            List<CustomerPoint> customerPoints = new List<CustomerPoint>();
            for (int i = 0; i < this.numberCustomerPoint; i++)
            {
                double x = rand.NextDouble() * 1000;
                double y = rand.NextDouble() * 1000;
                customerPoints.Add(new CustomerPoint(x, y));
                this.chart.Series[0].Points.Add(new DataPoint(x, y));
            }
            List<SupplierPoint> supplierPoints = new List<SupplierPoint>();
            
            Series series = new Series();
            series.ChartType = SeriesChartType.Point;
            series.Color = Color.Red;
            for(int i = 0; i < this.numberSupplierPoint; i++)
            {
                double x = rand.NextDouble() * 1000;
                double y = rand.NextDouble() * 1000;
                supplierPoints.Add(new SupplierPoint(i, x, y));

                series.Points.Add(new DataPoint(x, y));
            }
            this.chart.Series.Add(series);


            for (int i = 0; i < customerPoints.Count; i++)
            {
                for (int j = 0; j < supplierPoints.Count; j++)
                {
                    double x = customerPoints[i].X - supplierPoints[j].X;
                    double y = customerPoints[i].Y - supplierPoints[j].Y;

                    supplierPoints[j].Length = Math.Sqrt(x * x + y * y);
                }

                supplierPoints.Sort();
                customerPoints[i].Index = supplierPoints[0].Index;
            }

            List<Color> listcolor = new List<Color>();
            List<Series> listSeires = new List<Series>();

            DataPoint p = new DataPoint();
            
            for (int i = 0; i < supplierPoints.Count; i++)
            {
                Color color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

                if (!listcolor.Contains(color))
                {
                    listcolor.Add(color);
                    Series s = new Series();
                    s.Color = color;
                    s.ChartType = SeriesChartType.Line;

                    listSeires.Add(s);
                }
                else
                    i--;
            }

            
            for (int i = 0; i < customerPoints.Count; i++)
            {
                

                CustomerPoint cp = customerPoints[i];

                SupplierPoint points = supplierPoints.Find(v => v.Index == cp.Index);

                listSeires[cp.Index].Points.Add(new DataPoint(cp.X, cp.Y));
                listSeires[cp.Index].Points.Add(new DataPoint(points.X, points.Y));
                
                
            }

            for (int i = 0; i < listSeires.Count; i++)
                this.chart.Series.Add(listSeires[i]);
            
        }
    }
}
