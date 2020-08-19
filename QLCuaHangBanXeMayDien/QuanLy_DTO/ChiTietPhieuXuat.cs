using System;
using System.Data;

namespace QLCuaHangBanXeMayDien.QuanLy_DTO
{
    public class ChiTietPhieuXuat
    {
        private string maPhieuXuat;
        private string maHang;
        private int soLuongXuat;
        private float donGiaXuat;
        private float thue;

        #region set and get attributes
        public string MaPhieuXuat { get => maPhieuXuat; set => maPhieuXuat = value; }
        public string MaHang { get => maHang; set => maHang = value; }
        public int SoLuongXuat { get => soLuongXuat; set => soLuongXuat = value; }
        public float DonGiaXuat { get => donGiaXuat; set => donGiaXuat = value; }
        public float Thue { get => thue; set => thue = value; }
        #endregion

        #region Contructors
        public ChiTietPhieuXuat() { }

        public ChiTietPhieuXuat(string maPX, string maHang, int sLXuat, float donGiaXuat, float thue)
        {
            this.maPhieuXuat = maPX;
            this.maHang = maHang;
            this.soLuongXuat = sLXuat;
            this.donGiaXuat = donGiaXuat;
            this.thue = thue;
        }

        public ChiTietPhieuXuat(DataRow row)
        {
            this.maPhieuXuat = row["MaPhieuXuat"].ToString();
            this.maHang = row["MaHang"].ToString();
            this.soLuongXuat = (int)row["SoLuongXuat"];
            this.donGiaXuat = (float)row["DonGiaXuat"];
            this.thue = (float)row["Thue"];
        }
        #endregion
    }
}
