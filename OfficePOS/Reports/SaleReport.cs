using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace OfficePOS
{
    public partial class SaleReport : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=office_db");
        MySqlCommand cmd;

        public SaleReport()
        {
            InitializeComponent();
            cmbType.SelectedIndex = 0;
        }

        private void loadSaleItems()
        {
            string searchTerm = "";

            dgv_SaleItems.DataSource = null;

            if (txtSearch.Text != "Search...")
            {
                searchTerm = txtSearch.Text;
            }

            cmd = new MySqlCommand("SELECT * FROM  `order_imports` WHERE CONCAT (`Order_ID`,`Supplier_Name`, `Import_Date`, `Checked`) LIKE '%" + searchTerm + "%'", conn);
        }
    }
}
