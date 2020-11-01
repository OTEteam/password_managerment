using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Transfer_Object;
using Data_Access_Object;
using System.Security.Cryptography;

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

        private string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public UserDTO CheckLogin(string Username, string Password)
        {
            UserDTO user = UserDAO.Instance.CheckLogin(Username, ComputeSha256Hash(Password));
            user.Password = Password;
            return user;
        }

        public void CreateUser(string Username, string Password, string Phone)
        {
            Password = ComputeSha256Hash(Password);
            UserDAO.Instance.CreateUser(Username, Password, Phone);
        }
    }
}
