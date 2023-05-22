using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thithu
{
     class KiemTraDN
    {
        public int CheckLogin(string username, string password)
        {
            Connection connection = new Connection();
            SqlDataReader reader = connection.ExecuteReader("SELECT UserName, Pass_Word FROM Users");
            while (reader.Read())
            {
                if (reader[0].ToString() == username && reader[1].ToString() == password)
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
