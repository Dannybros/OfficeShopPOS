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
using System.Data.SqlClient;

namespace OfficePOS
{
    public partial class Sale : Form
    {
       /* MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=office_db");
        MySqlCommand cmd;*/

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1KL12NM;Initial Catalog=office_db;Integrated Security=True");
        SqlCommand cmd;

        List<SaleItem> SaleItemList = new List<SaleItem>();
        public string Sale_ID;
        private double Total = 0;

        public Sale()
        {
            InitializeComponent();
            startForm();
        }

        private void startForm()
        {
            LoadProductType();
            LoadCustomer();
            LoadEmployee();
            LoadProducts();
            GenerateSaleID();
            cmbCategory.SelectedIndex = 0;
            cmbEmployee.Text = "";
            cmb_customer.Text = "";
        }

        private void GenerateSaleID()
        {
            StringBuilder sb = new StringBuilder();
            int numGuidsToConcat = (((8 - 1) / 32) + 1);
            for (int i = 1; i <= numGuidsToConcat; i++)
            {
                sb.Append(Guid.NewGuid().ToString("N"));
            }

            Sale_ID = "S-" + sb.ToString(0, 8);
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

        private void LoadEmployee()
        {
            cmd = new SqlCommand("SELECT * FROM [employee]", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var dataRow = dt.Rows[i];
                cmbEmployee.Items.Add(dataRow["Employee_Name"].ToString());
            }
        }

        private void LoadCustomer()
        {
            cmd = new SqlCommand("SELECT Customer_Name FROM [customer]", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var dataRow = dt.Rows[i];
                cmb_customer.Items.Add(dataRow["Customer_Name"].ToString());
            }
        }

        public void LoadProducts()
        {
            panelItems.Controls.Clear();

            string searchTerm = "";
            if (txtSearch.Text != "Search...")
            {
                searchTerm = txtSearch.Text;
            }
            if (cmbCategory.Text == "ທັງໝົດ")
            {
                cmd = new SqlCommand("SELECT * FROM [products] WHERE CONCAT (Product_ID, Product_Name) LIKE '%" + searchTerm + "%' AND Quantity > 0", conn);
            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM [products] WHERE CONCAT (Product_ID, Product_Name) LIKE '%" + searchTerm + "%' AND Product_Type_Name = @type AND Quantity > 0", conn);
                cmd.Parameters.AddWithValue("@type", cmbCategory.Text);
            }

            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var dataRow = dt.Rows[i];
                popItems(dataRow["Product_ID"].ToString(), dataRow["Product_Name"].ToString(), dataRow["Quantity"].ToString(), dataRow["Counter_Name"].ToString(), (double)dataRow["Selling_Price"], (byte[])dataRow["Product_Img"]);
            }
        }

        private void enableItem(string s)
        {
            foreach (Panel p in panelItems.Controls.OfType<Panel>())
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
            foreach (Panel p in panelItems.Controls.OfType<Panel>())
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

        private void popItems(string id, string prodTitle, string totalAmount, string counter, double priceTag, byte[] picByte)
        {
            string allTag = id + "/" + priceTag.ToString() + "/" + prodTitle + "/" + totalAmount + "/" + counter;

            PictureBox pic = new PictureBox();
            MemoryStream ms = new MemoryStream(picByte);
            pic.BackgroundImage = Image.FromStream(ms);
            pic.BackColor = Color.White;
            pic.Width = 150;
            pic.Height = 120;
            pic.Cursor = Cursors.Hand;
            pic.BackgroundImageLayout = ImageLayout.Zoom;

            FlowLayoutPanel header = new FlowLayoutPanel();
            header.Width = 150;
            header.Height = 120;
            header.Dock = DockStyle.Top;
            header.BackColor = Color.Transparent;
            header.Click += new EventHandler(flowLayoutPanel_Click);
            header.Tag = allTag;
            pic.Controls.Add(header);

            Label price = new Label();
            price.Text = priceTag.ToString("#,##0") + " K";
            price.Font = new Font("Times news Roman", 10, FontStyle.Regular);
            price.TextAlign = ContentAlignment.MiddleCenter;
            price.BackColor = Color.FromArgb(36, 45, 55);
            price.ForeColor = Color.White;
            var marginPrice = price.Margin;
            marginPrice.Left = -10;
            price.Margin = marginPrice;
            header.Controls.Add(price);

            Label amount = new Label();
            amount.Text = totalAmount + " " + counter;
            var marginAmount = amount.Margin;
            marginAmount.Left = -10;
            amount.Margin = marginAmount;
            amount.Width = 70;
            amount.Font = new Font("Phetsarath OT", 10, FontStyle.Regular);
            amount.TextAlign = ContentAlignment.MiddleCenter;
            amount.BackColor = Color.FromArgb(46, 125, 50);
            amount.ForeColor = Color.White;
            header.Controls.Add(amount);

            Label title = new Label();
            title.Text = prodTitle;
            title.Tag = allTag;
            title.Cursor = Cursors.Hand;
            title.AutoSize = false;
            title.Dock = DockStyle.Bottom;
            title.Height = 30;
            title.TextAlign = ContentAlignment.MiddleCenter;
            title.Font = new Font("Phetsarath OT", 12);
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

            panelItems.Controls.Add(product);
        }

        public void addSaleItem(string id, string name, double price, int amount, int total_quantity)
        {
            SaleItemList.Add(new SaleItem(id, name, price, amount, total_quantity));
            LoadOrderList();
            disenableItem(name);
        }

        private void flowLayoutPanel_Click(object sender, EventArgs e)
        {
            string parameters = ((FlowLayoutPanel)sender).Tag.ToString();
            string id = parameters.Split('/')[0];
            double price = double.Parse(parameters.Split('/')[1]);
            string name = parameters.Split('/')[2];
            int total_quantity = int.Parse(parameters.Split('/')[3]);

            SaleAmount sam = new SaleAmount(id, name, price, total_quantity, this);
            sam.Show();
        }

        private void title_Click(object sender, EventArgs e)
        {
            string parameters = ((Label)sender).Tag.ToString();
            string id = parameters.Split('/')[0];
            double price = double.Parse(parameters.Split('/')[1]);
            string name = parameters.Split('/')[2];
            int total_quantity = int.Parse(parameters.Split('/')[3]);

            SaleAmount sam = new SaleAmount(id, name, price, total_quantity, this);
            sam.Show();
        }

        private void addOrderListToPanel(string proID, string name, double pricer, string quantity)
        {
            FlowLayoutPanel orderPanel = new FlowLayoutPanel();
            orderPanel.Width = panelOrderList.Width - 5;
            orderPanel.Height = 40;
            orderPanel.Dock = DockStyle.Top;
            orderPanel.BorderStyle = BorderStyle.FixedSingle;
            orderPanel.Padding = new Padding(0, 0, 0, 0);

            Label title = new Label();
            title.Text = name;
            title.Font = new Font("Phetsarath OT", 12, FontStyle.Regular);
            title.Width = 140;
            title.Height = 40;
            var titleMargin = title.Margin;
            titleMargin.Left = 20;
            titleMargin.Right = 10;
            title.Margin = titleMargin;
            title.TextAlign = ContentAlignment.MiddleCenter;
            orderPanel.Controls.Add(title);

            PictureBox picLess = new PictureBox();
            picLess.Size = new Size(20, 20);
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
            amount.Width = (orderPanel.Width - 40) / 5;
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

            Label total = new Label();
            total.Text = (pricer * (int.Parse(quantity))).ToString("#,##0");
            total.Font = new Font("Times new Roman", 12, FontStyle.Regular);
            total.Height = 40;
            total.Width = (orderPanel.Width - 40) / 4;
            total.TextAlign = ContentAlignment.MiddleCenter;
            var totalMargin = total.Margin;
            totalMargin.Right = 10;
            total.Margin = totalMargin;
            orderPanel.Controls.Add(total);

            PictureBox picDel = new PictureBox();
            picDel.Cursor = Cursors.Hand;
            picDel.Size = new Size(20, 20);
            picDel.Tag = proID + "/" + name;
            picDel.Dock = DockStyle.Right;
            var picDelMargin = picGreat.Margin;
            picDelMargin.Top = 10;
            picDelMargin.Bottom = 10;
            picDel.Margin = picDelMargin;
            picDel.BackgroundImage = OfficePOS.Properties.Resources.delete;
            picDel.BackgroundImageLayout = ImageLayout.Stretch;
            picDel.Click += new EventHandler(del_order_click);
            orderPanel.Controls.Add(picDel);

            panelOrderList.Controls.Add(orderPanel);
        }

        public void LoadOrderList()
        {
            Total = 0;
            panelOrderList.Controls.Clear();

            foreach (var item in SaleItemList)
            {
                Total += item.Total;
                addOrderListToPanel(item.ProID, item.Name, item.Price, item.Amount.ToString());
            }

            txt_sum_supply.Text =" " + Total.ToString("#,##0");
        }

        private void del_order_click(object sender, EventArgs e)
        {
            string props = ((PictureBox)sender).Tag.ToString();
            string proID = props.Split('/')[0];
            string name = props.Split('/')[1];

            var foundItem = SaleItemList.FirstOrDefault(c => c.ProID == proID);
            SaleItemList.Remove(foundItem);
            LoadOrderList();
            enableItem(name);
        }

        private void decrease_amount_click(object sender, EventArgs e)
        {
            string props = ((PictureBox)sender).Tag.ToString();
            string proID = props.Split('/')[0];
            string name = props.Split('/')[1];

            var foundItem = SaleItemList.FirstOrDefault(c => c.ProID == proID);

            if (foundItem.Amount <= 1)
            {
                SaleItemList.Remove(foundItem);
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

            var foundItem = SaleItemList.FirstOrDefault(c => c.ProID == proID);
            int tempAmount = foundItem.Amount + 1;

            if(foundItem.Total_Quant < tempAmount)
            {
                MessageBox.Show("You reached maxium amount of this product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                foundItem.Amount = tempAmount;
                foundItem.Total = foundItem.Amount * foundItem.Price;
            }

            LoadOrderList();
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
            foreach(var item in SaleItemList)
            {
                disenableItem(item.Name);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            SaleItemList.Clear();
            LoadProducts();
            LoadOrderList();
            cmbEmployee.Text = "";
            cmb_customer.Text = "";
        }

        private void btn_Bill_Click(object sender, EventArgs e)
        {
            if (cmb_customer.Text == "" || cmbEmployee.Text == "")
            {
                MessageBox.Show("Please Choose Customer AND Employee!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn.Open();
                foreach (var item in SaleItemList)
                {
                    insertSaleDetail(item.ProID, item.Name, item.Price, item.Amount, item.Total);
                    updateAmount(item.ProID, item.Amount);
                }
                insertSaleDB();
                conn.Close();
            }
        }

        private void insertSaleDetail(string pId, string name, double price, int amount, double total)
        {
            cmd = new SqlCommand("INSERT INTO [sale_details] (Sale_ID, Product_ID, Product_Name, Price, Amount, Product_Total) VALUES (@saleId, @prodId, @name, @price, @amount, @total)", conn);
            cmd.Parameters.AddWithValue("@saleId", Sale_ID);
            cmd.Parameters.AddWithValue("@prodId", pId);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@total", total);

            cmd.ExecuteNonQuery();
        }

        private void updateAmount(string id, double amount)
        {
            cmd = new SqlCommand("UPDATE [products] SET Quantity=Quantity-@amount WHERE Product_ID=@prodId", conn);
            cmd.Parameters.AddWithValue("@prodId", id);
            cmd.Parameters.AddWithValue("@amount", amount);

            cmd.ExecuteNonQuery();
        }

        private void insertSaleDB()
        {
            cmd = new SqlCommand("INSERT INTO [sale](Sale_ID, Customer_Name, Employee_Name, Total, Paid, Date) VALUES (@saleID, @name, @empName, @total, @paid, @date)", conn);

            cmd.Parameters.AddWithValue("@saleID", Sale_ID);
            cmd.Parameters.AddWithValue("@name", cmb_customer.Text);
            cmd.Parameters.AddWithValue("@empName", cmbEmployee.Text);
            cmd.Parameters.AddWithValue("@total", double.Parse(txt_sum_supply.Text));
            cmd.Parameters.AddWithValue("@paid", double.Parse(txtReceive.Text));
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));

            if (cmd.ExecuteNonQuery() == 1)
            {
                DialogResult result = MessageBox.Show("Sale Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    SaleBillViewer saleViewer = new SaleBillViewer(SaleItemList, Sale_ID, cmb_customer.Text, cmbEmployee.Text, txtChange.Text, txtReceive.Text);
                    saleViewer.Show();

                    SaleItemList.Clear();
                    LoadProducts();
                    LoadOrderList();
                    cmbEmployee.Text = "";
                    cmb_customer.Text = "";

                }
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
            foreach (var item in SaleItemList)
            {
                disenableItem(item.Name);
            }
        }

        private void txtReceive_TextChanged(object sender, EventArgs e)
        {
            if (txtReceive.Text != "")
            {
                double rec = double.Parse(txtReceive.Text);
                txtChange.Text = (rec - Total).ToString("#,##0");
            }
            else
            {
                txtReceive.Text = "0";
                txtChange.Text = "0";
            }
        }

        private void txtReceive_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
