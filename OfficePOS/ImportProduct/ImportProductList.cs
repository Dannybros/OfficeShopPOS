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

namespace OfficePOS
{
    public partial class ImportProductList : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=office_db");
        MySqlCommand cmd;

        public ImportProductList()
        {
            InitializeComponent();
            fillData();
            cmbCategory.SelectedIndex = 0;
        }

        public void fillData()
        {
            string searchTerm="";

            DGV_orderList.DataSource = null;

            if (txtSearch.Text != "Search...")
            {
                searchTerm = txtSearch.Text;
            }

            cmd = new MySqlCommand("SELECT * FROM `order_imports` WHERE CONCAT (`Order_ID`,`Supplier_Name`) LIKE '%" + searchTerm + "%' AND `Checked` = @status", conn);
            cmd.Parameters.AddWithValue("@status", cmbCategory.Text);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);

            DGV_orderList.DataSource = tb;
            DGV_orderList.ReadOnly = true;
            DGV_orderList.RowTemplate.Height = 40;
            DGV_orderList.AllowUserToAddRows = false;
            DGV_orderList.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            DGV_orderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn item in DGV_orderList.Columns)
            {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            DGV_orderList.Columns[4].DefaultCellStyle.Font = new Font("Phetsarath OT", 12, FontStyle.Bold);

        }

        private void DGV_orderList_Click(object sender, EventArgs e)
        {
            if (DGV_orderList.RowCount > 0)
            {
                string id = DGV_orderList.CurrentRow.Cells[0].Value.ToString();
                string checkStatus = DGV_orderList.CurrentRow.Cells[4].Value.ToString();
                string total = DGV_orderList.CurrentRow.Cells[3].Value.ToString();

                CheckImports ci = new CheckImports(id, checkStatus, total);
                ci.Show();
            }
        }

        private void DGV_orderList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DGV_orderList.Rows[e.RowIndex].Cells[4].Value.ToString() == "ຍັງບໍ່ກວດ")
            {
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.BackColor = Color.FromArgb(153, 31, 0);
                style.ForeColor = Color.White;
                DGV_orderList.Rows[e.RowIndex].Cells[4].Style = style;
            }
            else
            {
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.BackColor = Color.FromArgb(0, 153, 51);
                style.ForeColor = Color.White;
                DGV_orderList.Rows[e.RowIndex].Cells[4].Style = style;
            }
        }

        private void DGV_orderList_SelectionChanged(object sender, EventArgs e)
        {
            DGV_orderList.ClearSelection();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            txtSearch.ForeColor = Color.Black;
            fillData();
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

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillData();
        }
    }
}
