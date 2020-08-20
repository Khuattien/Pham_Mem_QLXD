using QLCuaHangBanXeMayDien.QuanLy_BUS;
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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
            stateFirst();
            LoadDataNV();

        }
        /// <summary>
        /// phương thức hiện thị thông tin hàng hóa lên datagridview
        /// </summary>
        #region Phương thức của form
        void LoadDataNV()
        {
            dtgvListNV.DataSource = NhanVienBUS.Instance.GetDataNhanVien();
            
        }
        void stateFirst()
        {
            ResetText();
            CloseProperties();
            btnAddNV.Enabled = true;
            btnDeleteNV.Enabled = true;
            btnUpdateNV.Enabled = true;
            btnSaveNV.Enabled = false;
            btnCancelNV.Enabled = false;
        }
        /// <summary>
        /// phương thức cài lại giá trị của các control
        /// </summary>
        void ResetText()
        {
            txbMaNV.ResetText();
            txbTenNV.ResetText();
            txbNamSinhNV.ResetText();
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            txbDienThoaiNV.ResetText();
            txbDiaChi.ResetText();
            txbChucVuNV.ResetText();
            txbLuongNV.ResetText();
        }

        void CloseProperties()
        {
            txbMaNV.Enabled = false;
            txbTenNV.Enabled = false;
            txbNamSinhNV.Enabled = false;
            rdbNam.Enabled = false;
            rdbNu.Enabled = false;
            txbDiaChi.Enabled = false;
            txbDienThoaiNV.Enabled = false;
            txbChucVuNV.Enabled = false;
            txbLuongNV.Enabled = false;
        }

        void OpenProperties()
        {
            txbMaNV.Enabled = true;
            txbTenNV.Enabled = true;
            txbNamSinhNV.Enabled = true;
            rdbNam.Enabled = true;
            rdbNu.Enabled = true;
            txbDiaChi.Enabled = true;
            txbDienThoaiNV.Enabled = true;
            txbChucVuNV.Enabled = true;
            txbLuongNV.Enabled = true;
        }

       
        #endregion

        #region Sự kiện của form
        /// <summary>
        /// sự kiện bắt đầu quá trình thêm nhân viên
        /// </summary>

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            OpenProperties();
            ResetText();
            btnSaveNV.Enabled = true;
            btnCancelNV.Enabled = true;
            btnDeleteNV.Enabled = false;
            btnUpdateNV.Enabled = false;
        }
        /// <summary>
        /// sự kiện bắt đầu sửa thông tin khách hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnUpdateNV_Click_1(object sender, EventArgs e)
        {
            OpenProperties();
            btnSaveNV.Enabled = true;
            btnCancelNV.Enabled = true;
            btnAddNV.Enabled = false;
            btnDeleteNV.Enabled = false;
        }


        /// <summary>
        /// sự kiện đẩy dữ liệu lên text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgvListNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txbMaNV.Text = dtgvListNV.Rows[row].Cells["MaNhanVien"].Value.ToString();
                txbTenNV.Text = dtgvListNV.Rows[row].Cells["TenNhanVien"].Value.ToString();
                txbNamSinhNV.Text = dtgvListNV.Rows[row].Cells["NamSinh"].Value.ToString();
                if (dtgvListNV.Rows[row].Cells["GioiTinh"].Value.ToString() == "Nam")
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;
                txbDienThoaiNV.Text = dtgvListNV.Rows[row].Cells["DienThoai"].Value.ToString();
                txbDiaChi.Text = dtgvListNV.Rows[row].Cells["DiaChi"].Value.ToString();
                txbChucVuNV.Text = dtgvListNV.Rows[row].Cells["ChucVu"].Value.ToString();
                txbLuongNV.Text = dtgvListNV.Rows[row].Cells["Luong"].Value.ToString();
            }
        }

        /// <summary>
        /// sự kiện xóa 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbMaNV.Text == "")
                {
                    MessageBox.Show("Chưa điền đủ mã nhân viên");
                    if (txbMaNV.Text == "") txbMaNV.Focus();
                }
                else
                {
                    DialogResult dlr = MessageBox.Show("Bạn muốn xóa nhân viên này?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dlr == DialogResult.Yes)
                    {
                        if (NhanVienBUS.Instance.DeleteNhanVien(txbMaNV.Text) == true)
                            MessageBox.Show("đã xóa thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                ResetText();
                LoadDataNV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// sự kiện bắt lỗi dữ liệu txbNamSinhNV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbNamSinhNV_TextChanged(object sender, EventArgs e)
        {
            int val;
            if (int.TryParse(txbNamSinhNV.Text, out val) == false && txbNamSinhNV.Text != "")
            {
                MessageBox.Show("Phải nhập số", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbNamSinhNV.ResetText();
            }
        }

        /// <summary>
        /// sự kiện bắt lỗi dữ liệu txbLuongNV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbLuongNV_TextChanged(object sender, EventArgs e)
        {
            int val;
            if (int.TryParse(txbLuongNV.Text, out val) == false && txbLuongNV.Text != "")
            {
                MessageBox.Show("Phải nhập số", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbLuongNV.ResetText();
            }
        }

        /// <summary>
        /// sự kiện thêm và sửa thông tin nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveNV_Click(object sender, EventArgs e)
        {
            
            if(btnUpdateNV.Enabled==false)
            {
                try
                {
                    if (txbMaNV.Text == "" || txbTenNV.Text == "" || (rdbNam.Checked == false && rdbNu.Checked == false) || txbNamSinhNV.Text == "" || txbDienThoaiNV.Text == "" || txbDiaChi.Text == "" || txbChucVuNV.Text == "" || txbLuongNV.Text == "")
                    {
                        MessageBox.Show("Chưa điền đủ thông tin nhân viên");
                    }
                    else
                    {
                        string gt;
                        if (rdbNam.Checked == true)
                            gt = "Nam";
                        else
                            gt = "Nữ";

                        if (NhanVienBUS.Instance.InsertNhanvien(txbMaNV.Text, txbTenNV.Text, int.Parse(txbNamSinhNV.Text), gt, int.Parse(txbDienThoaiNV.Text), txbDiaChi.Text, txbChucVuNV.Text, float.Parse(txbLuongNV.Text)))
                        {
                            MessageBox.Show("Thêm thành công");
                            LoadDataNV();
                            stateFirst();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi khi thêm nhân viên");
                            ResetText();
                        }
                    }
                }
                catch (SqlException ex)
                {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            if(btnAddNV.Enabled==false)
            {
                try
                {
                    if (txbMaNV.Text == "" || txbTenNV.Text == "" || (rdbNam.Checked == false && rdbNu.Checked == false) || txbNamSinhNV.Text == "" || txbDienThoaiNV.Text == "" || txbDiaChi.Text == "" || txbChucVuNV.Text == "" || txbLuongNV.Text == "")
                    {
                        MessageBox.Show("Chưa điền đủ thông tin nhân viên");
                       
                        if (txbMaNV.Text == "") 
                            txbMaNV.Focus();
                        else
                            if (txbTenNV.Text == "") txbTenNV.Focus();
                                else
                                    if (rdbNam.Checked == false && rdbNu.Checked == false) 
                                        MessageBox.Show("Chọn giới tính");
                                    else
                                    {
                                        if (txbLuongNV.Text == "") txbLuongNV.Focus();
                                        if (txbChucVuNV.Text == "") txbChucVuNV.Focus();
                                        if (txbDiaChi.Text == "") txbDiaChi.Focus();
                                        if (txbDienThoaiNV.Text == "") txbDienThoaiNV.Focus();
                                        if (txbNamSinhNV.Text == "") txbNamSinhNV.Focus();
                                    }    
                                        


                    }
                    else
                    {
                        string gt;
                        if (rdbNam.Checked == true)
                            gt = "Nam";
                        else
                            gt = "Nữ";
                        if (NhanVienBUS.Instance.UpdateNhanVien(txbMaNV.Text, txbTenNV.Text, int.Parse(txbNamSinhNV.Text), gt, int.Parse(txbDienThoaiNV.Text), txbDiaChi.Text, txbChucVuNV.Text, float.Parse(txbLuongNV.Text)))
                        {
                            MessageBox.Show("Sửa thành công");
                            LoadDataNV();
                            stateFirst();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi khi sửa thông tin nhân viên");
                            ResetText();
                        }
                    }
                    
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        /// <summary>
        /// sự kiện hủy các nút chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelNV_Click(object sender, EventArgs e)
        {
            stateFirst();
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbTimKiemNV.Text != "")
                {
                    DataTable data = NhanVienBUS.Instance.SearchNhanVien(txbTimKiemNV.Text);
                    if (data.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadDataNV();
                    }
                    else
                        dtgvListNV.DataSource = data;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///  Chỉnh sửa thanh tìm kiếm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbTimKiemNV_Click(object sender, EventArgs e)
        {
            txbTimKiemNV.ResetText();
        }
        private void txbTimKiemNV_Leave(object sender, EventArgs e)
        {
            if (txbTimKiemNV.Text == "")
                txbTimKiemNV.Text = "Nhập tên nhân viên cần tìm";
        }
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }

}
