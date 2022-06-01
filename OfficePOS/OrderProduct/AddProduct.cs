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
    public partial class AddProduct : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=office_db");

        public AddProduct()
        {
            InitializeComponent();
            txt_id.Text = GUID();
            pb_product_img.Image = OfficePOS.Properties.Resources.download;
            LoadProductType();
        }

        private void LoadProductType()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT `Product_Type_Name` FROM `product_types`", conn);
            conn.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                combo_type.Items.Add(reader.GetString("Product_Type_Name"));
            }
            conn.Close();
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
            foreach (TextBox text in product_Info.Controls.OfType<TextBox>()) { text.Text = ""; }
            combo_type.Text = "";
            pb_product_img.Image = null;
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
                addProductType();
                addProduct();
            }
        }

        private void addProductType()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT `Product_Type_ID`, `Product_Type_Name` FROM `product_types` WHERE `Product_Type_Name`='" + combo_type.Text + "'", conn);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO `product_types`( `Product_Type_Name`) VALUES ('"+combo_type.Text+"')", conn);

                conn.Open();

                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        private void addProduct()
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `products`(`Product_ID`, `Product_Name`, `Product_Type_Name`, `Product_Brand`, `Size`, `Original_Price`, `Selling_Price`, `Production_Date`, `Expiration_Date`, `Product_Img`) VALUES (@id, @name, @type, @brand, @size, @orgPrice, @selPrice, @pDate, @eDate, @img)", conn);

            cmd.Parameters.AddWithValue("@id", txt_id.Text);
            cmd.Parameters.AddWithValue("@name", txt_productName.Text);
            cmd.Parameters.AddWithValue("@type", combo_type.Text);
            cmd.Parameters.AddWithValue("@brand", txt_Brand.Text);
            cmd.Parameters.AddWithValue("@size", txt_weight.Text);
            cmd.Parameters.AddWithValue("@orgPrice", txt_origin_price.Text);
            cmd.Parameters.AddWithValue("@selPrice", txt_selling_price.Text);
            cmd.Parameters.AddWithValue("@pDate", txt_production_date.Text);
            cmd.Parameters.AddWithValue("@eDate", txtExpire_date.Text);

            MemoryStream ms = new MemoryStream();
            pb_product_img.Image.Save(ms, pb_product_img.Image.RawFormat);

            cmd.Parameters.Add("@img", MySqlDbType.LongBlob).Value = ms.ToArray();

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("You have successfully added new Products", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
                var sp = Application.OpenForms.OfType<SupplyProduct>().Single();
                sp.LoadProducts();
                this.Close();
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
