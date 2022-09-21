using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace newWebForm.Models
{
    public class ConnectionDB
    {
        public static SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CAV8Q06;Initial Catalog=QuanLyBanHang;Integrated Security=True");
            if (conn != null)
            {
                return conn;
            }
            return null;
        }

        public static void Close(SqlConnection conn)
        {
            conn.Close();
        }
    }
}