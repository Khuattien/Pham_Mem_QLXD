using QLCuaHangBanXeMayDien.QuanLy_DAO;
using QLCuaHangBanXeMayDien.QuanLy_DTO;
using System;
using System.Collections.Generic;
using System.Data;


namespace QLCuaHangBanXeMayDien.QuanLy_BUS
{
    public class MatHangBUS
    {
        private static MatHangBUS instance;

        public static MatHangBUS Instance 
        {
            get { if (instance == null) instance = new MatHangBUS(); return instance; }
            private set => instance = value; 
        }

        private MatHangBUS() { }
        /// <summary>
        /// Phương thức lấy ra một danh sách các mặt hàng từ database
        /// </summary>
        /// <returns>  List<MatHang>  </returns>
        public List<MatHang> getListMatHang()
        {
            List<MatHang> listHang = new List<MatHang>();

            //Lấy dữ liệu đưa vào bảng.

            string query = "SELECT * FROM dbo.MatHang";
            DataTable result = new DataTable();
            result = DataProvider.Instance.ExecuteQuery(query);

            if(result != null)
            {
                foreach(DataRow item in result.Rows)
                {
                   //trả về một đối tượng xe điện từ một dòng trong bảng result
                    MatHang xeDien = new MatHang(item);
                    //Thêm đối tượng vào danh sách.
                    listHang.Add(xeDien);
                }    
            }  
            
            return listHang;
        }

        /// <summary>
        /// Phương thức thêm một mặt hàng mới
        /// </summary>
        /// <param name="maH"> mã hàng</param>
        /// <param name="tenH"> tên hàng</param>
        /// <param name="nsx"> nhà sản xuất</param>
        /// <param name="moTa"> mô tả</param>
        /// <param name="ttBaoHanh"> thông tin bảo hành</param>
        /// <param name="soLuong"> số lương </param>
        /// <param name="donVi">  đơn vị </param>
        /// <param name="anhMinhHoa"> đường dẫn ảnh minh họa </param>
        /// <returns> 
        /// Trả về true nếu thêm thành công
        /// Ngược lại false nếu thêm không thành công
        /// </returns>
        public bool InsertMatHang(string maH,  string tenH, string nsx, string moTa, string ttBaoHanh, int soLuong, string donVi, int giaBan ,string anhMinhHoa)
        {
            string query = "EXEC dbo.USP_InsertMatHang @maHang , @tenHang , @nhaSX , @moTa , @thongtinBH , @soLuong , @donVi , @giaBan , @anhMinhHoa";

            ///<param name="result"> đếm số dòng thực hiện thành công của ExecuteNonQuery </param>
            int result = 0;
            result =  DataProvider.Instance.ExecuteNonQuery(query , new object[] { maH, tenH, nsx, moTa, ttBaoHanh, soLuong, donVi, giaBan, anhMinhHoa});
            // Đúng khi ExecuteNonQuery thực hiện được ít nhất 1 lần.
            return result > 0;
        }

        /// <summary>
        /// Phương thức thực sửa thông tin của một mặt hàng.
        /// </summary>
        public bool UpdateMatHang(string maH, string tenH, string nsx, string moTa, string ttBaoHanh, int soLuong, string donVi, int giaBan,string anhMinhHoa)
        {
            string query = "EXEC dbo.USP_UpdateMatHang @maHang , @tenHang , @nhaSX , @moTa , @thongtinBH , @soLuong , @donVi , @giaBan , @anhMinhHoa";
            int result = 0;
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maH, tenH, nsx, moTa, ttBaoHanh, soLuong, donVi, giaBan, anhMinhHoa });
            return result > 0;
        }

        /// <summary>
        /// Phương thức xóa mặt hàng bằng mã mặt hàng
        /// </summary>
        /// <param name="maH"> mã mặt hàng</param>
        /// <returns>trả về true nếu reuslt  > 0 va ngược lại</returns>
        public bool DeleteMatHang(string maH)
        {
            string query = "EXEC dbo.USP_DeleteMatHang @maHang ";
            int result = 0;
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maH });
            return result > 0;
        }

        /// <summary>
        /// Phương thức tìm kiếm mặt hàng theo tên 
        /// </summary>
        /// <param name="name"> truyền vào tên cần tìm kiếm </param>
        /// <returns> trả về một danh sách các kêt quả</returns>
        public List<MatHang> getListMatHangByNanme(string name)
        {
            List<MatHang> listHang = new List<MatHang>();
            string query = string.Format("SELECT * FROM dbo.MatHang WHERE TenHang LIKE '%{0}%' " , name);
            DataTable result = new DataTable();
            result = DataProvider.Instance.ExecuteQuery(query);

            if (result != null)
            {
                foreach (DataRow item in result.Rows)
                {
                    //trả về một đối tượng xe điện từ một dòng trong bảng result
                    MatHang xeDien = new MatHang(item);
                    //Thêm đối tượng vào danh sách.
                    listHang.Add(xeDien);
                }
            }
            return listHang;
        }
        /// <summary>
        /// Phương thức tìm kiếm mặt hàng theo mã hàng
        /// </summary>
        /// <param name="ID"> truyền vào mã cần tìm </param>
        /// <returns></returns>
        public DataTable getListMatHangByID(string ID)
        {
            string query = string.Format("SELECT * FROM dbo.MatHang WHERE MaHang LIKE '%{0}%' ", ID);
            DataTable result = new DataTable();
            result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
    }
}
