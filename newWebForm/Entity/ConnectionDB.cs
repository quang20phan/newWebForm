using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace newWebForm.Entity
{
    public class ConnectionDB
    {
        public static SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString);
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