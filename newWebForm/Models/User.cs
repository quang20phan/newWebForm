using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace newWebForm.Models
{
    public class User
    {
        public static List<ObjUser> getOneUser(String userName, String passWord)
        {
            List<ObjUser> users = new List<ObjUser>();

            SqlConnection conn = ConnectionDB.getConnection();
            String sql = "SELECT userName, userPassWord FROM tbl_Users WHERE userName= '"+userName+"' AND userPassWord= '"+passWord+"' ";

            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            conn.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while(sqlDataReader.Read())
            {
                ObjUser user = new ObjUser();
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