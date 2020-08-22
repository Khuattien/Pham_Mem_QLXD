using QLCuaHangBanXeMayDien.QuanLy_BUS;
using QLCuaHangBanXeMayDien.QuanLy_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangBanXeMayDien
{
    public partial class frmHangHoa : Form
    {
        private AccountLogin account = new AccountLogin();
        public frmHangHoa(AccountLogin transmission)
        {
            InitializeComponent();
            loadListXe(MatHangBUS.Instance.getListMatHang());
            account = transmission;
        }

        MatHang hang = new MatHang();

        /// <summary>
        ///     Phương thức hiển thị mặt hàng lên form
        /// </summary>
        /// 
        #region Một số phương thức  lấy ra các dữ liệu và hiển thị dữ liệu từ database.
        private void loadListXe( List<MatHang> list)
        {
            flpListHangHoa.Controls.Clear();
            List<MatHang> listHang = list;
            foreach (MatHang item in listHang)
            {
                flpListHangHoa.Controls.Add(ShowInforMatHang(item));
            }
        }
        /// <summary>
        /// Phương thúc tạo một thẻ hiển thị hàng lên form
        /// </summary>
        private FlowLayoutPanel ShowInforMatHang(MatHang xedien)
        {
            FlowLayoutPanel flpSanPham = new FlowLayoutPanel() { Width = 200, Height = 220, BackColor = Color.Orange };

            PictureBox picHang = new PictureBox() { Width = 200, Height = 150, SizeMode = PictureBoxSizeMode.StretchImage };

            //int length = xedien.TenHang.Length;
            //int marginValue = (200 - length) / 2;

            Label lbTenHang = new Label() { ForeColor = Color.Blue, TextAlign = ContentAlignment.MiddleCenter, Width = 150, Height = 60 };
            lbTenHang.Font = new Font("Century", 14);
            lbTenHang.Margin = new Padding(25, 0, 25, 10);
            lbTenHang.Text = xedien.TenHang;

            try
            {
                picHang.Image = Image.FromFile(xedien.AnhMinhHoa);
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message , "Lỗi" , MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }



            picHang.Click += PicHang_Click;
            picHang.Tag = xedien;

            flpSanPham.Controls.Add(picHang);
            flpSanPham.Controls.Add(lbTenHang);

            return flpSanPham;
        }
        #endregion

        #region Các sự kiện trong form Hàng Hóa

        /// <summary>
        /// Sự kiện tạo một đối tượng mới    
        /// </summary>
        private void btnAddHangHoa_Click(object sender, EventArgs e)
        {
            frmInsertMatHang frm = new frmInsertMatHang();
            frm.ShowDialog();
            loadListXe(MatHangBUS.Instance.getListMatHang());
        }
        /// <summary>
        ///    Sự kiện hiển thị thông tin của sản phẩm được click.
        /// </summary>
        private void PicHang_Click(object sender, EventArgs e)
        {
            MatHang result = ((sender as PictureBox).Tag) as MatHang;
            //Sao chép dữ liệu của đối tượng để truyền dữ liệu sang form khác làm việc
            frmInforMatHang frm = new frmInforMatHang(result ,account);
            frm.ShowDialog();
            loadListXe(MatHangBUS.Instance.getListMatHang());
        }
        /// <summary>
        /// Sự kiện khi click vào ảnh sẽ hiển thị một số thông tin của sản phẩm 
        /// </summary>
        private void btnViewListHH_Click(object sender, EventArgs e)
        {
            frmDSChiTietHangHoa frm = new frmDSChiTietHangHoa(account);
            this.Hide();
            frm.ShowDialog();
            this.Show();
            loadListXe(MatHangBUS.Instance.getListMatHang());
        }

        /// <summary>
        /// Sự kiện tìm kiếm tên một sản phẩm trong danh sách
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txbSearch.Text != "")
            {
                List<MatHang> listHang = MatHangBUS.Instance.getListMatHangByNanme(txbSearch.Text);
                if (listHang.Count > 0)
                    loadListXe(listHang);
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm này.");
                }
            }
            else
            {
                loadListXe(MatHangBUS.Instance.getListMatHang());
            }
        }
        #endregion
    }
}
