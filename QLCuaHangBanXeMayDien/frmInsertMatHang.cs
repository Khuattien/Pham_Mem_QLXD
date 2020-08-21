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
    public partial class frmInsertMatHang : Form
    {
        public frmInsertMatHang()
        {
            InitializeComponent();
        }
        MatHang xeDien = new MatHang();
        /// <summary>
        /// Phương thức gán các giá trị cho các thuộc tính của sản phẩm mới trước khi thêm
        /// </summary>
        private void settingDataInput()
        {
            xeDien.MaHang = txbMaHang.Text;
            xeDien.TenHang = txbTenHang.Text;
            xeDien.NhaSanXuat = txbNSX.Text;

            if (txbMoTa.Text != "")
                xeDien.MoTa = txbMoTa.Text;

            if (txbTTBH.Text != "")
                xeDien.ThongTinBaoHanh = txbTTBH.Text;

            xeDien.SoLuong = (int)numSoLuong.Value;

            if (txbDVTinh.Text != "")
                xeDien.DonViTinh = txbDVTinh.Text;

            if (txbGiaBan.Text != "")
                xeDien.GiaBan = int.Parse(txbGiaBan.Text);
            else
                xeDien.GiaBan = 0;
        }

        #region Các sự kiện trong form

        /// <summary>
        /// Sự kiện kiểm tra giá bán nhập vào có đúng là số
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbGiaBan_TextChanged(object sender, EventArgs e)
        {
            int val;
            if (int.TryParse(txbGiaBan.Text, out val) == false && txbGiaBan.Text != "")
            {
                MessageBox.Show("Giá bán phải là một con số và giá tối đa hiện tại cho phép là 2,1 tỷ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Sự kiện thêm ảnh minh họa cho sản phẩm sắp được thêm
        /// </summary>
        private void btnAddPic_Click(object sender, EventArgs e)
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
                    picMathang.Image = Image.FromFile(xeDien.AnhMinhHoa);
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Sự kiện lưu sản phẩm mới vừa nhập
        /// </summary>
        private void btnSaveMatHangMoi_Click(object sender, EventArgs e)
        {
            if (txbMaHang.Text == "" || txbTenHang.Text == "" || txbNSX.Text == "")
            {
                MessageBox.Show("Mã hàng , tên hàng, nhà sản xuất không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (xeDien.AnhMinhHoa == "")
            {
                MessageBox.Show("Hãy thêm ảnh minh họa cho chiếc xe.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    settingDataInput();
                    bool result = MatHangBUS.Instance.InsertMatHang(xeDien.MaHang, xeDien.TenHang, xeDien.NhaSanXuat, xeDien.MoTa, xeDien.ThongTinBaoHanh, xeDien.SoLuong, xeDien.DonViTinh, xeDien.GiaBan,xeDien.AnhMinhHoa);
                    if (result)
                    {
                        MessageBox.Show("Thêm thành công.");
                        this.Close();
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion
    }
}
