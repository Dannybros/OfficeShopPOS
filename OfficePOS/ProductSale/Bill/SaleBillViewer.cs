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
    public partial class SaleBillViewer : Form
    {
        List<SaleItem> items = new List<SaleItem>();
        public SaleBillViewer(List<SaleItem> saleItems)
        {
            InitializeComponent();
            items = saleItems;
           
        }

        private void SaleBillViewer_Load(object sender, EventArgs e)
        {
            SaleBillReport crp1 = new SaleBillReport();
            crystalReportViewer1.ReportSource = crp1;
            crp1.SetDataSource(items);
        }
    }
}
