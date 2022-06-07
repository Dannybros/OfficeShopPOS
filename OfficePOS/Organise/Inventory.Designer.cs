
namespace OfficePOS
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.panelDisplayItems = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.panelSearcBox = new System.Windows.Forms.Panel();
            this.picSearchIcon = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelTop.SuspendLayout();
            this.panelCategory.SuspendLayout();
            this.panelSearcBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDisplayItems
            // 
            this.panelDisplayItems.AutoScroll = true;
            this.panelDisplayItems.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDisplayItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisplayItems.Location = new System.Drawing.Point(0, 79);
            this.panelDisplayItems.Name = "panelDisplayItems";
            this.panelDisplayItems.Size = new System.Drawing.Size(1190, 653);
            this.panelDisplayItems.TabIndex = 27;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(77)))));
            this.panelTop.Controls.Add(this.panelCategory);
            this.panelTop.Controls.Add(this.panelSearcBox);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1190, 79);
            this.panelTop.TabIndex = 26;
            // 
            // panelCategory
            // 
            this.panelCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(77)))));
            this.panelCategory.Controls.Add(this.cmbCategory);
            this.panelCategory.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCategory.Location = new System.Drawing.Point(623, 0);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(285, 79);
            this.panelCategory.TabIndex = 1;
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
            this.cmbCategory.Location = new System.Drawing.Point(62, 19);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbCategory.Size = new System.Drawing.Size(164, 42);
            this.cmbCategory.TabIndex = 0;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // panelSearcBox
            // 
            this.panelSearcBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(77)))));
            this.panelSearcBox.Controls.Add(this.picSearchIcon);
            this.panelSearcBox.Controls.Add(this.txtSearch);
            this.panelSearcBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSearcBox.Location = new System.Drawing.Point(908, 0);
            this.panelSearcBox.Name = "panelSearcBox";
            this.panelSearcBox.Size = new System.Drawing.Size(282, 79);
            this.panelSearcBox.TabIndex = 2;
            // 
            // picSearchIcon
            // 
            this.picSearchIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picSearchIcon.BackColor = System.Drawing.Color.White;
            this.picSearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("picSearchIcon.Image")));
            this.picSearchIcon.Location = new System.Drawing.Point(201, 29);
            this.picSearchIcon.Name = "picSearchIcon";
            this.picSearchIcon.Size = new System.Drawing.Size(25, 25);
            this.picSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearchIcon.TabIndex = 1;
            this.picSearchIcon.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(30, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 34);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Search...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDisplayItems);
            this.Controls.Add(this.panelTop);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(1190, 732);
            this.panelTop.ResumeLayout(false);
            this.panelCategory.ResumeLayout(false);
            this.panelSearcBox.ResumeLayout(false);
            this.panelSearcBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelDisplayItems;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Panel panelSearcBox;
        private System.Windows.Forms.PictureBox picSearchIcon;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
