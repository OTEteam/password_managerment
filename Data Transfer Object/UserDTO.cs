using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Transfer_Object
{
    public class UserDTO
    {
        private string username, password, phone;

        public UserDTO(string username, string password, string phone)
        {
            this.username = username;
            this.password = password;
            this.phone = phone;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
