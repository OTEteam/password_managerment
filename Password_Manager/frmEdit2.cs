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
    public partial class frmEdit2 : Form
    {
        private AccountDTO account;
        private UserDTO user;
        public frmEdit2(AccountDTO account, UserDTO user)
        {
            InitializeComponent();
            this.account = account;
            this.user = user;
            txtEditAccount.Text = account.Account;
            txtEditWebSite.Text = account.Website;
            txtEditAccountPassword.Text = account.Account_psw;
            txtEditNote.Text = account.Note;
        }

        private void txtEditAccountPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSaveAccount_Click(object sender, EventArgs e)
        {
            string website = StringCipher.Encrypt(txtEditWebSite.Text, user.Password);
            string acc = StringCipher.Encrypt(txtEditAccount.Text, user.Password);
            string password = StringCipher.Encrypt(txtEditAccountPassword.Text, user.Password);
            string note = StringCipher.Encrypt(txtEditNote.Text, user.Password);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtEditWebSite_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
