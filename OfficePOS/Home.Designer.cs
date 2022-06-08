
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_import = new System.Windows.Forms.Label();
            this.lbl_report = new System.Windows.Forms.Label();
            this.lbl_order_product = new System.Windows.Forms.Label();
            this.lblSale = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.activePanel = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SideBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
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
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.lbl_import);
            this.panelMenu.Controls.Add(this.lbl_report);
            this.panelMenu.Controls.Add(this.lbl_order_product);
            this.panelMenu.Controls.Add(this.lblSale);
            this.panelMenu.Controls.Add(this.lblHome);
            this.panelMenu.Controls.Add(this.activePanel);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 210);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(378, 650);
            this.panelMenu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(11, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ລະບົບຈັດການ ການຂາຍເຄື່ຶອງຮັບໃຊ້ຫ້ອງການ ";
            // 
            // lbl_import
            // 
            this.lbl_import.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_import.ForeColor = System.Drawing.Color.Gray;
            this.lbl_import.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_import.Location = new System.Drawing.Point(125, 333);
            this.lbl_import.Name = "lbl_import";
            this.lbl_import.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_import.Size = new System.Drawing.Size(230, 73);
            this.lbl_import.TabIndex = 12;
            this.lbl_import.Text = "ນຳເຂົ້າສິນຄ້າ";
            this.lbl_import.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_import.Click += new System.EventHandler(this.lbl_import_Click);
            // 
            // lbl_report
            // 
            this.lbl_report.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_report.ForeColor = System.Drawing.Color.Gray;
            this.lbl_report.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_report.Location = new System.Drawing.Point(125, 443);
            this.lbl_report.Name = "lbl_report";
            this.lbl_report.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_report.Size = new System.Drawing.Size(230, 73);
            this.lbl_report.TabIndex = 11;
            this.lbl_report.Text = "ລາຍງານ";
            this.lbl_report.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_report.Click += new System.EventHandler(this.lbl_report_Click);
            // 
            // lbl_order_product
            // 
            this.lbl_order_product.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_product.ForeColor = System.Drawing.Color.Gray;
            this.lbl_order_product.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_order_product.Location = new System.Drawing.Point(125, 223);
            this.lbl_order_product.Name = "lbl_order_product";
            this.lbl_order_product.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_order_product.Size = new System.Drawing.Size(230, 73);
            this.lbl_order_product.TabIndex = 10;
            this.lbl_order_product.Text = "ສັ່ງຊື້ສິນຄ້າ";
            this.lbl_order_product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_order_product.Click += new System.EventHandler(this.lbl_order_product_Click);
            // 
            // lblSale
            // 
            this.lblSale.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.ForeColor = System.Drawing.Color.Gray;
            this.lblSale.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSale.Location = new System.Drawing.Point(125, 113);
            this.lblSale.Name = "lblSale";
            this.lblSale.Padding = new System.Windows.Forms.Padding(10);
            this.lblSale.Size = new System.Drawing.Size(230, 73);
            this.lblSale.TabIndex = 9;
            this.lblSale.Text = "ຂາຍສິນຄ້າ";
            this.lblSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSale.Click += new System.EventHandler(this.lblSale_Click);
            // 
            // lblHome
            // 
            this.lblHome.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.Gray;
            this.lblHome.Location = new System.Drawing.Point(125, 3);
            this.lblHome.Name = "lblHome";
            this.lblHome.Padding = new System.Windows.Forms.Padding(10);
            this.lblHome.Size = new System.Drawing.Size(230, 73);
            this.lblHome.TabIndex = 8;
            this.lblHome.Text = "ຈັດການຂໍ້ມູນ";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
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
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(380, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(934, 862);
            this.panelMain.TabIndex = 2;
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(932, 860);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SideBar.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel activePanel;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lbl_report;
        private System.Windows.Forms.Label lbl_order_product;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lbl_import;
    }
}