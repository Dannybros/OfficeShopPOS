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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            refresh();
        }

        private void refresh()
        {
            this.ActiveControl = label3;
            txtUsername.Text = "Username...";
            txtPassword.Text = "Password...";
            txtUsername.ForeColor = Color.Gray;
            txtPassword.ForeColor = Color.Gray;
            txtPassword.UseSystemPasswordChar = false;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username...")
            {
                txtUsername.Text = null;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password...")
            {
                txtPassword.Text = null;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username...";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password...";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.ForeColor = Color.Black;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }
    }
}
