using System;
using System.Data;

namespace QLCuaHangBanXeMayDien.QuanLy_DTO
{
    public class KhachHang
    {
        private string maKhachHang;
        private string tenKhacHang;
        private string diaChi;
        private string dienThoai;
        private string email;

        #region Get and Set Attributes
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string TenKhacHang { get => tenKhacHang; set => tenKhacHang = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string Email { get => email; set => email = value; }
        #endregion

        #region Contructors
        public KhachHang() { }
        
        public KhachHang(string maKH, string tenKH, string diaChi, string dienThoai, string email)
        {
            this.maKhachHang = maKH;
            this.tenKhacHang = tenKH;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
            this.email = email;
        }

        public KhachHang(DataRow row)
        {
            this.maKhachHang = row["MaKhachHang"].ToString();
            this.tenKhacHang = row["TenKhacHang"].ToString();
            this.diaChi = row["DiaChi"].ToString();
            this.dienThoai = row["DienThoai"].ToString();
            this.email = row["Email"].ToString();
        }
        #endregion
    }
}
