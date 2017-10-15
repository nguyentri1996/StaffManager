using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManegement.Presenter.Them
{
    interface PresenterThemInterface
    {
        void KiemTraThongTin(
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
            );
    }
}
