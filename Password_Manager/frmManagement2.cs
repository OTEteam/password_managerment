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

namespace Password_Manager
{
    public partial class frmManagement2 : Form
    {
        private UserDTO user;
        private DataTable dtAccounts;

        public frmManagement2(UserDTO user)
        {
            //splitContainer1.Size(450, 500);
            InitializeComponent();
            this.user = user;
            dgvPasswordManager.AutoGenerateColumns = false;
            loadAccount();
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
        public frmManagement2()
        {
            InitializeComponent();
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
    }
}
