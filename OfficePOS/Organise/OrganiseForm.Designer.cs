﻿
namespace OfficePOS
{
    partial class OrganiseForm
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_Employee = new System.Windows.Forms.Label();
            this.lbl_supplier = new System.Windows.Forms.Label();
            this.lbl_product = new System.Windows.Forms.Label();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.lbl_counter = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 100);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1390, 504);
            this.panelContent.TabIndex = 20;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.lbl_counter);
            this.panelTop.Controls.Add(this.lbl_category);
            this.panelTop.Controls.Add(this.lbl_Employee);
            this.panelTop.Controls.Add(this.lbl_supplier);
            this.panelTop.Controls.Add(this.lbl_product);
            this.panelTop.Controls.Add(this.lbl_customer);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1390, 100);
            this.panelTop.TabIndex = 19;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Phetsarath OT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_category.Location = new System.Drawing.Point(884, 35);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(123, 32);
            this.lbl_category.TabIndex = 4;
            this.lbl_category.Text = "ປະເພດສິນຄ້າ";
            this.lbl_category.Click += new System.EventHandler(this.lbl_category_Click);
            // 
            // lbl_Employee
            // 
            this.lbl_Employee.AutoSize = true;
            this.lbl_Employee.Font = new System.Drawing.Font("Phetsarath OT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_Employee.Location = new System.Drawing.Point(657, 33);
            this.lbl_Employee.Name = "lbl_Employee";
            this.lbl_Employee.Size = new System.Drawing.Size(101, 32);
            this.lbl_Employee.TabIndex = 3;
            this.lbl_Employee.Text = "ພະນັກງານ";
            this.lbl_Employee.Click += new System.EventHandler(this.lbl_Employee_Click);
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.AutoSize = true;
            this.lbl_supplier.Font = new System.Drawing.Font("Phetsarath OT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supplier.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_supplier.Location = new System.Drawing.Point(435, 33);
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(96, 32);
            this.lbl_supplier.TabIndex = 2;
            this.lbl_supplier.Text = "ຜູ້ສະໜອງ";
            this.lbl_supplier.Click += new System.EventHandler(this.lbl_supplier_Click);
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Font = new System.Drawing.Font("Phetsarath OT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product.ForeColor = System.Drawing.Color.White;
            this.lbl_product.Location = new System.Drawing.Point(53, 33);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(64, 32);
            this.lbl_product.TabIndex = 1;
            this.lbl_product.Text = "ສິນຄ້າ";
            this.lbl_product.Click += new System.EventHandler(this.lbl_product_Click);
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Font = new System.Drawing.Font("Phetsarath OT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_customer.Location = new System.Drawing.Point(243, 33);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(66, 32);
            this.lbl_customer.TabIndex = 0;
            this.lbl_customer.Text = "ລູກຄ້າ";
            this.lbl_customer.Click += new System.EventHandler(this.lbl_customer_Click);
            // 
            // lbl_counter
            // 
            this.lbl_counter.AutoSize = true;
            this.lbl_counter.Font = new System.Drawing.Font("Phetsarath OT", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_counter.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_counter.Location = new System.Drawing.Point(1133, 35);
            this.lbl_counter.Name = "lbl_counter";
            this.lbl_counter.Size = new System.Drawing.Size(142, 32);
            this.lbl_counter.TabIndex = 5;
            this.lbl_counter.Text = "ຫົວໜ່ວຍສິນຄ້າ";
            this.lbl_counter.Click += new System.EventHandler(this.lbl_counter_Click);
            // 
            // OrganiseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 604);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrganiseForm";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lbl_supplier;
        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.Label lbl_customer;
        private System.Windows.Forms.Label lbl_Employee;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_counter;
    }
}