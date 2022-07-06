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
    public partial class AddProduct : Form
    {
        //      MYSQL CASE
        //MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=office_db");

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1KL12NM;Initial Catalog=office_db;Integrated Security=True");
        SqlCommand cmd;

        private SupplyProduct _supplyProduct;

        Action m;

        public AddProduct(SupplyProduct supplyProduct)
        {
            _supplyProduct = supplyProduct;
            InitializeComponent();
            txt_id.Text = GUID();
            pb_product_img.Image = OfficePOS.Properties.Resources.download;
            txt_production_date.CustomFormat = " dd-MM-yyyy";
            txtExpire_date.CustomFormat = " dd-MM-yyyy";
            LoadProductType();
        }

        private void LoadProductType()
        {
            cmd = new SqlCommand("SELECT * FROM [product_categories]", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var dataRow = dt.Rows[i];
                combo_type.Items.Add(dataRow["Product_Type_Name"].ToString());
            }
        }

        private void clearData()
        {
            foreach (TextBox txt in product_Info.Controls.OfType<TextBox>())
            {
                txt.Text = "";
            }
            combo_type.Text = "";
            pb_product_img.Image = OfficePOS.Properties.Resources.download;
        }

        private string GUID()
        {
            StringBuilder sb = new StringBuilder();
            int numGuidsToConcat = (((8 - 1) / 32) + 1);
            for (int i = 1; i <= numGuidsToConcat; i++)
            {
                sb.Append(Guid.NewGuid().ToString("N"));
            }

            return "P-"+sb.ToString(0, 8);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pb_product_img.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {  
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_id.Text=="" || txt_productName.Text=="" || txt_weight.Text == "" || txt_Brand.Text == "" || combo_type.Text == "" || txt_selling_price.Text == "" || txt_origin_price.Text == "" || txt_production_date.Text == "" || txtExpire_date.Text == "")
            {
                MessageBox.Show("Please Fill In Every Textbox Fields To Save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addProduct();
            }
        }

        private void addProduct()
        {
            cmd = new SqlCommand("INSERT INTO [products] (Product_ID, Product_Name, Product_Type_Name, Product_Brand, Size, Original_Price, Selling_Price, Production_Date, Expiration_Date, Product_Img) VALUES (@id, @name, @type, @brand, @size, @orgPrice, @selPrice, @pDate, @eDate, @img)", conn);

            cmd.Parameters.AddWithValue("@id", txt_id.Text);
            cmd.Parameters.AddWithValue("@name", txt_productName.Text);
            cmd.Parameters.AddWithValue("@type", combo_type.Text);
            cmd.Parameters.AddWithValue("@brand", txt_Brand.Text);
            cmd.Parameters.AddWithValue("@size", txt_weight.Text);
            cmd.Parameters.AddWithValue("@orgPrice", txt_origin_price.Text);
            cmd.Parameters.AddWithValue("@selPrice", txt_selling_price.Text);
            cmd.Parameters.AddWithValue("@pDate", txt_production_date.Value.ToShortDateString());
            cmd.Parameters.AddWithValue("@eDate", txtExpire_date.Value.ToShortDateString());

            MemoryStream ms = new MemoryStream();
            pb_product_img.Image.Save(ms, pb_product_img.Image.RawFormat);

            cmd.Parameters.AddWithValue("@img", ms.ToArray());

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                DialogResult result =  MessageBox.Show("You have successfully added new product", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(result == DialogResult.OK)
                {
                    _supplyProduct.LoadProducts();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("error");
            }

            conn.Close();
        }

        private void txt_selling_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
