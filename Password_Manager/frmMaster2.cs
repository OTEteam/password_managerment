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
    public partial class frmMaster2 : Form
    {
        public frmMaster2()
        {
            InitializeComponent();
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = true;
        }

        private void txtConfirmNewPassword_TextChanged(object sender, EventArgs e)
        {
            txtConfirmNewPassword.UseSystemPasswordChar = true;
        }
    }
}
