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
            CustomerInfos cInfo = new CustomerInfos();
            switchForm(cInfo);
        }

        private void lbl_Employee_Click(object sender, EventArgs e)
        {
            EmployeeInfos eInfo = new EmployeeInfos();
            switchForm(eInfo);
        }

        private void lbl_supplier_Click(object sender, EventArgs e)
        {
            SupplierInfos sInfo = new SupplierInfos();
            switchForm(sInfo);
        }

        private void lbl_category_Click(object sender, EventArgs e)
        {
            CategoryInfo category = new CategoryInfo();
            switchForm(category);
        }
    }
}
