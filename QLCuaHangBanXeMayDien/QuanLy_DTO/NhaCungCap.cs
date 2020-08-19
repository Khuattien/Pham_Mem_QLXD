using System;
using System.Data;
namespace QLCuaHangBanXeMayDien.QuanLy_DTO
{
    public class NhaCungCap
    {
        private string maNhaCungCap;
        private string tenNhaCungCap;
        private string diaChi;
        private int dienThoai;
        private string email;

        #region get and set attributes
        public string MaNhaCungCap { get => maNhaCungCap; set => maNhaCungCap = value; }
        public string TenNhaCungCap { get => tenNhaCungCap; set => tenNhaCungCap = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int DienThoai { get => dienThoai; set => dienThoai = value; }
        public string Email { get => email; set => email = value; }
        #endregion

        #region Contructors
        public NhaCungCap() { }
        
        public NhaCungCap(string maNCC, string tenNCC, string diaChi, int dienThoai, string email)
        {
            this.maNhaCungCap = maNCC;
            this.tenNhaCungCap = tenNCC;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
            this.email = email;
        }

        public NhaCungCap(DataRow row)
        {
            this.maNhaCungCap = row["MaNhaCungCap"].ToString();
            this.tenNhaCungCap = row["TenNhaCungCap"].ToString();
            this.diaChi = row["DiaChi"].ToString();
            this.dienThoai = (int)row["DienThoai"];
            this.email = row["Email"].ToString();
        }
        #endregion
    }
}
