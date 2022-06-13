using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace OfficePOS
{
    public partial class ProductReport : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=office_db");
        MySqlCommand cmd;

        public ProductReport()
        {
            InitializeComponent();
            LoadProducts();
            cmbType.SelectedIndex = 0;
        }

        public void LoadProducts()
        {
            string searchTerm = "";
            if (txtSearch.Text != "Search...") searchTerm = txtSearch.Text;

            if (cmbType.SelectedIndex == 0) cmd = new MySqlCommand("SELECT * FROM `products` WHERE CONCAT (`Product_ID`,`Product_Name`) LIKE '%" + searchTerm + "%' ORDER BY Expiration_Date", conn);
            else if(cmbType.SelectedIndex ==1) cmd = new MySqlCommand("SELECT * FROM `products` WHERE CONCAT (`Product_ID`,`Product_Name`) LIKE '%" + searchTerm + "%'  ORDER BY `Quantity`", conn);
            else cmd = new MySqlCommand("SELECT t1.* FROM products AS t1 NATURAL JOIN (SELECT Product_ID, sum(Amount) AS count from sale_details GROUP BY Product_ID ORDER BY count DESC) AS t2 ORDER BY t2.count DESC", conn);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);

            dataGridView1.DataSource = tb;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[10];
            picCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            txtSearch.ForeColor = Color.Black;
            LoadProducts();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search...")
            {
                txtSearch.Text = null;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}


