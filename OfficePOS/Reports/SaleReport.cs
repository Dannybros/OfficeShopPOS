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
        }

        private void loadSaleItems()
        {
            string searchTerm = "";

            dgv_SaleItems.DataSource = null;

            if (txtSearch.Text != "Search...")
            {
                searchTerm = txtSearch.Text;
            }

            cmd = new MySqlCommand("SELECT * FROM `sale` WHERE CONCAT (`Sale_ID`,`Customer_Name`, `Date`) LIKE '%" + searchTerm + "%'", conn);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);

            dgv_SaleItems.DataSource = tb;
            dgv_SaleItems.ReadOnly = true;
            dgv_SaleItems.RowTemplate.Height = 40;
            dgv_SaleItems.AllowUserToAddRows = false;
            dgv_SaleItems.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dgv_SaleItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn item in dgv_SaleItems.Columns)
            {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            txtSearch.ForeColor = Color.Black;
            loadSaleItems();
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

        private void dgv_SaleItems_Click(object sender, EventArgs e)
        {
            if(dgv_SaleItems.RowCount > 0)
            {
                string id = dgv_SaleItems.CurrentRow.Cells[0].Value.ToString();
                string total = dgv_SaleItems.CurrentRow.Cells[2].Value.ToString();
                SaleDetailReport sdr = new SaleDetailReport(id, total);
                sdr.Show();
            }
        }
    }
}
