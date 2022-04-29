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

            Dashboard dashboard = new Dashboard();
            switchPanel(dashboard);
        }

        private void switchPanel(UserControl panel)
        {
            panelContent.Controls.Clear();
            //panel.TopLevel = false;
            panel.Dock = DockStyle.Fill;
            panelContent.Controls.Add(panel);
            panel.Show();
        }

        private void lblProducts_Click(object sender, EventArgs e)
        {
            Products pd = new Products();
            switchPanel(pd);
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            switchPanel(dashboard);
        }

        private void lblSale_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales();
            switchPanel(sale);
        }

        private void lblImportProduct_Click(object sender, EventArgs e)
        {
            SupplyForm sf = new SupplyForm();
            switchPanel(sf);
        }
    }
}
