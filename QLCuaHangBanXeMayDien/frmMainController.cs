﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangBanXeMayDien
{
    public partial class frmMainController : Form
    {
        public frmMainController()
        {
            InitializeComponent();
         
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoa frm = new frmHangHoa();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
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
            frmNhaCungCap frm = new frmNhaCungCap();
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

    }
}
