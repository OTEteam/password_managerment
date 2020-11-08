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
        bool[] accept = {false, false, false, false};

        private bool isAccept()
        {
            return accept[0] & accept[1] & accept[2] & accept[3];
        }

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
            if (isAccept())
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string phone = txtPhone.Text;
                try
                {
                    FrmManagementLogic.Instance.CreateUser(username, password, phone);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Tài khoản đã tồn tại", "Lỗi rồi");
                }
            }
            else
            {
                MessageBox.Show(this, "Dữ liệu không hợp lệ", "Lỗi rồi");
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsername.Text.Length == 0)
            {
                provider.SetError(txtUsername, "Vui lòng nhập username");
                accept[0] = false;
            }
            else if (txtUsername.Text.Length > 1000)
            {
                provider.SetError(txtUsername, "username quá dài");
                accept[0] = false;
            }
            else if (!Regex.IsMatch(txtUsername.Text, "^[a-zA-Z0-9]+$"))
            {
                provider.SetError(txtUsername, "username không bao gồm khoảng trắng và ký tự đặc biệt");
                accept[0] = false;
            }
            else
            {
                accept[0] = true;
                provider.Clear();
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text.Length == 0)
            {
                provider.SetError(txtPassword, "Mật khẩu không được trống");
                accept[1] = false;
            }
            else
            {
                accept[1] = true;
                provider.Clear();
            }
        }

        private void txtRePassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text != txtRePassword.Text)
            {
                provider.SetError(txtRePassword, "Mật khẩu không khớp");
                accept[2] = false;
            }
            else
            {
                accept[2] = true;
                provider.Clear();
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhone.Text.Length == 0)
            {
                provider.SetError(txtPhone, "Số điện thoại không được trống");
                accept[3] = false;
            }
            else if (!Regex.IsMatch(txtPhone.Text, "^\\d+$") | txtPhone.Text.Length > 13)
            {
                provider.SetError(txtPhone, "số điện thoại không hợp lệ");
                accept[3] = false;
            }
            else
            {
                accept[3] = true;
                provider.Clear();
            }
        }
    }
}
