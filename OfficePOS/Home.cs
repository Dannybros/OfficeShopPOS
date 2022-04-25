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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            foreach (Label lbl in this.panelMenu.Controls)
            {
                mouseHover(lbl);
            }
        }

        private void mouseHover(Label cont)
        {
            cont.MouseEnter += (s, e) =>
            {
                cont.ForeColor = Color.White;
            };

            cont.MouseLeave += (s, e) =>
            {
                cont.ForeColor = Color.Gray;
            };
        }

    }
}
