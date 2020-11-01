using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class frmResister : Form
    {
        public frmResister()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://opensource.org/licenses/MIT");
        }

        private void frmResister_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string phone = txtPhone.Text;
            try
            {
                FrmManagementLogic.Instance.CreateUser(username, password, phone);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Lỗi rồi");
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsername.Text.Length == 0)
            {
                provider.SetError(txtUsername, "Vui lòng nhập username");
                e.Cancel = true;
            }
            else if (txtUsername.Text.Length > 1000)
            {
                provider.SetError(txtUsername, "username quá dài");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtUsername.Text, "^[a-zA-Z0-9]+$"))
            {
                provider.SetError(txtUsername, "username không bao gồm khoảng trắng và ký tự đặc biệt");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                provider.Clear();
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text.Length == 0)
            {
                provider.SetError(txtPassword, "Mật khẩu không được trống");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                provider.Clear();
            }
        }

        private void txtRePassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text != txtRePassword.Text)
            {
                provider.SetError(txtRePassword, "Mật khẩu không khớp");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                provider.Clear();
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhone.Text.Length == 0)
            {
                provider.SetError(txtPhone, "Số điện thoại không được trống");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtPhone.Text, "^\\d+$") | txtPhone.Text.Length > 13)
            {
                provider.SetError(txtPhone, "số điện thoại không hợp lệ");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                provider.Clear();
            }
        }
    }
}
