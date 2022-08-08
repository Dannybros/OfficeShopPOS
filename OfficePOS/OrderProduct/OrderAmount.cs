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
    public partial class OrderAmount : Form
    {
        private string id, name;
        private double price;
        SupplyProduct _sp;

        public OrderAmount(string id, string name, double price, SupplyProduct sp)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.price = price;
            this._sp = sp;
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            int amt = int.Parse(txtAmount.Text);

            if (txtAmount.Text == "")
            {
                MessageBox.Show("Please Insert Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _sp.addOrderListItem(id, name, price, amt);
                this.Close();
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
