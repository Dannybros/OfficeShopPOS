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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();

            loadForm();

            foreach (Label lbl in panelTop.Controls.OfType<Label>())
            {
                lbl.Cursor = Cursors.Hand;
                lbl.Click += (s, e) =>
                {
                    foreach (Label label in panelTop.Controls.OfType<Label>())
                    {
                        label.ForeColor = Color.Gray;
                    };

                    lbl.ForeColor = Color.White;
                };
            }
        }

        private void loadForm()
        {
            lbl_report_sale.ForeColor = Color.White;
            SaleReport sr = new SaleReport();
            switchPanel(sr);
        }

        public void switchPanel(Form panel)
        {
            panelContent.Controls.Clear();
            panel.TopLevel = false;
            panel.Dock = DockStyle.Fill;
            panelContent.Controls.Add(panel);
            panel.Show();
        }

        private void lbl_report_sale_Click(object sender, EventArgs e)
        {
            SaleReport sr = new SaleReport();
            switchPanel(sr);
        }

        private void lbl_report_revenue_Click(object sender, EventArgs e)
        {
            RevenueReport rev = new RevenueReport();
            switchPanel(rev);
        }

        private void switchPanel2(UserControl panel)
        {
            panelContent.Controls.Clear();
            panel.Dock = DockStyle.Fill;
            panelContent.Controls.Add(panel);
            panel.Show();
        }

        private void lbl_report_customer_Click(object sender, EventArgs e)
        {
            PeopleReports peReport = new PeopleReports();
            switchPanel(peReport);
        }

        private void lbl_report_products_Click(object sender, EventArgs e)
        {
            ProductReport pr = new ProductReport();
            switchPanel(pr);
        }
    }
}
