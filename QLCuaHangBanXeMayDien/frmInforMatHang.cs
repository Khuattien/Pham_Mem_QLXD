using QLCuaHangBanXeMayDien.QuanLy_BUS;
using QLCuaHangBanXeMayDien.QuanLy_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLCuaHangBanXeMayDien
{
    public partial class frmInforMatHang : Form
    {
        MatHang XeDien = new MatHang();

        public frmInforMatHang(MatHang transmission)
        {
            InitializeComponent();

            XeDien = transmission;
            loadInfo();
        }

        /// <summary>
        /// HIển thị thông tin của sản phẩm lên form
        /// </summary>
        private void loadInfo()
        {
            lbTenHang.Text += XeDien.TenHang;
            lbNhaSX.Text += XeDien.NhaSanXuat;
            lbSL.Text += XeDien.SoLuong;
            lbDonVi.Text = XeDien.DonViTinh;
            lbGiaBan.Text += XeDien.GiaBan;
            txbMota.Text = XeDien.MoTa;
            txbThongTinBaoHanh.Text = XeDien.ThongTinBaoHanh;
        }

        /// <summary>
        /// Sự kiện sửa đổi thông tin của sản phẩm trong một form mới
        /// </summary>
        private void btnUpdateHangHoa_Click(object sender, EventArgs e)
        {
            frmUpdateHangHoa frm = new frmUpdateHangHoa(XeDien);
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Sự kiện xóa sản phẩm khỏi danh sách
        /// </summary>
        private void btnDeleleHangHoa_Click(object sender, EventArgs e)
        {
            if (XeDien.SoLuong > 0)
                MessageBox.Show("Số lượng mặt hàng này vẫn còn không thể xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        bool result = MatHangBUS.Instance.DeleteMatHang(XeDien.MaHang);
                        if (result)
                        {
                            MessageBox.Show("Bạn đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
        }
    }
}
