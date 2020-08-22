using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLCuaHangBanXeMayDien.QuanLy_BUS;
using QLCuaHangBanXeMayDien.QuanLy_DTO;

namespace QLCuaHangBanXeMayDien
{
    public partial class frmNhaCungCap : Form
    {
        private AccountLogin account = new AccountLogin();
        public frmNhaCungCap(AccountLogin transmission)
        {
            InitializeComponent();
            EnableTextBox(false);
            LoadDataNCC();
            account = transmission;
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
        void LoadDataNCC()
        {
            dtgvNhaCungCap.DataSource = NhaCungCapBUS.Instance.GetDataNhaCC();
            ButtonFormLoad();
            EnableTextBox(false);
            addStatus = false;
            updateStatus = false;
            if (txbMaNhaCC.Text == "")
            {
                btnUpdateNhaCC.Enabled = false;
                btnDeleteNhaCC.Enabled = false;
            }
        }
        /// <summary>
        /// phương thức cài lại giá trị của các controll textbox
        /// </summary>
        void ResetText()
        {
            txbMaNhaCC.ResetText();
            txbDiaChiNhaCC.ResetText();
            txbDienThoaiNhaCC.ResetText();
            txbEmailNhaCC.ResetText();
            txbTenNhaCC.ResetText();
            txbTimKiemNhaCC.ResetText();
        }
        /// <summary>
        /// phương thức cài các nút khi load dữ liệu form
        /// </summary>
        void ButtonFormLoad()
        {
            btnAddNhaCC.Enabled = true;
            btnDeleteNhaCC.Enabled = true;
            btnUpdateNhaCC.Enabled = true;
            btnCancelNhaCC.Enabled = false;
            btnSaveNhaCC.Enabled = false;
            btnSearchNcc.Enabled = true;
        }
        /// <summary>
        /// phương thức enabled nút thêm sửa xóa khi click nút thêm sửa xóa
        /// </summary>
        void ButtonEnable()
        {
            btnAddNhaCC.Enabled = false;
            btnDeleteNhaCC.Enabled = false;
            btnUpdateNhaCC.Enabled = false;
            btnSaveNhaCC.Enabled = true;
            btnCancelNhaCC.Enabled = true;
            btnSearchNcc.Enabled = false;
        }
        /// <summary>
        /// phương thức enabled các textbox
        /// </summary>
        /// <param name="bol">trạng thái</param>
        void EnableTextBox(bool bol)
        {
            txbMaNhaCC.Enabled = bol;
            txbTenNhaCC.Enabled = bol;
            txbEmailNhaCC.Enabled = bol;
            txbDienThoaiNhaCC.Enabled = bol;
            txbDiaChiNhaCC.Enabled = bol;
        }
        #endregion

        #region Sự kiện của form
        
        private void btnSearchNcc_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txbTimKiemNhaCC.Text != "")
                {
                    DataTable data = NhaCungCapBUS.Instance.SearchNhaCC(txbTimKiemNhaCC.Text);
                    if (data.Rows.Count == 0)
                    {
                        MessageBox.Show("không tìm thấy", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadDataNCC();
                    }
                    else
                        dtgvNhaCungCap.DataSource = data;
                }
                else
                    LoadDataNCC();
                txbTimKiemNhaCC.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAddNhaCC_Click_1(object sender, EventArgs e)
        {
            ButtonEnable();
            addStatus = true;
            EnableTextBox(true);
            ResetText();
        }

        private void btnUpdateNhaCC_Click_1(object sender, EventArgs e)
        {
            ButtonEnable();
            updateStatus = true;
            EnableTextBox(true);
            txbMaNhaCC.Enabled = false;
        }

        private void btnDeleteNhaCC_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (NhaCungCapBUS.Instance.DeleteNhaCC(txbMaNhaCC.Text) == true)
                {
                    MessageBox.Show("đã xóa thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ResetText();
                LoadDataNCC();
                btnUpdateNhaCC.Enabled = false;
                btnDeleteNhaCC.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveNhaCC_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txbMaNhaCC.Text == "" || txbTenNhaCC.Text == "" || txbDiaChiNhaCC.Text == "" || txbEmailNhaCC.Text == "")
                {
                    MessageBox.Show("không được để trống", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (txbMaNhaCC.Text == "") txbMaNhaCC.Focus();
                    if (txbTenNhaCC.Text == "") txbTenNhaCC.Focus();
                    if (txbDiaChiNhaCC.Text == "") txbDiaChiNhaCC.Focus();
                    if (txbEmailNhaCC.Text == "") txbEmailNhaCC.Focus();
                }
                else if (addStatus == true)
                {
                    NhaCungCapBUS.Instance.InsertNhaCC(txbMaNhaCC.Text, txbTenNhaCC.Text, txbDiaChiNhaCC.Text, txbDienThoaiNhaCC.Text, txbEmailNhaCC.Text);
                    MessageBox.Show("đã thêm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetText();
                    LoadDataNCC();
                }
                else if (updateStatus == true)
                {
                    NhaCungCapBUS.Instance.UpdateNhaCC(txbMaNhaCC.Text, txbTenNhaCC.Text, txbDiaChiNhaCC.Text, txbDienThoaiNhaCC.Text, txbEmailNhaCC.Text);
                    MessageBox.Show("đã sửa thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetText();
                    LoadDataNCC();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelNhaCC_Click_1(object sender, EventArgs e)
        {
            ButtonEnable();
            LoadDataNCC();
            ResetText();
        }

        private void dtgvNhaCungCap_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                EnableTextBox(false);
                btnAddNhaCC.Enabled = true;
                btnDeleteNhaCC.Enabled = true;
                btnUpdateNhaCC.Enabled = true;
                btnCancelNhaCC.Enabled = false;
                btnSaveNhaCC.Enabled = false;
                btnSearchNcc.Enabled = true;
                if (dtgvNhaCungCap.CurrentCell.Value.ToString()=="")
                {
                    btnDeleteNhaCC.Enabled = false;
                    btnUpdateNhaCC.Enabled = false;
                }
                txbMaNhaCC.Text = dtgvNhaCungCap.Rows[row].Cells["MaNhaCungCap"].Value.ToString();
                txbTenNhaCC.Text = dtgvNhaCungCap.Rows[row].Cells["TenNhaCungCap"].Value.ToString();
                txbDienThoaiNhaCC.Text = dtgvNhaCungCap.Rows[row].Cells["DienThoai"].Value.ToString();
                txbDiaChiNhaCC.Text = dtgvNhaCungCap.Rows[row].Cells["DiaChi"].Value.ToString();
                txbEmailNhaCC.Text = dtgvNhaCungCap.Rows[row].Cells["Email"].Value.ToString();
            }
        }

        private void txbDienThoaiNhaCC_TextChanged_1(object sender, EventArgs e)
        {
            int result;
            if (int.TryParse(txbDienThoaiNhaCC.Text, out result) == false && txbDienThoaiNhaCC.Text != "")
            {
                MessageBox.Show("Phải nhập số", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDienThoaiNhaCC.ResetText();
            }
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            if(account.LoaiTaiKhoan == 0)
            {
                btnUpdateNhaCC.Enabled = false;
                btnDeleteNhaCC.Enabled = false;
            }
        }

        #endregion
    }
}
