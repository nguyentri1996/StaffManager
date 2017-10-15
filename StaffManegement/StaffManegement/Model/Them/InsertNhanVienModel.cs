using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StaffManegement.Model.Them
{
    class InsertNhanVienModel
    {
        public static void insertNhanVien(
            int _maphong,
            string _hoten,
            string _ngaysinh,
            string _cmnd,
            string _diachi,
            string _dienthoai,
            string _quoctich,
            string _loai,
            int _luongngay,
            int _luongthang,
            int _bacluong,
            int _tongluong
            )
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            string sql = "INSERT INTO nhanvien(ID, ID_PHONG, HOTEN, NGAYSINH, CMND, DIACHI, DIENTHOAI, QUOCTICH, LOAI_NV, LUONGNGAY, LUONGTHANG, BACLUONG, TONGLUONG) " +
                "VALUES(null, @ID_PHONG, @HOTEN, @NGAYSINH, @CMND, @DIACHI, @DIENTHOAI, @QUOCTICH, @LOAI_NV, @LUONGNGAY, @LUONGTHANG, @BACLUONG, @TONGLUONG)";
            cmd.Connection = conn;
            cmd.CommandText = sql;

            cmd.Parameters.Add("@ID_PHONG", MySqlDbType.Int32).Value = _maphong;
            cmd.Parameters.Add("@HOTEN", MySqlDbType.String).Value = _hoten;
            cmd.Parameters.Add("@NGAYSINH", MySqlDbType.String).Value = _ngaysinh;
            cmd.Parameters.Add("@CMND", MySqlDbType.String).Value = _cmnd;
            cmd.Parameters.Add("@DIACHI", MySqlDbType.String).Value = _diachi;
            cmd.Parameters.Add("@DIENTHOAI", MySqlDbType.String).Value = _dienthoai;
            cmd.Parameters.Add("@QUOCTICH", MySqlDbType.String).Value = _quoctich;
            cmd.Parameters.Add("@LOAI_NV", MySqlDbType.String).Value = _loai;
            cmd.Parameters.Add("@LUONGNGAY", MySqlDbType.Int32).Value = _luongngay;
            cmd.Parameters.Add("@LUONGTHANG", MySqlDbType.Int32).Value = _luongthang;
            cmd.Parameters.Add("@BACLUONG", MySqlDbType.Int32).Value = _bacluong;
            cmd.Parameters.Add("@TONGLUONG", MySqlDbType.Int32).Value = _tongluong;
            int rowCount = cmd.ExecuteNonQuery();
            Console.WriteLine("Row Count affected = " + rowCount);
            conn.Close();
            
        }

    }
}
