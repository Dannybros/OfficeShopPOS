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
    public partial class ProductReport : UserControl
    {
        public ProductReport()
        {
            InitializeComponent();
            cmbType.SelectedIndex = 0;
        }
    }
}
