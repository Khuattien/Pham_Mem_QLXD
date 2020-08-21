using QLCuaHangBanXeMayDien.QuanLy_BUS;
using QLCuaHangBanXeMayDien.QuanLy_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangBanXeMayDien
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        AccountLogin account = new AccountLogin();

        private bool CheckRegExp(string reg, TextBox textBox)
        {
            Regex regex = new Regex(reg);
            if (regex.IsMatch(textBox.Text))
                return true;
            else
                return false;
        }

        private bool processingInfoAccountBeforCreate()
        {
            bool isOK = false;
            if (txbUserName.Text == "" || txbPassword.Text == "" || txbDisplayName.Text == "" || txbPhoneNumber.Text == "" || txbEmail.Text == "")
            {
                MessageBox.Show("Cần điền đầy đủ thông tin để có thể tạo một tài khoản mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txbConfirmPass.Text == "")
            {
                MessageBox.Show("Hãy xác nhận lại mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!txbPassword.Text.Equals(txbConfirmPass.Text))
            {
                MessageBox.Show("Mật khấu không khớp");
                picValidConfirmPass.Image = Properties.Resources.icons8_cancel_30;
            }
            else
            {
                account.UserName = txbUserName.Text.ToLower();
                account.PassWord = txbPassword.Text.ToLower();
                account.TenHienThi = txbDisplayName.Text;
                account.DienThoai = txbPhoneNumber.Text;
                account.Email = txbEmail.Text;
                isOK = true;
            }
            return isOK;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (!processingInfoAccountBeforCreate())
                {
                    return;
                }

                else if (AccountBUS.Instance.InsertAccount(account.UserName, account.PassWord, account.LoaiTaiKhoan, account.TenHienThi, account.DienThoai, account.Email))
                {
                    string mess = string.Format("Bạn đã tạo một tài khoản với: \nTên đăng nhập : {0} \nMật khẩu : {1}\n Quay lại để đăng nhập ", account.UserName, account.PassWord);

                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch (Exception)
            {
                MessageBox.Show("Tạo tài khoản thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

    }
}
