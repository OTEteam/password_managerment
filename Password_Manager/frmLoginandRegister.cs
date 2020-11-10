using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class frmLoginandRegister : Form
    {
        public frmLoginandRegister()
        {
            InitializeComponent();
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoginPage_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        private void btnRegisterPage_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtLoginPassword_TextChanged(object sender, EventArgs e)
        {
            txtLoginPassword.UseSystemPasswordChar = true;
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmOTP otp = new frmOTP();
            otp.Show();
        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
