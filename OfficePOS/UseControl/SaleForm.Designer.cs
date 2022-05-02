
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
            this.lblSaleReport = new System.Windows.Forms.Label();
            this.lblSale = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(77)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.lblSaleReport);
            this.panelMenu.Controls.Add(this.lblSale);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1221, 68);
            this.panelMenu.TabIndex = 19;
            // 
            // lblSaleReport
            // 
            this.lblSaleReport.AutoSize = true;
            this.lblSaleReport.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleReport.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSaleReport.Location = new System.Drawing.Point(580, 21);
            this.lblSaleReport.Name = "lblSaleReport";
            this.lblSaleReport.Size = new System.Drawing.Size(133, 26);
            this.lblSaleReport.TabIndex = 1;
            this.lblSaleReport.Text = "Sale Report";
            this.lblSaleReport.Click += new System.EventHandler(this.lblSaleReport_Click);
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.ForeColor = System.Drawing.Color.White;
            this.lblSale.Location = new System.Drawing.Point(58, 21);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(144, 26);
            this.lblSale.TabIndex = 0;
            this.lblSale.Text = "Sale Product";
            this.lblSale.Click += new System.EventHandler(this.lblSale_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 68);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1221, 606);
            this.panelContent.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(310, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Info";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label1;
    }
}
