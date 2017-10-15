using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StaffManegement.Presenter.Them;

namespace StaffManegement.View.Them
{
    public partial class AddStaff : Form , ViewThemNhanVien
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonThemNV_Click(object sender, EventArgs e)
        {
            PresenterThemNhanVien presenterThemNhanVien = new PresenterThemNhanVien(this);
            string _luongngay = textBoxLuongNgay.Text;
            string _luongthang = textBoxLuongThang.Text;
            string _bacluong = textBoxBacLuong.Text;
            string _maphong = textBoxMaPhong.Text;
            int maphong = int.Parse(_maphong);
            int luongngay = int.Parse(_luongngay);
            int luongthang = int.Parse(_luongthang);
            int bacluong = int.Parse(_bacluong);
            int tongluong;
            if (luongngay != 0)
            {
                tongluong = luongngay;
            }
            else
            {
                tongluong = luongthang * bacluong;
            }
            
            presenterThemNhanVien.KiemTraThongTin(
                maphong,
                textBoxHoTen.Text,
                textBoxNgaySinh.Text,
                textBoxCMND.Text,
                textBoxDiaChi.Text,
                textBoxDienThoai.Text,
                textBoxQuocTich.Text,
                textBoxLoai.Text,
                luongngay,
                luongthang,
                bacluong,
                tongluong
                );

        }

        public void KiemTraThanhCong()
        {

            Console.WriteLine("THÊM THÀNH CÔNG");
            MessageBox.Show("THÊM THÀNH CÔNG", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void KiemTraThatBai()
        {

            Console.WriteLine("THÊM THẤT BẠI");
            MessageBox.Show("THÊM THẤT BẠI", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
