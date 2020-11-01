using Data_Transfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Object
{
    public class UserDAO : DBConnect
    {
        private static UserDAO instance;

        public static UserDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserDAO();
                }
                return instance;
            }
        }
        private UserDAO() { }

        public UserDTO CheckLogin(string Username, string Password)
        {
            UserDTO user = null;
            string SQL = "SELECT u.usr_name, u.psw, u.phone FROM dbo.users u\n" +
                "WHERE u.usr_name = @Username AND u.psw = @Password";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            try
            {
                foreach (DataRow item in dt.Rows)
                {
                    user = new UserDTO(item.ItemArray.GetValue(0).ToString(),
                        item.ItemArray.GetValue(1).ToString(),
                        item.ItemArray.GetValue(2).ToString());
                }
            }
            catch
            {
                user = null;
            }
            conn.Close();
            return user;
        }
        //TODO: write code here

        public void CreateUser(string Username, string Password, string Phone)
        {
            string SQL = "INSERT dbo.users\n" +
                         "(usr_name, psw, phone, active)\n" +
                         "VALUES (@Username, @Password, @Phone, 0)";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
