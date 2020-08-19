using QLCuaHangBanXeMayDien.QuanLy_BUS;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QLCuaHangBanXeMayDien
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
            EnableTextBox(false);
            LoadDataKH();
        }
        /// <summary>
        /// biến kiểm tra trang thái enabled của phương thức thêm
        /// </summary>
        private bool addStatus = false;

        /// <summary>
        /// biến kiểm tra trang thái enabled của phương thức sửa
        /// </summary>
        private bool updateStatus = false;

        #region Phương thức của form
        /// <summary>
        /// phương thức hiện thị thông tin hàng hóa lên datagridview
        /// </summary>
        void LoadDataKH()
        {
            dtgvKhachHang.DataSource = KhachHangBUS.Instance.GetDataKhachHang();
            ButtonFormLoad();
            addStatus = false;
            updateStatus = false;
        }
        /// <summary>
        /// phương thức cài lại giá trị của các controll textbox
        /// </summary>
        void ResetText()
        {
            txbMaKH.ResetText();
            txbDiaChiKH.ResetText();
            txbDienThoaiKH.ResetText();
            txbEmailKH.ResetText();
            txbTenKH.ResetText();
            txbTimKiemKH.ResetText();
        }
        /// <summary>
        /// phương thức cài các nút khi load dữ liệu form
        /// </summary>
        void ButtonFormLoad()
        {
            btnAddKH.Enabled = true;
            btnDeleteKH.Enabled = true;
            btnUpdateKH.Enabled = true;
            btnCancelKH.Enabled = false;
            btnSaveKH.Enabled = false;
            btnSeacrh.Enabled = true;
        }
        /// <summary>
        /// phương thức enabled nút thêm sửa xóa khi click nút thêm sửa xóa
        /// </summary>
        void ClickButtomEnable()
        {
            btnAddKH.Enabled = false;
            btnDeleteKH.Enabled = false;
            btnUpdateKH.Enabled = false;
            btnSaveKH.Enabled = true;
            btnCancelKH.Enabled = true;
            btnSeacrh.Enabled = false;
        }
        /// <summary>
        /// phương thức enabled các textbox
        /// </summary>
        /// <param name="bol">trạng thái</param>
        void EnableTextBox(bool bol)
        {
            txbMaKH.Enabled = bol;
            txbTenKH.Enabled = bol;
            txbEmailKH.Enabled = bol;
            txbDienThoaiKH.Enabled = bol;
            txbDiaChiKH.Enabled = bol;
        }
        #endregion

        #region Sự kiện của form
        
        /// <summary>
        /// sự kiện thêm khách hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddKH_Click(object sender, EventArgs e)
        {
            ClickButtomEnable();
            addStatus = true;
            EnableTextBox(true);
            ResetText();
        }
        /// <summary>
        /// sự kiện sửa thông tin khách hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateKH_Click(object sender, EventArgs e)
        {
            ClickButtomEnable();
            updateStatus = true;
            EnableTextBox(true);
            txbMaKH.Enabled = false;
        }
        /// <summary>
        /// sự kiện đẩy dữ liệu lên text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableTextBox(false);
            btnUpdateKH.Enabled = true;
            btnAddKH.Enabled = true;
            btnDeleteKH.Enabled = true;
            int row = e.RowIndex;
            if (row >= 0)
            {
                if(dtgvKhachHang.CurrentCell.Value.ToString() == "")
                {
                    btnDeleteKH.Enabled = false;
                    btnUpdateKH.Enabled = false;
                }
                txbMaKH.Text = dtgvKhachHang.Rows[row].Cells["MaKhachHang"].Value.ToString();
                txbTenKH.Text = dtgvKhachHang.Rows[row].Cells["TenKHachHang"].Value.ToString();
                txbDienThoaiKH.Text = dtgvKhachHang.Rows[row].Cells["DienThoai"].Value.ToString();
                txbDiaChiKH.Text = dtgvKhachHang.Rows[row].Cells["DiaChi"].Value.ToString();
                txbEmailKH.Text = dtgvKhachHang.Rows[row].Cells["Email"].Value.ToString();
            }
        }
        /// <summary>
        /// sự kiện bắt lỗi dữ liệu txbDienThoai
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbDienThoaiKH_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (int.TryParse(txbDienThoaiKH.Text, out result) == false && txbDienThoaiKH.Text != "")
            {
                MessageBox.Show("Phải nhập số", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDienThoaiKH.ResetText();
            }

        }
        /// <summary>
        /// sự kiện mở các nút chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbMaKH.Text == "" || txbTenKH.Text == "" || txbDiaChiKH.Text == "" || txbEmailKH.Text == "")
                {
                    MessageBox.Show("không được để trống", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (txbMaKH.Text == "") txbMaKH.Focus();
                    if (txbTenKH.Text == "") txbTenKH.Focus();
                    if (txbDiaChiKH.Text == "") txbDiaChiKH.Focus();
                    if (txbEmailKH.Text == "") txbEmailKH.Focus();
                }
                else if (addStatus == true)
                {
                    KhachHangBUS.Instance.InsertKhachHang(txbMaKH.Text, txbTenKH.Text, txbDiaChiKH.Text, int.Parse(txbDienThoaiKH.Text), txbEmailKH.Text);
                    MessageBox.Show("đã thêm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetText();
                    LoadDataKH();
                }
                else if(updateStatus == true)
                {
                    KhachHangBUS.Instance.UpdateKhachHang(txbMaKH.Text, txbTenKH.Text, txbDiaChiKH.Text, int.Parse(txbDienThoaiKH.Text), txbEmailKH.Text);
                    MessageBox.Show("đã sửa thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetText();
                    LoadDataKH();
                }    
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// sự kiện hủy các nút chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelKH_Click(object sender, EventArgs e)
        {
            btnAddKH.Enabled = true;
            btnDeleteKH.Enabled = true;
            btnUpdateKH.Enabled = true;
            btnCancelKH.Enabled = false;
            btnSaveKH.Enabled = false;
            btnSeacrh.Enabled = true;
            LoadDataKH();
        }
        /// <summary>
        /// sự kiện xóa 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (KhachHangBUS.Instance.DeleteKhachHang(txbMaKH.Text) == true)
                {
                    MessageBox.Show("đã xóa thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ResetText();
                LoadDataKH();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// sự kiện tìm kiếm khách hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeacrh_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbTimKiemKH.Text != "")
                {
                    DataTable data = KhachHangBUS.Instance.SearchKhachHang(txbTimKiemKH.Text);
                    if (data.Rows.Count == 0)
                    {
                        MessageBox.Show("không tìm thấy", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadDataKH();
                    }
                    else
                        dtgvKhachHang.DataSource = data;
                }
                else
                LoadDataKH();
                txbTimKiemKH.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}