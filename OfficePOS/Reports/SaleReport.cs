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
using System.Data.SqlClient;

namespace OfficePOS
{
    public partial class SaleReport : Form
    {
        //      SQL CASE
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1KL12NM;Initial Catalog=office_db;Integrated Security=True");
        SqlCommand cmd;

        List<SaleItem> SaleItemList = new List<SaleItem>();

        /* MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=office_db");
         MySqlCommand cmd;*/

        public SaleReport()
        {
            InitializeComponent();
            loadSaleItems();
        }

        private void loadSaleItems()
        {
            string searchTerm = "";

            dgv_SaleItems.DataSource = null;

            if (txtSearch.Text != "Search...")
            {
                searchTerm = txtSearch.Text;
            }

            cmd = new SqlCommand("SELECT * FROM [sale] WHERE CONCAT (Sale_ID, Customer_Name, Date) LIKE '%" + searchTerm + "%'", conn);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);

            dgv_SaleItems.DataSource = tb;
            dgv_SaleItems.ReadOnly = true;
            dgv_SaleItems.RowTemplate.Height = 40;
            dgv_SaleItems.AllowUserToAddRows = false;
            dgv_SaleItems.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dgv_SaleItems.Columns[1].DefaultCellStyle.Font = new Font("Phetsarath OT", 12);
            dgv_SaleItems.Columns[2].DefaultCellStyle.Font = new Font("Phetsarath OT", 12);
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

        private void getAllSaleItems(string id)
        {
            cmd = new SqlCommand("SELECT * FROM [sale_details] WHERE Sale_ID = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);

            for (var i = 0; i < tb.Rows.Count; i++)
            {
                var dataRow = tb.Rows[i];

                string proId = dataRow["Product_ID"].ToString();
                string proName = dataRow["Product_Name"].ToString();
                string price = dataRow["Price"].ToString();
                string amount = dataRow["Amount"].ToString();

                SaleItemList.Add(new SaleItem(proId, proName, double.Parse(price), int.Parse(amount), 0));
            }
        }

        private void dgv_SaleItems_Click(object sender, EventArgs e)
        {
            if(dgv_SaleItems.RowCount > 0)
            {
                string id = dgv_SaleItems.CurrentRow.Cells[0].Value.ToString();
                string custoner_name = dgv_SaleItems.CurrentRow.Cells[1].Value.ToString();
                string employee_name = dgv_SaleItems.CurrentRow.Cells[2].Value.ToString();
                string total = dgv_SaleItems.CurrentRow.Cells[3].Value.ToString();
                string paid = dgv_SaleItems.CurrentRow.Cells[4].Value.ToString();
                string change = (int.Parse(total) - int.Parse(paid)).ToString("#,##0");

                getAllSaleItems(id);

                SaleBillViewer saleViewer = new SaleBillViewer(SaleItemList, id, custoner_name, employee_name, change, paid);
                saleViewer.Show();

            }
        }
    }
}
