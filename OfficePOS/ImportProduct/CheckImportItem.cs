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
    public partial class CheckImportItem : Form
    {
        private string id;
        private int arrivedAmount = 0;

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1KL12NM;Initial Catalog=office_db;Integrated Security=True");
        SqlCommand cmd;
        ImportProductList _importP;

        public CheckImportItem(string id, ImportProductList imp)
        {
            InitializeComponent();
            this.id = id;
            _importP = imp;
            btn_check.Enabled = true;
            LoadImports();
            LoadEmployee();
        }

        private void refresh()
        {
            txtArrive.Value = 0;
            txtName.Text = "";
            txtPrice.Text = "";
            txt_id.Text = "";
            arrivedAmount = 0;
            btn_check.Enabled = true;
            LoadImports();
        }
        private void LoadEmployee()
        {
            cmd = new SqlCommand("SELECT * FROM [employee]", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var dataRow = dt.Rows[i];
                cmbEmp.Items.Add(dataRow["Employee_Name"].ToString());
            }
        }

        private void LoadImports()
        {
            dataGridView1.DataSource = null;

            cmd = new SqlCommand("SELECT Import_No, Product_ID, Product_Name, Original_Price as Price, Amount, Arrived FROM [import_details] WHERE Order_ID ='" + id + "'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int qty = int.Parse(dataGridView1.CurrentRow.Cells["Amount"].Value.ToString());
                txt_id.Text = dataGridView1.CurrentRow.Cells["Import_No"].Value.ToString();
                txtName.Text = dataGridView1.CurrentRow.Cells["Product_Name"].Value.ToString();
                txtPrice.Text = dataGridView1.CurrentRow.Cells["Price"].Value.ToString();
                txtArrive.Text = dataGridView1.CurrentRow.Cells["Arrived"].Value.ToString();
                txtArrive.Tag = dataGridView1.CurrentRow.Cells["Amount"].Value.ToString();
                txt_id.Tag = dataGridView1.CurrentRow.Cells["Product_ID"].Value.ToString();
                arrivedAmount = int.Parse(dataGridView1.CurrentRow.Cells["Arrived"].Value.ToString());

                if (arrivedAmount >= qty) btn_check.Enabled = false;
                else btn_check.Enabled = true;
            }
        }

        private void UpdateAmount(string id, int amount)
        {
            cmd = new SqlCommand("UPDATE [products] SET Quantity=Quantity+@amount WHERE Product_ID=@prodId", conn);
            cmd.Parameters.AddWithValue("@prodId", id);
            cmd.Parameters.AddWithValue("@amount", amount);

            cmd.ExecuteNonQuery();
        }

        private void UpdateStatus()
        {
            cmd = new SqlCommand("UPDATE [order_imports] SET Checked=@status,  Employee_Name = @name, CheckedDate=@cDate WHERE Order_ID='" + id + "'", conn);
            cmd.Parameters.AddWithValue("@status", "ກວດແລ້ວ");
            cmd.Parameters.AddWithValue("@name", cmbEmp.Text);
            cmd.Parameters.AddWithValue("@cDate", txtdate.Value);

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Checked Import Successfully", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _importP.fillData();

                this.Close();
            }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            if (txtArrive.Value > int.Parse(txtArrive.Tag.ToString()))
            {
                MessageBox.Show("Please Check Amount Again");
            } 
            else if (txt_id.Text=="")
            {
                MessageBox.Show("Please Choose Product First");
            }
            else
            {
                int newAmount = Convert.ToInt32(txtArrive.Value) - arrivedAmount;

                cmd = new SqlCommand("update import_details set Arrived = Arrived + @amt where Import_No = @id", conn);
                cmd.Parameters.AddWithValue("@amt", newAmount);
                cmd.Parameters.AddWithValue("@id", txt_id.Text);

                conn.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {

                    UpdateAmount(txt_id.Tag.ToString(), newAmount);

                    refresh();
                }
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (cmbEmp.Text == "")
            {
                MessageBox.Show("Please Choose Employee");
            }
            else
            {
                foreach(DataGridViewRow dr in dataGridView1.Rows)
                {
                    string importNo = dataGridView1.CurrentRow.Cells["Import_No"].Value.ToString();
                    string proID = dataGridView1.CurrentRow.Cells["Product_ID"].Value.ToString();
                    int qty = int.Parse(dataGridView1.CurrentRow.Cells["Amount"].Value.ToString());
                    int arrived = int.Parse(dataGridView1.CurrentRow.Cells["Arrived"].Value.ToString());

                    UpdateAmount(proID, qty - arrived);

                    cmd = new SqlCommand("update import_details set Arrived = @amt where Import_No = @id", conn);
                    cmd.Parameters.AddWithValue("@amt", arrived);
                    cmd.Parameters.AddWithValue("@id", importNo);
                    cmd.ExecuteNonQuery();
                }

                UpdateStatus();
            }
            conn.Close();

        }
    }
}
