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

        public UpdateNVModel(String sql)
        {
            MySqlConnection conn   = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            MySqlDataReader MyReader2;
            MyReader2 = cmd.ExecuteReader();
            MessageBox.Show("Đã cập nhật !","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
        }

    }
}
