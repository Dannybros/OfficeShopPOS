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
    public partial class EditProduct : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=office_db");
        MySqlCommand cmd;
        public EditProduct(string id)
        {
            InitializeComponent();
            LoadProductType();
            txt_id.Text = id;
        }
        private void LoadProductType()
        {
            cmd = new MySqlCommand("SELECT `Product_Type_Name` FROM `product_types`", conn);
            conn.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                combo_type.Items.Add(reader.GetString("Product_Type_Name"));
            }
            conn.Close();
        }

        private void refresh()
        {
            cmd = new MySqlCommand("", conn);
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
    }
}
