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
        MySqlCommand cmd;

        List<OrderItem> OrderItemList = new List<OrderItem>();

        public string Order_ID;
        private double Total = 0;

        public SupplyProduct()
        {
            InitializeComponent();
        }
        public void startForm()
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

           Order_ID = "O-" + sb.ToString(0, 8);
        }

        private void LoadProductType()
        {
            cmd = new MySqlCommand("SELECT `Product_Type_Name` FROM `product_types`", conn);
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
            cmd = new MySqlCommand("SELECT `Supplier_Name` FROM `suppliers`", conn);
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

            string searchTerm = "";
            if(txtSearch.Text != "Search...")
            {
                searchTerm = txtSearch.Text;
            }

            if(cmbCategory.Text == "ທັງໝົດ")
            {
                cmd = new MySqlCommand("SELECT * FROM `products` WHERE CONCAT (`Product_ID`,`Product_Name`) LIKE '%" + searchTerm + "%'", conn);
            }
            else
            {
                cmd = new MySqlCommand("SELECT * FROM `products` WHERE CONCAT (`Product_ID`,`Product_Name`) LIKE '%" + searchTerm + "%' AND `Product_Type_Name` = @type", conn);
                cmd.Parameters.AddWithValue("@type", cmbCategory.Text);
            }

            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
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
            pic.BackColor = Color.White;
            pic.Width = 150;
            pic.Height = 120;
            pic.BackgroundImageLayout = ImageLayout.Zoom;
            pic.Click += new EventHandler(picture_Click);
            pic.Tag = ID + "/" + price.ToString() + "/" + name;

            Label title = new Label();
            title.Text = name;
            title.Tag = ID + "/" + price.ToString() + "/" + name;
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
            string name = parameters.Split('/')[2];

            OrderItemList.Add(new OrderItem(id, name, price, 1));
            LoadOrderList();
            disenableItem(name);
        }

        private void title_Click(object sender, EventArgs e)
        {
            string parameters = ((Label)sender).Tag.ToString();
            string id = parameters.Split('/')[0];
            double price = double.Parse(parameters.Split('/')[1]);
            string name =  parameters.Split('/')[2];

            OrderItemList.Add(new OrderItem(id, name, price, 1));
            LoadOrderList();
            disenableItem(name);
        }

        private void enableItem(string s)
        {
            foreach (Panel p in panelSupplyItems.Controls.OfType<Panel>())
            {
                foreach (Label lbl in p.Controls.OfType<Label>())
                {
                    if (lbl.Text == s)
                    {
                        p.Enabled = true;
                    }
                }
            }
        }

        private void disenableItem(string s)
        {
            foreach (Panel p in panelSupplyItems.Controls.OfType<Panel>())
            {
                foreach (Label lbl in p.Controls.OfType<Label>())
                {
                    if (lbl.Text == s)
                    {
                        p.Enabled = false;
                    }
                }
            }
        }

        public void LoadOrderList()
        {
            Total = 0;
            panelSupplyList.Controls.Clear();

            foreach (var item in OrderItemList)
            {
                Total += item.Total;

                addOrderListToPanel(item.ProID, item.Name, item.Amount.ToString());
            }

            txt_sum_supply.Text =" " + Total.ToString("#,##0");
        }

        private void addOrderListToPanel(string proID, string name, string quantity)
        {
            FlowLayoutPanel orderPanel = new FlowLayoutPanel();
            orderPanel.Width = panelSupplyList.Width - 5;
            orderPanel.Height = 40;
            orderPanel.Dock = DockStyle.Top;
            orderPanel.BorderStyle = BorderStyle.FixedSingle;
            orderPanel.Padding = new Padding(0, 0, 0, 0);

            Label Id = new Label();
            Id.Text = proID;
            Id.Font = new Font("Times new Roman", 12, FontStyle.Regular);
            Id.Height = 40;
            Id.Width = (orderPanel.Width-40) / 4;
            var idMargin = Id.Margin;
            idMargin.Left = 20;
            idMargin.Right = 10;
            Id.Margin = idMargin;
            Id.TextAlign = ContentAlignment.MiddleCenter;
            orderPanel.Controls.Add(Id);

            Label title = new Label();
            title.Text = "ເພີ່ມສິນຄ້າໃຫມ່";
            title.Font = new Font("Phetsarath OT", 12, FontStyle.Regular);
            title.AutoSize = false;
            title.Width = (orderPanel.Width - 40) / 4;
            title.Height = 40;
            var titleMargin = title.Margin;
            titleMargin.Right = 10;
            title.Margin = titleMargin;
            title.TextAlign = ContentAlignment.MiddleCenter;
            orderPanel.Controls.Add(title);

            PictureBox picLess = new PictureBox();
            picLess.Size = new Size(20,20);
            picLess.Cursor = Cursors.Hand;
            var picLessMargin = picLess.Margin;
            picLessMargin.Top = 10;
            picLessMargin.Bottom = 10;
            picLess.Margin = picLessMargin;
            picLess.BackgroundImage = OfficePOS.Properties.Resources.less_than_symbol;
            picLess.BackgroundImageLayout = ImageLayout.Stretch;
            picLess.Tag = proID + "/" + name;
            picLess.Click += new EventHandler(decrease_amount_click);
            orderPanel.Controls.Add(picLess);

            Label amount = new Label();
            amount.Text = quantity;
            amount.Font = new Font("Times new Roman", 14, FontStyle.Bold);
            amount.AutoSize = false;
            amount.Width = (orderPanel.Width - 40) / 8; 
            amount.Height = 20;
            var amountMargin = amount.Margin;
            amountMargin.Top = 10;
            amountMargin.Bottom = 10;
            amount.Margin = amountMargin;
            amount.TextAlign = ContentAlignment.MiddleCenter;
            orderPanel.Controls.Add(amount);

            PictureBox picGreat = new PictureBox();
            picGreat.Size = new Size(20, 20);
            picGreat.Cursor = Cursors.Hand;
            var picGreatMargin = picGreat.Margin;
            picGreatMargin.Top = 10;
            picGreatMargin.Bottom = 10;
            picGreat.Margin = picGreatMargin;
            picGreat.BackgroundImage = OfficePOS.Properties.Resources.greater_than_symbol;
            picGreat.BackgroundImageLayout = ImageLayout.Stretch;
            picGreat.Tag = proID;
            picGreat.Click += new EventHandler(increase_amount_click);
            orderPanel.Controls.Add(picGreat);

            PictureBox picDel = new PictureBox();
            picDel.Cursor = Cursors.Hand;
            picDel.Size = new Size(20, 20);
            picDel.Tag = proID + "/" + name;
            picDel.Dock = DockStyle.Right;
            var picDelMargin = picGreat.Margin;
            picDelMargin.Top = 10;
            picDelMargin.Left = 40;
            picDelMargin.Bottom = 10;
            picDel.Margin = picDelMargin;
            picDel.BackgroundImage = OfficePOS.Properties.Resources.delete;
            picDel.BackgroundImageLayout = ImageLayout.Stretch;
            picDel.Click += new EventHandler(del_order_click);
            orderPanel.Controls.Add(picDel);

            panelSupplyList.Controls.Add(orderPanel);
        }

        private void del_order_click(object sender, EventArgs e)
        {
            string props = ((PictureBox)sender).Tag.ToString();
            string proID = props.Split('/')[0];
            string name = props.Split('/')[1];

            var foundItem = OrderItemList.FirstOrDefault(c => c.ProID == proID);
            OrderItemList.Remove(foundItem);
            enableItem(name);
            LoadOrderList();
        }

        private void decrease_amount_click(object sender, EventArgs e)
        {
            string props = ((PictureBox)sender).Tag.ToString();
            string proID = props.Split('/')[0];
            string name = props.Split('/')[1];

            var foundItem = OrderItemList.FirstOrDefault(c => c.ProID == proID); 

            if (foundItem.Amount <= 1)
            {
                OrderItemList.Remove(foundItem);
                enableItem(name);
            }
            else
            {
                foundItem.Amount -= 1;
                foundItem.Total = foundItem.Amount * foundItem.Price;
            }

            LoadOrderList();

        }

        private void increase_amount_click(object sender, EventArgs e)
        {
            string proID = ((PictureBox)sender).Tag.ToString();

            var foundItem = OrderItemList.FirstOrDefault(c => c.ProID == proID);
            foundItem.Amount += 1;
            foundItem.Total = foundItem.Amount * foundItem.Price;

            LoadOrderList();
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
            LoadProducts();
            foreach (var item in OrderItemList)
            {
                disenableItem(item.Name);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            OrderItemList.Clear();
            LoadOrderList();

            foreach (Panel p in panelSupplyItems.Controls.OfType<Panel>())
            {
                p.Enabled = true;
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
            foreach (var item in OrderItemList)
            {
                disenableItem(item.Name);
            }
        }

        private void btn_Bill_Click(object sender, EventArgs e)
        {
            if (cmb_supplier.Text == "")
            {
                MessageBox.Show("Please Choose Supplier!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn.Open();
                foreach(var item in OrderItemList)
                {
                    insertOrderDetailDB(item.ProID, item.Name, item.Price, item.Amount, item.Total);
                }

                insertOrderDB();

                conn.Close();
            }
        }

        private void insertOrderDetailDB(string pId, string name, double price, int amount, double total)
        {
            cmd = new MySqlCommand("INSERT INTO `import_details`(`Order_ID`, `Product_ID`, `Product_Name`, `Original_Price`, `Amount`, `Total_Price`) VALUES (@orderId, @prodId, @name, @price, @amount, @total)", conn);
            cmd.Parameters.AddWithValue("@orderId", Order_ID);
            cmd.Parameters.AddWithValue("@prodId", pId);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@total", total);

            cmd.ExecuteNonQuery();
        }

        private void insertOrderDB()
        {
            cmd = new MySqlCommand("INSERT INTO `order_imports`(`Order_ID`, `Supplier_Name`, `Import_Date`, `Total`, `Checked`) VALUES (@orderId, @supplier, @date, @total, @check)", conn);

            cmd.Parameters.AddWithValue("@orderId", Order_ID);
            cmd.Parameters.AddWithValue("@supplier", cmb_supplier.Text);
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("MM/dd/yyyy"));
            cmd.Parameters.AddWithValue("@total", double.Parse(txt_sum_supply.Text));
            cmd.Parameters.AddWithValue("@check", "ຍັງບໍ່ກວດ");

            if (cmd.ExecuteNonQuery() == 1)
            {
               DialogResult result =  MessageBox.Show("Ordered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(result == DialogResult.OK)
                {
                    OrderBillViewer obw = new OrderBillViewer(OrderItemList, Order_ID, cmb_supplier.Text);
                    obw.Show();
                    OrderItemList.Clear();
                    LoadOrderList();

                    foreach (Panel p in panelSupplyItems.Controls.OfType<Panel>())
                    {
                        p.Enabled = true;
                    }
                }
            }
        }

        private void SupplyProduct_Load(object sender, EventArgs e)
        {
            startForm();
        }
    }
}
