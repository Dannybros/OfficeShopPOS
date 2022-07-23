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
    public partial class Counters : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1KL12NM;Initial Catalog=office_db;Integrated Security=True");
        SqlCommand cmd;

        public Counters()
        {
            InitializeComponent();
            fillGrid();
            refresh();
        }

        private string GenerateCounterID()
        {
            StringBuilder sb = new StringBuilder();
            int numGuidsToConcat = (((8 - 1) / 32) + 1);
            for (int i = 1; i <= numGuidsToConcat; i++)
            {
                sb.Append(Guid.NewGuid().ToString("N"));
            }

            return "Coutner-" + sb.ToString(0, 8);
        }

        private void refresh()
        {
            txt_counter.Text = "";
            txtCounter_ID.Text = "";
        }

        public void fillGrid()
        {
            cmd = new SqlCommand("SELECT * FROM [counters]", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);

            dgvCounter.RowTemplate.Height = 40;
            dgvCounter.DataSource = tb;
            dgvCounter.ReadOnly = true;
            dgvCounter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCounter.AllowUserToAddRows = false;
            dgvCounter.DefaultCellStyle.Font = new Font("Phetsarath OT", 12);
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
            cmd = new SqlCommand("SELECT * FROM [counters] WHERE CONCAT (Counter_ID, Counter_Name) LIKE '%" + txtSearch.Text + "%' ", conn);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dgvCounter.DataSource = dt;
        }

        private void addCategory()
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [counters](Counter_ID, Counter_Name) VALUES ('" + GenerateCounterID() + "', @name)", conn);
            cmd.Parameters.AddWithValue("@name", txt_counter.Text);

            conn.Open();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Counter has been Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillGrid();
                refresh();
            }

            conn.Close();
        }

        private void updateCategory()
        {
            cmd = new SqlCommand("UPDATE [counters] SET Counter_Name=@name WHERE Counter_ID='" + txtCounter_ID.Text + "'", conn);
            cmd.Parameters.AddWithValue("@name", txt_counter.Text);

            conn.Open();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Counter has been updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
                fillGrid();
            }

            conn.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtCounter_ID.Text != "")
            {
                updateCategory();
            }
            else addCategory();
        }

        private void dgvCounter_Click(object sender, EventArgs e)
        {
            if (dgvCounter.RowCount > 0)
            {
                txtCounter_ID.Text = dgvCounter.CurrentRow.Cells[0].Value.ToString();
                txt_counter.Text = dgvCounter.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to delete this Employee?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                cmd = new SqlCommand("DELETE FROM [counters] WHERE Counter_ID='" + txtCounter_ID.Text + "'", conn);

                conn.Open();

                if (cmd.ExecuteNonQuery() == 1)
                {
                    refresh();
                    fillGrid();
                }

                conn.Close();
            }
        }
    }
}
