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
using Data_Transfer_Object;

namespace Password_Manager
{
    public partial class frmLoginandRegister : Form
    {
        bool[] accept = { false, false, false, false };

        private bool isAccept()
        {
            return accept[0] & accept[1] & accept[2] & accept[3];
        }
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
            otp.ShowDialog();
        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {
            txtRegisterPassword.UseSystemPasswordChar = true;
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void txtConfirmRegisterPassword_TextChanged(object sender, EventArgs e)
        {
            txtConfirmRegisterPassword.UseSystemPasswordChar = true;
        }

        private void btnLoginAccount_Click(object sender, EventArgs e)
        {
            string username = txtLoginAccount.Text;
            string password = txtLoginPassword.Text;
            UserDTO user = FrmManagementLogic.Instance.CheckLogin(username, password);
            if (user == null)
            {
                MessageBox.Show("Invalid ID or Password\nPlease Try Again");
            }
            else
            {
                this.Hide();
                frmManagement2 frm = new frmManagement2(user);
                frm.Show();
            }
        }

        private void btnAccountRegister_Click(object sender, EventArgs e)
        {
            if (isAccept())
            {
                string username = txtRegisterAccount.Text;
                string password = txtRegisterPassword.Text;
                string phone = txtRegisterPhoneNumber.Text;
                try
                {
                    FrmManagementLogic.Instance.CreateUser(username, password, phone);
                    MessageBox.Show(this, "Tạo tài khoản thành công", "Thông báo");
                    bunifuPages1.SetPage(0);
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

        private void txtRegisterAccount_Validating(object sender, CancelEventArgs e)
        {
            if (txtRegisterAccount.Text.Length == 0)
            {
                errorProvider.SetError(txtRegisterAccount, "Vui lòng nhập username");
                accept[0] = false;
            }
            else if (txtRegisterAccount.Text.Length > 1000)
            {
                errorProvider.SetError(txtRegisterAccount, "username quá dài");
                accept[0] = false;
            }
            else if (!Regex.IsMatch(txtRegisterAccount.Text, "^[a-zA-Z0-9]+$"))
            {
                errorProvider.SetError(txtRegisterAccount, "username không bao gồm khoảng trắng và ký tự đặc biệt");
                accept[0] = false;
            }
            else
            {
                accept[0] = true;
                errorProvider.Clear();
            }
        }

        private void txtRegisterPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtRegisterPassword.Text.Length == 0)
            {
                errorProvider.SetError(txtRegisterPassword, "Mật khẩu không được trống");
                accept[1] = false;
            }
            else
            {
                accept[1] = true;
                errorProvider.Clear();
            }
        }

        private void txtConfirmRegisterPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtRegisterPassword.Text != txtConfirmRegisterPassword.Text)
            {
                errorProvider.SetError(txtConfirmRegisterPassword, "Mật khẩu không khớp");
                accept[2] = false;
            }
            else
            {
                accept[2] = true;
                errorProvider.Clear();
            }
        }

        private void txtRegisterPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (txtRegisterPhoneNumber.Text.Length == 0)
            {
                errorProvider.SetError(txtRegisterPhoneNumber, "Số điện thoại không được trống");
                accept[3] = false;
            }
            else if (!Regex.IsMatch(txtRegisterPhoneNumber.Text, "^\\d+$") | txtRegisterPhoneNumber.Text.Length > 13)
            {
                errorProvider.SetError(txtRegisterPhoneNumber, "số điện thoại không hợp lệ");
                accept[3] = false;
            }
            else
            {
                accept[3] = true;
                errorProvider.Clear();
            }
        }

        private void chkPolicy_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            btnAccountRegister.Enabled = chkPolicy.Checked;
        }
    }
}
