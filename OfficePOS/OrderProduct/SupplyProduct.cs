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
    public partial class SupplyProduct : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=office_db");

        public string Order_ID;

        public SupplyProduct()
        {
            InitializeComponent();
            startForm();
        }

        private void startForm()
        {
            LoadProductType();
            LoadSupplier();
            LoadProducts();
            GenerateOrderID();
            cmbCategory.SelectedIndex = 0;
        }

        private void GenerateOrderID()
        {
            StringBuilder sb = new StringBuilder();
            int numGuidsToConcat = (((8 - 1) / 32) + 1);
            for (int i = 1; i <= numGuidsToConcat; i++)
            {
                sb.Append(Guid.NewGuid().ToString("N"));
            }

           Order_ID = "Order-" + sb.ToString(0, 8);
        }

        private void LoadProductType()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT `Product_Type_Name` FROM `product_types`", conn);
            conn.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmbCategory.Items.Add(reader.GetString("Product_Type_Name"));
            }
            conn.Close();
        }

        private void LoadSupplier()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT `Supplier_Name` FROM `suppliers`", conn);
            conn.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmb_supplier.Items.Add(reader.GetString("Supplier_Name"));
            }
            conn.Close();
        }

        public void LoadProducts()
        {
            panelSupplyItems.Controls.Clear();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `products`", conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var dataRow = dt.Rows[i];
                popItems(dataRow["Product_Name"].ToString(), dataRow["Product_ID"].ToString(), (double)dataRow["Original_Price"], (byte[])dataRow["Product_Img"]);
            }
        }

        private void popItems(string name, string ID, double price, byte[] picArray)
        {
            PictureBox pic = new PictureBox();
            MemoryStream ms = new MemoryStream(picArray);
            pic.BackgroundImage = Image.FromStream(ms);
            pic.Width = 150;
            pic.Height = 120;
            pic.BackgroundImageLayout = ImageLayout.Stretch;
            pic.Click += new EventHandler(picture_Click);
            pic.Tag = ID + "/" + price.ToString();

            Label title = new Label();
            title.Text = name;
            title.Tag = ID + "/" + price.ToString();
            title.AutoSize = false;
            title.Dock = DockStyle.Bottom;
            title.Height = 30;
            title.TextAlign = ContentAlignment.MiddleCenter;
            title.Font = new Font("Times news Roman", 12);
            title.BackColor = Color.FromArgb(50, 0, 166, 90);
            title.Click += new EventHandler(title_Click);

            Panel product = new Panel();
            product.Width = 150;
            product.Height = 150;
            var marginproduct = product.Margin;
            marginproduct.Right = 20;
            marginproduct.Left = 20;
            marginproduct.Top = 20;
            marginproduct.Bottom = 20;
            product.Margin = marginproduct;
            product.Controls.Add(pic);
            product.Controls.Add(title);

            panelSupplyItems.Controls.Add(product);
        }

        private void picture_Click(object sender, EventArgs e)
        {
            string parameters = ((PictureBox)sender).Tag.ToString();
            string id = parameters.Split('/')[0];
            double price = double.Parse(parameters.Split('/')[1]);

            insertOrderDetail(id, price);
        }

        private void title_Click(object sender, EventArgs e)
        {
            string parameters = ((Label)sender).Tag.ToString();
            string id = parameters.Split('/')[0];
            double price = double.Parse(parameters.Split('/')[1]);

            insertOrderDetail(id, price);
        }

        private void insertOrderDetail(string proId, double price)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `import_details`(`Order_ID`, `Product_ID`, `Original_Price`, `Amount`, `Total_Price`) VALUES (@orderId, @proId, @price, @amount, @total)", conn);
            cmd.Parameters.AddWithValue("@orderId", Order_ID);
            cmd.Parameters.AddWithValue("@proId", proId);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@amount", 1);
            cmd.Parameters.AddWithValue("@total", price);

            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                LoadOrderList();
            }
            
            conn.Close();

        }

        public void LoadOrderList()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `import_details` NATURAL JOIN `products` WHERE `Order_ID` = '"+Order_ID+"'", conn);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var dataRow = dt.Rows[i];
                addOrderListToPanel(dataRow["Product_ID"].ToString(), dataRow["Product_Name"].ToString(), dataRow["Amount"].ToString(), (byte[])dataRow["Product_Img"]);
            }
        }

        private void addOrderListToPanel(string proID, string name, string quantity, byte[] picArray)
        {
            FlowLayoutPanel orderPanel = new FlowLayoutPanel();
            orderPanel.Width = panelSupplyList.Width - 5;
            orderPanel.Height = 70;
            orderPanel.Dock = DockStyle.Top;
            orderPanel.BorderStyle = BorderStyle.FixedSingle;
            orderPanel.Padding = new Padding(0, 0, 0, 0);

            PictureBox picOrder = new PictureBox();
            picOrder.Size = new Size(100, 60);
            MemoryStream ms = new MemoryStream(picArray);
            picOrder.BackgroundImage = Image.FromStream(ms);
            picOrder.BackgroundImageLayout = ImageLayout.Stretch;
            picOrder.Dock = DockStyle.Left;
            orderPanel.Controls.Add(picOrder);

            Label title = new Label();
            title.Text = name;
            title.Tag = proID;
            title.Font = new Font("Times new Roman", 14, FontStyle.Regular);
            title.AutoSize = false;
            title.Width = 150;
            title.Height = 70;
            var titleMargin = title.Margin;
            titleMargin.Left = 20;
            titleMargin.Right = 10;
            title.Margin = titleMargin;
            title.TextAlign = ContentAlignment.MiddleCenter;
            orderPanel.Controls.Add(title);

            PictureBox picLess = new PictureBox();
            picLess.Size = new Size(25, 25);
            picLess.Cursor = Cursors.Hand;
            var picLessMargin = picLess.Margin;
            picLessMargin.Top = 20;
            picLessMargin.Bottom = 20;
            picLess.Margin = picLessMargin;
            picLess.BackgroundImage = OfficePOS.Properties.Resources.less_than_symbol;
            picLess.BackgroundImageLayout = ImageLayout.Stretch;
            orderPanel.Controls.Add(picLess);

            Label amount = new Label();
            amount.Text = quantity;
            amount.Tag = proID;
            amount.Font = new Font("Times new Roman", 14, FontStyle.Bold);
            amount.AutoSize = false;
            amount.Width = 30;
            amount.Height = 30;
            var amountMargin = amount.Margin;
            amountMargin.Left = 5;
            amountMargin.Right = 5;
            amountMargin.Top = 20;
            amountMargin.Bottom = 20;
            amount.Margin = amountMargin;
            amount.TextAlign = ContentAlignment.MiddleCenter;
            orderPanel.Controls.Add(amount);

            PictureBox picGreat = new PictureBox();
            picGreat.Size = new Size(25, 25);
            picGreat.Cursor = Cursors.Hand;
            var picGreatMargin = picGreat.Margin;
            picGreatMargin.Top = 20;
            picGreatMargin.Bottom = 20;
            picGreat.Margin = picGreatMargin;
            picGreat.BackgroundImage = OfficePOS.Properties.Resources.greater_than_symbol;
            picGreat.BackgroundImageLayout = ImageLayout.Stretch;
            orderPanel.Controls.Add(picGreat);

            PictureBox picDel = new PictureBox();
            picDel.Cursor = Cursors.Hand;
            picDel.Size = new Size(30, 30);
            picDel.Tag = proID;
            picDel.Dock = DockStyle.Right;
            var picDelMargin = picGreat.Margin;
            picDelMargin.Top = 20;
            picDelMargin.Left = 30;
            picDelMargin.Bottom = 20;
            picDel.Margin = picDelMargin;
            picDel.BackgroundImage = OfficePOS.Properties.Resources.delete;
            picDel.BackgroundImageLayout = ImageLayout.Stretch;
            orderPanel.Controls.Add(picDel);

            panelSupplyList.Controls.Add(orderPanel);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.Show();
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
        }
    }
}
