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
    public partial class MonthlyRevenueReport : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=office_db");
        MySqlCommand cmd;

        List<MonthlyRevenue> revenueList = new List<MonthlyRevenue>();

        public MonthlyRevenueReport()
        {
            InitializeComponent();
            getRevenue();
            getExpenditure();
            fillData();
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
            cmd = new MySqlCommand("SELECT sum(Total) AS Revenue, Date FROM `sale` GROUP BY YEAR(Date), MONTH(Date)", conn);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                string monthYear = Convert.ToDateTime(dt.Rows[i]["Date"]).ToString("MM-yyyy");
                double revenue = Convert.ToDouble(dt.Rows[i]["Revenue"]);

                revenueList.Add(new MonthlyRevenue(monthYear, revenue, 0));
            }
        }

        private void getExpenditure()
        {
            cmd = new MySqlCommand("SELECT sum(Total) AS Expenditure, Import_Date FROM `order_imports` GROUP BY YEAR(Import_Date), MONTH(Import_Date)", conn);

            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                string monthYear = Convert.ToDateTime(dt.Rows[i]["Import_Date"]).ToString("MM-yyyy");
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
