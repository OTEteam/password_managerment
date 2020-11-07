using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable GetAccounts(string username)
        {
            string SQL = "SELECT a.id, a.website, a.account, a.account_psw, a.note\n" +
                            "FROM dbo.accounts a\n" +
                           "WHERE a.usr_name = @Username";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable accounts = new DataTable();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                adapter.Fill(accounts);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return accounts;
        }
    }
}
