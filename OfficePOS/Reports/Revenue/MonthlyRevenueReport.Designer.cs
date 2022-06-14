
namespace OfficePOS
{
    partial class MonthlyRevenueReport
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_clear_cal = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.month_cal = new OfficePOS.MonthCalendar();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btn_clear_cal);
            this.panel3.Controls.Add(this.month_cal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1319, 65);
            this.panel3.TabIndex = 11;
            // 
            // btn_clear_cal
            // 
            this.btn_clear_cal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear_cal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_cal.Location = new System.Drawing.Point(270, 11);
            this.btn_clear_cal.Name = "btn_clear_cal";
            this.btn_clear_cal.Size = new System.Drawing.Size(111, 40);
            this.btn_clear_cal.TabIndex = 8;
            this.btn_clear_cal.Text = "Clear";
            this.btn_clear_cal.UseVisualStyleBackColor = true;
            this.btn_clear_cal.Click += new System.EventHandler(this.btn_clear_cal_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(40);
            this.panel2.Size = new System.Drawing.Size(1319, 676);
            this.panel2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(40, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1235, 592);
            this.dataGridView1.TabIndex = 0;
            // 
            // month_cal
            // 
            this.month_cal.CustomFormat = "MM-yyyy";
            this.month_cal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_cal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.month_cal.Location = new System.Drawing.Point(40, 17);
            this.month_cal.Name = "month_cal";
            this.month_cal.Size = new System.Drawing.Size(200, 30);
            this.month_cal.TabIndex = 7;
            this.month_cal.Value = new System.DateTime(2022, 6, 14, 20, 19, 33, 569);
            this.month_cal.ValueChanged += new System.EventHandler(this.month_cal_ValueChanged);
            // 
            // MonthlyRevenueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 741);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonthlyRevenueReport";
            this.Text = "MonthlyRevenueReport";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MonthCalendar month_cal;
        private System.Windows.Forms.Button btn_clear_cal;
    }
}