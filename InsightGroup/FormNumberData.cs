using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsightGroup
{
    public partial class FormNumberData : Form
    {
        public FormNumberData()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                int numberSupplierPoint = Convert.ToInt32(this.tbSupplierPoint.Text);
                int numberCustomerPoint = Convert.ToInt32(this.tbCustomerPoint.Text);

                Form1 formChart = new Form1(this.rbSupplierPointRandom.Checked, numberSupplierPoint, this.rbCustomerPointRandom.Checked, numberCustomerPoint);
                formChart.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                // use Console.WriteLine instead of log class
                Console.WriteLine("Level: Error, Message: " + ex.Message);
            }
            
        }

        private void tbSupplierPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void tbCustomerPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }
        
    }
}
