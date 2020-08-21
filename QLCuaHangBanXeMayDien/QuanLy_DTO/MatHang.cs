using System;
using System.Data;

namespace QLCuaHangBanXeMayDien.QuanLy_DTO
{
    public class MatHang
    {
        private string maHang;
        private string tenHang;
        private string nhaSanXuat;
        private string moTa;
        private string thongTinBaoHanh;
        private int soLuong;
        private string donViTinh;
        private int giaBan;
        private string anhMinhHoa;    // ảnh minh họa được lưu dưới dạng đường dẫn của máy cục bộ.

        #region Get and Set Attributes 
        public string MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public string NhaSanXuat { get => nhaSanXuat; set => nhaSanXuat = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string ThongTinBaoHanh { get => thongTinBaoHanh; set => thongTinBaoHanh = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public string AnhMinhHoa { get => anhMinhHoa; set => anhMinhHoa = value; }
        #endregion
        #region Contructors
        public MatHang()
        {
            this.maHang = "";
            this.tenHang = "";
            this.nhaSanXuat = "";
            this.moTa = "Không có";
            this.thongTinBaoHanh = "Không có";
            this.soLuong = 0;
            this.donViTinh = "Chiếc";
            this.giaBan = 0;
            this.anhMinhHoa = "";
        }

        public MatHang(string maH, string tenH, string nhaSX, string moTa, string ttBaoHanh, int soLuong, string donVi, int giaBan , string image)
        {
            this.maHang = maH;
            this.tenHang = tenH;
            this.nhaSanXuat = nhaSX;
            this.moTa = moTa;
            this.thongTinBaoHanh = ttBaoHanh;
            this.soLuong = soLuong;
            this.donViTinh = donVi;
            this.giaBan = giaBan;
            this.anhMinhHoa = image;
        }

        public MatHang(DataRow row)
        {
            this.maHang = row["MaHang"].ToString();
            this.tenHang = row["TenHang"].ToString();
            this.nhaSanXuat = row["NhaSanXuat"].ToString();
            this.moTa = row["MoTa"].ToString();
            this.thongTinBaoHanh = row["ThongTinBaoHanh"].ToString();
            this.soLuong = (int)row["SoLuong"];
            this.donViTinh = row["DonViTinh"].ToString();
            this.giaBan = int.Parse(row["GiaBan"].ToString());
            this.anhMinhHoa = row["AnhMinhHoa"].ToString();
        }
        #endregion

    }
}
