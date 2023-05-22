using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thithu
{
    class Connection
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=DESKTOP-4OLQIDQ\MAYAO;Initial Catalog=thu1;Integrated Security=True");
        }
        SqlConnection conn;
        public void DisConnect()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }
        public void ExcuteNonQuery(string sql)// thuc hien truy van
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            DisConnect();
            cmd.Dispose();
        }
        public SqlDataReader ExecuteReader(string sql)// doc du lieu
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}

