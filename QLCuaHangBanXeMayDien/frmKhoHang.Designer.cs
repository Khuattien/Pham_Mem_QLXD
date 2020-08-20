namespace QLCuaHangBanXeMayDien
{
    partial class frmKhoHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTittleKho = new System.Windows.Forms.Panel();
            this.lbTittleKho = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgvHangcon = new System.Windows.Forms.DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThongTinBaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnhMinhHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgvHanghet = new System.Windows.Forms.DataGridView();
            this.MaHang1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaSanXuat1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThongTinBaoHanh1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnhMinhHoa1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTittleKho.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangcon)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHanghet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTittleKho
            // 
            this.panelTittleKho.BackColor = System.Drawing.Color.DarkBlue;
            this.panelTittleKho.Controls.Add(this.lbTittleKho);
            this.panelTittleKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittleKho.Location = new System.Drawing.Point(0, 0);
            this.panelTittleKho.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelTittleKho.Name = "panelTittleKho";
            this.panelTittleKho.Size = new System.Drawing.Size(1064, 63);
            this.panelTittleKho.TabIndex = 1;
            // 
            // lbTittleKho
            // 
            this.lbTittleKho.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTittleKho.AutoSize = true;
            this.lbTittleKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittleKho.ForeColor = System.Drawing.Color.White;
            this.lbTittleKho.Location = new System.Drawing.Point(471, 20);
            this.lbTittleKho.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTittleKho.Name = "lbTittleKho";
            this.lbTittleKho.Size = new System.Drawing.Size(113, 26);
            this.lbTittleKho.TabIndex = 2;
            this.lbTittleKho.Text = "Kho hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Location = new System.Drawing.Point(0, 637);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1066, 52);
            this.panel2.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(12, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(97, 35);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 568);
            this.panel1.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-2, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1066, 561);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.dtgvHangcon);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1058, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hàng còn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgvHangcon
            // 
            this.dtgvHangcon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHangcon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenHang,
            this.NhaSanXuat,
            this.MoTa,
            this.ThongTinBaoHanh,
            this.SoLuong,
            this.DonViTinh,
            this.AnhMinhHoa});
            this.dtgvHangcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvHangcon.Location = new System.Drawing.Point(3, 3);
            this.dtgvHangcon.Name = "dtgvHangcon";
            this.dtgvHangcon.ReadOnly = true;
            this.dtgvHangcon.Size = new System.Drawing.Size(1052, 524);
            this.dtgvHangcon.TabIndex = 0;
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Mã hàng";
            this.MaHang.Name = "MaHang";
            this.MaHang.ReadOnly = true;
            // 
            // TenHang
            // 
            this.TenHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.HeaderText = "Tên hàng";
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            // 
            // NhaSanXuat
            // 
            this.NhaSanXuat.DataPropertyName = "NhaSanXuat";
            this.NhaSanXuat.HeaderText = "Nhà sản xuất";
            this.NhaSanXuat.Name = "NhaSanXuat";
            this.NhaSanXuat.ReadOnly = true;
            this.NhaSanXuat.Width = 140;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.MoTa.Width = 115;
            // 
            // ThongTinBaoHanh
            // 
            this.ThongTinBaoHanh.DataPropertyName = "ThongTinBaoHanh";
            this.ThongTinBaoHanh.HeaderText = "Thông tin bảo hành";
            this.ThongTinBaoHanh.Name = "ThongTinBaoHanh";
            this.ThongTinBaoHanh.ReadOnly = true;
            this.ThongTinBaoHanh.Width = 160;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            this.DonViTinh.Width = 120;
            // 
            // AnhMinhHoa
            // 
            this.AnhMinhHoa.DataPropertyName = "AnhMinhHoa";
            this.AnhMinhHoa.HeaderText = "Ảnh minh họa";
            this.AnhMinhHoa.Name = "AnhMinhHoa";
            this.AnhMinhHoa.ReadOnly = true;
            this.AnhMinhHoa.Width = 140;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgvHanghet);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1058, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hàng hết";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgvHanghet
            // 
            this.dtgvHanghet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHanghet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang1,
            this.TenHang1,
            this.NhaSanXuat1,
            this.MoTa1,
            this.ThongTinBaoHanh1,
            this.SoLuong1,
            this.DonViTinh1,
            this.AnhMinhHoa1});
            this.dtgvHanghet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvHanghet.Location = new System.Drawing.Point(3, 3);
            this.dtgvHanghet.Name = "dtgvHanghet";
            this.dtgvHanghet.ReadOnly = true;
            this.dtgvHanghet.Size = new System.Drawing.Size(1052, 524);
            this.dtgvHanghet.TabIndex = 0;
            // 
            // MaHang1
            // 
            this.MaHang1.DataPropertyName = "MaHang";
            this.MaHang1.HeaderText = "Mã hàng";
            this.MaHang1.Name = "MaHang1";
            this.MaHang1.ReadOnly = true;
            // 
            // TenHang1
            // 
            this.TenHang1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHang1.DataPropertyName = "TenHang";
            this.TenHang1.HeaderText = "Tên hàng";
            this.TenHang1.Name = "TenHang1";
            this.TenHang1.ReadOnly = true;
            // 
            // NhaSanXuat1
            // 
            this.NhaSanXuat1.DataPropertyName = "NhaSanXuat";
            this.NhaSanXuat1.HeaderText = "Nhà sản xuất";
            this.NhaSanXuat1.Name = "NhaSanXuat1";
            this.NhaSanXuat1.ReadOnly = true;
            this.NhaSanXuat1.Width = 140;
            // 
            // MoTa1
            // 
            this.MoTa1.DataPropertyName = "MoTa";
            this.MoTa1.HeaderText = "Mô tả";
            this.MoTa1.Name = "MoTa1";
            this.MoTa1.ReadOnly = true;
            this.MoTa1.Width = 115;
            // 
            // ThongTinBaoHanh1
            // 
            this.ThongTinBaoHanh1.DataPropertyName = "ThongTinBaoHanh";
            this.ThongTinBaoHanh1.HeaderText = "Thông tin bảo hành";
            this.ThongTinBaoHanh1.Name = "ThongTinBaoHanh1";
            this.ThongTinBaoHanh1.ReadOnly = true;
            this.ThongTinBaoHanh1.Width = 160;
            // 
            // SoLuong1
            // 
            this.SoLuong1.DataPropertyName = "SoLuong";
            this.SoLuong1.HeaderText = "Số lượng ";
            this.SoLuong1.Name = "SoLuong1";
            this.SoLuong1.ReadOnly = true;
            // 
            // DonViTinh1
            // 
            this.DonViTinh1.DataPropertyName = "DonViTinh";
            this.DonViTinh1.HeaderText = "Đơn vị tính";
            this.DonViTinh1.Name = "DonViTinh1";
            this.DonViTinh1.ReadOnly = true;
            this.DonViTinh1.Width = 120;
            // 
            // AnhMinhHoa1
            // 
            this.AnhMinhHoa1.DataPropertyName = "AnhMinhHoa";
            this.AnhMinhHoa1.HeaderText = "Ảnh minh họa";
            this.AnhMinhHoa1.Name = "AnhMinhHoa1";
            this.AnhMinhHoa1.ReadOnly = true;
            this.AnhMinhHoa1.Width = 140;
            // 
            // frmKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 687);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTittleKho);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 726);
            this.MinimumSize = new System.Drawing.Size(1080, 726);
            this.Name = "frmKhoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho hàng";
            this.Load += new System.EventHandler(this.frmKhoHang_Load);
            this.panelTittleKho.ResumeLayout(false);
            this.panelTittleKho.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHangcon)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHanghet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTittleKho;
        private System.Windows.Forms.Label lbTittleKho;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgvHangcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThongTinBaoHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnhMinhHoa;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgvHanghet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaSanXuat1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThongTinBaoHanh1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnhMinhHoa1;
    }
}