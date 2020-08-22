using QLCuaHangBanXeMayDien.QuanLy_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangBanXeMayDien
{
    public partial class frmMainController : Form
    {
        private AccountLogin account = new AccountLogin();

        public frmMainController(AccountLogin transmission)
        {
            InitializeComponent();
            account = transmission;
         
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoa frm = new frmHangHoa(account);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien(account);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frm = new frmNhaCungCap(account);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang frm = new frmNhapHang();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            frmBanHang frm = new frmBanHang();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            frmDoanhThu frm = new frmDoanhThu();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnHangTon_Click(object sender, EventArgs e)
        {
            frmKhoHang frm = new frmKhoHang();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void linkLabelFB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/We-Love-ANIG-100678891551670");
        }

        private void toolStripMenuItemThongTin_Click(object sender, EventArgs e)
        {
            frmAccountInformation frm = new frmAccountInformation(account);
            frm.ShowDialog();
        }

        private void toolStripMenuItemChangePass_Click(object sender, EventArgs e)
        {
            frmChangePassWord frm = new frmChangePassWord(account);
            frm.ShowDialog();
        }

        private void frmMainController_Load(object sender, EventArgs e)
        {
            if(account.LoaiTaiKhoan == 0)
            {
                toolStripMenuAdmin.Enabled = false;
            }    
        }
    }
}
