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
    public partial class frmEdit : Form
    {
        private AccountDTO account;
        private UserDTO user;
        public frmEdit(AccountDTO account, UserDTO user)
        {
            InitializeComponent();
            this.account = account;
            this.user = user;
            txtAccount.Text = account.Account;
            txtWebsite.Text = account.Website;
            txtPassword.Text = account.Account_psw;
            txtNote.Text = account.Note;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string website = StringCipher.Encrypt(txtWebsite.Text, user.Password);
            string acc = StringCipher.Encrypt(txtAccount.Text, user.Password);
            string password = StringCipher.Encrypt(txtPassword.Text, user.Password);
            string note = StringCipher.Encrypt(txtNote.Text, user.Password);
            AccountDTO accountDTO = new AccountDTO(account.Id, website, acc, password, note, user.Username);
            FrmManagementLogic.Instance.UpdateAccount(accountDTO);
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(this, "Do you want to delete this account?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                FrmManagementLogic.Instance.DelAccount(account);
                this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
