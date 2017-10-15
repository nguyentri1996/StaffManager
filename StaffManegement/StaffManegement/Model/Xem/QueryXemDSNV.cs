using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StaffManegement.Model.Xem
{
    class QueryXemDSNV
    {
        public static MySqlDataAdapter da;
        public static void execute(string sql)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;

            da = new MySqlDataAdapter(cmd);
            
            
            

        }
    }
}
