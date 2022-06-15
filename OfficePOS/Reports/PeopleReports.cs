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
    public partial class PeopleReports : Form
    {
        /*MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=office_db");
        MySqlCommand cmd;*/

        //      SQL CASE
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1KL12NM;Initial Catalog=office_db;Integrated Security=True");
        SqlCommand cmd;

        public PeopleReports()
        {
            InitializeComponent();
            cmbType.SelectedIndex = 0;
            fillGrid();
        }

        private void fillGrid()
        {
            dataGridView1.DataSource = null;

            string searchTerm = "";
            if (txtSearch.Text != "Search...") searchTerm = txtSearch.Text;

            if (cmbType.Text == "ລູກຄ້າ") fillCustomer(searchTerm);
            if (cmbType.Text == "ຜູ້ສະໜອງ") fillSupplier(searchTerm);
            if (cmbType.Text == "ພະນັກງານ") fillEmployee(searchTerm); 

            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void fillCustomer(string searchTerm)
        {
            cmd = new SqlCommand("SELECT Customer_ID, Customer_Name, Gender, Address, Email, Phone FROM [customer] WHERE CONCAT (Customer_ID, Customer_Name, Email) LIKE '%" + searchTerm + "%' ", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);

            dataGridView1.DataSource = tb;
            dataGridView1.Columns[3].DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dataGridView1.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void fillEmployee(string searchTerm)
        {
            cmd = new SqlCommand("SELECT Employee_ID, Employee_Name, Employee_Phone, Employee_Email, Employee_Address FROM [employee] WHERE CONCAT (Employee_ID, Employee_Name) LIKE '%" + searchTerm + "%' ", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);

            dataGridView1.DataSource = tb;
            dataGridView1.Columns[2].DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dataGridView1.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void fillSupplier(string searchTerm)
        {
            cmd = new SqlCommand("SELECT Supplier_ID, Supplier_Name, Supplier_Address, Supplier_Email, Supplier_Tel FROM [supplier] WHERE CONCAT (Supplier_ID, Supplier_Name, Supplier_Email) LIKE '%" + searchTerm + "%' ", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);

            dataGridView1.DataSource = tb;
            dataGridView1.Columns[2].DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dataGridView1.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            txtSearch.ForeColor = Color.Black;
            fillGrid();
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
    }
}
