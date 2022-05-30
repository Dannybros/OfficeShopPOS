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

namespace OfficePOS
{
    public partial class Revenue : UserControl
    {
        public Revenue()
        {
            InitializeComponent();
            addPanels();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            chartSetting();
        }

        private void chartSetting()
        {
            Title title = new Title();
            title.Font = new Font("Phetsarath OT", 24, FontStyle.Bold);
            title.Alignment = ContentAlignment.TopLeft;
            title.Text = "ການຂາຍສໍາລັບອາທິດນີ້";
            chart1.Titles.Add(title);

            chart1.ChartAreas[0].AxisX.IsMarginVisible = false;

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;

            chart1.ChartAreas[0].AxisX.LineColor = Color.Black;
            chart1.ChartAreas[0].AxisY.LineColor = Color.Black;
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

            panel.Width = (panelDashboard.Width - 20)/ 3;
            panel.Height = 150;
            panel.Padding = new Padding(20, 20, 20, 20);
            var margin = panel.Margin;
            margin.Top = 40;
            margin.Right = 40;
            margin.Left = 40;
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

            Label content = new Label() { Text = mainNumber};
            content.Font = new Font("Times New Roman", 22, FontStyle.Bold);
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
            addLabel(p1, "ລາຍ​ຮັບ​ສໍາ​ລັບ​ອາ​ທິດ​", "3,000,000 KIP", "ລາຄາລວມຂອງສິນຄ້າທີ່ຂາຍໃນອາທິດນີ້");

            createPanel(p2, Color.FromArgb(167, 42, 43));
            addLabel(p2, "ລາຍຈ່າຍສິນຄ້າ", "1,000,000 KIP", "ລາຄາລວມຂອງສິນຄ້າທີ່ສັ່ງຊື້ໃນອາທິດນີ້");

            createPanel(p3, Color.FromArgb(254, 178, 8));
            addLabel(p3, "ລາຍຈ່າຍພະນັກງານ", "500,000 KIP", "ລາຍຈ່າຍທັງໝົດຂອງຂອງເງິນເດືອນພະນັກງານ");
        }

    }
}
