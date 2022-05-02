
namespace OfficePOS
{
    partial class Home
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SideBar = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblSecurity = new System.Windows.Forms.Label();
            this.lblImportProduct = new System.Windows.Forms.Label();
            this.lblSale = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.activePanel = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelIntro = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SideBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelIntro.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SideBar.Controls.Add(this.panelMenu);
            this.SideBar.Controls.Add(this.panelLogo);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(380, 862);
            this.SideBar.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.lblSecurity);
            this.panelMenu.Controls.Add(this.lblImportProduct);
            this.panelMenu.Controls.Add(this.lblSale);
            this.panelMenu.Controls.Add(this.lblHome);
            this.panelMenu.Controls.Add(this.lblProducts);
            this.panelMenu.Controls.Add(this.activePanel);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 210);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(378, 650);
            this.panelMenu.TabIndex = 2;
            // 
            // lblSecurity
            // 
            this.lblSecurity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurity.ForeColor = System.Drawing.Color.Gray;
            this.lblSecurity.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSecurity.Location = new System.Drawing.Point(125, 359);
            this.lblSecurity.Name = "lblSecurity";
            this.lblSecurity.Padding = new System.Windows.Forms.Padding(10);
            this.lblSecurity.Size = new System.Drawing.Size(230, 73);
            this.lblSecurity.TabIndex = 11;
            this.lblSecurity.Text = "Security";
            this.lblSecurity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSecurity.Click += new System.EventHandler(this.lblSecurity_Click);
            // 
            // lblImportProduct
            // 
            this.lblImportProduct.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportProduct.ForeColor = System.Drawing.Color.Gray;
            this.lblImportProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblImportProduct.Location = new System.Drawing.Point(125, 270);
            this.lblImportProduct.Name = "lblImportProduct";
            this.lblImportProduct.Padding = new System.Windows.Forms.Padding(10);
            this.lblImportProduct.Size = new System.Drawing.Size(230, 73);
            this.lblImportProduct.TabIndex = 10;
            this.lblImportProduct.Text = "Supplier";
            this.lblImportProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblImportProduct.Click += new System.EventHandler(this.lblImportProduct_Click);
            // 
            // lblSale
            // 
            this.lblSale.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.ForeColor = System.Drawing.Color.Gray;
            this.lblSale.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSale.Location = new System.Drawing.Point(125, 181);
            this.lblSale.Name = "lblSale";
            this.lblSale.Padding = new System.Windows.Forms.Padding(10);
            this.lblSale.Size = new System.Drawing.Size(230, 73);
            this.lblSale.TabIndex = 9;
            this.lblSale.Text = "Sale";
            this.lblSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSale.Click += new System.EventHandler(this.lblSale_Click);
            // 
            // lblHome
            // 
            this.lblHome.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.Gray;
            this.lblHome.Location = new System.Drawing.Point(125, 3);
            this.lblHome.Name = "lblHome";
            this.lblHome.Padding = new System.Windows.Forms.Padding(10);
            this.lblHome.Size = new System.Drawing.Size(230, 73);
            this.lblHome.TabIndex = 8;
            this.lblHome.Text = "Dashboard";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // lblProducts
            // 
            this.lblProducts.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.ForeColor = System.Drawing.Color.Gray;
            this.lblProducts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblProducts.Location = new System.Drawing.Point(125, 93);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Padding = new System.Windows.Forms.Padding(10);
            this.lblProducts.Size = new System.Drawing.Size(230, 73);
            this.lblProducts.TabIndex = 7;
            this.lblProducts.Text = "Products";
            this.lblProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProducts.Click += new System.EventHandler(this.lblProducts_Click);
            // 
            // activePanel
            // 
            this.activePanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.activePanel.Location = new System.Drawing.Point(-1, 0);
            this.activePanel.Name = "activePanel";
            this.activePanel.Size = new System.Drawing.Size(13, 76);
            this.activePanel.TabIndex = 2;
            // 
            // panelLogo
            // 
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(378, 210);
            this.panelLogo.TabIndex = 1;
            // 
            // panelIntro
            // 
            this.panelIntro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelIntro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIntro.Controls.Add(this.label1);
            this.panelIntro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIntro.Location = new System.Drawing.Point(0, 0);
            this.panelIntro.Name = "panelIntro";
            this.panelIntro.Size = new System.Drawing.Size(932, 64);
            this.panelIntro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Office Equipment Management System";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Controls.Add(this.panelIntro);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(380, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(934, 862);
            this.panelMain.TabIndex = 2;
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 64);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(932, 796);
            this.panelContent.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OfficePOS.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(62, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 862);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.SideBar);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SideBar.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelIntro.ResumeLayout(false);
            this.panelIntro.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel panelIntro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel activePanel;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblSecurity;
        private System.Windows.Forms.Label lblImportProduct;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblProducts;
    }
}