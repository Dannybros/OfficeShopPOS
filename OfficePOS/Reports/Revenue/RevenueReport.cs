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
    public partial class RevenueReport : Form
    {
        public RevenueReport()
        {
            InitializeComponent();

            GraphicRevenueReport rr = new GraphicRevenueReport();
            switchPanel(rr);
            foreach (Label lbl in panel1.Controls.OfType<Label>())
            {
                lbl.Cursor = Cursors.Hand;
                lbl.Click += (s, e) =>
                {
                    foreach (Label label in panel1.Controls.OfType<Label>())
                    {
                        label.ForeColor = Color.Gray;
                    };

                    lbl.ForeColor = Color.White;
                };
            }
        }

        public void switchPanel(Form panel)
        {
            panelContent.Controls.Clear();
            panel.TopLevel = false;
            panel.Dock = DockStyle.Fill;
            panelContent.Controls.Add(panel);
            panel.Show();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            GraphicRevenueReport rr = new GraphicRevenueReport();
            switchPanel(rr);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MonthlyRevenueReport mrr = new MonthlyRevenueReport();
            switchPanel(mrr);
        }
    }
}
