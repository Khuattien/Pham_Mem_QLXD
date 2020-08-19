using System;
using System.Data;

namespace QLCuaHangBanXeMayDien.QuanLy_DTO
{
    public class AccountLogin
    {
        private string userName;
        private string passWord;
        private int loaiTaiKhoan;
        private string tenHienThi;
        private int dienThoai;
        private string email;
        #region Get and Set Attributes
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public int LoaiTaiKhoan { get => loaiTaiKhoan; set => loaiTaiKhoan = value; }
        public string TenHienThi { get => tenHienThi; set => tenHienThi = value; }
        public int DienThoai { get => dienThoai; set => dienThoai = value; }
        public string Email { get => email; set => email = value; }
        #endregion
        #region Contructors
        public AccountLogin() { }
        public AccountLogin(string userName, string passWord, int loaiTaiKhoan, string tenHienThi,int dienThoai, string email)
        {
            this.userName = userName;
            this.passWord = passWord;
            this.loaiTaiKhoan = loaiTaiKhoan;
            this.tenHienThi = tenHienThi;
            this.dienThoai = dienThoai;
            this.email = email;
        }

        public AccountLogin(DataRow row)
        {
            this.userName = row["UserName"].ToString();
            this.passWord = row["PassWord"].ToString();
            this.loaiTaiKhoan = (int)row["LoaiTaiKhoan"];
            this.tenHienThi = row["TenHienThi"].ToString();
            this.dienThoai = (int)row["TenHienThi"];
            this.email = row["Email"].ToString();
        }
        #endregion
    }
}
