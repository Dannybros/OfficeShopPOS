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
    public partial class SupplyItemInfo : Form
    {
        public SupplyItemInfo()
        {
            InitializeComponent();
            txt_id.Text = "dd0";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txtAmount.Text = null;
            txt_price.Text = null;
        }
    }
}
