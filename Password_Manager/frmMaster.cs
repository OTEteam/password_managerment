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
    }
}
