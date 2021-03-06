using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace OfficePOS
{
    public partial class GraphicRevenueReport : Form
    {
        //      MYSQL CASE
        /* MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=office_db");
         MySqlCommand cmd;*/

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1KL12NM;Initial Catalog=office_db;Integrated Security=True");
        SqlCommand cmd;

        double Revenue=0, Expenditure=0;

        public GraphicRevenueReport()
        {
            InitializeComponent();
            getMonthlySaleRevenue();
            getMonthlyOrderExpenditure();
            getWeekly();
            addPanels();
        }

        private void RevenueReport_Load(object sender, EventArgs e)
        {
            chartSetting();
        }

        private void chartSetting()
        {
            Title title = new Title();
            title.Font = new Font("Phetsarath OT", 16, FontStyle.Bold);
            title.Alignment = ContentAlignment.TopLeft;
            title.Text = "ການຂາຍໃນ 7 ມື້ທີ່ຜ່ານມາ";
            chart1.Titles.Add(title);

            chart1.ChartAreas[0].AxisX.IsMarginVisible = false;

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;

            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
        }

        private void createPanel(TableLayoutPanel panel, Color color)
        {
            panel.ColumnCount = 1;
            panel.RowCount = 3;
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));

            panel.Width = (panelDashboard.Width - 20) / 3;
            panel.Height = 145;
            panel.Padding = new Padding(20, 20, 20, 20);
            var margin = panel.Margin;
            margin.Top = 20;
            margin.Right = 40;
            margin.Left = 40;
            margin.Bottom = 40;
            panel.ForeColor = Color.White;
            panel.Margin = margin;
            panel.BackColor = color;
            panelDashboard.Controls.Add(panel);
        }

        private void addLabel(TableLayoutPanel p, string t, string mainNumber, string description)
        {
            var title = new Label() { Text = t };
            title.Font = new Font("Phetsarath OT", 15);
            title.AutoSize = true;
            title.Height = p.Height / 3;
            title.TextAlign = ContentAlignment.BottomLeft;
            p.Controls.Add(title);

            Label content = new Label() { Text = mainNumber };
            content.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            content.AutoSize = true;
            content.Height = p.Height / 3;
            content.TextAlign = ContentAlignment.MiddleLeft;
            p.Controls.Add(content);

            Label des = new Label() { Text = description };
            des.Font = new Font("Phetsarath OT", 12);
            des.AutoSize = true;
            des.Height = p.Height / 3;
            des.TextAlign = ContentAlignment.TopLeft;
            p.Controls.Add(des);
        }

        private void addPanels()
        {
            TableLayoutPanel p1 = new TableLayoutPanel();
            TableLayoutPanel p2 = new TableLayoutPanel();
            TableLayoutPanel p3 = new TableLayoutPanel();
            createPanel(p1, Color.FromArgb(11, 94, 215));
            addLabel(p1, "ລາຍຮັບການຂາຍລາຍເດືອນ", Revenue.ToString("#,##0") + " KIP", "ລາຄາລວມຂອງສິນຄ້າທີ່ຂາຍໃນ​ເດືອນນີ້");

            createPanel(p2, Color.FromArgb(167, 42, 43));
            addLabel(p2, "ລາຍຈ່າຍ​ການ​ສັ່ງສິນຄ້າ​ປະ​ຈໍາ​ເດືອນ​", Expenditure.ToString("#,##0") + " KIP", "ລາຄາລວມຂອງສິນຄ້າທີ່ສັ່ງຊື້ໃນ​ເດືອນນີ້");

            createPanel(p3, Color.FromArgb(0, 128, 0));
            addLabel(p3, "ກໍາໄລລາຍເດືອນ", (Revenue - Expenditure).ToString("#,##0")+" KIP", "ນີ້ແມ່ນກໍາໄລປະຈໍາເດືອນຈາກການຂາຍສິນຄ້າ");
        }

        private void getWeekly()
        {
            chart1.Series["Sale"].Points.Clear();

            int thisMonth =Convert.ToInt32( DateTime.Now.Month);
            int thisYear = Convert.ToInt32(DateTime.Now.Year);
            int todayDate = Convert.ToInt32(DateTime.Now.Day);

            cmd = new SqlCommand("SELECT sum(Total) AS Revenue, Date FROM [sale] WHERE CAST(MONTH(Date) AS int)=@month AND CAST(YEAR(Date) AS int)=@year AND CAST(Day(Date) AS int) BETWEEN @date-8 AND @date GROUP BY Date", conn);
            cmd.Parameters.AddWithValue("@month", thisMonth);
            cmd.Parameters.AddWithValue("@year", thisYear);
            cmd.Parameters.AddWithValue("@date", todayDate);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (!HasNull(dt))
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    double revenue = Convert.ToDouble(dt.Rows[i]["Revenue"]);
                    var date = DateTime.Parse(dt.Rows[i]["Date"].ToString());

                    chart1.Series["Sale"].Points.AddXY(date, revenue);
                }
            }
        }

        private void getMonthlySaleRevenue()
        {
            int thisMonth = Convert.ToInt32(DateTime.Now.Month);
            int thisYear = Convert.ToInt32(DateTime.Now.Year);

            cmd = new SqlCommand("SELECT SUM(Total) AS revenue FROM [sale] WHERE CAST(MONTH(Date) AS int)=@month AND Cast(YEAR(Date) AS int)=@year", conn);
            cmd.Parameters.AddWithValue("@month", thisMonth);
            cmd.Parameters.AddWithValue("@year", thisYear);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (!HasNull(dt))
            {
                Revenue = Convert.ToDouble(dt.Rows[0]["revenue"]);
            }

        }

        public bool HasNull(DataTable table)
        {
            foreach (DataColumn column in table.Columns)
            {
                if (table.Rows.OfType<DataRow>().Any(r => r.IsNull(column)))
                    return true;
            }

            return false;
        }

        private void getMonthlyOrderExpenditure()
        {
            int thisMonth = Convert.ToInt32(DateTime.Now.Month);
            int thisYear = Convert.ToInt32(DateTime.Now.Year);

            cmd = new SqlCommand("SELECT sum(Total) AS expenditure FROM [order_imports] WHERE CAST(MONTH(Import_Date) AS int)=@month AND CAST(YEAR(Import_Date) AS int)=@year", conn);
            cmd.Parameters.AddWithValue("@month", thisMonth);
            cmd.Parameters.AddWithValue("@year", thisYear);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (!HasNull(dt))
            {
                Expenditure = Convert.ToDouble(dt.Rows[0]["expenditure"]);
            }
        }

        
    }
}
