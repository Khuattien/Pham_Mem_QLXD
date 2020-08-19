using System;
using System.Data;
using System.Runtime.InteropServices;

namespace QLCuaHangBanXeMayDien.QuanLy_DTO
{
    public class ChiTietPhieuNhap
    {
        private string maPhieuNhap;
        private string maHang;
        private int soLuongNhap;
        private float donGiaNhap;
        private float thue;

        #region get and set attributes
        public string MaPhieuNhap { get => maPhieuNhap; set => maPhieuNhap = value; }
        public string MaHang { get => maHang; set => maHang = value; }
        public int SoLuongNhap { get => soLuongNhap; set => soLuongNhap = value; }
        public float DonGiaNhap { get => donGiaNhap; set => donGiaNhap = value; }
        public float Thue { get => thue; set => thue = value; }
        #endregion

        #region Contructors
        public ChiTietPhieuNhap() { }

        public ChiTietPhieuNhap(string maPN, string maHang, int sLNhap, float donGia, float thue)
        {
            this.maPhieuNhap = maPN;
            this.maHang = maHang;
            this.soLuongNhap = sLNhap;
            this.donGiaNhap = donGia;
            this.thue = thue;
        }

        public ChiTietPhieuNhap(DataRow row)
        {
            this.maPhieuNhap = row["MaPhieuNhap"].ToString();
            this.maHang = row["MaHang"].ToString();
            this.soLuongNhap = (int)row["SoLuongNhap"];
            this.donGiaNhap = (float)row["DonGiaNhap"];
            this.thue = (float)row["Thue"];
        }
        #endregion
    }
}
