using QLCuaHangBanXeMayDien.QuanLy_BUS;
using QLCuaHangBanXeMayDien.QuanLy_DAO;
using QLCuaHangBanXeMayDien.QuanLy_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLCuaHangBanXeMayDien
{
    public partial class frmDSChiTietHangHoa : Form
    {
        public frmDSChiTietHangHoa()
        {
            InitializeComponent();
            loadData();
            setEnableButton1();
            setEnableTextBox1();
        }

        private MatHang xeDien = new MatHang();
        //Biến đánh dấu sự kiện sửa thông tin hàng hóa xuất hiện
        public bool btnInsertStatus = false;

        #region Các phương thức load dữ liệu
        /// <summary>
        /// Phương thức hiển thị danh sách các thông tin của từng sản phẩm
        /// </summary>
        private void loadData()
        {
            dtgvDanhSach.DataSource = DataProvider.Instance.ExecuteQuery("select * from dbo.MatHang");
        }

        /// <summary>
        /// Phương thức hiển thị thông tin của từng sản phẩm lên các textbox, picturebox,...
        /// </summary>
        /// <param name="row"></param>
        private void loadInForRowFromDatagridview(int row)
        {
            txbMaHang.Text = dtgvDanhSach.Rows[row].Cells["colMaHang"].Value.ToString();
            txbTenHang.Text = dtgvDanhSach.Rows[row].Cells["colTenHang"].Value.ToString();
            txbNhaSX.Text = dtgvDanhSach.Rows[row].Cells["colNSX"].Value.ToString();
            txbMoTa.Text = dtgvDanhSach.Rows[row].Cells["colMoTa"].Value.ToString();
            txbBaoHanh.Text = dtgvDanhSach.Rows[row].Cells["colBaoHanh"].Value.ToString();
            numSoLuong.Value = (int)dtgvDanhSach.Rows[row].Cells["colSoLuong"].Value;
            txbDonVi.Text = dtgvDanhSach.Rows[row].Cells["colDonVi"].Value.ToString();
            picAMH.Image = Image.FromFile(dtgvDanhSach.Rows[row].Cells["colImage"].Value.ToString());
            setEnableButton3();
        }
        #endregion

        #region Setting Controls
        /// <summary>
        /// PHương thức xóa các chữ hiển thị trên các textbox,..
        /// </summary>
        private void clearTextbox()
        {
            txbMaHang.ResetText();
            txbTenHang.ResetText();
            txbNhaSX.ResetText();
            txbMoTa.ResetText();
            txbBaoHanh.ResetText();
            txbDonVi.ResetText();
            numSoLuong.Value = 0;
        }
        /// <summary>
        /// Không cho phép sửa xóa dữ liệu trên textbox... khi chưa nhấn thêm, sửa , xóa
        /// </summary>
        private void setEnableTextBox1()
        {
            txbMaHang.Enabled = false;
            txbTenHang.Enabled = false;
            txbNhaSX.Enabled = false;
            txbMoTa.Enabled = false;
            txbBaoHanh.Enabled = false;
            txbDonVi.Enabled = false;
            numSoLuong.Enabled = false;
        }
        /// <summary>
        /// Cho phép điền các thông tin vào textbox... để thêm sản phẩm mới.
        /// </summary>
        private void setEnableTextBox2()
        {
            txbMaHang.Enabled = true;
            txbTenHang.Enabled = true;
            txbNhaSX.Enabled = true;
            txbMoTa.Enabled = true;
            txbBaoHanh.Enabled = true;
            txbDonVi.Enabled = true;
            numSoLuong.Enabled = true;
        }
        /// <summary>
        /// Cho phép sửa các thông tin của sản phẩm trừ mã của sản phẩm.
        /// </summary>
        private void setEnableTextBox3()
        {
            txbMaHang.Enabled = false;
            txbTenHang.Enabled = true;
            txbNhaSX.Enabled = true;
            txbMoTa.Enabled = true;
            txbBaoHanh.Enabled = true;
            txbDonVi.Enabled = true;
            numSoLuong.Enabled = true;
        }


        /// <summary>
        ///Trạng thái button trước khi thực hiện thêm sửa.
        /// </summary>
        private void setEnableButton1()
        {

            btnInsertHang.Enabled = true;
            btnUpdateHang.Enabled = true;
            btnDeleteHang.Enabled = true;
            btnSaveHang.Enabled = false;
            btnCancelHang.Enabled = false;
            btnImage.Enabled = false;
        }

        /// <summary>
        /// Trạng thái của các button khi thực hiện thêm, sửa.
        /// </summary>
        private void setEnableButton2()
        {
            btnInsertHang.Enabled = false;
            btnUpdateHang.Enabled = false;
            btnDeleteHang.Enabled = false;
            btnSaveHang.Enabled = true;
            btnCancelHang.Enabled = true;
            btnImage.Enabled = true;
        }
        /// <summary>
        /// Trạng thái của button sửa và xóa khi click vào ô có dữ liệu trên Datagridview
        /// </summary>
        private void setEnableButton3()
        {
            btnUpdateHang.Enabled = true;
            btnDeleteHang.Enabled = true;
        }
        /// <summary>
        /// Trạng thái của button sửa và xóa khi click vào ô không có dữ liệu trên Datagridview 
        /// </summary>
        private void setEnableButton4()
        {
            btnUpdateHang.Enabled = false;
            btnDeleteHang.Enabled = false;
        }
        /// <summary>
        /// Phương thức gán các giá trị vào các thuộc tính của sản phẩm mới trước khi thêm.
        /// </summary>
        private void settingDataInputBeforeInsert()
        {
            xeDien.MaHang = txbMaHang.Text;
            xeDien.TenHang = txbTenHang.Text;
            xeDien.NhaSanXuat = txbNhaSX.Text;

            if (txbMoTa.Text != "")
                xeDien.MoTa = txbMoTa.Text;

            if (txbBaoHanh.Text != "")
                xeDien.ThongTinBaoHanh = txbBaoHanh.Text;

            xeDien.SoLuong = (int)numSoLuong.Value;

            if (txbDonVi.Text != "")
                xeDien.DonViTinh = txbDonVi.Text;

        }
        //Biến đánh dấu sự thay đổi ảnh minh họa của sản phẩm
        public bool picChanged = false;
        /// <summary>
        /// Phương thức gán các giá trị vào các thuộc tính của 
        /// sản phẩm trước khi được cập nhập lại thông tin mới.
        /// </summary>
        private void settingDataInputBeforeUpdate()
        {
            int row = dtgvDanhSach.CurrentCell.RowIndex;
            xeDien.MaHang = dtgvDanhSach.Rows[row].Cells["colMaHang"].Value.ToString();

            xeDien.TenHang = txbTenHang.Text;
            xeDien.NhaSanXuat = txbNhaSX.Text;
            if (txbMoTa.Text != "")
                xeDien.MoTa = txbMoTa.Text;
            if (txbBaoHanh.Text != "")
                xeDien.ThongTinBaoHanh = txbBaoHanh.Text;
            xeDien.SoLuong = (int)numSoLuong.Value;
            xeDien.DonViTinh = txbDonVi.Text;
            if (!picChanged)
                xeDien.AnhMinhHoa = dtgvDanhSach.Rows[row].Cells["colImage"].Value.ToString();
        }

        #endregion


        #region Các sự kiên trên form
        /// <summary>
        /// Sự kiện hiển thị thông tin của sản phẩm lên các textbox khi
        /// nhấn vào một ô thuộc tính của sản phẩm trên dòng đó
        /// </summary>
        private void dtgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dtgvDanhSach.CurrentCell.RowIndex;
                loadInForRowFromDatagridview(row);
                setEnableTextBox1();
                setEnableButton1();
            }
            catch (InvalidCastException ex)
            {
                clearTextbox();
                //MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                setEnableButton4();
            }
        }
        /// <summary>
        /// Sự kiện lấy ra một ảnh dưới dạng đường dẫn thư mục đến ảnh đó
        /// để thêm hoặc sửa ảnh minh họa của sản phẩm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImage_Click(object sender, EventArgs e)
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
                    picChanged = true;
                }
                picAMH.Image = Image.FromFile(xeDien.AnhMinhHoa);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Sự kiện sửa thông tin hàng hóa
        /// </summary>
        private void BtnInsertHang_Click(object sender, EventArgs e)
        {
            setEnableButton2();
            setEnableTextBox2();
            clearTextbox();
            btnInsertStatus = true;
        }
        /// <summary>
        /// Sự kiện chỉnh sửa thông tin của hàng hóa
        /// </summary>
        private void btnUpdateHang_Click(object sender, EventArgs e)
        {
            setEnableButton2();
            setEnableTextBox3();
        }

        /// <summary>
        /// Sự kiện lưu lại những thay đổi của sản phẩm.
        /// Hoặc xác nhân lưu sản phẩm mới vào danh sách.
        /// </summary>
        private void btnSaveHang_Click(object sender, EventArgs e)
        {
            if (btnInsertStatus)
            {
                if (txbMaHang.Text == "" || txbTenHang.Text == "" || txbNhaSX.Text == "")
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
                        settingDataInputBeforeInsert();
                        bool result = MatHangBUS.Instance.InsertMatHang(xeDien.MaHang, xeDien.TenHang, xeDien.NhaSanXuat, xeDien.MoTa, xeDien.ThongTinBaoHanh, xeDien.SoLuong, xeDien.DonViTinh, xeDien.AnhMinhHoa);
                        if (result)
                        {
                            MessageBox.Show("Thêm thành công.");
                            loadData();
                            setEnableButton1();
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
            else
            {
                if (txbTenHang.Text == "" || txbNhaSX.Text == "")
                {
                    MessageBox.Show("Mã hàng , tên hàng, nhà sản xuất không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        settingDataInputBeforeUpdate();
                        bool result = MatHangBUS.Instance.UpdateMatHang(xeDien.MaHang, xeDien.TenHang, xeDien.NhaSanXuat, xeDien.MoTa, xeDien.ThongTinBaoHanh, xeDien.SoLuong, xeDien.DonViTinh, xeDien.AnhMinhHoa);
                        if (result)
                        {
                            MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData();
                            setEnableButton1();
                            setEnableTextBox1();
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
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }

        }
        /// <summary>
        /// Sự kiện xóa sản phẩm khỏi danh sách.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteHang_Click(object sender, EventArgs e)
        {
            int row = dtgvDanhSach.CurrentCell.RowIndex;
            int soLuong = (int)dtgvDanhSach.Rows[row].Cells["colSoLuong"].Value;

            if(soLuong > 0 )
            {
                MessageBox.Show("Số lượng mặt hàng này vẫn còn không thể xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        string id = dtgvDanhSach.Rows[row].Cells["colMaHang"].Value.ToString();
                        bool result = MatHangBUS.Instance.DeleteMatHang(id);
                        if (result)
                        {
                            MessageBox.Show("Bạn đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData();
                        }
                    }
                    catch (NullReferenceException ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
        /// <summary>
        /// Sự kiện hủy trạng thái thêm, sửa
        /// </summary>
        private void btnCancelHang_Click(object sender, EventArgs e)
        {
            clearTextbox();
            setEnableButton1();
            setEnableTextBox1();
        }
        /// <summary>
        /// Sự kiện tìm tiếm mã sản phẩm trong danh sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchID_Click(object sender, EventArgs e)
        {
            if (txbSearchID.Text != "")
            {
                DataTable data = MatHangBUS.Instance.getListMatHangByID(txbSearchID.Text);
                if(data.Rows.Count > 0)
                {
                    dtgvDanhSach.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã hàng này trong danh sách", "Thôngn báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
            }
            else
            {
                loadData();
            }    
        }
        #endregion
    }
}
