using System;
using System.Data;

namespace QLCuaHangBanXeMayDien.QuanLy_DTO
{
    public class PhieuXuat
    {
        private string maPhieuXuat;
        private string maNhanVien;
        private string maKhachHang;
        private DateTime ngayXuat;

        #region get and set attributes
        public string MaPhieuXuat { get => maPhieuXuat; set => maPhieuXuat = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public DateTime NgayXuat { get => ngayXuat; set => ngayXuat = value; }
        #endregion

        #region Contructors
        public PhieuXuat() { }


        public PhieuXuat(string maPX, string maNV, string maKH, DateTime ngayXuat)
        {
            this.maPhieuXuat = maPX;
            this.maNhanVien = maNV;
            this.maKhachHang = maKH;
            this.ngayXuat = ngayXuat;
        }

        public PhieuXuat(DataRow row )
        {
            this.maPhieuXuat = row["MaPhieuXuat"].ToString();
            this.maNhanVien = row["MaNhanVien"].ToString();
            this.maKhachHang = row["MaKhachHang"].ToString();
            this.ngayXuat = (DateTime)row["NgayXuat"];
        }
        #endregion
    }
}
