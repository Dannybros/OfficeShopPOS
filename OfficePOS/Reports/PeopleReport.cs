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
    public partial class PeopleReport : UserControl
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=office_db");
        MySqlCommand cmd;

        public PeopleReport()
        {
            InitializeComponent();
            fillGrid();
            cmbType.SelectedIndex = 0;
        }

        private void fillGrid()
        {
            if (cmbType.Text == "ລູກຄ້າ") fillCustomer();
            else if (cmbType.Text == "ຜູ້ສະໜອງ") fillSupplier();
            else fillEmployee();

            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void fillCustomer()
        {
            cmd = new MySqlCommand("SELECT * FROM `customer` WHERE CONCAT (`Customer_ID`,`Customer_Name`, `Email`, `Phone`) LIKE '%" + txtSearch.Text + "%' ", conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);

            dataGridView1.DataSource = tb;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[6];
            picCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.Columns[3].DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dataGridView1.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void fillSupplier()
        {
            cmd = new MySqlCommand("SELECT * FROM `suppliers` WHERE CONCAT (`Supplier_ID`,`Supplier_Name`, `Supplier_Email`) LIKE '%" + txtSearch.Text + "%' ", conn);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);

            dataGridView1.DataSource = tb;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[5];
            picCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.Columns[2].DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dataGridView1.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void fillEmployee()
        {
            cmd = new MySqlCommand("SELECT * FROM `suppliers` WHERE CONCAT (`Supplier_ID`,`Supplier_Name`, `Supplier_Email`) LIKE '%" + txtSearch.Text + "%' ", conn);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);

            dataGridView1.DataSource = tb;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[5];
            picCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.Columns[2].DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dataGridView1.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            txtSearch.ForeColor = Color.Black;
            fillGrid();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillGrid();
        }
    }
}
