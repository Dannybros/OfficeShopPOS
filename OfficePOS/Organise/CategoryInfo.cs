using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OfficePOS
{
    public partial class CategoryInfo : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1KL12NM;Initial Catalog=office_db;Integrated Security=True");
        SqlCommand cmd;

        public CategoryInfo()
        {
            InitializeComponent();
            fillGrid();
        }
        private string GenerateCategoryID()
        {
            StringBuilder sb = new StringBuilder();
            int numGuidsToConcat = (((8 - 1) / 32) + 1);
            for (int i = 1; i <= numGuidsToConcat; i++)
            {
                sb.Append(Guid.NewGuid().ToString("N"));
            }

            return "Category-" + sb.ToString(0, 8);
        }

        public void fillGrid()
        {
            cmd = new SqlCommand("SELECT * FROM [product_categories]", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);

            dgvCategory.RowTemplate.Height = 40;
            dgvCategory.DataSource = tb;
            dgvCategory.ReadOnly = true;
            dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.DefaultCellStyle.Font = new Font("Times New Roman", 12);
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
            cmd = new SqlCommand("SELECT * FROM [product_categories] WHERE CONCAT (Product_Type_Name, Product_Type_ID) LIKE '%" + txtSearch.Text + "%' ", conn);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dgvCategory.DataSource = dt;
        }

        private void dgvCategory_Click(object sender, EventArgs e)
        {
            if (dgvCategory.RowCount > 0)
            {
                string id = dgvCategory.CurrentRow.Cells[0].Value.ToString();
                string name = dgvCategory.CurrentRow.Cells[1].Value.ToString();
                EditCategory ec = new EditCategory("update", id, name, fillGrid);
                ec.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditCategory ec = new EditCategory("save", GenerateCategoryID(), "", fillGrid);
            ec.Show();
        }
    }
}
