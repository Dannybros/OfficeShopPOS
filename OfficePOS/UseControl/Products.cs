﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfficePOS
{
    public partial class Products : UserControl
    {   
        public Products()
        {
            InitializeComponent();

            foreach (Label lbl in panelMenu.Controls.OfType<Label>())
            {
                lbl.Cursor = Cursors.Hand;
                lbl.Click += (s, e) =>
                {
                    foreach (Label label in panelMenu.Controls.OfType<Label>())
                    {
                        label.ForeColor = Color.Gray;
                    };

                    lbl.ForeColor = Color.White;
                };
            }
        }
       
        private void switchPanel(UserControl panel)
        {
            panelContent.Controls.Clear();
            //panel.TopLevel = false;
            panel.Dock = DockStyle.Fill;
            panelContent.Controls.Add(panel);
            panel.Show();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            lblInventory.ForeColor = Color.White;
            Inventory inv = new Inventory();
            switchPanel(inv);
        }

        private void lblInventory_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            switchPanel(inv);

        }

        private void lblProdReport_Click(object sender, EventArgs e)
        {
            Product_Report pr = new Product_Report();
            switchPanel(pr);
        }
    }
}
