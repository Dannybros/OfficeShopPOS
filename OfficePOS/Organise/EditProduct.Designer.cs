
namespace OfficePOS
{
    partial class EditProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.product_Info = new System.Windows.Forms.Panel();
            this.txt_production_date = new System.Windows.Forms.DateTimePicker();
            this.txtExpire_date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.lblExpire = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Brand = new System.Windows.Forms.TextBox();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txt_origin_price = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.combo_type = new System.Windows.Forms.ComboBox();
            this.product_image = new System.Windows.Forms.PictureBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txt_selling_price = new System.Windows.Forms.TextBox();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.product_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.product_Info);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 595);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Del);
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 493);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1143, 102);
            this.panel2.TabIndex = 24;
            // 
            // btn_Del
            // 
            this.btn_Del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Del.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Del.FlatAppearance.BorderSize = 0;
            this.btn_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Del.Font = new System.Drawing.Font("Phetsarath OT", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Del.Location = new System.Drawing.Point(521, 32);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(130, 39);
            this.btn_Del.TabIndex = 29;
            this.btn_Del.Text = "ລຶບ";
            this.btn_Del.UseVisualStyleBackColor = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Phetsarath OT", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(744, 32);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(130, 39);
            this.btn_cancel.TabIndex = 28;
            this.btn_cancel.Text = "ຍົກເລີກ";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Phetsarath OT", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_add.Location = new System.Drawing.Point(963, 32);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(130, 39);
            this.btn_add.TabIndex = 27;
            this.btn_add.Text = "ບັນທຶກ";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // product_Info
            // 
            this.product_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.product_Info.Controls.Add(this.txt_production_date);
            this.product_Info.Controls.Add(this.txtExpire_date);
            this.product_Info.Controls.Add(this.label8);
            this.product_Info.Controls.Add(this.lblExpire);
            this.product_Info.Controls.Add(this.panel4);
            this.product_Info.Controls.Add(this.label5);
            this.product_Info.Controls.Add(this.label7);
            this.product_Info.Controls.Add(this.txt_Brand);
            this.product_Info.Controls.Add(this.txt_weight);
            this.product_Info.Controls.Add(this.label6);
            this.product_Info.Controls.Add(this.panel3);
            this.product_Info.Controls.Add(this.lblAmount);
            this.product_Info.Controls.Add(this.Label2);
            this.product_Info.Controls.Add(this.Label4);
            this.product_Info.Controls.Add(this.txt_origin_price);
            this.product_Info.Controls.Add(this.Label3);
            this.product_Info.Controls.Add(this.txt_id);
            this.product_Info.Controls.Add(this.combo_type);
            this.product_Info.Controls.Add(this.product_image);
            this.product_Info.Controls.Add(this.txt_amount);
            this.product_Info.Controls.Add(this.btn_upload);
            this.product_Info.Controls.Add(this.Label1);
            this.product_Info.Controls.Add(this.txt_selling_price);
            this.product_Info.Controls.Add(this.txt_productName);
            this.product_Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.product_Info.ForeColor = System.Drawing.Color.White;
            this.product_Info.Location = new System.Drawing.Point(0, 0);
            this.product_Info.Name = "product_Info";
            this.product_Info.Size = new System.Drawing.Size(1143, 493);
            this.product_Info.TabIndex = 23;
            // 
            // txt_production_date
            // 
            this.txt_production_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_production_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_production_date.Location = new System.Drawing.Point(493, 432);
            this.txt_production_date.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.txt_production_date.Name = "txt_production_date";
            this.txt_production_date.Size = new System.Drawing.Size(209, 30);
            this.txt_production_date.TabIndex = 68;
            // 
            // txtExpire_date
            // 
            this.txtExpire_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpire_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtExpire_date.Location = new System.Drawing.Point(877, 430);
            this.txtExpire_date.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.txtExpire_date.Name = "txtExpire_date";
            this.txtExpire_date.Size = new System.Drawing.Size(212, 30);
            this.txtExpire_date.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(342, 432);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 29);
            this.label8.TabIndex = 66;
            this.label8.Text = "ວັນ​ທີ​ຜະລິດຕະພັນ:";
            // 
            // lblExpire
            // 
            this.lblExpire.AutoSize = true;
            this.lblExpire.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpire.ForeColor = System.Drawing.Color.White;
            this.lblExpire.Location = new System.Drawing.Point(740, 429);
            this.lblExpire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpire.Name = "lblExpire";
            this.lblExpire.Size = new System.Drawing.Size(115, 29);
            this.lblExpire.TabIndex = 65;
            this.lblExpire.Text = "ວັນ​ທີ​ໝົດ​ອາ​ຍຸ:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(340, 398);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(749, 5);
            this.panel4.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(745, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 29);
            this.label5.TabIndex = 64;
            this.label5.Text = "ຍີ່ຫໍ້:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(341, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 29);
            this.label7.TabIndex = 63;
            this.label7.Text = "ນ້ຳໜັກ:";
            // 
            // txt_Brand
            // 
            this.txt_Brand.BackColor = System.Drawing.Color.White;
            this.txt_Brand.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Brand.ForeColor = System.Drawing.Color.Black;
            this.txt_Brand.Location = new System.Drawing.Point(877, 187);
            this.txt_Brand.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Brand.Name = "txt_Brand";
            this.txt_Brand.Size = new System.Drawing.Size(212, 30);
            this.txt_Brand.TabIndex = 56;
            // 
            // txt_weight
            // 
            this.txt_weight.BackColor = System.Drawing.Color.White;
            this.txt_weight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_weight.ForeColor = System.Drawing.Color.Black;
            this.txt_weight.Location = new System.Drawing.Point(490, 183);
            this.txt_weight.Margin = new System.Windows.Forms.Padding(4);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(212, 30);
            this.txt_weight.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(735, 346);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 29);
            this.label6.TabIndex = 61;
            this.label6.Text = "ລາຄາຊື້:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(340, 321);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(749, 5);
            this.panel3.TabIndex = 53;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(344, 256);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(74, 29);
            this.lblAmount.TabIndex = 60;
            this.lblAmount.Text = "ຈໍາ​ນວນ:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Label2.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(341, 120);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 29);
            this.Label2.TabIndex = 57;
            this.Label2.Text = "ຊື່ສິນຄ້າ:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(341, 349);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(87, 29);
            this.Label4.TabIndex = 59;
            this.Label4.Text = "ລາ​ຄາ​ຂາຍ:";
            // 
            // txt_origin_price
            // 
            this.txt_origin_price.BackColor = System.Drawing.Color.White;
            this.txt_origin_price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_origin_price.ForeColor = System.Drawing.Color.Black;
            this.txt_origin_price.Location = new System.Drawing.Point(877, 349);
            this.txt_origin_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_origin_price.Name = "txt_origin_price";
            this.txt_origin_price.Size = new System.Drawing.Size(212, 30);
            this.txt_origin_price.TabIndex = 51;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(745, 121);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(110, 29);
            this.Label3.TabIndex = 58;
            this.Label3.Text = "ປະເພດສິນຄ້າ:";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.Silver;
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.Black;
            this.txt_id.Location = new System.Drawing.Point(490, 54);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(212, 30);
            this.txt_id.TabIndex = 46;
            // 
            // combo_type
            // 
            this.combo_type.BackColor = System.Drawing.Color.White;
            this.combo_type.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_type.ForeColor = System.Drawing.Color.Black;
            this.combo_type.FormattingEnabled = true;
            this.combo_type.Location = new System.Drawing.Point(877, 121);
            this.combo_type.Margin = new System.Windows.Forms.Padding(4);
            this.combo_type.Name = "combo_type";
            this.combo_type.Size = new System.Drawing.Size(212, 30);
            this.combo_type.TabIndex = 50;
            // 
            // product_image
            // 
            this.product_image.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.product_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.product_image.Location = new System.Drawing.Point(52, 51);
            this.product_image.Name = "product_image";
            this.product_image.Size = new System.Drawing.Size(226, 183);
            this.product_image.TabIndex = 43;
            this.product_image.TabStop = false;
            // 
            // txt_amount
            // 
            this.txt_amount.BackColor = System.Drawing.Color.White;
            this.txt_amount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.ForeColor = System.Drawing.Color.Black;
            this.txt_amount.Location = new System.Drawing.Point(490, 253);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(212, 30);
            this.txt_amount.TabIndex = 49;
            // 
            // btn_upload
            // 
            this.btn_upload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.ForeColor = System.Drawing.Color.Black;
            this.btn_upload.Location = new System.Drawing.Point(52, 241);
            this.btn_upload.Margin = new System.Windows.Forms.Padding(4);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(226, 42);
            this.btn_upload.TabIndex = 44;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(345, 62);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(41, 22);
            this.Label1.TabIndex = 45;
            this.Label1.Text = "ID: ";
            // 
            // txt_selling_price
            // 
            this.txt_selling_price.BackColor = System.Drawing.Color.White;
            this.txt_selling_price.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_selling_price.ForeColor = System.Drawing.Color.Black;
            this.txt_selling_price.Location = new System.Drawing.Point(490, 345);
            this.txt_selling_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_selling_price.Name = "txt_selling_price";
            this.txt_selling_price.Size = new System.Drawing.Size(212, 30);
            this.txt_selling_price.TabIndex = 48;
            // 
            // txt_productName
            // 
            this.txt_productName.BackColor = System.Drawing.Color.White;
            this.txt_productName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productName.ForeColor = System.Drawing.Color.Black;
            this.txt_productName.Location = new System.Drawing.Point(490, 117);
            this.txt_productName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(212, 30);
            this.txt_productName.TabIndex = 47;
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 595);
            this.Controls.Add(this.panel1);
            this.Name = "EditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProduct";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.product_Info.ResumeLayout(false);
            this.product_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Button btn_Del;
        internal System.Windows.Forms.Button btn_cancel;
        internal System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel product_Info;
        private System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txt_Brand;
        internal System.Windows.Forms.TextBox txt_weight;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label lblAmount;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txt_origin_price;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txt_id;
        internal System.Windows.Forms.ComboBox combo_type;
        private System.Windows.Forms.PictureBox product_image;
        internal System.Windows.Forms.TextBox txt_amount;
        internal System.Windows.Forms.Button btn_upload;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txt_selling_price;
        internal System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.DateTimePicker txt_production_date;
        private System.Windows.Forms.DateTimePicker txtExpire_date;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label lblExpire;
    }
}