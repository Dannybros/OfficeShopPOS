using System;
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
    public partial class ErrorMsg : Form
    {
        public ErrorMsg(string title, string des)
        {
            InitializeComponent();
            label1.Text = title;
            label1.Text = des;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
