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
    public partial class frmLogin2 : Form
    {
        public frmLogin2()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
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

        private void lblCloseLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblCloseRegister_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmOTP otp = new frmOTP();
            otp.Show();
        }
    }
}
