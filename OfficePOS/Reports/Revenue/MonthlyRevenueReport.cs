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
using System.Data.SqlClient;

namespace OfficePOS
{
    public partial class MonthlyRevenueReport : Form
    {
        //      MYSQL CASE
        /* MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=office_db");
         MySqlCommand cmd;*/

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1KL12NM;Initial Catalog=office_db;Integrated Security=True");
        SqlCommand cmd;

        List<MonthlyRevenue> revenueList = new List<MonthlyRevenue>();

        public MonthlyRevenueReport()
        {
            InitializeComponent();
            getRevenue();
            getExpenditure();
            fillData();
            month_cal.Value = DateTime.Today;
        }
        private void btn_clear_cal_Click(object sender, EventArgs e)
        {
            month_cal.CustomFormat = " ";
            fillData();
        }

        private void month_cal_ValueChanged(object sender, EventArgs e)
        {
            month_cal.CustomFormat = "MM-yyyy";
            fillData();
        }

        private void fillData()
        {
            dataGridView1.DataSource = null;

            if (month_cal.CustomFormat == "MM-yyyy")
            {
                List<MonthlyRevenue> searchedRevenueList = new List<MonthlyRevenue>();
                string getCal = month_cal.Value.ToString("MM-yyyy");

                foreach (var item in revenueList)
                {
                    if (item.Month == getCal)
                    {
                        searchedRevenueList.Add(item);
                    }
                }

                var source = new BindingSource();
                source.DataSource = searchedRevenueList;
                dataGridView1.DataSource = source;
            }
            if (month_cal.CustomFormat == " ")
            {
                var source = new BindingSource();
                source.DataSource = revenueList;
                dataGridView1.DataSource = source;
            }

            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 12);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void getRevenue()
        {
            //  MYSQL CASE
            //cmd = new MYSqlCommand("SELECT sum(Total) AS Revenue, Date FROM sale GROUP BY YEAR(Date), MONTH(Date)", conn);

            cmd = new SqlCommand("SELECT SUM(TOTAL) AS Revenue, FORMAT(Date, 'MM-yyyy') AS Month FROM [sale] GROUP BY FORMAT(Date, 'MM-yyyy')", conn);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                string monthYear = Convert.ToDateTime(dt.Rows[i]["Month"]).ToString("MM-yyyy");
                double revenue = Convert.ToDouble(dt.Rows[i]["Revenue"]);

                revenueList.Add(new MonthlyRevenue(monthYear, revenue, 0));
            }
        }

        private void getExpenditure()
        {
            cmd = new SqlCommand("SELECT sum(Total) AS Expenditure, FORMAT(Import_Date, 'MM-yyyy') AS Month FROM [order_imports] GROUP BY FORMAT(Import_Date, 'MM-yyyy')", conn);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                string monthYear = Convert.ToDateTime(dt.Rows[i]["Month"]).ToString("MM-yyyy");
                double expenditure = Convert.ToDouble(dt.Rows[i]["Expenditure"]);

                foreach(var item in revenueList)
                {
                    if(item.Month == monthYear)
                    {
                        item.Expenditure = expenditure;
                        item.Profit = item.Revenue - item.Expenditure;
                    }
                }
            }
        }
    }
}
