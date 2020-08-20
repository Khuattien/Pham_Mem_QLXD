using QLCuaHangBanXeMayDien.QuanLy_BUS;
using QLCuaHangBanXeMayDien.QuanLy_DAO;
using QLCuaHangBanXeMayDien.QuanLy_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLCuaHangBanXeMayDien
{
    public partial class frmKhoHang : Form
    {
        public frmKhoHang()
        {
            InitializeComponent();
        }

        private void frmKhoHang_Load(object sender, EventArgs e)
        {
            dtgvHangcon.DataSource = DataProvider.Instance.ExecuteQuery("select * from MatHang where SoLuong >0");
            dtgvHanghet.DataSource = DataProvider.Instance.ExecuteQuery("select * from MatHang where SoLuong =0");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
