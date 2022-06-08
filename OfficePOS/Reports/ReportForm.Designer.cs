
namespace OfficePOS
{
    partial class ReportForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lbl_report_revenue = new System.Windows.Forms.Label();
            this.lbl_report_products = new System.Windows.Forms.Label();
            this.lbl_report_customer = new System.Windows.Forms.Label();
            this.lbl_report_sale = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.lbl_report_revenue);
            this.panelTop.Controls.Add(this.lbl_report_products);
            this.panelTop.Controls.Add(this.lbl_report_customer);
            this.panelTop.Controls.Add(this.lbl_report_sale);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1146, 100);
            this.panelTop.TabIndex = 19;
            // 
            // lbl_report_revenue
            // 
            this.lbl_report_revenue.AutoSize = true;
            this.lbl_report_revenue.Font = new System.Drawing.Font("Phetsarath OT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_report_revenue.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_report_revenue.Location = new System.Drawing.Point(267, 33);
            this.lbl_report_revenue.Name = "lbl_report_revenue";
            this.lbl_report_revenue.Size = new System.Drawing.Size(158, 32);
            this.lbl_report_revenue.TabIndex = 4;
            this.lbl_report_revenue.Text = "ລາຍຮັບ-ລາຍຈ່າຍ";
            this.lbl_report_revenue.Click += new System.EventHandler(this.lbl_report_revenue_Click);
            // 
            // lbl_report_products
            // 
            this.lbl_report_products.AutoSize = true;
            this.lbl_report_products.Font = new System.Drawing.Font("Phetsarath OT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_report_products.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_report_products.Location = new System.Drawing.Point(707, 33);
            this.lbl_report_products.Name = "lbl_report_products";
            this.lbl_report_products.Size = new System.Drawing.Size(64, 32);
            this.lbl_report_products.TabIndex = 3;
            this.lbl_report_products.Text = "ສິນຄ້າ";
            this.lbl_report_products.Click += new System.EventHandler(this.lbl_report_products_Click);
            // 
            // lbl_report_customer
            // 
            this.lbl_report_customer.AutoSize = true;
            this.lbl_report_customer.Font = new System.Drawing.Font("Phetsarath OT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_report_customer.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_report_customer.Location = new System.Drawing.Point(545, 33);
            this.lbl_report_customer.Name = "lbl_report_customer";
            this.lbl_report_customer.Size = new System.Drawing.Size(42, 32);
            this.lbl_report_customer.TabIndex = 1;
            this.lbl_report_customer.Text = "ຄົນ";
            this.lbl_report_customer.Click += new System.EventHandler(this.lbl_report_customer_Click);
            // 
            // lbl_report_sale
            // 
            this.lbl_report_sale.AutoSize = true;
            this.lbl_report_sale.Font = new System.Drawing.Font("Phetsarath OT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_report_sale.ForeColor = System.Drawing.Color.White;
            this.lbl_report_sale.Location = new System.Drawing.Point(58, 33);
            this.lbl_report_sale.Name = "lbl_report_sale";
            this.lbl_report_sale.Size = new System.Drawing.Size(89, 32);
            this.lbl_report_sale.TabIndex = 0;
            this.lbl_report_sale.Text = "ການຂາຍ";
            this.lbl_report_sale.Click += new System.EventHandler(this.lbl_report_sale_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 100);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1146, 551);
            this.panelContent.TabIndex = 21;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 651);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lbl_report_revenue;
        private System.Windows.Forms.Label lbl_report_products;
        private System.Windows.Forms.Label lbl_report_customer;
        private System.Windows.Forms.Label lbl_report_sale;
        private System.Windows.Forms.Panel panelContent;
    }
}