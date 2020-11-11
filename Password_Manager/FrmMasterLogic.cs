using Data_Access_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Password_Manager
{
    class FrmMasterLogic
    {
        private static FrmMasterLogic instance;

        public static FrmMasterLogic Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FrmMasterLogic();
                }
                return instance;
            }
        }

        private FrmMasterLogic() { }

        public void ChangePassword(string Username, string Password)
        {
            UserDAO.Instance.ChangePassword(Username, StringCipher.Encrypt(Password, StringCipher.DefaultPsw));
        }
    }
}
