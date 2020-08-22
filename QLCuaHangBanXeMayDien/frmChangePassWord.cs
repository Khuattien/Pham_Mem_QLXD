using QLCuaHangBanXeMayDien.QuanLy_BUS;
using QLCuaHangBanXeMayDien.QuanLy_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangBanXeMayDien
{
    public partial class frmChangePassWord : Form
    {
        AccountLogin account = new AccountLogin();
        public frmChangePassWord( AccountLogin  accountLogin)
        {
            InitializeComponent();

            account = accountLogin;
        }
        private bool CheckPassRegExp()
        {
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,20}$");
            if (regex.IsMatch(txbNewPass.Text))
                return true;
            else
                return false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txbOldPass.Text == "")
            {
                MessageBox.Show("Nhập mật khẩu cũ trước khi đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(!txbOldPass.Text.Equals(account.PassWord))
            {
                lbenteroldpassfail.Text = "Mật khẩu không chính xác.";
            }
            else
            {
                lbenteroldpassfail.ResetText();
                if(txbNewPass.Text == "" || txbConfirm.Text == "")
                {
                    MessageBox.Show("Hãy nhập mật khẩu mới và xác nhận lại mật khẩu mới.");
                    if (txbNewPass.Text == "")
                        lbErrorPassReg.Text = "";
                    if(txbConfirm.Text == "")
                        lbConfirmNewPassMess.Text = "";
                }
                else if(CheckPassRegExp())
                {
                    lbErrorPassReg.Text = "Mật khẩu không hợp lệ.";
                }    
                else if( !txbNewPass.Text.Equals(txbConfirm.Text))
                {
                    lbConfirmNewPassMess.Text = "Mật khẩu không khớp.";
                }
                else
                {
                    lbConfirmNewPassMess.ResetText();
                    try
                    {
                        account.PassWord = txbNewPass.Text;
                        if (AccountBUS.Instance.changePassword(account.UserName, txbNewPass.Text))
                        {
                            MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }    
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
