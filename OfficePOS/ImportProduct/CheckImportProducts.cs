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
    public partial class CheckImportProducts : Form
    {
        public CheckImportProducts()
        {
            InitializeComponent();
        }

        private void DGV_orderList_Click(object sender, EventArgs e)
        {
            CheckImports ci = new CheckImports();
            ci.Show();
        }
    }
}
