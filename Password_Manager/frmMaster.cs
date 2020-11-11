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
using Utils;

namespace Password_Manager
{
    public partial class frmMaster : Form
    {
        private DataTable dataTable;
        private UserDTO user;
        bool[] accept = { false, false, false };
        public frmMaster(DataTable dataTable, UserDTO user)
        {
            InitializeComponent();
            this.dataTable = dataTable;
            this.user = user;
        }

        private bool isAccept()
        {
            return accept[0] & accept[1] & accept[2];
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (isAccept())
            {
                string password = txtNewPsw.Text;
                FrmManagementLogic.Instance.ChangePassword(user.Username, password);
                foreach (DataRow row in dataTable.Rows)
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

        private void txtOlderPsw_Validating(object sender, CancelEventArgs e)
        {
            if (txtOlderPsw.Text != user.Password)
            {
                provider.SetError(txtOlderPsw, "Mật khẩu không khớp");
                accept[0] = false;
            }
            else
            {
                accept[0] = true;
                provider.Clear();
            }
        }

        private void txtNewPsw_Validating(object sender, CancelEventArgs e)
        {
            if (txtNewPsw.Text.Length == 0)
            {
                provider.SetError(txtNewPsw, "Mật khẩu không được trống");
                accept[1] = false;
            }
            else
            {
                accept[1] = true;
                provider.Clear();
            }
        }

        private void txtReNewPsw_Validating(object sender, CancelEventArgs e)
        {
            if (txtReNewPsw.Text != txtNewPsw.Text)
            {
                provider.SetError(txtReNewPsw, "Mật khẩu không khớp");
                accept[2] = false;
            }
            else
            {
                accept[2] = true;
                provider.Clear();
            }
        }

        private void txtOlderPsw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
