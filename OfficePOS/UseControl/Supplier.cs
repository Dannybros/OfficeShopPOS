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
    public partial class SupplyForm : UserControl
    { 
        public SupplyForm()
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
            label1.ForeColor = Color.White;
            SupplierInfo sinfo = new SupplierInfo();
            switchPanel(sinfo);
        }

        private void switchPanel(UserControl panel)
        {
            panelContent.Controls.Clear();
            //panel.TopLevel = false;
            panel.Dock = DockStyle.Fill;
            panelContent.Controls.Add(panel);
            panel.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SupplierInfo sinfo = new SupplierInfo();
            switchPanel(sinfo);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SupplyProducts sprod = new SupplyProducts();
            switchPanel(sprod);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SupplyReport sreport = new SupplyReport();
            switchPanel(sreport);
        }
    }
}
