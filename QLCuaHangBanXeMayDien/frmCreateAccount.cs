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

        private void InputIsValid(Label label , PictureBox picture)
        {
            label.ResetText();
            picture.Image = Properties.Resources.icons8_checkmark_48;
        }

        private void InputIsInValid(Label label, PictureBox picture, string mess)
        {
            label.Text = mess;
            picture.Image = Properties.Resources.icons8_cancel_30;
        }

        private bool processingInfoAccountBeforCreate()
        {
            int allIsOK = 1;
            if (txbUserName.Text == "" || txbPassword.Text == "" || txbDisplayName.Text == "" || txbPhoneNumber.Text == "" || txbEmail.Text == "")
            {
                MessageBox.Show("Cần điền đầy đủ thông tin để có thể tạo một tài khoản mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                picValidDisplayname.Image = Properties.Resources.icons8_verified_account_32;

                //Kiểm tra định dạng tên đăng nhập
                if (!CheckRegExp("^[a-zA-Z0-9]{5,30}$", txbUserName) || txbUserName.Text.Length < 6)
                {
                    string mess = "Tài khoản không hợp lệ.";
                    InputIsInValid(lbErrorUserName, picValidUsername, mess);
                }
                else
                {
                    InputIsValid(lbErrorUserName, picValidUsername);
                    allIsOK++;
                }
                //Kiểm tra định dạng mật khẩu
                if (!CheckRegExp(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,20}$", txbPassword))
                {
                    string mess = "Mật khẩu không hợp lệ.";
                    InputIsInValid(lbErrorPass, picValidPass, mess);
                }
                else
                {
                    InputIsValid(lbErrorPass, picValidPass);
                    allIsOK++;
                }
                //Kiểm tra định dạng số điện thoại
                if (!CheckRegExp("^0[1-9]{9}$", txbPhoneNumber))
                {
                    string mess = "Số điện thoại không hợp lệ.";
                    InputIsInValid(lbErrorPhoneNumber, picValidPhoneNumeber, mess);
                }
                else
                {
                    InputIsValid(lbErrorPhoneNumber, picValidPhoneNumeber);
                    allIsOK++;
                }
                //Kiểm tra định dạng email
                if (!CheckRegExp(@"^[a-z0-9]+@gmail\.com$", txbEmail))
                {
                    string mess = "Email không đúng định dạng.";
                    InputIsInValid(lbErrorEmail, picValidEmail, mess);
                }
                else
                {
                    InputIsValid(lbErrorEmail, picValidEmail);
                    allIsOK++;
                }
                //Tên đặt tùy ý nên không cần phải kiểm tra :V
                picValidDisplayname.Image = Properties.Resources.icons8_checkmark_48;

            }
            //Xác nhận lại mật khẩu khớp với mật khẩu muốn tạo
            if (txbConfirmPass.Text == "")
            {
                string mess = "Hãy xác nhận lại mật khẩu.";
                lbErrorConfirm.Text = mess;
            }
            else if (!txbPassword.Text.Equals(txbConfirmPass.Text))
            {
                string mess = "Mật khấu không khớp";
                InputIsInValid(lbErrorConfirm, picValidConfirmPass, mess);
            }
            else
            {
                InputIsValid(lbErrorConfirm, picValidConfirmPass);
                allIsOK++;
            }

            if(allIsOK ==  6)
            {
                account.UserName = txbUserName.Text.ToLower();
                account.PassWord = txbPassword.Text;
                account.TenHienThi = txbDisplayName.Text;
                account.DienThoai = txbPhoneNumber.Text;
                account.Email = txbEmail.Text;
            }

            return allIsOK == 6;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
