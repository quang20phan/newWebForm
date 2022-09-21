using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using newWebForm.Entity;
using System.Data.SqlClient;

namespace newWebForm.DAO
{
    public class Users
    {
        public static List<User> getOneUser(string _username, string _password)
        {
            List<User> users = new List<User>();
            SqlConnection conn = ConnectionDB.getConnection();

            string sql = "SELECT userName, userPassWord FROM tbl_Users WHERE userName='"+_username+"' AND userPassWord= '"+_password+"' ";

            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = System.Data.CommandType.Text;


            conn.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


            while (sqlDataReader.Read())
            {
                User user = new User();
                user.userName = Convert.ToString(sqlDataReader["userName"]);
                user.userPassWord = Convert.ToString(sqlDataReader["userPassWord"]);
                users.Add(user);
            }
            sqlDataReader.Close();
            ConnectionDB.Close(conn);
            conn.Dispose();
            return users;

        }
    }
}