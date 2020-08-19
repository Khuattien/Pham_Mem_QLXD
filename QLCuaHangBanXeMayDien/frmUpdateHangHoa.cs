using QLCuaHangBanXeMayDien.QuanLy_BUS;
using QLCuaHangBanXeMayDien.QuanLy_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangBanXeMayDien
{
    public partial class frmUpdateHangHoa : Form
    {
        private MatHang xeDien = new MatHang();
        public frmUpdateHangHoa( MatHang transmission)
        {
            InitializeComponent();

            xeDien = transmission;
            showInforMatHang();
        }


        /// <summary>
        /// Phương thức hiển thị thông tin của sản phẩm trước khi sửa lên form
        /// </summary>
        private void showInforMatHang()
        {
            txbTenHang.Text = xeDien.TenHang;
            txbNhaSX.Text = xeDien.NhaSanXuat;
            numSoLuong.Value = xeDien.SoLuong;
            txbDonVi.Text = xeDien.DonViTinh;
            txbMoTa.Text = xeDien.MoTa;
            txbTTBH.Text = xeDien.ThongTinBaoHanh;
            picMatHang.Image = Image.FromFile(xeDien.AnhMinhHoa);
        }
        /// <summary>
        /// Phương thức gán các giá trị thay đổi cho các thuộc tính 
        /// của sản phẩm trước khi cập cập nhập lại thông tin của nó.
        /// </summary>
        private void settingDataInput()
        {
            xeDien.TenHang = txbTenHang.Text;
            xeDien.NhaSanXuat = txbNhaSX.Text;
            if (txbMoTa.Text != "")
                xeDien.MoTa = txbMoTa.Text;
            if (txbTTBH.Text != "")
                xeDien.ThongTinBaoHanh = txbTTBH.Text;
            xeDien.SoLuong = (int)numSoLuong.Value;
            if(txbDonVi.Text != "")
                xeDien.DonViTinh = txbDonVi.Text;
        }

        #region Các sự kiện trong form cập nhập thông tin hàng hóa

        /// <summary>
        ///   Sự kiển hủy thay đổi các thông tin của sản phẩm 
        /// </summary>
        private void btnCancelNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Sự lưu lại nhưng thay đổi về thông tin của sản phẩm
        /// </summary>
        private void btnSaveNV_Click(object sender, EventArgs e)
        {
            if (txbTenHang.Text == "" || txbNhaSX.Text == "")
            {
                MessageBox.Show("Mã hàng , tên hàng, nhà sản xuất không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    settingDataInput();

                    bool result = MatHangBUS.Instance.UpdateMatHang(xeDien.MaHang, xeDien.TenHang, xeDien.NhaSanXuat, xeDien.MoTa, xeDien.ThongTinBaoHanh, xeDien.SoLuong, xeDien.DonViTinh, xeDien.AnhMinhHoa);
                    if (result)
                    {
                        MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        /// <summary>
        /// Sự kiện thay đổi ảnh minh họa sản phẩm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangePic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Title = "Thêm một ảnh";
                dlg.Filter = "Image|*.jpg;*.png";
                dlg.InitialDirectory = @"D:\";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    xeDien.AnhMinhHoa = dlg.FileName;
                }
                picMatHang.Image = Image.FromFile(xeDien.AnhMinhHoa);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
