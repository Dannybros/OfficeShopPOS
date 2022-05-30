
namespace OfficePOS
{
    partial class SaleForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.lblSaleReport = new System.Windows.Forms.Label();
            this.lblSale = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(77)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.lblCustomerInfo);
            this.panelMenu.Controls.Add(this.lblSaleReport);
            this.panelMenu.Controls.Add(this.lblSale);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1221, 68);
            this.panelMenu.TabIndex = 19;
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.AutoSize = true;
            this.lblCustomerInfo.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInfo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCustomerInfo.Location = new System.Drawing.Point(54, 16);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(118, 35);
            this.lblCustomerInfo.TabIndex = 2;
            this.lblCustomerInfo.Text = "ຂໍ້ມູນລູກຄ້າ";
            this.lblCustomerInfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSaleReport
            // 
            this.lblSaleReport.AutoSize = true;
            this.lblSaleReport.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleReport.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSaleReport.Location = new System.Drawing.Point(580, 16);
            this.lblSaleReport.Name = "lblSaleReport";
            this.lblSaleReport.Size = new System.Drawing.Size(225, 35);
            this.lblSaleReport.TabIndex = 1;
            this.lblSaleReport.Text = "ລາຍງານການຂາຍສິນຄ້າ";
            this.lblSaleReport.Click += new System.EventHandler(this.lblSaleReport_Click);
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Font = new System.Drawing.Font("Phetsarath OT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSale.Location = new System.Drawing.Point(330, 16);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(109, 35);
            this.lblSale.TabIndex = 0;
            this.lblSale.Text = "ຂາຍສິນຄ້າ";
            this.lblSale.Click += new System.EventHandler(this.lblSale_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 68);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1221, 606);
            this.panelContent.TabIndex = 20;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Name = "SaleForm";
            this.Size = new System.Drawing.Size(1221, 674);
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblSaleReport;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.Panel panelContent;
    }
}
