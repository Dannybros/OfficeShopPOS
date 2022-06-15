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
using System.Globalization;
using System.Data.SqlClient;

namespace OfficePOS
{
    public partial class EditProduct : Form
    {
       /* MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=office_db");
        MySqlCommand cmd;*/

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1KL12NM;Initial Catalog=office_db;Integrated Security=True");
        SqlCommand cmd;

        private string proID;
        private Inventory _inv;

        public EditProduct(string id, Inventory invv)
        {
            _inv = invv;
            InitializeComponent();
            proID = id;
            LoadProductType();
            refresh();
            txt_production_date.CustomFormat = " dd-MM-yyyy";
            txtExpire_date.CustomFormat = " dd-MM-yyyy";
            txt_id.Text = id;
        }
        private void LoadProductType()
        {
            cmd = new SqlCommand("SELECT * FROM [product_types]", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var dataRow = dt.Rows[i];
                combo_type.Items.Add(dataRow["Product_Type_Name"].ToString());
            }
        }

        private void refresh()
        {
            cmd = new SqlCommand("SELECT * FROM [products] WHERE Product_ID='"+ proID + "'", conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            txt_productName.Text = dt.Rows[0]["Product_Name"].ToString();
            combo_type.Text = dt.Rows[0]["Product_Type_Name"].ToString();
            txt_weight.Text = dt.Rows[0]["Size"].ToString();
            txt_Brand.Text = dt.Rows[0]["Product_Brand"].ToString();
            txt_amount.Text = dt.Rows[0]["Quantity"].ToString();
            txt_selling_price.Text = Convert.ToInt32(dt.Rows[0]["Selling_Price"]).ToString("#,##0");
            txt_origin_price.Text = Convert.ToInt32(dt.Rows[0]["Original_Price"]).ToString("#,##0");
            txt_production_date.Text = dt.Rows[0]["Production_Date"].ToString();
            txtExpire_date.Text = dt.Rows[0]["Expiration_Date"].ToString();

            MemoryStream ms = new MemoryStream((byte[])dt.Rows[0]["Product_Img"]);
            product_image.BackgroundImage = Image.FromStream(ms);
            product_image.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                product_image.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to delete this product?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                cmd = new SqlCommand("DELETE FROM [products] WHERE Product_ID='" + txt_id.Text + "'", conn);

                conn.Open();

                if (cmd.ExecuteNonQuery() == 1)
                {
                    _inv.LoadProducts();
                    this.Close();
                }

                conn.Close();
            }
        }

        private void addProductType()
        {
            cmd = new SqlCommand("SELECT * FROM [product_types] WHERE Product_Type_Name='" + combo_type.Text + "'", conn);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                SqlCommand command = new SqlCommand("INSERT INTO [product_types]( Product_Type_Name) VALUES ('" + combo_type.Text + "')", conn);

                conn.Open();

                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE [products] SET Product_Name=@name, Product_Type_Name=@type, Product_Brand=@brand, Size=@size, Quantity=@quantity, Original_Price=@orgPrice, Selling_Price=@selPrice, Production_Date=@pDate, Expiration_Date=@eDate, Product_Img=@img WHERE Product_ID=@id", conn);
            cmd.Parameters.AddWithValue("@id", txt_id.Text);
            cmd.Parameters.AddWithValue("@name", txt_productName.Text);
            cmd.Parameters.AddWithValue("@type", combo_type.Text);
            cmd.Parameters.AddWithValue("@brand", txt_Brand.Text);
            cmd.Parameters.AddWithValue("@quantity", int.Parse(txt_amount.Text));
            cmd.Parameters.AddWithValue("@size", txt_weight.Text);
            cmd.Parameters.AddWithValue("@orgPrice", double.Parse(txt_origin_price.Text));
            cmd.Parameters.AddWithValue("@selPrice", double.Parse(txt_selling_price.Text));
            cmd.Parameters.AddWithValue("@pDate", txt_production_date.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@eDate", txtExpire_date.Value.ToShortDateString());

            MemoryStream ms = new MemoryStream();
            product_image.BackgroundImage.Save(ms, product_image.BackgroundImage.RawFormat);

            cmd.Parameters.AddWithValue("@img", ms.ToArray());

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
               DialogResult result = MessageBox.Show("You have successfully updated product info", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            conn.Close();

            addProductType();
        }
    }
}
