using Data_Transfer_Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Utils;

namespace Password_Manager
{
    public partial class frmOTP : Form
    {
        string otp;
        UserDTO user;
        DataTable dtAccounts;
        public frmOTP()
        {
            InitializeComponent();
        }

        

        private void btnConfirmOTP_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(otp) == txtOTP.Text)
            {
                dtAccounts = FrmManagementLogic.Instance.GetAccounts(user);
                ChangePswPanel.Visible = true;
            }
            else
            {
                otpMsg.Text = "OTP không hợp lệ";
            }
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            UserDTO user = FrmLoginLogic.Instance.GetUser(txtUsername.Text, txtPhone.Text);
            if (user == null)
            {
                txtMsg.Text = "tài khoản và sđt không khớp";
            }
            else
            {
                string phone = "+84" + user.Phone.Substring(1);
                otp = FrmOTPLogic.Instance.SendOtp(phone);
                bunifuPanel1.Visible = false;
                this.user = user;
            }
        }

        private void txtNewPsw_Validating(object sender, CancelEventArgs e)
        {
            if (txtNewPsw.Text.Length == 0)
            {
                errorProvider1.SetError(txtNewPsw, "mật khẩu không được bỏ trống");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtConfirmPsw_Validating(object sender, CancelEventArgs e)
        {
            if (txtNewPsw.Text != txtConfirmPsw.Text)
            {
                errorProvider1.SetError(txtConfirmPsw, "mật khẩu không khớp");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtNewPsw.Text == txtConfirmPsw.Text)
            {
                string password = txtNewPsw.Text;
                FrmManagementLogic.Instance.ChangePassword(user.Username, password);
                foreach (DataRow row in dtAccounts.Rows)
                {
                    string website = StringCipher.Encrypt(row[1].ToString(), password);
                    string acc = StringCipher.Encrypt(row[2].ToString(), password);
                    string psw = StringCipher.Encrypt(row[3].ToString(), password);
                    string note = StringCipher.Encrypt(row[4].ToString(), password);
                    AccountDTO accountDTO = new AccountDTO(Convert.ToInt32(row[0]), website, acc, psw, note, user.Username);
                    FrmManagementLogic.Instance.UpdateAccount(accountDTO);
                }
                Application.Restart();
                Environment.Exit(0);
            }
        }
    }
}
