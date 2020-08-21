using QLCuaHangBanXeMayDien.QuanLy_DAO;
using System.Data;

namespace QLCuaHangBanXeMayDien.QuanLy_BUS
{
    public class NhaCungCapBUS
    {
        private static NhaCungCapBUS instance;

        public static NhaCungCapBUS Instance
        {
            get { if (instance == null) instance = new NhaCungCapBUS(); return instance; }
            private set => instance = value;
        }

        private NhaCungCapBUS() { }
        /// <summary>
        /// Phương thức lấy ra một danh sách các nhà cung cấp từ database
        /// </summary>
        /// <returns>  DataTable  </returns>
        public DataTable GetDataNhaCC()
        {

            //lấy dữ liệu vào bảng
            string query = "SELECT * FROM dbo.NhaCungCap";
            DataTable result = new DataTable();
            result = DataProvider.Instance.ExecuteQuery(query);

            return result;
        }
        /// <summary>
        /// phương thức thêm 1 nhà cc mới
        /// </summary>
        /// <param name="maNcc"></param>
        /// <param name="tenMcc"></param>
        /// <param name="diaC"></param>
        /// <param name="dienT"></param>
        /// <param name="email"></param>
        /// <returns>
        /// true nếu thành công
        /// false nếu thất bại
        /// </returns>
        public bool InsertNhaCC(string maNcc, string tenMcc, string diaC, string dienT, string email)
        {
            string query = "EXEC dbo.USP_InsertNhaCC @MaNhaCungCap , @TenNhaCungCap , @DiaChi , @DienThoai , @Email";

            int result = 0;
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNcc, tenMcc, diaC, dienT, email });

            return result > 0;
        }

        /// <summary>
        /// phương thứ sửa 1 nhà cung cấp
        /// </summary>
        /// <param name="maNcc"></param>
        /// <param name="tenNcc"></param>
        /// <param name="diaC"></param>
        /// <param name="dienT"></param>
        /// <param name="email"></param>
        /// <returns>
        /// true nếu thành công
        /// false nếu thất bại
        /// </returns>

        public bool UpdateNhaCC(string maNcc, string tenNcc, string diaC, string dienT, string email)
        {
            string query = "EXEC USP_UpdateNhaCC @MaNhaCungCap , @TenNhaCungCap , @DiaChi , @DienThoai , @Email";

            int result = 0;
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNcc, tenNcc, diaC, dienT, email });

            return result > 0;
        }

        /// <summary>
        /// phương thức xóa thông tin nhà cung cấp
        /// </summary>
        /// <param name="maNcc"></param>
        /// <returns>
        /// true nếu thàng công
        /// false nếu không thành công
        /// </returns>

        public bool DeleteNhaCC(string maNcc)
        {
            string query = "EXEC dbo.USP_DeleteNhaCC @MaNhaCungCap ";

            int result = 0;
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNcc });

            return result > 0;
        }
        /// <summary>
        /// phương thức tìm kiếm khách hàng
        /// </summary>
        /// <param name="tenKh"></param>
        /// <returns>datatable</returns>
        public DataTable SearchNhaCC(string text)
        {
            string query = "SELECT * FROM NhaCungCap WHERE MaNhaCungCap LIKE '%" + text + "%'";

            DataTable result = new DataTable();
            result = DataProvider.Instance.ExecuteQuery(query);

            return result;
        }
    }
}
