using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace newWebForm
{
    public class Connection
    {
        public SqlConnection conn ;

        public void getConnection()
        {
            conn = new SqlConnection("Data Source=DESKTOP-CAV8Q06;Initial Catalog=QuanLyBanHang;Integrated Security=True");
            conn.Open();
        }

        public DataTable getData()
        {
            DataTable dt = new DataTable();
            getConnection();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM tbl_Users", conn);
            adapt.Fill(dt);
            return dt;
        }

        public void addData(string userName, string pass)
        {
            getConnection();
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO tbl_Users(userName, userPassWord) values " +
                "('" + userName + "','" + pass + "')"
            , conn);
            cmd.ExecuteNonQuery();

        }

        public void deleteData(int userID)
        {
            getConnection();
            SqlCommand cmd = new SqlCommand(
               "DELETE FROM tbl_Users WHERE userID = '"+userID+"' "
            , conn);
            cmd.ExecuteNonQuery();

        }


        public void updateData(int userID, string userName, string pass)
        {
            getConnection();
            SqlCommand cmd = new SqlCommand(
               "UPDATE tbl_Users SET userName = '" + userName+"', userPassWord = '"+pass+"' WHERE userID = '"+userID+"'"
            , conn);
            cmd.ExecuteNonQuery();

        }
    }
}