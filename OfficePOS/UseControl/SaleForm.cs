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
    public partial class SaleForm : UserControl
    {
        public SaleForm()
        {
            InitializeComponent();
            foreach (Label lbl in panelMenu.Controls.OfType<Label>())
            {
                lbl.Cursor = Cursors.Hand;
                lbl.Click += (s, e) =>
                {
                    foreach (Label label in panelMenu.Controls.OfType<Label>())
                    {
                        label.ForeColor = Color.Gray;
                    };

                    lbl.ForeColor = Color.White;
                };
            }
        }

        private void switchPanel(UserControl panel)
        {
            panelContent.Controls.Clear();
            //panel.TopLevel = false;
            panel.Dock = DockStyle.Fill;
            panelContent.Controls.Add(panel);
            panel.Show();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            lblSale.ForeColor = Color.White;
            Sales sales = new Sales();
            switchPanel(sales);
        }

        private void lblSale_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            switchPanel(sales);
        }

        private void lblSaleReport_Click(object sender, EventArgs e)
        {
            SaleReport sp = new SaleReport();
            switchPanel(sp);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CustomerInfo cinfo = new CustomerInfo();
            switchPanel(cinfo);
        }
    }
}
