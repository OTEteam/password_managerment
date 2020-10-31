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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPsw.Text;
            UserDTO user = FrmManagementLogic.Instance.CheckLogin(username, password);
            if (user == null)
            {
                MessageBox.Show("Invalid ID or Password\nPlease Try Again");
            }
            else
            {
                this.Hide();
                frmManagement frm = new frmManagement(user);
                frm.Show();
            }
        }
    }
}
