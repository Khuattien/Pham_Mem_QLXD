using QLCuaHangBanXeMayDien.QuanLy_BUS;
using QLCuaHangBanXeMayDien.QuanLy_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangBanXeMayDien
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
            LoadListAccount();
            setTextBox1();
            setButton3();
        }

        AccountLogin account = new AccountLogin();

        #region Các phương thức trong form
        /// <summary>
        /// Phương thức hiển thị danh sách các tài khoản lên form
        /// </summary>
        private void LoadListAccount()
        {
            dtgvListAccount.DataSource = AccountBUS.Instance.getListAccount();
        }

        /// <summary>
        /// Xóa tất cả thông tin trên các textbox để chuẩn bị thêm tài khoản mới
        /// Hoặc click vào ô không có thông tin datagridview
        /// </summary>
        private void clearTextBox()
        {
            txbUsername.ResetText();
            txbPassword.ResetText();
            txbDisplayname.ResetText();
            txbPhoneNumber.ResetText();
            txbEmail.ResetText();
            cbxAccountType.Text = "Loại tài khoản";
        }
        /// <summary>
        /// Khi không thêm sửa nữa xóa các thông báo lỗi đi.
        /// </summary>
        private void resetLable()
        {
            lbErrorUserName.ResetText();
            lbErrorPass.ResetText();
            lbErrorPhoneNumber.ResetText();
            lbErrorEmail.ResetText();
        }

        /// <summary>
        /// Trạng thái các textbox khi không thêm sửa
        /// </summary>
        private void setTextBox1()
        {
            txbUsername.Enabled = false;
            txbPassword.Enabled = false;
            txbDisplayname.Enabled = false;
            txbPhoneNumber.Enabled = false;
            txbEmail.Enabled = false;
            cbxAccountType.Enabled = false;
        }

        /// <summary>
        /// Trạng thái các textbox khi thực hiện thêm
        /// </summary>
        private void setTextBox2()
        {
            txbUsername.Enabled = true;
            txbPassword.Enabled = true;
            txbDisplayname.Enabled = true;
            txbPhoneNumber.Enabled = true;
            txbEmail.Enabled = true;
            cbxAccountType.Enabled = true;

            txbUsername.Text = "Nhập tên tài khoản.";
            txbUsername.Focus();
        }

        /// <summary>
        /// Trạng thái các textbox khi thực hiện sửa
        /// </summary>
        private void setTextBox3()
        {
            txbUsername.Enabled = false;
            txbPassword.Enabled = true;
            txbDisplayname.Enabled = true;
            txbPhoneNumber.Enabled = true;
            txbEmail.Enabled = true;
            cbxAccountType.Enabled = true;
        }


        /// <summary>
        /// Trạng thái các button khi không thực hiện thêm sửa
        /// </summary>
        private void setButton1()
        {
            btnInsertAcc.Enabled = true;
            btnUpdateAcc.Enabled = true;
            btnDeleteAcc.Enabled = true;
            btnSaveAcc.Enabled = false;
            btnCancelAcc.Enabled = false;
        }

        /// <summary>
        /// Trạng thái các buttuon khi thực hiện thêm sửa
        /// </summary>
        private void setButton2()
        {
            btnInsertAcc.Enabled = false;
            btnUpdateAcc.Enabled = false;
            btnDeleteAcc.Enabled = false;
            btnSaveAcc.Enabled = true;
            btnCancelAcc.Enabled = true;
        }

        /// <summary>
        /// Trạng thái các button khi mới mở form
        /// </summary>
        private void setButton3()
        {
            btnInsertAcc.Enabled = true;
            btnUpdateAcc.Enabled = false;
            btnDeleteAcc.Enabled = false;
            btnSaveAcc.Enabled = false;
            btnCancelAcc.Enabled = false;
        }

        /// <summary>
        /// Lấy các giá trị từ datagridview đưa lên textbox
        /// </summary>
        private void getValueFromCellDataGridView()
        {
            int row = dtgvListAccount.CurrentCell.RowIndex;
            txbUsername.Text = dtgvListAccount.Rows[row].Cells["colUsername"].Value.ToString();
            txbPassword.Text = dtgvListAccount.Rows[row].Cells["colPassword"].Value.ToString();
            txbDisplayname.Text = dtgvListAccount.Rows[row].Cells["colDisplayName"].Value.ToString();
            txbPhoneNumber.Text = dtgvListAccount.Rows[row].Cells["colPhoneNumber"].Value.ToString();
            txbEmail.Text = dtgvListAccount.Rows[row].Cells["colEmail"].Value.ToString();

            if (dtgvListAccount.Rows[row].Cells["colAccountType"].Value.ToString() == "1")
                cbxAccountType.SelectedIndex = 1;
            else
                cbxAccountType.SelectedIndex = 0;
        }


        /// <summary>
        /// Phương thức kiểm tra định dạng
        /// </summary>

        private bool CheckRegExp(string reg, TextBox textBox)
        {
            Regex regex = new Regex(reg);
            if (regex.IsMatch(textBox.Text))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Kiểm tra hợp lệ dữ liệu nhập vào trước khi thêm mới 
        /// </summary>
        private bool processingInfoAccountBeforCreate()
        {
            int allIsOK = 1;
            if (txbUsername.Text == "" || txbPassword.Text == "" || txbDisplayname.Text == "" || txbPhoneNumber.Text == "" || txbEmail.Text == "")
            {
                MessageBox.Show("Cần điền đầy đủ thông tin để có thể tạo một tài khoản mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Kiểm tra định dạng tên đăng nhập
                if (!CheckRegExp("^[a-zA-Z0-9]{5,30}$", txbUsername) || txbUsername.Text.Length < 6)
                {
                    string mess = "Tài khoản không hợp lệ.";
                    lbErrorUserName.Text = mess;
                }
                else
                {
                    lbErrorUserName.ResetText();
                    allIsOK++;
                }
                //Kiểm tra định dạng mật khẩu
                if (!CheckRegExp(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,20}$", txbPassword))
                {
                    string mess = "Mật khẩu không hợp lệ.";
                    lbErrorPass.Text = mess;
                }
                else
                {
                    lbErrorPass.ResetText();
                    allIsOK++;
                }
                //Kiểm tra định dạng số điện thoại
                if (!CheckRegExp("^0[1-9]{9}$", txbPhoneNumber))
                {
                    string mess = "SĐT đúng định dạng.";
                    lbErrorPhoneNumber.Text = mess;
                }
                else
                {
                    lbErrorPhoneNumber.ResetText();
                    allIsOK++;
                }
                //Kiểm tra định dạng email
                if (!CheckRegExp(@"^[a-z0-9]+@gmail\.com$", txbEmail))
                {
                    string mess = "Email không đúng định dạng.";
                    lbErrorEmail.Text = mess;
                }
                else
                {
                    lbErrorEmail.ResetText();
                    allIsOK++;
                }

                if (cbxAccountType.Text == "Loại tài khoản")
                    MessageBox.Show("Hãy chọn loại tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    allIsOK++;
            }

            if (allIsOK == 6)
            {
                account.UserName = txbUsername.Text.ToLower();
                account.PassWord = txbPassword.Text;
                account.TenHienThi = txbDisplayname.Text;
                account.DienThoai = txbPhoneNumber.Text;
                account.Email = txbEmail.Text;
                account.LoaiTaiKhoan = cbxAccountType.SelectedIndex;
            }

            return allIsOK == 6;
        }


        /// <summary>
        /// Kiểm tra hợp lệ dữ liệu nhập vào trước khi sửa đổi
        /// </summary>
        private bool processingInfoAccountBeforUpdate()
        {
            int allIsOK = 0;
            if (txbPassword.Text == "" || txbDisplayname.Text == "" || txbPhoneNumber.Text == "" || txbEmail.Text == "")
            {
                MessageBox.Show("Một thông tin nào đó bị xóa trống. Cần điền lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Kiểm tra định dạng mật khẩu
                if (!CheckRegExp(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,20}$", txbPassword))
                {
                    string mess = "Mật khẩu không hợp lệ.";
                    lbErrorPass.Text = mess;
                }
                else
                {
                    lbErrorPass.ResetText();
                    allIsOK++;
                }
                //Kiểm tra định dạng số điện thoại
                if (!CheckRegExp("^0[1-9]{9}$", txbPhoneNumber))
                {
                    string mess = "SĐT đúng định dạng.";
                    lbErrorPhoneNumber.Text = mess;
                }
                else
                {
                    lbErrorPhoneNumber.ResetText();
                    allIsOK++;
                }
                //Kiểm tra định dạng email
                if (!CheckRegExp(@"^[a-z0-9]+@gmail\.com$", txbEmail))
                {
                    string mess = "Email không đúng định dạng.";
                    lbErrorEmail.Text = mess;
                }
                else
                {
                    lbErrorEmail.ResetText();
                    allIsOK++;
                }
            }

            if (allIsOK == 3)
            {
                account.UserName = txbUsername.Text;
                account.PassWord = txbPassword.Text;
                account.TenHienThi = txbDisplayname.Text;
                account.DienThoai = txbPhoneNumber.Text;
                account.Email = txbEmail.Text;
                account.LoaiTaiKhoan = cbxAccountType.SelectedIndex;
            }

            return allIsOK == 3;
        }

        #endregion

        #region Sự kiện trong form
        private void dtgvListAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                getValueFromCellDataGridView();
                setButton1();
                setTextBox1();
                resetLable();
            }
            catch (InvalidCastException)
            {
                clearTextBox();
            }
        }

        private bool isBtnInsert = false;
        private void btnInsertAcc_Click(object sender, EventArgs e)
        {
            clearTextBox();
            setTextBox2();
            setButton2();
            isBtnInsert = true;
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            setTextBox3();
            setButton2();
        }

        private void btnSaveAcc_Click(object sender, EventArgs e)
        {
            if (isBtnInsert)
            {
                if (processingInfoAccountBeforCreate())
                {
                    try
                    {
                        //processingInfoAccountBeforCreate();
                        if (AccountBUS.Instance.InsertAccount(account.UserName, account.PassWord, account.LoaiTaiKhoan, account.TenHienThi, account.DienThoai, account.Email))
                        {
                            MessageBox.Show("Đã thêm thành công một tài khoản mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadListAccount();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                    setButton2();
            }
            else
            {
                if (processingInfoAccountBeforUpdate())
                {

                    try
                    {
                        //processingInfoAccountBeforUpdate();
                        if (AccountBUS.Instance.UpdateAccount(account.UserName, account.PassWord, account.LoaiTaiKhoan, account.TenHienThi, account.DienThoai, account.Email))
                        {
                            MessageBox.Show("Đã Cập nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadListAccount();
                        }
                    }

                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                    setButton2();
            }
        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dtgvListAccount.CurrentCell.RowIndex;
                string username = dtgvListAccount.Rows[row].Cells["colUsername"].Value.ToString();
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (AccountBUS.Instance.DeleteAccount(username))
                    {
                        MessageBox.Show("Đã xóa tài khoản này", "Thông báo", MessageBoxButtons.OK);
                        LoadListAccount();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}