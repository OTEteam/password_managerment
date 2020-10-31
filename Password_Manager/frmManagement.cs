using Data_Transfer_Object;
using System;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class frmManagement : Form
    {
        private UserDTO user;

        public frmManagement(UserDTO user)
        {
            //splitContainer1.Size(450, 500);
            InitializeComponent();
            this.user = user;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
        }

        private void frmManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
