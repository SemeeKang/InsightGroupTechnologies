/* 
    Author :    Semee Kang, Mohawk College
 */

using System;
using System.Windows.Forms;

namespace InsightGroup
{
    public partial class FormNumberData : Form
    {
        public delegate void SetDataEventHandler(int supplierPoint, int customerPoint);
        public event SetDataEventHandler SetDataEvent;

        public FormNumberData()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Get Number of Supplier and Customer Point
            try
            {
                int numberSupplierPoint = Convert.ToInt32(this.tbSupplierPoint.Text);
                int numberCustomerPoint = Convert.ToInt32(this.tbCustomerPoint.Text);

                this.SetDataEvent(numberSupplierPoint, numberCustomerPoint);
                this.Close();
            }
            catch (Exception ex)
            {
                // use Console.WriteLine instead of log class
                Console.WriteLine("Level: Error, Message: " + ex.Message);
            }
            
        }

        // Check the entered text which is number
        private void tbSupplierPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        // Check the entered text which is number
        private void tbCustomerPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }
    }
}
