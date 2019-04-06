using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleReportApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var order = OrderBusiness.GetOrder();
            this.OrderBindingSource.DataSource = order;
            this.OrderDetailBindingSource.DataSource = order.OrderDetails;
            this.reportViewer1.RefreshReport();
        }
    }
}