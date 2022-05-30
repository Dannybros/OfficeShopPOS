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
    public partial class Reports : UserControl
    { 
        public Reports()
        {
            InitializeComponent();

            loadForm();
            
            foreach(Label lbl in panelTop.Controls.OfType<Label>())
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

        private void switchPanel(UserControl panel)
        {
            panelContent.Controls.Clear();
            //panel.TopLevel = false;
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
            Revenue rev = new Revenue();
            switchPanel(rev);
        }

        private void lbl_report_people_Click(object sender, EventArgs e)
        {
            PeopleReport peReport = new PeopleReport();
            switchPanel(peReport);
        }

        private void lbl_report_products_Click(object sender, EventArgs e)
        {
            ProductReport pr = new ProductReport();
            switchPanel(pr);
        }
    }
}
