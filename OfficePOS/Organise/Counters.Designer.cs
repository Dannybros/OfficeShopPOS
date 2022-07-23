
namespace OfficePOS
{
    partial class Counters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Counters));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.txt_counter = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picSearchIcon = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCounter = new System.Windows.Forms.DataGridView();
            this.txtCounter_ID = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_Del);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.txt_counter);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtCounter_ID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 289);
            this.panel1.TabIndex = 0;
            // 
            // btn_Del
            // 
            this.btn_Del.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Del.FlatAppearance.BorderSize = 0;
            this.btn_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Del.Font = new System.Drawing.Font("Phetsarath OT", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Del.Location = new System.Drawing.Point(592, 156);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(130, 39);
            this.btn_Del.TabIndex = 63;
            this.btn_Del.Text = "ລຶບ";
            this.btn_Del.UseVisualStyleBackColor = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Phetsarath OT", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_add.Location = new System.Drawing.Point(262, 156);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(130, 39);
            this.btn_add.TabIndex = 62;
            this.btn_add.Text = "ບັນທຶກ";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Phetsarath OT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(58, 58);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(160, 48);
            this.Label2.TabIndex = 61;
            this.Label2.Text = "ຊື່ຫົວໜ່ວຍ:";
            // 
            // txt_counter
            // 
            this.txt_counter.BackColor = System.Drawing.Color.White;
            this.txt_counter.Font = new System.Drawing.Font("Phetsarath OT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_counter.ForeColor = System.Drawing.Color.Black;
            this.txt_counter.Location = new System.Drawing.Point(262, 48);
            this.txt_counter.Margin = new System.Windows.Forms.Padding(4);
            this.txt_counter.Name = "txt_counter";
            this.txt_counter.Size = new System.Drawing.Size(584, 66);
            this.txt_counter.TabIndex = 60;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(77)))));
            this.panel3.Controls.Add(this.picSearchIcon);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 218);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1203, 69);
            this.panel3.TabIndex = 0;
            // 
            // picSearchIcon
            // 
            this.picSearchIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picSearchIcon.BackColor = System.Drawing.Color.White;
            this.picSearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("picSearchIcon.Image")));
            this.picSearchIcon.Location = new System.Drawing.Point(209, 22);
            this.picSearchIcon.Name = "picSearchIcon";
            this.picSearchIcon.Size = new System.Drawing.Size(23, 24);
            this.picSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearchIcon.TabIndex = 3;
            this.picSearchIcon.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(39, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 30);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Search...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCounter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 289);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(40, 20, 40, 40);
            this.panel2.Size = new System.Drawing.Size(1205, 373);
            this.panel2.TabIndex = 1;
            // 
            // dgvCounter
            // 
            this.dgvCounter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCounter.Location = new System.Drawing.Point(40, 20);
            this.dgvCounter.Name = "dgvCounter";
            this.dgvCounter.RowHeadersWidth = 51;
            this.dgvCounter.RowTemplate.Height = 24;
            this.dgvCounter.Size = new System.Drawing.Size(1125, 313);
            this.dgvCounter.TabIndex = 0;
            this.dgvCounter.Click += new System.EventHandler(this.dgvCounter_Click);
            // 
            // txtCounter_ID
            // 
            this.txtCounter_ID.Location = new System.Drawing.Point(725, 91);
            this.txtCounter_ID.Name = "txtCounter_ID";
            this.txtCounter_ID.Size = new System.Drawing.Size(100, 22);
            this.txtCounter_ID.TabIndex = 64;
            this.txtCounter_ID.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(424, 156);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(136, 40);
            this.btn_cancel.TabIndex = 65;
            this.btn_cancel.Text = "ຍົກເລີກ";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Counters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 662);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Counters";
            this.Text = "Counters";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCounter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvCounter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picSearchIcon;
        private System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txt_counter;
        internal System.Windows.Forms.Button btn_Del;
        internal System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtCounter_ID;
        internal System.Windows.Forms.Button btn_cancel;
    }
}