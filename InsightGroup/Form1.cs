/*
 * Author:  Semee Kang, Mohawk College
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace InsightGroup
{
    public partial class Form1 : Form
    {
        DataControl control = new DataControl();
        public Form1()
        {
            InitializeComponent();

            FormNumberData numberForm = new FormNumberData();
            numberForm.SetDataEvent += new FormNumberData.SetDataEventHandler(SetNumberData);
            numberForm.ShowDialog();
        }

        public void SetNumberData(int numberSupplierPoint, int numberCustomerPoint)
        {
            //random supplier point
            control.SetRandomSupplier(numberSupplierPoint);
            //random customer point
            control.SetRandomCustomer(numberCustomerPoint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Find lines
            control.FindClosestPoint();

            // Draw Graph
            this.chart.Series.Clear();
            List<Series> listSeries = control.GetSeries();

            foreach (Series s in listSeries)
                this.chart.Series.Add(s);
        }
    }
}
