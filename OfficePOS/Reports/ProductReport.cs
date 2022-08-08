﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace OfficePOS
{
    public partial class ProductReport : Form
    {
        //      MYSQL CASE
        /* MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=office_db");
         MySqlCommand cmd;*/

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1KL12NM;Initial Catalog=office_db;Integrated Security=True");
        SqlCommand cmd;

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

            if (cmbType.SelectedIndex == 0) cmd = new SqlCommand("SELECT Product_ID, Product_Name, Product_Type_Name, Quantity, Expiration_Date FROM [products] WHERE CONCAT (Product_ID, Product_Name) LIKE '%" + searchTerm + "%' AND Expiration_Date BETWEEN DATEADD(MONTH,-1,GETDATE()) AND EOMONTH(DATEADD(MONTH,1,GETDATE())) ORDER BY Expiration_Date", conn);

            else if(cmbType.SelectedIndex ==1) cmd = new SqlCommand("SELECT Product_ID, Product_Name, Product_Type_Name, Quantity, Counter_Name FROM [products] WHERE CONCAT (Product_ID, Product_Name) LIKE '%" + searchTerm + "%' ORDER BY Quantity", conn);

            else cmd = new SqlCommand("SELECT t1.Product_ID, t1.Product_Name, t1.Product_Type_Name, t1.Quantity, t1.Counter_Name, t2.Sold FROM [products] AS t1 INNER JOIN (SELECT Product_ID, sum(Amount) AS Sold from [sale_details] GROUP BY Product_ID) AS t2 ON t1.Product_ID = t2.Product_ID WHERE CONCAT (t1.Product_ID, Product_Name) LIKE '%" + searchTerm + "%' ORDER BY t2.Sold DESC", conn);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);

            dataGridView1.DataSource = tb;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DefaultCellStyle.Font = new Font("Phetsarath OT", 12);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

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


