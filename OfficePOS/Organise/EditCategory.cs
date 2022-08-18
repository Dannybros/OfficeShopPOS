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
    public partial class EditCategory : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1KL12NM;Initial Catalog=office_db;Integrated Security=True");
        SqlCommand cmd;
        private string id, action;
        Action fillData;

        public EditCategory(string action, string id, string name, Action fillData)
        {
            InitializeComponent();
            this.id = id;
            this.action = action;
            this.fillData = fillData;
            if (action == "update")
            {
                txt_category.Text = name;
            }
        }
        
        private void addProductType()
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [product_categories](Product_Type_ID, Product_Type_Name) VALUES (@id, @type)", conn);
            cmd.Parameters.AddWithValue("@type", txt_category.Text);
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();

            if (cmd.ExecuteNonQuery() == 1)
            {
                fillData.Invoke();
                this.Close();
            }

            conn.Close();
        }

        private void updateProductType()
        {
            cmd = new SqlCommand("UPDATE [product_categories] SET Product_Type_Name=@type WHERE Product_Type_ID=@id", conn);
            cmd.Parameters.AddWithValue("@type", txt_category.Text);
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Category has been updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillData.Invoke();
                this.Close();
            }

            conn.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (action == "save") { addProductType(); }
            else { updateProductType(); }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (txt_category.Text == "" && action=="save")
            {
                this.Close();
            }
            else if (txt_category.Text == "" && action == "update")
            {
                MessageBox.Show("Please fill in the name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM [product_categories] WHERE Product_Type_ID =@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();

                if (cmd.ExecuteNonQuery() == 1)
                {
                    fillData.Invoke();
                    this.Close();
                }

                conn.Close();
            }
        }
    }
}
