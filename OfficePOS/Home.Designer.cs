
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
            this.activePanel = new System.Windows.Forms.Panel();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelIntro = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.SideBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelIntro.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SideBar.Controls.Add(this.panelMenu);
            this.SideBar.Controls.Add(this.pictureBox1);
            this.SideBar.Controls.Add(this.panelLogo);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(380, 785);
            this.SideBar.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.activePanel);
            this.panelMenu.Controls.Add(this.lblProducts);
            this.panelMenu.Controls.Add(this.lblHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 209);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(378, 574);
            this.panelMenu.TabIndex = 2;
            // 
            // activePanel
            // 
            this.activePanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.activePanel.Location = new System.Drawing.Point(-1, 0);
            this.activePanel.Name = "activePanel";
            this.activePanel.Size = new System.Drawing.Size(13, 76);
            this.activePanel.TabIndex = 2;
            // 
            // lblProducts
            // 
            this.lblProducts.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.ForeColor = System.Drawing.Color.Gray;
            this.lblProducts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblProducts.Location = new System.Drawing.Point(2, 76);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Padding = new System.Windows.Forms.Padding(10);
            this.lblProducts.Size = new System.Drawing.Size(375, 73);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "Manage Products";
            this.lblProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHome
            // 
            this.lblHome.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.Gray;
            this.lblHome.Location = new System.Drawing.Point(2, 3);
            this.lblHome.Name = "lblHome";
            this.lblHome.Padding = new System.Windows.Forms.Padding(10);
            this.lblHome.Size = new System.Drawing.Size(375, 73);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Dashboard";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OfficePOS.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelLogo
            // 
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(378, 209);
            this.panelLogo.TabIndex = 1;
            // 
            // panelIntro
            // 
            this.panelIntro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(94)))), ((int)(((byte)(215)))));
            this.panelIntro.Controls.Add(this.label1);
            this.panelIntro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIntro.Location = new System.Drawing.Point(380, 0);
            this.panelIntro.Name = "panelIntro";
            this.panelIntro.Size = new System.Drawing.Size(854, 66);
            this.panelIntro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Office Equipment Management System";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(380, 66);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(854, 719);
            this.panelMain.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 785);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelIntro);
            this.Controls.Add(this.SideBar);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SideBar.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelIntro.ResumeLayout(false);
            this.panelIntro.PerformLayout();
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
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Panel panelMain;
    }
}