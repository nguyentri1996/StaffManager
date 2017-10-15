using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StaffManegement.Model.Sua
{
    class UpdateNVModel
    {
        private bool kiemtra = false;
        public UpdateNVModel(String sql)
        {
            MySqlConnection conn   = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            MySqlDataReader MyReader2;
            MyReader2 = cmd.ExecuteReader();
            kiemtra = true;
            conn.Close();
        }
        public bool getKiemtra()
        {
            return kiemtra;
        }

    }
}
