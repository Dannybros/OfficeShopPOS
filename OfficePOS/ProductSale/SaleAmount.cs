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
    public partial class SaleAmount : Form
    {
        private double price;
        private int total_quantity;
        private string id, name;
        Sale _sale;

        public SaleAmount(string id, string name, double price, int total_quantity, Sale sale)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.price = price;
            this.total_quantity = total_quantity;
            _sale = sale;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int amt = int.Parse(txtAmount.Text);

            if (txtAmount.Text == "")
            {
                MessageBox.Show("Please Insert Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (amt > total_quantity)
            {
                MessageBox.Show("You reached maxium amount of this product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _sale.addSaleItem(id, name, price, amt, total_quantity);

                this.Close();
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
