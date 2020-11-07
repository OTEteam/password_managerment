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
            dsAccount.DataSource = dtAccounts;
        }

        private void dsAccount_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                dsAccount.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }
    }
}
