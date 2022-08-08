using CrystalDecisions.Shared;
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
        string Bill_ID, Customer, Paid, Change, Employee;
        public SaleBillViewer(List<SaleItem> saleItems, string Bill_ID, string Customer, string Employee, string change, string paid)
        {
            InitializeComponent();
            items = saleItems;
            this.Bill_ID = Bill_ID;
            this.Customer = Customer;
            this.Employee = Employee;
            this.Paid = paid;
            this.Change = change;
        }

        private void SaleBillViewer_Load(object sender, EventArgs e)
        {
            SaleBillReport crp1 = new SaleBillReport();

            crystalReportViewer1.ReportSource = crp1;
            crp1.SetDataSource(items);
            crp1.SetParameterValue("CustomerName", Customer);
            crp1.SetParameterValue("EmployeeName", Employee);
            crp1.SetParameterValue("Bill_ID", Bill_ID);
            crp1.SetParameterValue("Change", Change + " KIP");
            crp1.SetParameterValue("Paid", int.Parse(Paid).ToString("#,##0") + " KIP");

        }
    }
}
