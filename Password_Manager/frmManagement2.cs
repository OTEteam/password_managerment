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

namespace Password_Manager
{
    public partial class frmManagement2 : Form
    {
        private UserDTO user;
        private DataTable dtAccounts;
        public frmManagement2(UserDTO user)
        {
            InitializeComponent();
            this.user = user;
            dgvPasswordManager.AutoGenerateColumns = false;
            loadAccount();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
        }

        private void btnMnu_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (sideMenu.Width == 60)
            {
                sideMenu.Visible = false;
                sideMenu.Width = 260;
                panelTransition.ShowSync(sideMenu);
                logoTransition.ShowSync(logo);
                logoTransition.ShowSync(txtFindAccount);
                logoTransition.ShowSync(lblCopyright);
                logoTransition.ShowSync(picCopyRight);
            }
            else
            {
                logoTransition.Hide(txtFindAccount);
                logoTransition.Hide(lblCopyright);
                logoTransition.Hide(picCopyRight);
                logoTransition.Hide(logo);
                sideMenu.Visible = false;
                sideMenu.Width = 60;
                panelTransition.ShowSync(sideMenu);
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            frmAccount2 frmAccount = new frmAccount2(user);
            frmAccount.ShowDialog();
            loadAccount();
        }

        private void frmManagement2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loadAccount()
        {
            dtAccounts = FrmManagementLogic.Instance.GetAccounts(user);
            dgvPasswordManager.Columns[0].DataPropertyName = "website";
            dgvPasswordManager.Columns[1].DataPropertyName = "account";
            dgvPasswordManager.Columns[4].DataPropertyName = "id";
            dgvPasswordManager.Columns[5].DataPropertyName = "id";
            dgvPasswordManager.Columns[6].DataPropertyName = "account_psw";
            dgvPasswordManager.Columns[7].DataPropertyName = "note";
            dgvPasswordManager.DataSource = dtAccounts;
        }

        private void txtFindAccount_TextChanged(object sender, EventArgs e)
        {
            if (txtFindAccount.Text != "")
            {
                dtAccounts.DefaultView.RowFilter = "website LIKE '%" + txtFindAccount.Text + "%'";
            }
            else
            {
                dtAccounts.DefaultView.RowFilter = "";
            }
        }

        private void dgvPasswordManager_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.Value != null)
            {
                e.Value = "Edit";
            }
        }

        private void dgvPasswordManager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvPasswordManager.Rows[e.RowIndex];
            if (e.ColumnIndex == 3 & e.RowIndex != -1)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[3];
                if (Convert.ToBoolean(chk.EditedFormattedValue) == true)
                {
                    row.Cells[2].Value = row.Cells[6].Value.ToString();
                }
                else
                {
                    row.Cells[2].Value = "****************";
                }
                dgvPasswordManager.EndEdit();
                dgvPasswordManager.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
            else if (e.ColumnIndex == 4)
            {
                AccountDTO account = new AccountDTO(Convert.ToInt32(row.Cells[5].Value.ToString()),
                                                    row.Cells[0].Value.ToString(),
                                                    row.Cells[1].Value.ToString(),
                                                    row.Cells[6].Value.ToString(),
                                                    row.Cells[7].Value.ToString(),
                                                    user.Username);
                frmEdit2 frmEdit = new frmEdit2(account, user);
                frmEdit.ShowDialog();
                loadAccount();
            }
        }

        private void btnChangeMasterKey_Click(object sender, EventArgs e)
        {
            frmMaster2 frmMaster = new frmMaster2(dtAccounts, user);
            frmMaster.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
