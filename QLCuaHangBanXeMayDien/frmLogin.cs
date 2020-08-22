using QLCuaHangBanXeMayDien.QuanLy_BUS;
using QLCuaHangBanXeMayDien.QuanLy_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangBanXeMayDien
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txbUserName.Text == "" || txbPassWord.Text == "")
            {
                MessageBox.Show("Điền thông tin tài khoản mật khẩu để có thể đăng nhập và sử dụng.", "Thông báo" ,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }    
            else if (AccountBUS.Instance.checkAccount(txbUserName.Text, txbPassWord.Text))
            {
                frmMainController frm = new frmMainController(AccountBUS.Instance.getAccountByUserNameAndPassWord(txbUserName.Text,txbPassWord.Text));
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            frmCreateAccount frm = new frmCreateAccount();
            frm.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            panelLogin.BackColor = Color.FromArgb(100,0,48,143);
        }
    }
}
