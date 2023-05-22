using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thithu
{
     class utility
    {
        public static SqlConnection cnn;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;

        public SqlConnection OpenDB()
        {
            cnn = new SqlConnection(@"Data Source=DESKTOP-4OLQIDQ\MAYAO;Initial Catalog=TypingTest;Integrated Security=True");
            return cnn;
        }
        public static void OpenConnection()
        {
            string sql = @"Data Source=DESKTOP-4OLQIDQ\MAYAO;Initial Catalog=TypingTest;Integrated Security=True";
            try
            {
                cnn = new SqlConnection(sql);
                cnn.Open();
            }
            catch(Exception ex)
            {

            }
        }
        public static void CloseConnection()
        {
            cnn.Close();
            cnn.Dispose();
            cnn = null;
        }
        public static DataTable GetDataTable(string sql)
        {
            cmd = new SqlCommand(sql,cnn);

            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            da.Dispose();
            dt.Dispose();

            return dt;
        }
        public static void Excute(string sql)
        {
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
   

    }
}
