using System;
using System.Data;

namespace QLCuaHangBanXeMayDien.QuanLy_DTO
{
    public class NhanVien
    {
        private string maNhanVien;
        private string tenNhanVien;
        private int namSinh;
        private string gioiTinh;
        private string dienThoai;
        private string diaChi;
        private string chucVu;
        private float luong;
        #region Get and set Attributes
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public float Luong { get => luong; set => luong = value; }
        #endregion
        #region Contructors
        public NhanVien() { }

        public NhanVien(string maNV, string tenNV, int namSinh, string gioiTinh, string dienThoai, string diaChi, string chucVu, float luong )
        {
            this.maNhanVien = maNV; ;
            this.tenNhanVien = tenNV;
            this.namSinh = namSinh;
            this.gioiTinh = gioiTinh;
            this.dienThoai = dienThoai;
            this.diaChi = diaChi;
            this.chucVu = chucVu;
            this.luong = luong;
        }

        public NhanVien(DataRow row)
        {
            this.maNhanVien = row["MaNhanVien"].ToString(); ;
            this.tenNhanVien = row["TenNhanVien"].ToString();
            this.namSinh = (int)row["NamSinh"];
            this.gioiTinh = row["GioiTinh"].ToString();
            this.dienThoai = row["DienThoai"].ToString();
            this.diaChi = row["DiaChi"].ToString();
            this.chucVu = row["ChucVu"].ToString();
            this.luong = (float)row["Luong"];
        }
        #endregion
    }
}
