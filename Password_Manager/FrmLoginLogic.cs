using Data_Access_Object;
using Data_Transfer_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Password_Manager
{
    class FrmLoginLogic
    {
        private static FrmLoginLogic instance;

        public static FrmLoginLogic Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FrmLoginLogic();
                }
                return instance;
            }
        }

        private FrmLoginLogic() { }

        public UserDTO CheckLogin(string Username, string Password)
        {
            UserDTO user = UserDAO.Instance.CheckLogin(Username);
            try
            {
                user.Password = StringCipher.Decrypt(user.Password, StringCipher.DefaultPsw);
            }
            catch (Exception)
            {
                return null;
            }
            if (user.Password != Password)
            {
                return null;
            }
            return user;
        }
        public UserDTO GetUser(string Username, string Phone)
        {
            UserDTO user = UserDAO.Instance.GetUser(Username, Phone);
            if (user != null)
            {
                user.Password = StringCipher.Decrypt(user.Password, StringCipher.DefaultPsw);
            }
            return user;
        }

        public void CreateUser(string Username, string Password, string Phone)
        {
            Password = StringCipher.Encrypt(Password, StringCipher.DefaultPsw);
            UserDAO.Instance.CreateUser(Username, Password, Phone);
        }

        public void AddAccount(AccountDTO account)
        {
            AccountDAO.Instance.AddAccount(account);
        }

        public void DelAccount(AccountDTO account)
        {
            AccountDAO.Instance.DelAccount(account.Id);
        }

        public void UpdateAccount(AccountDTO account)
        {
            AccountDAO.Instance.UpdateAccount(account);
        }
    }
}
