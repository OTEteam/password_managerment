using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Transfer_Object;
using Data_Access_Object;
namespace Password_Manager
{
    class FrmManagementLogic
    {
        //TODO: using code here to access DAO instead of directly access (3 layer architecture RULE)

        private static FrmManagementLogic instance;

        public static FrmManagementLogic Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FrmManagementLogic();
                }
                return instance;
            }
        }

        private FrmManagementLogic() { }

        public UserDTO CheckLogin(string Username, string Password)
        {
            UserDTO user = UserDAO.Instance.CheckLogin(Username, Password);
            return user;
        }
    }
}
