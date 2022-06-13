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
    public partial class SupplierInfos : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=office_db");

        public SupplierInfos()
        {
            InitializeComponent();
            clearData();
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
            MySqlCommand cmd = new MySqlCommand("SELECT `Supplier_ID`, `Supplier_Name`, `Supplier_Address`, `Supplier_Email`, `Supplier_Tel`, `Supplier_Img` FROM `suppliers`", conn);
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
            pb_supplier.Image = OfficePOS.Properties.Resources.supplier;
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
            MySqlCommand cmd = new MySqlCommand("SELECT `Supplier_ID`, `Supplier_Name`, `Supplier_Address`, `Supplier_Email`, `Supplier_Tel`, `Supplier_Img` FROM `suppliers` WHERE CONCAT (`Supplier_ID`,`Supplier_Name`, `Supplier_Email`) LIKE '%" + txtSearch.Text + "%' ", conn);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pb_supplier.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btn_GUID_Click(object sender, EventArgs e)
        {
            string supp_id = "s-" + GUID();
            txt_sup_ID.Text = supp_id;
        }

        private bool checkIfSupplierExist()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT `Supplier_Name`, `Supplier_Address`, `Supplier_Email`, `Supplier_Tel`, `Supplier_Img` FROM `suppliers` WHERE  `Supplier_ID` = '" + txt_sup_ID.Text + "'", conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0)
            { return true; }
            else
            { return false; }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_sup_ID.Text == "" || txt_email.Text == "" || txt_sup_name.Text == "" || txt_phone.Text == "" || txt_address.Text == "")
            {
                MessageBox.Show("Please Fill In Every Textbox Fields To Save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkIfSupplierExist()) { updateSup(); }
                else { insertSup(); }
            }
        }

        private void insertSup()
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `suppliers`(`Supplier_ID`, `Supplier_Name`, `Supplier_Address`, `Supplier_Email`, `Supplier_Tel`, `Supplier_Img`) VALUES (@id, @name, @address, @email, @tel, @img)", conn);

            cmd.Parameters.AddWithValue("@id", txt_sup_ID.Text);
            cmd.Parameters.AddWithValue("@name", txt_sup_name.Text);
            cmd.Parameters.AddWithValue("@address", txt_address.Text);
            cmd.Parameters.AddWithValue("@email", txt_email.Text);
            cmd.Parameters.AddWithValue("@tel", txt_phone.Text);

            MemoryStream ms = new MemoryStream();
            pb_supplier.Image.Save(ms, pb_supplier.Image.RawFormat);

            cmd.Parameters.Add("@img", MySqlDbType.LongBlob).Value = ms.ToArray();

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("You have successfully added new Employee", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
                fillGrid();
            }
            else
            {
                MessageBox.Show("error");
            }

            conn.Close();
        }

        private void updateSup()
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE `suppliers` SET `Supplier_Name`=@name, `Supplier_Address`=@address, `Supplier_Email`=@email, `Supplier_Tel`=@phone, `Supplier_Img`=@img WHERE `Supplier_ID`=@id", conn);

            cmd.Parameters.AddWithValue("@id", txt_sup_ID.Text);
            cmd.Parameters.AddWithValue("@name", txt_sup_name.Text);
            cmd.Parameters.AddWithValue("@address", txt_address.Text);
            cmd.Parameters.AddWithValue("@email", txt_email.Text);
            cmd.Parameters.AddWithValue("@phone", txt_phone.Text);

            MemoryStream ms = new MemoryStream();
            pb_supplier.Image.Save(ms, pb_supplier.Image.RawFormat);

            cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = ms.ToArray();

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("You have successfully updated Employee", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
                fillGrid();
            }
            else
            {
                MessageBox.Show("error");
            }

            conn.Close();
        }

        private void txt_sup_phone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                txt_sup_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_sup_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_address.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_email.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_phone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                byte[] pic;
                pic = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(pic);
                pb_supplier.Image = Image.FromStream(ms);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to delete this supplier?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `suppliers` WHERE `Supplier_ID`='" + txt_sup_ID.Text + "'", conn);

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
    }
}
