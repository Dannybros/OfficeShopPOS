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
    public partial class EmployeeInfos : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=office_db");
        MySqlCommand cmd;

        public EmployeeInfos()
        {
            InitializeComponent();
            fillGrid();
        }

        private string GUID()
        {
            long ticks = DateTime.Now.Ticks;
            byte[] bytes = BitConverter.GetBytes(ticks);
            string id = Convert.ToBase64String(bytes)
                                    .Replace('+', '_')
                                    .Replace('/', '-')
                                    .TrimEnd('=');
            return id;
        }

        private void fillGrid()
        {
            dataGridView1.DataSource = null;

            string searchTerm = "";
            if (txtSearch.Text != "Search...")
            {
                searchTerm = txtSearch.Text;
            }

            cmd = new MySqlCommand("SELECT * FROM `employee` WHERE CONCAT (`Employee_ID`,`Employee_Name`) LIKE '%" + searchTerm + "%' ", conn);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adp.Fill(tb);

            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = tb;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[5];
            picCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void clearData()
        {
            foreach (TextBox txt in groupBox1.Controls.OfType<TextBox>())
            {
                txt.Text = "";
            }
            pb_emp.Image = OfficePOS.Properties.Resources.employee;
        }

        private void btn_GUID_Click(object sender, EventArgs e)
        {
            string emp_id = "emp-" + GUID();
            txt_ID.Text = emp_id;
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pb_emp.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "" || txt_email.Text == "" || txt_name.Text == "" || txt_phone.Text == "" || txt_address.Text == "")
            {
                MessageBox.Show("Please Fill In Every Textbox Fields To Save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmd = new MySqlCommand("INSERT INTO `employee`(`Employee_ID`, `Employee_Name`, `Employee_Phone`, `Employee_Email`, `Employee_Address`, `Emp_Img`) VALUES (@id, @name, @phone, @email, @addr, @img) ON DUPLICATE KEY UPDATE Employee_Name=@name, Employee_Address=@addr, Employee_Email=@email, Employee_Phone=@phone, Emp_Img=@img", conn);

                cmd.Parameters.AddWithValue("@id", txt_ID.Text);
                cmd.Parameters.AddWithValue("@name", txt_name.Text);
                cmd.Parameters.AddWithValue("@addr", txt_address.Text);
                cmd.Parameters.AddWithValue("@email", txt_email.Text);
                cmd.Parameters.AddWithValue("@phone", txt_phone.Text);

                MemoryStream ms = new MemoryStream();
                pb_emp.Image.Save(ms, pb_emp.Image.RawFormat);
                cmd.Parameters.Add("@img", MySqlDbType.LongBlob).Value = ms.ToArray();

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Query Completed", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
                fillGrid();
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to delete this Employee?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `employee` WHERE `Employee_ID`='" + txt_ID.Text + "'", conn);

                conn.Open();

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Supplier Deleted successfully", "Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clearData();
                    fillGrid();
                }

                conn.Close();
            }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount > 0)
            {
                txt_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_phone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_email.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_address.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                byte[] pic;
                pic = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(pic);
                pb_emp.Image = Image.FromStream(ms);
            }
        }
    }
}
