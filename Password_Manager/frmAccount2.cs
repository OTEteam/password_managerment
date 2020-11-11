using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Transfer_Object;
using Utils;

namespace Password_Manager
{
    public partial class frmAccount2 : Form
    {
        private UserDTO user;
        public frmAccount2(UserDTO user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void txtCreateAccountPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string website = StringCipher.Encrypt(txtCreateWebsiteName.Text, user.Password);
            string account = StringCipher.Encrypt(txtCreateAccount.Text, user.Password);
            string password = StringCipher.Encrypt(txtCreateAccountPassword.Text, user.Password);
            string note = StringCipher.Encrypt(txtCreateNote.Text, user.Password);
            AccountDTO accountDTO = new AccountDTO(0, website, account, password, note, user.Username);
            FrmManagementLogic.Instance.AddAccount(accountDTO);
            this.Hide();
            MessageBox.Show(this, "Tạo mới thành công", "Thông Báo");
        }

        private void txtCreateAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCreateWebsiteName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
