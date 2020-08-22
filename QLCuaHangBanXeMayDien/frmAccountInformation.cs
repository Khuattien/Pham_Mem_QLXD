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

        private void processingAccountBeforeUpdate()
        {
            account.TenHienThi = txbDisplayName.Text;
            account.DienThoai = txbPhoneNumber.Text;
            account.Email = txbEmail.Text;
        }

        private bool isBtnSua = false;
        private void btnSua_Click(object sender, EventArgs e)
        {
            TextBoxState2();
            btnSua.Enabled = false;
            isBtnSua = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txbDisplayName.Text == "" || txbPhoneNumber.Text == "" || txbEmail.Text == "")
            {
                MessageBox.Show("Bạn đã xóa trống một thông tin nào đó.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (isBtnSua)
            {
                try
                {
                    processingAccountBeforeUpdate();
                    if (AccountBUS.Instance.UpdateAccount(account.UserName, account.PassWord, account.LoaiTaiKhoan, account.TenHienThi, account.DienThoai, account.Email))
                    {
                        MessageBox.Show("Đã cập nhập thông tin tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnSua.Enabled = true;
                        isBtnSua = false;
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
                this.Close();
            }
        }
    }
}
