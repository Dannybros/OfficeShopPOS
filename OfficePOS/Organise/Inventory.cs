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
    public partial class Inventory : Form
    {
        //      MYSQL CASE
        /*MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=office_db");
        MySqlCommand cmd;*/

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1KL12NM;Initial Catalog=office_db;Integrated Security=True");

        SqlCommand cmd;

        public Inventory()
        {
            InitializeComponent();
            startForm();
        }

        public void startForm()
        {
            LoadProductType();
            LoadProducts();
            cmbCategory.SelectedIndex = 0;
        }

        public void LoadProducts()
        {
            panelDisplayItems.Controls.Clear();

            string searchTerm = "";
            if (txtSearch.Text != "Search...")
            {
                searchTerm = txtSearch.Text;
            }

            if (cmbCategory.Text == "ທັງໝົດ")
            {
                cmd = new SqlCommand("SELECT * FROM [products] WHERE CONCAT (Product_ID, Product_Name) LIKE '%" + searchTerm + "%'", conn);
            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM [products] WHERE CONCAT (Product_ID, Product_Name) LIKE '%" + searchTerm + "%' AND Product_Type_Name = @type", conn);
                cmd.Parameters.AddWithValue("@type", cmbCategory.Text);
            }

            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var dataRow = dt.Rows[i];
                popItems(dataRow["Product_ID"].ToString(), dataRow["Product_Name"].ToString(), (byte[])dataRow["Product_Img"]);
            }
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
                cmbCategory.Items.Add(dataRow["Product_Type_Name"].ToString());
            }
        }

        private void popItems(string id, string name, byte[] picArray)
        {
            PictureBox pic = new PictureBox();
            pic.Width = 200;
            pic.Height = 150;
            MemoryStream ms = new MemoryStream(picArray);
            pic.BackgroundImage = Image.FromStream(ms);
            pic.BackgroundImageLayout = ImageLayout.Zoom;
            pic.Click += new EventHandler(picture_Click);
            pic.Tag = id;

            Label pro_ID = new Label();
            pro_ID.Text = id;
            pro_ID.Font = new Font("Times news Roman", 10, FontStyle.Regular);
            pro_ID.TextAlign = ContentAlignment.MiddleCenter;
            pro_ID.BackColor = Color.IndianRed;
            pro_ID.ForeColor = Color.White;
            pic.Controls.Add(pro_ID);

            Label title = new Label();
            title.Text = name;
            title.Tag = id;
            title.AutoSize = false;
            title.Dock = DockStyle.Bottom;
            title.Height = 30;
            title.TextAlign = ContentAlignment.MiddleCenter;
            title.Font = new Font("Times news Roman", 12);
            title.BackColor = Color.FromArgb(50, 0, 166, 90);
            title.Click += new EventHandler(title_Click);

            Panel product = new Panel();
            product.Width = 200;
            product.Height = 180;
            var marginproduct = product.Margin;
            marginproduct.Right = 22;
            marginproduct.Left = 22;
            marginproduct.Top = 30;
            marginproduct.Bottom = 30;
            product.Margin = marginproduct;
            product.Controls.Add(pic);
            product.Controls.Add(title);

            panelDisplayItems.Controls.Add(product);
        }

        private void picture_Click(object sender, EventArgs e)
        {
            string id = ((PictureBox)sender).Tag.ToString();
            EditProduct ep = new EditProduct(id, this);
            ep.Show();
        }

        private void title_Click(object sender, EventArgs e)
        {
            string id = ((Label)sender).Text;
            EditProduct ep = new EditProduct(id, this);
            ep.Show();
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
            LoadProducts();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
