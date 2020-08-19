using QLCuaHangBanXeMayDien.QuanLy_DAO;
using QLCuaHangBanXeMayDien.QuanLy_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangBanXeMayDien.QuanLy_BUS
{
    public class KhachHangBUS
    {
        private static KhachHangBUS instance;

        public static KhachHangBUS Instance 
        {
            get { if (instance == null) instance = new KhachHangBUS(); return instance; }
            private set => instance = value;
        }

        private KhachHangBUS(){}
        /// <summary>
        /// Phương thức lấy ra một danh sách các mặt hàng từ database
        /// </summary>
        /// <returns>  List<KhachHang>  </returns>
        public DataTable GetDataKhachHang()
        {

            //lấy dữ liệu vào bảng
            string query = "SELECT * FROM dbo.KhachHang";
            DataTable result = new DataTable();
            result = DataProvider.Instance.ExecuteQuery(query);

            return result;
        }
        ///  <summary>
        ///  phương thức thêm khách hàng mới vào cơ sở dữ liệu
        ///  </summary>
        ///  <param name="maKh">MaKhachHang</param>
        ///  <param name="tenKh">TenKhachHang</param>
        ///  <param name="diaC">DiaChi</param>
        ///  <param name="dienT">DienThoai</param>
        ///  <param name="email">Email</param>
        ///  <returns>
        ///  true nếu thêm thành công
        ///  false nếu không thành công
        ///  </returns>
         
        public bool InsertKhachHang(string maKh, string tenKh, string diaC, int dienT, string email)
        {
            string query = "EXEC dbo.USP_InsertKhanhHang @MaKhachHang , @TenKhachHang , @DiaChi , @DienThoai , @Email";

            int result = 0;
            result = DataProvider.Instance.ExecuteNonQuery(query,new object[] { maKh, tenKh,  diaC, dienT, email } );

            return result > 0;
        }

        /// <summary>
        /// phương thức sửa thông tin khách hàng
        /// </summary>
        /// <param name="maKh"></param>
        /// <param name="tenKh"></param>
        /// <param name="diaC"></param>
        /// <param name="dienT"></param>
        /// <param name="email"></param>
        /// <returns></returns>

        public bool UpdateKhachHang(string maKh, string tenKh, string diaC, int dienT, string email)
        {
            string query = "EXEC USP_UpdateKhanhHang @MaKhachHang , @TenKhachHang , @DiaChi , @DienThoai , @Email";

            int result = 0;
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maKh, tenKh, diaC, dienT, email });

            return result > 0;
        }

        /// <summary>
        /// phương thức xóa thông tin khách hàng
        /// </summary>
        /// <param name="maKh"></param>
        /// <returns></returns>

        public bool DeleteKhachHang(string maKh)
        {
            string query = "EXEC dbo.USP_DeleteKhanhHang @MaKhachHang ";

            int result = 0;
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maKh });

            return result > 0;
        }
        /// <summary>
        /// phương thức tìm kiếm khách hàng
        /// </summary>
        /// <param name="tenKh"></param>
        /// <returns></returns>
        public DataTable SearchKhachHang(string text)
        {
            string query = "SELECT * FROM KhachHang WHERE MaKhachHang LIKE '%"+text+"%'";

            DataTable result = new DataTable();
            result = DataProvider.Instance.ExecuteQuery(query);

            return result;
        }
    }
}
