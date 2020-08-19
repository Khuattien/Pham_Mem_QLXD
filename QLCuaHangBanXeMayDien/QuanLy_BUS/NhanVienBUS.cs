using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLCuaHangBanXeMayDien.QuanLy_DAO;

namespace QLCuaHangBanXeMayDien.QuanLy_BUS
{
    public class NhanVienBUS
    {
        private static NhanVienBUS instance;

        public static NhanVienBUS Instance
        {
            get { if (instance == null) instance = new NhanVienBUS(); return instance; }
            private set => instance = value;
        }
        private NhanVienBUS() { }

        /// <summary>
        /// Phương thức lấy ra một danh sách các nhân viên từ database
        /// </summary>
        /// <returns>  List<NhanVien>  </returns>
        public DataTable GetDataNhanVien()
        {

            //lấy dữ liệu vào bảng
            string query = "SELECT * FROM NhanVien";
            DataTable result = new DataTable();
            result =DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        ///  <summary>
        ///  phương thức thêm nhân viên mới vào cơ sở dữ liệu
        ///  </summary>
        ///  <returns>
        ///  true nếu thêm thành công
        ///  false nếu không thành công
        ///  </returns>

        public bool InsertNhanvien(string manv, string tennv, int namsinh, string gt, int dt, string diachi, string chucvu, float luong)
        {
            string query = "EXEC USP_InsertNhanVien @manv , @tennv , @namsinh , @gt , @dt , @diachi , @chucvu , @luong";

            ///<param name="result"> đếm số dòng thực hiện thành công của ExecuteNonQuery </param>
            int result = 0;
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { manv, tennv, namsinh, gt, dt, diachi, chucvu, luong });
            // Đúng khi ExecuteNonQuery thực hiện được ít nhất 1 lần.
            return result > 0;

        }

        /// <summary>
        /// phương thức sửa thông tin nhân viên
        /// </summary>
        /// <param name="maKh"></param>
        /// <param name="tenKh"></param>
        /// <param name="diaC"></param>
        /// <param name="dienT"></param>
        /// <param name="email"></param>
        /// <returns></returns>

        public bool UpdateNhanVien(string manv, string tennv, int namsinh, string gt, int dt, string diachi, string chucvu, float luong)
        {
            string query = "EXEC USP_UpdateNhanVien @manv , @tennv , @namsinh , @gt , @dt , @diachi , @chucvu , @luong";
            int result = 0;
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { manv, tennv, namsinh, gt, dt, diachi, chucvu, luong });
            return result > 0;
        }

        /// <summary>
        /// phương thức xóa thông tin nhân viên
        /// </summary>
        /// <returns></returns>

        public bool DeleteNhanVien(string manv)
        {
            string query = "EXEC USP_DeleteNhanVien @manv ";
            int result = 0;
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { manv });
            return result > 0;
        }
        /// <summary>
        /// phương thức tìm kiếm nhân viên
        /// </summary>
        /// <returns></returns>
        public DataTable SearchNhanVien(string text)
        {
            string query = "SELECT * FROM NhanVien WHERE MaKhachHang LIKE '%" + text + "%'";
            DataTable result = new DataTable();
            result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
    }
}
