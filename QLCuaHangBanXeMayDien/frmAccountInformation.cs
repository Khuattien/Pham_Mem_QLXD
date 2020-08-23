using QLCuaHangBanXeMayDien.QuanLy_BUS;
using QLCuaHangBanXeMayDien.QuanLy_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangBanXeMayDien
{
    public partial class frmAccountInformation : Form
    {
        private AccountLogin account = new AccountLogin();

        public frmAccountInformation(AccountLogin accountLogin)
        {
            InitializeComponent();

            account = accountLogin;

            showInforAccountIsActive();
            TextBoxState1();
        }

        private void TextBoxState1()
        {
            txbDisplayName.Enabled = false;
            txbPhoneNumber.Enabled = false;
            txbEmail.Enabled = false;
            txbAccountType.Enabled = false;
        }

        private void TextBoxState2()
        {
            txbDisplayName.Enabled = true;
            txbPhoneNumber.Enabled = true;
            txbEmail.Enabled = true;
            txbAccountType.Enabled = false;
            txbDisplayName.Focus();
        }

        private bool CheckRegExp(string reg, TextBox textBox)
        {
            Regex regex = new Regex(reg);
            if (regex.IsMatch(textBox.Text))
                return true;
            else
                return false;
        }

        private void showInforAccountIsActive()
        {
            lbUserNameActive.Text = "Tài khoản : " + account.UserName + " - đang hoạt động.";
            txbDisplayName.Text = account.TenHienThi;
            txbPhoneNumber.Text = account.DienThoai;
            txbEmail.Text = account.Email;
            if (account.LoaiTaiKhoan == 0)
                txbAccountType.Text = "Thường";
            else
                txbAccountType.Text = "Admin";
        }

        private bool processingAccountBeforeUpdate()
        {
            bool isvalid = false;
            account.TenHienThi = txbDisplayName.Text;
            //Kiểm tra định dạng số điện thoại
            if (!CheckRegExp("^0[1-9]{9}$", txbPhoneNumber) || !CheckRegExp(@"^[a-z0-9]+@gmail\.com$", txbEmail))
            {
                string mess = "Số điện thoại hoặc email không hợp lệ.";
                MessageBox.Show(mess, "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                account.DienThoai = txbPhoneNumber.Text;
                account.Email = txbEmail.Text;
                isvalid = true;
            }

            return isvalid;
        }

        private bool btnUpdateWasClick = false;

        private void btnSua_Click(object sender, EventArgs e)
        {
            TextBoxState2();
            btnSua.Enabled = false;
            btnUpdateWasClick = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txbDisplayName.Text == "" || txbPhoneNumber.Text == "" || txbEmail.Text == "")
            {
                MessageBox.Show("Bạn đã xóa trống một thông tin nào đó.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (btnUpdateWasClick)
            {
                if (processingAccountBeforeUpdate())
                {
                    try
                    {
                        processingAccountBeforeUpdate();
                        if (AccountBUS.Instance.UpdateAccount(account.UserName, account.PassWord, account.LoaiTaiKhoan, account.TenHienThi, account.DienThoai, account.Email))
                        {
                            MessageBox.Show("Đã cập nhập thông tin tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnSua.Enabled = true;
                            btnUpdateWasClick = false;
                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cập nhập thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
            else
                this.Close();
        }
    }
}
