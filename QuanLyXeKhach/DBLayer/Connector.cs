using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeKhach.DBLayer
{
    internal class Connector
    {
        public string connStr = "Data Source=LAPTOP-J7585LDJ\\HONGTHAM;Initial Catalog=UngDungXeKhach;Integrated Security=True";
        SqlConnection conn = null;

        public Connector()
        {
            conn = new SqlConnection(connStr);
        }

        public SqlConnection GetConnection()
        {
            return conn;
        }

        public void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        public string GetConnectionString()
        {
            return connStr;
        }
    }
}
