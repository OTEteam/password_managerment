using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Transfer_Object;
namespace Data_Access_Object
{
    public class AccountDAO : DBConnect
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }
        }
        private AccountDAO() { }

        //public AccountDTO Access()
        //{
        //    AccountDTO dto = null;
        //    return dto;
        //}
        //TODO: write code here
    }
}
