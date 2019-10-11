/*
 * Author:  Semee Kang
 *  : Mohawk College
 *  Date:   October 10th, 2019
 *  
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
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();

            List<CustomerPoint> customerPoints = new List<CustomerPoint>();
            for (int i = 0; i < 100; i++)
            {
                double x = rand.NextDouble() * 1000;
                double y = rand.NextDouble() * 1000;
                customerPoints.Add(new CustomerPoint(x, y));
                this.chart.Series[0].Points.Add(new DataPoint(x, y));
            }
            List<SupplierPoint> supplierPoints = new List<SupplierPoint>();
            
            Series series = new Series();
            series.ChartType = SeriesChartType.Point;
            series.Points.Add(new DataPoint(100, 100));
            series.Points.Add(new DataPoint(300, 650));
            series.Points.Add(new DataPoint(780, 222));
            series.Points.Add(new DataPoint(680, 900));
            series.Points.Add(new DataPoint(150, 150));
            series.Points.Add(new DataPoint(200, 550));
            series.Points.Add(new DataPoint(870, 52));
            series.Points.Add(new DataPoint(68, 0));
            series.Color = Color.Red;

            supplierPoints.Add(new SupplierPoint(0, 100, 100));
            supplierPoints.Add(new SupplierPoint(1, 300, 650));
            supplierPoints.Add(new SupplierPoint(2, 780, 222));
            supplierPoints.Add(new SupplierPoint(3, 680, 900));
            supplierPoints.Add(new SupplierPoint(4, 150, 150));
            supplierPoints.Add(new SupplierPoint(5, 200, 550));
            supplierPoints.Add(new SupplierPoint(6, 870, 52));
            supplierPoints.Add(new SupplierPoint(7, 68, 00));

            this.chart.Series.Add(series);


            for (int i = 0; i < customerPoints.Count; i++)
            {
                for (int j = 0; j < supplierPoints.Count; j++)
                {
                    double x = customerPoints[i].X - supplierPoints[j].X;
                    double y = customerPoints[i].Y - supplierPoints[j].Y;

                    supplierPoints[j].length = Math.Sqrt(x * x + y * y);
                }

                supplierPoints.Sort();
                customerPoints[i].index = supplierPoints[0].index;
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

                SupplierPoint points = supplierPoints.Find(v => v.index == cp.index);

                listSeires[cp.index].Points.Add(new DataPoint(cp.X, cp.Y));
                listSeires[cp.index].Points.Add(new DataPoint(points.X, points.Y));
                
                
            }

            for (int i = 0; i < listSeires.Count; i++)
                this.chart.Series.Add(listSeires[i]);


            /*
            List<Color> listcolor = new List<Color>();

            for(int i = 0; i < supplierPoints.Count; i++)
            {
                Color color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

                if (!listcolor.Contains(color))
                    listcolor.Add(color);
                else
                    i--;
            }

            
            List<Series> listSeires = new List<Series>();
            for(int i = 0; i < customerPoints.Count; i++)
            {
                Series s = new Series();
                s.Points.Add(new DataPoint(customerPoints[i].X, customerPoints[i].Y));
                int index = customerPoints[i].index;

                SupplierPoint points = supplierPoints.Find(v => v.index == index);
                s.ChartType = SeriesChartType.Line;
                s.Points.Add(new DataPoint(points.X, points.Y));
                s.Color = listcolor[index];

                this.chart.Series.Add(s);
            }*/
        }
    }
}
