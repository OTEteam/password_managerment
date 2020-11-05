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
    public partial class frmAccount : Form
    {
        private UserDTO user;
        public frmAccount(UserDTO user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string website = StringCipher.Encrypt(txtWebsite.Text, user.Password);
            string account = StringCipher.Encrypt(txtAccount.Text, user.Password);
            string password = StringCipher.Encrypt(txtPass.Text, user.Password);
            string note = StringCipher.Encrypt(txtNote.Text, user.Password);
            AccountDTO accountDTO = new AccountDTO(0, website, account, password, note, user.Username);
            FrmManagementLogic.Instance.AddAccount(accountDTO);
            this.Hide();
            MessageBox.Show(this, "Tạo mới thành công", "Thông Báo");
        }
    }
}
