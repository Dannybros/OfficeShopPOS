
namespace OfficePOS
{
    partial class Sale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelItems = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSearchItems = new System.Windows.Forms.Panel();
            this.picSearchIcon = new System.Windows.Forms.PictureBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelOrderList = new System.Windows.Forms.FlowLayoutPanel();
            this.panelOrderTotal = new System.Windows.Forms.Panel();
            this.cmb_customer = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btn_Bill = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_sum_supply = new System.Windows.Forms.TextBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSearchItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).BeginInit();
            this.panel4.SuspendLayout();
            this.panelOrderTotal.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(500, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(164, 30);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Search...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 10);
            this.panel2.TabIndex = 1;
            // 
            // panelItems
            // 
            this.panelItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelItems.Location = new System.Drawing.Point(0, 90);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(688, 564);
            this.panelItems.TabIndex = 1;
            // 
            // panelSearchItems
            // 
            this.panelSearchItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearchItems.Controls.Add(this.picSearchIcon);
            this.panelSearchItems.Controls.Add(this.txtSearch);
            this.panelSearchItems.Controls.Add(this.cmbCategory);
            this.panelSearchItems.Controls.Add(this.panel2);
            this.panelSearchItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchItems.Location = new System.Drawing.Point(0, 0);
            this.panelSearchItems.Name = "panelSearchItems";
            this.panelSearchItems.Size = new System.Drawing.Size(688, 90);
            this.panelSearchItems.TabIndex = 0;
            // 
            // picSearchIcon
            // 
            this.picSearchIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSearchIcon.BackColor = System.Drawing.Color.Transparent;
            this.picSearchIcon.Image = global::OfficePOS.Properties.Resources.search;
            this.picSearchIcon.Location = new System.Drawing.Point(452, 31);
            this.picSearchIcon.Name = "picSearchIcon";
            this.picSearchIcon.Size = new System.Drawing.Size(30, 30);
            this.picSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearchIcon.TabIndex = 4;
            this.picSearchIcon.TabStop = false;
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.White;
            this.cmbCategory.DropDownHeight = 120;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.IntegralHeight = false;
            this.cmbCategory.Items.AddRange(new object[] {
            "ທັງໝົດ"});
            this.cmbCategory.Location = new System.Drawing.Point(28, 27);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbCategory.Size = new System.Drawing.Size(164, 42);
            this.cmbCategory.TabIndex = 3;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(639, 89);
            this.panel4.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 10);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "ລາຍການຂາຍສິນຄ້າ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.ForestGreen;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(639, 12);
            this.panel3.TabIndex = 32;
            // 
            // panelOrderList
            // 
            this.panelOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrderList.Location = new System.Drawing.Point(0, 89);
            this.panelOrderList.Name = "panelOrderList";
            this.panelOrderList.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.panelOrderList.Size = new System.Drawing.Size(639, 308);
            this.panelOrderList.TabIndex = 4;
            // 
            // panelOrderTotal
            // 
            this.panelOrderTotal.Controls.Add(this.label2);
            this.panelOrderTotal.Controls.Add(this.cmb_customer);
            this.panelOrderTotal.Controls.Add(this.panel3);
            this.panelOrderTotal.Controls.Add(this.Label3);
            this.panelOrderTotal.Controls.Add(this.btn_Bill);
            this.panelOrderTotal.Controls.Add(this.btn_Cancel);
            this.panelOrderTotal.Controls.Add(this.txt_sum_supply);
            this.panelOrderTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOrderTotal.Location = new System.Drawing.Point(0, 397);
            this.panelOrderTotal.Name = "panelOrderTotal";
            this.panelOrderTotal.Size = new System.Drawing.Size(639, 255);
            this.panelOrderTotal.TabIndex = 0;
            // 
            // cmb_customer
            // 
            this.cmb_customer.BackColor = System.Drawing.Color.White;
            this.cmb_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_customer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_customer.ForeColor = System.Drawing.Color.Black;
            this.cmb_customer.FormattingEnabled = true;
            this.cmb_customer.Location = new System.Drawing.Point(194, 35);
            this.cmb_customer.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_customer.Name = "cmb_customer";
            this.cmb_customer.Size = new System.Drawing.Size(362, 30);
            this.cmb_customer.TabIndex = 39;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(82, 36);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(74, 29);
            this.Label3.TabIndex = 38;
            this.Label3.Text = "ຊື່ລູກຄ້າ:";
            // 
            // btn_Bill
            // 
            this.btn_Bill.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Bill.FlatAppearance.BorderSize = 0;
            this.btn_Bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bill.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bill.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Bill.Location = new System.Drawing.Point(442, 188);
            this.btn_Bill.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Bill.Name = "btn_Bill";
            this.btn_Bill.Size = new System.Drawing.Size(136, 45);
            this.btn_Bill.TabIndex = 36;
            this.btn_Bill.Text = "ພິມໃບບິນ";
            this.btn_Bill.UseVisualStyleBackColor = false;
            this.btn_Bill.Click += new System.EventHandler(this.btn_Bill_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Cancel.Location = new System.Drawing.Point(67, 188);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(117, 45);
            this.btn_Cancel.TabIndex = 37;
            this.btn_Cancel.Text = "ຍົກເລີກ";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_sum_supply
            // 
            this.txt_sum_supply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sum_supply.BackColor = System.Drawing.SystemColors.InfoText;
            this.txt_sum_supply.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sum_supply.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_sum_supply.Location = new System.Drawing.Point(67, 94);
            this.txt_sum_supply.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sum_supply.Name = "txt_sum_supply";
            this.txt_sum_supply.Size = new System.Drawing.Size(511, 67);
            this.txt_sum_supply.TabIndex = 35;
            this.txt_sum_supply.Text = " 0.00";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panelItems);
            this.panelMenu.Controls.Add(this.panelSearchItems);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(688, 654);
            this.panelMenu.TabIndex = 7;
            // 
            // panelOrder
            // 
            this.panelOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrder.Controls.Add(this.panelOrderList);
            this.panelOrder.Controls.Add(this.panel4);
            this.panelOrder.Controls.Add(this.panelOrderTotal);
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOrder.Location = new System.Drawing.Point(688, 0);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(641, 654);
            this.panelOrder.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(467, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 55);
            this.label2.TabIndex = 40;
            this.label2.Text = "KIP";
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 654);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sale";
            this.panelSearchItems.ResumeLayout(false);
            this.panelSearchItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelOrderTotal.ResumeLayout(false);
            this.panelOrderTotal.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSearchIcon;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel panelItems;
        private System.Windows.Forms.Panel panelSearchItems;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel panelOrderList;
        private System.Windows.Forms.Panel panelOrderTotal;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelOrder;
        internal System.Windows.Forms.ComboBox cmb_customer;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btn_Bill;
        internal System.Windows.Forms.Button btn_Cancel;
        internal System.Windows.Forms.TextBox txt_sum_supply;
        private System.Windows.Forms.Label label2;
    }
}