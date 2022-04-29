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
    public partial class SupplyProducts : UserControl
    {
        public SupplyProducts()
        {
            InitializeComponent();

            for(var i= 0; i<10; i++)
            {
                popItems(i.ToString());
            }
        }
        private void popItems(string i)
        {
            PictureBox pic = new PictureBox();
            pic.Width = 150;
            pic.Height = 120;
            pic.BackgroundImageLayout = ImageLayout.Stretch;
            pic.BackgroundImage = OfficePOS.Properties.Resources.download;
            pic.Click += new EventHandler(picture_Click);
            pic.Tag = i;

            Label title = new Label();
            title.Text = i;
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
            SupplyItemInfo siinfo = new SupplyItemInfo();
            siinfo.Show();
        }

        private void title_Click(object sender, EventArgs e)
        {
            SupplyItemInfo siinfo = new SupplyItemInfo();
            siinfo.Show();

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.Show();
        }
    }
}
