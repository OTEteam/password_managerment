using Data_Transfer_Object;
using System;
using System.Data;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class frmManagement : Form
    {
        private UserDTO user;
        private DataTable dtAccounts;

        public frmManagement(UserDTO user)
        {
            //splitContainer1.Size(450, 500);
            InitializeComponent();
            this.user = user;
            dsAccount.AutoGenerateColumns = false;
            loadAccount();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAccount frmAccount = new frmAccount(user);
            frmAccount.ShowDialog();
        }

        private void frmManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loadAccount()
        {
            dtAccounts = FrmManagementLogic.Instance.GetAccounts(user);
            dsAccount.Columns[0].DataPropertyName = "website";
            dsAccount.Columns[1].DataPropertyName = "account";
            dsAccount.Columns[4].DataPropertyName = "id";
            dsAccount.Columns[5].DataPropertyName = "id";
            dsAccount.Columns[6].DataPropertyName = "account_psw";
            dsAccount.DataSource = dtAccounts;
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                dtAccounts.DefaultView.RowFilter = "website LIKE '%" + txtSearch.Text + "%'";
            }
            else
            {
                dtAccounts.DefaultView.RowFilter = "";
            }
        }

        private void dsAccount_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.Value != null)
            {
                dsAccount.Rows[e.RowIndex].Cells[2].Value = "****************";
                e.Value = "Edit";
            }
        }

        private void dsAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dsAccount.Rows[e.RowIndex];
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
                dsAccount.EndEdit();
            }
        }
    }
}
