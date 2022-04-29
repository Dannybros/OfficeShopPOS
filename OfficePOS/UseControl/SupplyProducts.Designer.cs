
namespace OfficePOS
{
    partial class SupplyProducts
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSupplyList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.cmb_supplier = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Bill = new System.Windows.Forms.Button();
            this.txt_sum_supply = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSupplyItems = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSearchItem = new System.Windows.Forms.Panel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelSearchItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelSupplyList);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panelTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(596, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 701);
            this.panel1.TabIndex = 0;
            // 
            // panelSupplyList
            // 
            this.panelSupplyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSupplyList.Location = new System.Drawing.Point(0, 90);
            this.panelSupplyList.Name = "panelSupplyList";
            this.panelSupplyList.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.panelSupplyList.Size = new System.Drawing.Size(632, 346);
            this.panelSupplyList.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(632, 90);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.ForestGreen;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 78);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(630, 10);
            this.panel5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supply List";
            // 
            // panelTotal
            // 
            this.panelTotal.Controls.Add(this.cmb_supplier);
            this.panelTotal.Controls.Add(this.Label3);
            this.panelTotal.Controls.Add(this.panel6);
            this.panelTotal.Controls.Add(this.btn_Cancel);
            this.panelTotal.Controls.Add(this.btn_Bill);
            this.panelTotal.Controls.Add(this.txt_sum_supply);
            this.panelTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTotal.Location = new System.Drawing.Point(0, 436);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(632, 265);
            this.panelTotal.TabIndex = 5;
            // 
            // cmb_supplier
            // 
            this.cmb_supplier.BackColor = System.Drawing.Color.White;
            this.cmb_supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_supplier.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_supplier.ForeColor = System.Drawing.Color.Black;
            this.cmb_supplier.FormattingEnabled = true;
            this.cmb_supplier.Location = new System.Drawing.Point(210, 38);
            this.cmb_supplier.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_supplier.Name = "cmb_supplier";
            this.cmb_supplier.Size = new System.Drawing.Size(362, 30);
            this.cmb_supplier.TabIndex = 34;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(62, 41);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(140, 22);
            this.Label3.TabIndex = 33;
            this.Label3.Text = "Supplier Name: ";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.ForestGreen;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(632, 12);
            this.panel6.TabIndex = 32;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Cancel.Location = new System.Drawing.Point(61, 190);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(117, 45);
            this.btn_Cancel.TabIndex = 31;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_Bill
            // 
            this.btn_Bill.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Bill.FlatAppearance.BorderSize = 0;
            this.btn_Bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bill.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bill.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Bill.Location = new System.Drawing.Point(455, 190);
            this.btn_Bill.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Bill.Name = "btn_Bill";
            this.btn_Bill.Size = new System.Drawing.Size(117, 45);
            this.btn_Bill.TabIndex = 30;
            this.btn_Bill.Text = "Get Bill";
            this.btn_Bill.UseVisualStyleBackColor = false;
            // 
            // txt_sum_supply
            // 
            this.txt_sum_supply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sum_supply.BackColor = System.Drawing.SystemColors.InfoText;
            this.txt_sum_supply.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sum_supply.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_sum_supply.Location = new System.Drawing.Point(61, 105);
            this.txt_sum_supply.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sum_supply.Name = "txt_sum_supply";
            this.txt_sum_supply.Size = new System.Drawing.Size(511, 67);
            this.txt_sum_supply.TabIndex = 23;
            this.txt_sum_supply.Text = " 0.00";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelSupplyItems);
            this.panel2.Controls.Add(this.panelSearchItem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 701);
            this.panel2.TabIndex = 1;
            // 
            // panelSupplyItems
            // 
            this.panelSupplyItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSupplyItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSupplyItems.Location = new System.Drawing.Point(0, 90);
            this.panelSupplyItems.Name = "panelSupplyItems";
            this.panelSupplyItems.Size = new System.Drawing.Size(596, 611);
            this.panelSupplyItems.TabIndex = 3;
            // 
            // panelSearchItem
            // 
            this.panelSearchItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearchItem.Controls.Add(this.btnAddProduct);
            this.panelSearchItem.Controls.Add(this.txtSearch);
            this.panelSearchItem.Controls.Add(this.cmbCategory);
            this.panelSearchItem.Controls.Add(this.panel3);
            this.panelSearchItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchItem.Location = new System.Drawing.Point(0, 0);
            this.panelSearchItem.Name = "panelSearchItem";
            this.panelSearchItem.Size = new System.Drawing.Size(596, 90);
            this.panelSearchItem.TabIndex = 2;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddProduct.Location = new System.Drawing.Point(32, 18);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(132, 45);
            this.btnAddProduct.TabIndex = 31;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(408, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(164, 30);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Search...";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategory.BackColor = System.Drawing.Color.White;
            this.cmbCategory.DropDownHeight = 120;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.IntegralHeight = false;
            this.cmbCategory.Items.AddRange(new object[] {
            "All",
            "Computer",
            "Chair",
            "Desk",
            "Lamp"});
            this.cmbCategory.Location = new System.Drawing.Point(196, 23);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbCategory.Size = new System.Drawing.Size(164, 34);
            this.cmbCategory.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.ForestGreen;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(594, 10);
            this.panel3.TabIndex = 1;
            // 
            // SupplyProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SupplyProducts";
            this.Size = new System.Drawing.Size(1228, 701);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelSearchItem.ResumeLayout(false);
            this.panelSearchItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel panelSupplyItems;
        private System.Windows.Forms.Panel panelSearchItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel panelSupplyList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Panel panel6;
        internal System.Windows.Forms.Button btn_Cancel;
        internal System.Windows.Forms.Button btn_Bill;
        internal System.Windows.Forms.TextBox txt_sum_supply;
        internal System.Windows.Forms.ComboBox cmb_supplier;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnAddProduct;
    }
}
