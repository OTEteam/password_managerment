using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public void AddAccount(AccountDTO account)
        {
            string SQL = "INSERT dbo.accounts\n" +
                         "(website, account, account_psw, note, usr_name)\n" +
                         "VALUES (@Website, @Account, @Password, @Note, @Username)";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@Website", account.Website);
            cmd.Parameters.AddWithValue("@Account", account.Website);
            cmd.Parameters.AddWithValue("@Password", account.Account_psw);
            cmd.Parameters.AddWithValue("@Note", account.Note);
            cmd.Parameters.AddWithValue("@Username", account.Username);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
