using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficePOS
{
    public partial class OrderBillViewer : Form
    {
        List<OrderItem> items = new List<OrderItem>();
        string Bill_ID, Supplier;


        public OrderBillViewer(List<OrderItem> orderItems, string Bill_ID, string Supplier)
        {
            InitializeComponent();
            items = orderItems;
            this.Bill_ID = Bill_ID;
            this.Supplier = Supplier;
        }

        private void OrderBillViewer_Load(object sender, EventArgs e)
        {
            OrderBillReport obr = new OrderBillReport();
            crystalReportViewer1.ReportSource = obr;
            obr.SetDataSource(items);
            obr.SetParameterValue("Supplier_Name", Supplier);
            obr.SetParameterValue("Order_ID", Bill_ID);
        }
    }
}
