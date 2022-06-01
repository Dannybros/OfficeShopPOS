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

namespace OfficePOS
{
    public partial class SupplyItemInfo : Form
    {
        public static string Amount = "";
        public static double  price;
        private string proId;

        MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=office_db");

        public SupplyItemInfo(string id)
        {
            InitializeComponent();
            getOriginalPrice(id);
            proId = id;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txtAmount.Text = null;
            this.Close();
        }

        private void getOriginalPrice(string id)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT `Original_Price` FROM `products` WHERE `Product_ID`='" + id + "'", conn);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            price = double.Parse(dt.Rows[0]["Original_Price"].ToString());
        }

        private void addOrderDetail(string orderID, string productID, double total)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `import_details`(`Order_ID`, `Product_ID`, `Original_Price`, `Amount`, `Total_Price`) VALUES (@orderID, @productID, @price @amount, @total)", conn);

            cmd.Parameters.AddWithValue("@orderID", "de");
            cmd.Parameters.AddWithValue("@productID", "ss");
            cmd.Parameters.AddWithValue("@price", 2.22);
            cmd.Parameters.AddWithValue("@amount", 1);
            cmd.Parameters.AddWithValue("@total", 3.33);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(int.Parse(txtAmount.Text) > 0)
            {
                Amount = txtAmount.Text;
                var sp = Application.OpenForms.OfType<SupplyProduct>().Single();
                double total = price * double.Parse(Amount);

                addOrderDetail(sp.Order_ID, proId, total);

                sp.LoadOrderList();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter greater than 0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
