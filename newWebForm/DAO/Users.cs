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

        public static List<User> getAllUser()
        {
            List<User> getAllUsers = new List<User>();

            SqlConnection conn = ConnectionDB.getConnection();
            string sql = "SELECT userID, userName, userPassWord FROM tbl_Users";

            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = System.Data.CommandType.Text;

            conn.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                User users = new User();
                users.userID = Convert.ToInt32(sqlDataReader["userID"]);
                users.userName = Convert.ToString(sqlDataReader["userName"]);
                users.userPassWord = Convert.ToString(sqlDataReader["userPassWord"]);
                getAllUsers.Add(users);
            }
            sqlDataReader.Close();
            ConnectionDB.Close(conn);
            conn.Dispose();

            return getAllUsers;

        }

        public static bool Delete(int _id)
        {
            SqlConnection conn = ConnectionDB.getConnection();

            string sql = "delete from [tbl_Users] where userID=@Id";
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = System.Data.CommandType.Text;

            sqlCommand.Parameters.AddWithValue("@Id", _id);

            int rs = sqlCommand.ExecuteNonQuery();
            if (rs > 0)
            {
                ConnectionDB.Close(conn);
                conn.Dispose();
                return true;
            }
            return false;
        }

        public static bool CreateOrUpdate(User user)
        {
            SqlConnection conn = ConnectionDB.getConnection();
            string sql = "";
            if (user.userID != 0)
            {
                sql = "update [tbl_Users] set userName=@username,userPassWord=@password where userID=@Id";
            }
            else
            {
                sql = "insert into [tbl_Users](userName,userPassWord) values(@username,@password)";
            }
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = System.Data.CommandType.Text;

            sqlCommand.Parameters.AddWithValue("@username", user.userName);
            sqlCommand.Parameters.AddWithValue("@password", user.userPassWord);
            sqlCommand.Parameters.AddWithValue("@Id", user.userID);

            int rs = sqlCommand.ExecuteNonQuery();
            if (rs > 0)
            {
                ConnectionDB.Close(conn);
                conn.Dispose();
                return true;
            }
            return false;
        }

        public static User GetUserById(int _id)
        {
            User user = null;

            SqlConnection conn = ConnectionDB.getConnection();

            string sql = "select userID, userName, userPassWord from [tbl_Users] where userID=@id";

            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = System.Data.CommandType.Text;

            conn.Open();

            sqlCommand.Parameters.AddWithValue("@id", _id);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                user = new User
                {
                    userID = Convert.ToInt32(sqlDataReader["userID"]),
                    userName = Convert.ToString(sqlDataReader["userName"]),
                    userPassWord = Convert.ToString(sqlDataReader["userPassWord"])
                };
            }

            sqlDataReader.Close();
            ConnectionDB.Close(conn);
            conn.Dispose();
            return user;
        }

        public static List<User> SearchUser(string _search)
        {
            List<User> users = new List<User>();
            SqlConnection conn = ConnectionDB.getConnection();
            string sql = "SELECT userID, userName FROM [tbl_Users] WHERE( userID LIKE '%" + _search + "%' or userName LIKE '%" + _search + "%' )";

            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            sqlCommand.CommandType = System.Data.CommandType.Text;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                User user = new User
                {
                    userID = Convert.ToInt32(sqlDataReader["userID"]),
                    userName = Convert.ToString(sqlDataReader["userName"]),
                };
                users.Add(user);
            }

            sqlDataReader.Close();
            conn.Close();
            conn.Dispose();
            return users;

        }

    }
}