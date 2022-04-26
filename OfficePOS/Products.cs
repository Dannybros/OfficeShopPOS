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
    public partial class Products : UserControl
    {
        public Products()
        {
            InitializeComponent();
            label1.Focus();
            cmbCategory.Text = "All";
        }

        private void popItems()
        {
            PictureBox pic = new PictureBox();
            pic.Width = 200;
            pic.Height = 150;
            pic.BackgroundImageLayout = ImageLayout.Stretch;
            pic.Image = OfficePOS.Properties.Resources.logo;
            pic.Click += new EventHandler(picture_Click);

            Label title = new Label();
            title.Text = "Test";
            title.AutoSize = false;
            title.Dock = DockStyle.Bottom;
            title.Height = 30;
            title.TextAlign = ContentAlignment.MiddleCenter;
            title.Font = new Font("Times news Roman", 12);
            title.BackColor = Color.FromArgb(50, 0, 166, 90);
            title.Click += new EventHandler(title_Click);

            Panel product = new Panel();
            product.Width = 200;
            product.Height = 180;
            var marginproduct = product.Margin;
            marginproduct.Right = 22;
            marginproduct.Left = 22;
            marginproduct.Top = 30;
            marginproduct.Bottom = 30;
            product.Margin = marginproduct;
            product.Tag = title.Text;
            product.Controls.Add(pic);
            product.Controls.Add(title);

            panelDisplayItems.Controls.Add(product);
        }

        private void Products_Load(object sender, EventArgs e)
        {
            for (var i = 0; i < 20; i++)
            { 
                popItems();
            }
        }

        private void picture_Click(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

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
        }
    }
}
