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
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            foreach(TextBox text in product_Info.Controls.OfType<TextBox>()) {text.Text = "";}
            combo_type.Text = "";
            product_image.Image = null;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            txt_id.Text = Inventory.SingleProductID;
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                product_image.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
