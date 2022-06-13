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
    public partial class OrganiseForm : Form
    {
        public OrganiseForm()
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
            lbl_product.ForeColor = Color.White;
            Inventory Inv = new Inventory();
            switchForm(Inv);
        }

        private void switchPanel(UserControl panel)
        {
            panelContent.Controls.Clear();
            //panel.TopLevel = false;
            panel.Dock = DockStyle.Fill;
            panelContent.Controls.Add(panel);
            panel.Show();
        }

        private void switchForm(Form panel)
        {
            panelContent.Controls.Clear();
            panel.TopLevel = false;
            panel.Dock = DockStyle.Fill;
            panelContent.Controls.Add(panel);
            panel.Show();
        }

        private void lbl_product_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            switchForm(inv);
        }

        private void lbl_customer_Click(object sender, EventArgs e)
        {
            CustomerInfo sinfo = new CustomerInfo();
            switchPanel(sinfo);
        }

        private void lbl_Employee_Click(object sender, EventArgs e)
        {
            Employee sEmp = new Employee();
            switchPanel(sEmp);
        }

        private void lbl_supplier_Click(object sender, EventArgs e)
        {
            SupplierInfo sSupp = new SupplierInfo();
            switchPanel(sSupp);
        }
    }
}
