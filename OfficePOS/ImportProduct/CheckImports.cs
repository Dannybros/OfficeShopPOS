using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data.SqlClient;

namespace OfficePOS
{
    public partial class CheckImports : Form
    {
        //      MYSQL CASE
       /* MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=office_db");
        MySqlCommand cmd;*/

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1KL12NM;Initial Catalog=office_db;Integrated Security=True");
        SqlCommand cmd;
        List<OrderItem> OrderItemList = new List<OrderItem>();

        private string id, status, total;
        Action fill;

        public CheckImports(string id, string status, string total, Action fillData)
        {
            InitializeComponent();
            fill = fillData;
            this.id = id;
            this.status = status;
            this.total = total;
            loadImports();
        }

        private void loadImports()
        {
            OrderItemList.Clear();
            importListPanel.Controls.Clear();

            cmd = new SqlCommand("SELECT * FROM [import_details] INNER JOIN [products] ON [import_details].Product_ID =[products].Product_ID WHERE Order_ID ='" + id +"'", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);


            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var dataRow = dt.Rows[i];

                OrderItemList.Add(new OrderItem(dataRow["Product_ID"].ToString(), "", 0, Convert.ToInt32(dataRow["Amount"])));

                addImportList(dataRow["Product_Name"].ToString(), dataRow["Product_ID"].ToString(), (double)dataRow["Original_Price"], dataRow["Amount"].ToString(), (double)dataRow["Total_Price"], (byte[])dataRow["Product_Img"]);
            }
        }

        private void addImportList(string name, string proId, double boughtPrice, string quantity, double total_price, byte[] picArray)
        {
            FlowLayoutPanel flp = new FlowLayoutPanel();
            flp.Width = importListPanel.Width -10;
            flp.Height = 80;
            flp.Padding = new Padding(50, 5, 20, 0);
            flp.BorderStyle = BorderStyle.FixedSingle;

            PictureBox pb = new PictureBox();
            MemoryStream ms = new MemoryStream(picArray);
            pb.BackgroundImage = Image.FromStream(ms);
            pb.Width = 80;
            pb.Height = 60;
            pb.BackColor = Color.White;
            pb.BackgroundImageLayout  = ImageLayout.Stretch;
            flp.Controls.Add(pb);

            Label id = new Label();
            id.Text = proId;
            id.AutoSize = false;
            id.Width = (importListPanel.Width) / 6;
            id.Height = flp.Height - 15;
            id.TextAlign = ContentAlignment.MiddleCenter;
            id.Font = new Font("Times news Roman", 12);
            id.ForeColor = Color.White;
            flp.Controls.Add(id);

            Label title = new Label();
            title.Text = name;
            title.AutoSize = false;
            title.Width = (importListPanel.Width)/4 + 10;
            title.Height = flp.Height - 15;
            title.TextAlign = ContentAlignment.MiddleCenter;
            title.Font = new Font("Times news Roman", 12);
            title.ForeColor = Color.White;
            flp.Controls.Add(title);

            Label price = new Label();
            price.Text = boughtPrice.ToString("#,##0") + " KIP";
            price.AutoSize = false;
            price.Width = 150;
            price.Height = flp.Height - 15;
            price.TextAlign = ContentAlignment.MiddleCenter;
            price.Font = new Font("Times news Roman", 12);
            price.ForeColor = Color.White;
            flp.Controls.Add(price);

            Label amount = new Label();
            amount.Text = quantity;
            amount.AutoSize = false;
            amount.Width = 60;
            amount.Height = flp.Height - 15;
            amount.TextAlign = ContentAlignment.MiddleCenter;
            amount.Font = new Font("Times news Roman", 12);
            amount.ForeColor = Color.White;
            flp.Controls.Add(amount);

            Label total = new Label();
            total.Text = total_price.ToString("#,##0") + " Kip";
            total.AutoSize = false;
            total.Width = 150;
            total.Height = flp.Height - 15;
            total.TextAlign = ContentAlignment.MiddleCenter;
            total.Font = new Font("Times news Roman", 12);
            total.ForeColor = Color.White;
            flp.Controls.Add(total);

            importListPanel.Controls.Add(flp);
        }

        private void CheckImports_Load(object sender, EventArgs e)
        {
            lbl_order_ID.Text = id;
            if (status == "ຍັງບໍ່ກວດ") btn_check.Enabled = true;
            else btn_check.Enabled = false;
            lbl_total.Text = (int.Parse(total)).ToString("#,##0") + " KIP";
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            conn.Open();

            UpdateAmount();
            UpdateStatus();

            conn.Close();
        }

        private void UpdateAmount()
        {
            foreach(var item in OrderItemList)
            {
                cmd = new SqlCommand("UPDATE [products] SET Quantity=Quantity+@amount WHERE Product_ID=@prodId", conn);
                cmd.Parameters.AddWithValue("@prodId", item.ProID);
                cmd.Parameters.AddWithValue("@amount", item.Amount);

                cmd.ExecuteNonQuery();
            }
        }

        private void UpdateStatus()
        {
            cmd = new SqlCommand("UPDATE [order_imports] SET Checked=@status WHERE Order_ID='" + id + "'", conn);
            cmd.Parameters.AddWithValue("@status", "ກວດແລ້ວ");

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("You have successfully added new product", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);

                fill.Invoke();

                this.Close();
            }
        }

        private void lbl_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
