using System;
using System.Data;
using System.Net.Http.Headers;

namespace QLCuaHangBanXeMayDien.QuanLy_DTO
{
    public class PhieuNhap
    {
        private string maPhieuNhap;
        private string maNhanVien;
        private string maNhacCungCap;
        private DateTime ngayNhap;

        #region get and set attributes
        public string MaPhieuNhap { get => maPhieuNhap; set => maPhieuNhap = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string MaNhacCungCap { get => maNhacCungCap; set => maNhacCungCap = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        #endregion

        #region Contructors
        public PhieuNhap() { }

        public PhieuNhap(string maPN, string maNV, string maNCC, DateTime ngayNhap)
        {
            this.maPhieuNhap = maPN;
            this.maNhanVien = maNV;
            this.maNhacCungCap = maNCC;
            this.ngayNhap = ngayNhap;
        }

        public PhieuNhap(DataRow row)
        {
            this.maPhieuNhap = row["MaPhieuNhap"].ToString();
            this.maNhanVien = row["MaNhanVien"].ToString();
            this.maNhacCungCap = row["MaNhacCungCap"].ToString();
            this.ngayNhap = (DateTime)row[""];
        }
        #endregion
    }
}
