using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Transfer_Object;
using Data_Access_Object;
using System.Security.Cryptography;
using System.Data;
using Utils;

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
            UserDTO user = UserDAO.Instance.CheckLogin(Username, StringCipher.ComputeSha256Hash(Password));
            user.Password = Password;
            return user;
        }

        public void CreateUser(string Username, string Password, string Phone)
        {
            Password = StringCipher.ComputeSha256Hash(Password);
            UserDAO.Instance.CreateUser(Username, Password, Phone);
        }

        public void AddAccount(AccountDTO account)
        {
            AccountDAO.Instance.AddAccount(account);
        }

        public DataTable GetAccounts(UserDTO user)
        {
            DataTable accounts =  AccountDAO.Instance.GetAccounts(user.Username);
            
            // On all tables' rows
            foreach (DataRow dtRow in accounts.Rows)
            {
                // On all tables' columns
                foreach (DataColumn dc in accounts.Columns)
                {
                    if (dc.ColumnName != "id")
                    {
                        dtRow[dc] = StringCipher.Decrypt(dtRow[dc].ToString(), user.Password);
                    }
                }
            }
            return accounts;
        }
    }
}
