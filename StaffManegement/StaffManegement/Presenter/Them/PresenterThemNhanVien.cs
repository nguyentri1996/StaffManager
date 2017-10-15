using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaffManegement.Model.Them;
using StaffManegement.View.Them;

namespace StaffManegement.Presenter.Them
{
    class PresenterThemNhanVien : PresenterThemInterface
    {
        AddStaff addStaffView;
        public PresenterThemNhanVien(AddStaff _addStaffView)
        {
            addStaffView = _addStaffView;
        }
        public void KiemTraThongTin(int _maphong, string _hoten, string _ngaysinh, string _cmnd, string _diachi, string _dienthoai, string _quoctich, string _loai, int _luongngay, int _luongthang, int _bacluong, int _tongluong)
        {
            if(_maphong.Equals("") || _hoten.Equals("") || _ngaysinh.Equals("") || _cmnd.Equals("") || _diachi.Equals("") || _dienthoai.Equals("") || _quoctich.Equals("") || _loai.Equals("") ||  (_luongngay.Equals("") && _luongthang.Equals("") && _bacluong.Equals("")) || _tongluong.Equals(""))
            {
                
                addStaffView.KiemTraThatBai();
            }
            else
            {
                // insert data into database quanlynhanvien / table nhanvien
                InsertNhanVienModel.insertNhanVien(
                    _maphong,
                    _hoten,
                    _ngaysinh,
                    _cmnd,
                    _diachi,
                    _dienthoai,
                    _quoctich,
                    _loai,
                    _luongngay,
                    _luongthang,
                    _bacluong,
                    _tongluong
                );

                addStaffView.KiemTraThanhCong();
                
            }
        }
    }
}
