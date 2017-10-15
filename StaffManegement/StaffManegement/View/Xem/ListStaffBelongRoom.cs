using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using StaffManegement.Presenter.Sua;
using StaffManegement.Presenter.Them;
using StaffManegement.View.Them;

namespace StaffManegement.View.Xem
{
    public partial class ListStaffBelongRoom : Form
    {
        private string ID_NHANVIEN;
        public ListStaffBelongRoom()
        {
            InitializeComponent();
        }

        private void ButtonXem_Update_Click(object sender, EventArgs e)
        {
            
            String sql = "SELECT nhanvien.ID, phongban.TENPHONG, HOTEN, NGAYSINH, CMND, DIACHI, DIENTHOAI, QUOCTICH, LOAI_NV, LUONGNGAY, LUONGTHANG, BACLUONG, TONGLUONG FROM nhanvien, phongban WHERE (nhanvien.ID_PHONG = phongban.ID AND phongban.TENPHONG = '"+ txtTenphong.Text+ "')";
            XemNVPresenter xem = new XemNVPresenter(this, sql);
            DataTable dt = new DataTable();
            xem.getDA().Fill(dt);
          
            listNV_find.DataSource = dt;

        }

        static DataTable ConvertListToDataTable(List<string[]> list)
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            int columns = 0;
            foreach (var array in list)
            {
                if (array.Length > columns)
                {
                    columns = array.Length;
                }
            }

            // Add columns.
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add();
            }

            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array);
            }

            return table;
        }

        private void textBoxTenPhong_TimNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void listNV_find_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            String sql = "SELECT nhanvien.ID, phongban.TENPHONG, HOTEN, NGAYSINH, CMND, DIACHI, DIENTHOAI, QUOCTICH, LOAI_NV, LUONGNGAY, LUONGTHANG, BACLUONG, TONGLUONG FROM nhanvien, phongban WHERE (nhanvien.ID_PHONG = phongban.ID)";
            XemNVPresenter xemNVPresenter = new XemNVPresenter(this, sql);
            DataTable dt = new DataTable();
            xemNVPresenter.getDA().Fill(dt);
            listNV_find.DataSource = dt;
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {

            //UPDATE table_name
            //SET column1 = value1, column2 = value2, ...
            //WHERE condition;

            int luongngay = int.Parse(txtLuongngay.Text);
            int luongthang = int.Parse(txtLuongthang.Text);
            int bacluong = int.Parse(txtBacluong.Text);
            int tongluong = 0;
            if(luongngay != 0)
            {
                tongluong = luongngay;
            }
            else
            {
                tongluong = luongthang * bacluong;
            }

            String sql = "UPDATE nhanvien " +
                "SET HOTEN = '" + txtHoten.Text + "'," +
                "NGAYSINH = '" + txtNgaysinh.Text + "'," +
                "CMND = '" + txtCMND.Text + "'," +
                "DIACHI = '" + txtDiachi.Text + "'," +
                "DIENTHOAI = '" + txtDienthoai.Text + "'," +
                "QUOCTICH = '" + txtQuoctich.Text + "'," +
                "LOAI_NV = '" + txtLoai.Text + "'," +
                "LUONGNGAY = '" + txtLuongngay.Text + "'," +
                "LUONGTHANG = '" + txtLuongthang.Text + "'," +
                "BACLUONG = '" + txtBacluong.Text + "'," +
                "TONGLUONG = '"+ tongluong + "' " +
                "WHERE ID = " + ID_NHANVIEN;
            UpdatePresenter updatePresenter = new UpdatePresenter(this, sql);

            //try
            //{
            //    //This is my connection string i have assigned the database file address path  
            //    string MyConnection2 = "datasource=localhost;database=quanlynhanvien;port=3306;username=root;password=''";
            //    //This is my update query in which i am taking input from the user through windows forms and update the record.  
            //    //string Query = "update student.studentinfo set idStudentInfo='" + this.IdTextBox.Text + "',Name='" + this.NameTextBox.Text + "',Father_Name='" + this.FnameTextBox.Text + "',Age='" + this.AgeTextBox.Text + "',Semester='" + this.SemesterTextBox.Text + "' where idStudentInfo='" + this.IdTextBox.Text + "';";
            //    //This is  MySqlConnection here i have created the object and pass my connection string.  
            //    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //    MySqlCommand MyCommand2 = new MySqlCommand(sql, MyConn2);
            //    MySqlDataReader MyReader2;
            //    MyConn2.Open();
            //    MyReader2 = MyCommand2.ExecuteReader();
            //    MessageBox.Show("Data Updated");
            //    while (MyReader2.Read())
            //    {
            //    }
            //    MyConn2.Close();//Connection closed here  
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void listNV_find_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = listNV_find.Rows[indexRow];
            ID_NHANVIEN = row.Cells[0].Value.ToString();
            txtPhong.Text = row.Cells[1].Value.ToString();
            txtHoten.Text = row.Cells[2].Value.ToString();
            txtNgaysinh.Text = row.Cells[3].Value.ToString();
            txtCMND.Text = row.Cells[4].Value.ToString();
            txtDiachi.Text = row.Cells[5].Value.ToString();
            txtDienthoai.Text = row.Cells[6].Value.ToString();
            txtQuoctich.Text = row.Cells[7].Value.ToString();
            txtLoai.Text = row.Cells[8].Value.ToString();
            txtLuongngay.Text = row.Cells[9].Value.ToString();
            txtLuongthang.Text = row.Cells[10].Value.ToString();
            txtBacluong.Text = row.Cells[11].Value.ToString();
            Console.WriteLine("ID_NHANVIEN = "+ID_NHANVIEN);
        }

        private void button2_Click(object sender, EventArgs e) // Xem lương cao nhất
        {
            String sql = "SELECT nhanvien.ID, phongban.TENPHONG, HOTEN, NGAYSINH, CMND, DIACHI, DIENTHOAI, QUOCTICH, LOAI_NV, LUONGNGAY, LUONGTHANG, BACLUONG, TONGLUONG FROM nhanvien, phongban WHERE ((nhanvien.ID_PHONG = phongban.ID) AND nhanvien.TONGLUONG = (SELECT MAX(TONGLUONG) FROM nhanvien))";
            XemNVPresenter xemNVPresenter = new XemNVPresenter(this, sql);
            DataTable dt = new DataTable();
            xemNVPresenter.getDA().Fill(dt);
            listNV_find.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStaff addStaff = new AddStaff();
            addStaff.Show();
        }
    }
}
