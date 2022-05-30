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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            startForm();

            foreach (Label lbl in panelMenu.Controls.OfType<Label>())
            {
                lbl.Width = panelMenu.Width;

                lbl.Click += (s, e) =>
                {
                    foreach (Label label in panelMenu.Controls.OfType<Label>())
                    {
                        label.ForeColor = Color.Gray;
                    };

                    lbl.ForeColor = Color.White;
                    activePanel.Height = lbl.Height;
                    activePanel.Top = lbl.Top;
                };
            }
        }

        private void startForm()
        { 
            lblHome.ForeColor = Color.White;
            activePanel.Height = lblHome.Height;
            activePanel.Top = lblHome.Top;

            OrganiseInfo organise = new OrganiseInfo();
            switchPanel(organise);
        }

        private void switchPanel(UserControl panel)
        {
            panelContent.Controls.Clear();
            //panel.TopLevel = false;
            panel.Dock = DockStyle.Fill;
            panelContent.Controls.Add(panel);
            panel.Show();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            OrganiseInfo organise = new OrganiseInfo();
            switchPanel(organise);
        }

        private void lblSale_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales();
            switchPanel(sale);
        }

        private void lbl_order_product_Click(object sender, EventArgs e)
        {
            SupplyProducts sp = new SupplyProducts();
            switchPanel(sp);
        }

        private void lbl_report_Click(object sender, EventArgs e)
        {
            Reports report = new Reports();
            switchPanel(report);
        }

        private void lbl_import_Click(object sender, EventArgs e)
        {
            CheckImportProduct cip = new CheckImportProduct();
            switchPanel(cip);
        }
    }
}
