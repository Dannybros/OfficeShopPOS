using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficePOS
{
    public partial class Sale : UserControl
    {
        public Sale()
        {
            InitializeComponent();
            btn_Bill.Focus();
           
        }

        private void popItems()
        {
            PictureBox pic = new PictureBox();
            pic.Width = 150;
            pic.Height = 120;
            pic.BackgroundImageLayout = ImageLayout.Stretch;
            pic.BackgroundImage = OfficePOS.Properties.Resources.download;
            pic.Click += new EventHandler(picture_Click);
            pic.Tag = "Text";

            Label price = new Label();
            price.Text = "$33";
            price.Font = new Font("Times news Roman", 10, FontStyle.Regular);
            price.TextAlign = ContentAlignment.MiddleCenter;
            price.BackColor = Color.IndianRed;
            price.ForeColor = Color.White;
            pic.Controls.Add(price);

            Label title = new Label();
            title.Text = "Test";
            title.Tag = "Test";
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

            panelItems.Controls.Add(product);
        }

        private void addOrderList()
        {
            FlowLayoutPanel orderPanel = new FlowLayoutPanel();
            orderPanel.Width = panelOrderList.Width - 5;
            orderPanel.Height = 70;
            orderPanel.Dock = DockStyle.Top;
            orderPanel.BorderStyle = BorderStyle.FixedSingle;
            orderPanel.Padding = new Padding(0,0,0,0);

            PictureBox picOrder= new PictureBox();
            picOrder.Size = new Size(100, 60);
            picOrder.BackgroundImage = OfficePOS.Properties.Resources.download;
            picOrder.BackgroundImageLayout = ImageLayout.Stretch;
            picOrder.Dock = DockStyle.Left;
            orderPanel.Controls.Add(picOrder);

            Label title = new Label();
            title.Text = "Test dafdf de sxdfadad";
            title.Font = new Font("Times new Roman", 14, FontStyle.Regular);
            title.AutoSize = false;
            title.Width = 150;
            title.Height = 70;
            var titleMargin = title.Margin;
            titleMargin.Left = 20;
            titleMargin.Right =10;
            title.Margin = titleMargin;
            title.TextAlign = ContentAlignment.MiddleCenter;
            orderPanel.Controls.Add(title);

            PictureBox picLess = new PictureBox();
            picLess.Size = new Size(25, 25);
            var picLessMargin = picLess.Margin;
            picLessMargin.Top = 20;
            picLessMargin.Bottom = 20;
            picLess.Margin = picLessMargin;
            picLess.BackgroundImage = OfficePOS.Properties.Resources.less_than_symbol;
            picLess.BackgroundImageLayout = ImageLayout.Stretch;
            orderPanel.Controls.Add(picLess);

            Label amount = new Label();
            amount.Text = "1";
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
            var picGreatMargin = picGreat.Margin;
            picGreatMargin.Top = 20;
            picGreatMargin.Bottom = 20;
            picGreat.Margin = picGreatMargin;
            picGreat.BackgroundImage = OfficePOS.Properties.Resources.greater_than_symbol;
            picGreat.BackgroundImageLayout = ImageLayout.Stretch;
            orderPanel.Controls.Add(picGreat);

            PictureBox picDel = new PictureBox();
            picDel.Size = new Size(30, 30);
            picDel.Dock = DockStyle.Right;
            var picDelMargin = picGreat.Margin;
            picDelMargin.Top = 20;
            picDelMargin.Left = 30;
            picDelMargin.Bottom = 20;
            picDel.Margin = picDelMargin;
            picDel.BackgroundImage = OfficePOS.Properties.Resources.delete;
            picDel.BackgroundImageLayout = ImageLayout.Stretch;
            orderPanel.Controls.Add(picDel);

            panelOrderList.Controls.Add(orderPanel);
        }

        private void picture_Click(object sender, EventArgs e)
        {
            string s = ((PictureBox)sender).Tag.ToString();
            ((PictureBox)sender).Enabled = false;

            addOrderList();
        }

        private void title_Click(object sender, EventArgs e)
        {
            string s = ((Label)sender).Tag.ToString();
            ((Label)sender).Enabled = false;

            addOrderList();

        }

        private void Sale_Load(object sender, EventArgs e)
        {
            for (var i = 0; i < 10; i++)
            {
                popItems();
            }
        }
    }
}
