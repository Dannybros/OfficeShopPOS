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
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace OfficePOS
{
    public partial class CustomerInfos : Form
    {
        //      SQL CASE
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1KL12NM;Initial Catalog=office_db;Integrated Security=True");
        SqlCommand cmd;

        //      MYSQL CASE
       /* MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=office_db");

        MySqlCommand cmd;*/

        public CustomerInfos()
        {
            InitializeComponent();
            fillGrid();
        }
        private void clearData()
        {
            foreach (TextBox txt in groupBox1.Controls.OfType<TextBox>())
            {
                txt.Text = "";
            }
            pb_customer.Image = Properties.Resources.programmer;

            rbMale.Checked = false;
            rbFemale.Checked = false;
        }

        private string GenerateSaleID()
        {
            StringBuilder sb = new StringBuilder();
            int numGuidsToConcat = (((8 - 1) / 32) + 1);
            for (int i = 1; i <= numGuidsToConcat; i++)
            {
                sb.Append(Guid.NewGuid().ToString("N"));
            }

            return "C-" + sb.ToString(0, 8);
        }

        private void fillGrid()
        {
            cmd = new SqlCommand("SELECT * FROM [customer]", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);

            dataGridCustomer.RowTemplate.Height = 80;
            dataGridCustomer.DataSource = tb;
            dataGridCustomer.ReadOnly = true;
            dataGridCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridCustomer.Columns[6];
            picCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridCustomer.AllowUserToAddRows = false;
            dataGridCustomer.DefaultCellStyle.Font = new Font("Phetsarath OT", 12);
            dataGridCustomer.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            foreach (DataGridViewColumn item in dataGridCustomer.Columns)
            {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btn_GUID_Click(object sender, EventArgs e)
        {
            txtID.Text = GenerateSaleID();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtAddress.Text == "" || txtPhone.Text == "" || txtEmail.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("Please Fill In Every Textbox Fields To Save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string gender;
                if (rbMale.Checked) gender = "Male";
                else gender = "Female";

                //      MYSQL CASE
                //cmd = new MySqlCommand("INSERT INTO customer (Customer_ID, Customer_Name, Gender, Address, Email, Phone, Customer_Image) VALUES (@id, @name, @gender, @addr, @email, @phone, @img) ON DUPLICATE KEY UPDATE Customer_Name=@name, Gender=@gender, Address=@addr, Email=@email, Phone=@phone, Customer_Image=@img", conn);

                if (checkIfSCustomerExist())
                {
                    cmd = new SqlCommand("UPDATE [customer] SET Customer_Name=@name, Gender=@gender, Address=@addr, Email=@email, Phone=@phone, Customer_Image=@img WHERE Customer_ID=@id", conn);
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO [customer] (Customer_ID, Customer_Name, Gender, Address, Email, Phone, Customer_Image) VALUES (@id, @name, @gender, @addr, @email, @phone, @img)", conn);
                }
               
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@addr", txtAddress.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);

                MemoryStream ms = new MemoryStream();
                pb_customer.Image.Save(ms, pb_customer.Image.RawFormat);
                cmd.Parameters.AddWithValue("@img", ms.ToArray());

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Query Completed", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
                fillGrid();
            }
        }

        private bool checkIfSCustomerExist()
        {
            cmd = new SqlCommand("SELECT * FROM [customer] WHERE Customer_ID = '" + txtID.Text + "'", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0)
            { return true; }
            else
            { return false; }
        }

        private void dataGridCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridCustomer.RowCount > 0)
            {
                txtID.Text = dataGridCustomer.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dataGridCustomer.CurrentRow.Cells[1].Value.ToString();
                string g = dataGridCustomer.CurrentRow.Cells[2].Value.ToString();
                if (g == "Male") rbMale.Checked = true;
                else rbFemale.Checked = true;
                txtAddress.Text = dataGridCustomer.CurrentRow.Cells[3].Value.ToString();
                txtEmail.Text = dataGridCustomer.CurrentRow.Cells[4].Value.ToString();
                txtPhone.Text = dataGridCustomer.CurrentRow.Cells[5].Value.ToString();

                byte[] pic;
                pic = (byte[])dataGridCustomer.CurrentRow.Cells[6].Value;
                MemoryStream ms = new MemoryStream(pic);
                pb_customer.Image = Image.FromStream(ms);
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you wish to delete this Customer?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                cmd = new SqlCommand("DELETE FROM [customer] WHERE Customer_ID='" + txtID.Text + "'", conn);

                conn.Open();

                if (cmd.ExecuteNonQuery() == 1)
                {
                    clearData();
                    fillGrid();
                }

                conn.Close();
            }
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
            cmd = new SqlCommand("SELECT * FROM [customer] WHERE CONCAT (Customer_ID, Customer_Name, Email, Phone) LIKE '%" + txtSearch.Text + "%' ", conn);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridCustomer.DataSource = dt;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pb_customer.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
