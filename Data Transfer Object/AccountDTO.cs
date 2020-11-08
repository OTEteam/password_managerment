using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Transfer_Object
{
    public class AccountDTO
    {
        private int id;
        private string website, account, account_psw, note, username;

        public AccountDTO(int id, string website, string account, string account_psw, string note, string username)
        {
            this.id = id;
            this.account = account;
            this.account_psw = account_psw;
            this.note = note;
            this.username = username;
            this.website = website;
        }

        public int Id { get => id; set => id = value; }
        public string Account { get => account; set => account = value; }
        public string Account_psw { get => account_psw; set => account_psw = value; }
        public string Note { get => note; set => note = value; }
        public string Username { get => username; set => username = value; }
        public string Website { get => website; set => website = value; }
    }
}
