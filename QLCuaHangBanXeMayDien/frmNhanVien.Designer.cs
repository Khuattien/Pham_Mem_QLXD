namespace QLCuaHangBanXeMayDien
{
    partial class frmNhanVien
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
            this.panelTittleNhanVien = new System.Windows.Forms.Panel();
            this.lbTittleNhanVien = new System.Windows.Forms.Label();
            this.grbNhanVien = new System.Windows.Forms.GroupBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.grbGioiTInh = new System.Windows.Forms.GroupBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.txbTimKiemNV = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.txbDienThoaiNV = new System.Windows.Forms.TextBox();
            this.txbLuongNV = new System.Windows.Forms.TextBox();
            this.txbChucVuNV = new System.Windows.Forms.TextBox();
            this.txbNamSinhNV = new System.Windows.Forms.TextBox();
            this.txbTenNV = new System.Windows.Forms.TextBox();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.lbDiaChiNV = new System.Windows.Forms.Label();
            this.lbDienThoaiNV = new System.Windows.Forms.Label();
            this.lbLuongNV = new System.Windows.Forms.Label();
            this.lbChucVuNV = new System.Windows.Forms.Label();
            this.lbNamSinhNV = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.panelListNV = new System.Windows.Forms.Panel();
            this.lbListNV = new System.Windows.Forms.Label();
            this.dtgvListNV = new System.Windows.Forms.DataGridView();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControlNV = new System.Windows.Forms.Panel();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.btnCancelNV = new System.Windows.Forms.Button();
            this.btnSaveNV = new System.Windows.Forms.Button();
            this.btnDeleteNV = new System.Windows.Forms.Button();
            this.btnUpdateNV = new System.Windows.Forms.Button();
            this.btnAddNV = new System.Windows.Forms.Button();
            this.panelTittleNhanVien.SuspendLayout();
            this.grbNhanVien.SuspendLayout();
            this.grbGioiTInh.SuspendLayout();
            this.panelListNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListNV)).BeginInit();
            this.panelControlNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTittleNhanVien
            // 
            this.panelTittleNhanVien.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTittleNhanVien.Controls.Add(this.lbTittleNhanVien);
            this.panelTittleNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittleNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTittleNhanVien.ForeColor = System.Drawing.Color.White;
            this.panelTittleNhanVien.Location = new System.Drawing.Point(0, 0);
            this.panelTittleNhanVien.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelTittleNhanVien.Name = "panelTittleNhanVien";
            this.panelTittleNhanVien.Size = new System.Drawing.Size(1064, 75);
            this.panelTittleNhanVien.TabIndex = 1;
            // 
            // lbTittleNhanVien
            // 
            this.lbTittleNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTittleNhanVien.AutoSize = true;
            this.lbTittleNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittleNhanVien.Location = new System.Drawing.Point(459, 25);
            this.lbTittleNhanVien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTittleNhanVien.Name = "lbTittleNhanVien";
            this.lbTittleNhanVien.Size = new System.Drawing.Size(123, 26);
            this.lbTittleNhanVien.TabIndex = 0;
            this.lbTittleNhanVien.Text = "Nhân Viên";
            // 
            // grbNhanVien
            // 
            this.grbNhanVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbNhanVien.Controls.Add(this.btnTimkiem);
            this.grbNhanVien.Controls.Add(this.grbGioiTInh);
            this.grbNhanVien.Controls.Add(this.txbTimKiemNV);
            this.grbNhanVien.Controls.Add(this.txbDiaChi);
            this.grbNhanVien.Controls.Add(this.txbDienThoaiNV);
            this.grbNhanVien.Controls.Add(this.txbLuongNV);
            this.grbNhanVien.Controls.Add(this.txbChucVuNV);
            this.grbNhanVien.Controls.Add(this.txbNamSinhNV);
            this.grbNhanVien.Controls.Add(this.txbTenNV);
            this.grbNhanVien.Controls.Add(this.txbMaNV);
            this.grbNhanVien.Controls.Add(this.lbDiaChiNV);
            this.grbNhanVien.Controls.Add(this.lbDienThoaiNV);
            this.grbNhanVien.Controls.Add(this.lbLuongNV);
            this.grbNhanVien.Controls.Add(this.lbChucVuNV);
            this.grbNhanVien.Controls.Add(this.lbNamSinhNV);
            this.grbNhanVien.Controls.Add(this.lbTenNV);
            this.grbNhanVien.Controls.Add(this.lbMaNV);
            this.grbNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhanVien.Location = new System.Drawing.Point(0, 75);
            this.grbNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.grbNhanVien.Name = "grbNhanVien";
            this.grbNhanVien.Padding = new System.Windows.Forms.Padding(4);
            this.grbNhanVien.Size = new System.Drawing.Size(1064, 232);
            this.grbNhanVien.TabIndex = 2;
            this.grbNhanVien.TabStop = false;
            this.grbNhanVien.Text = "Thông tin nhân viên";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(957, 178);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 26);
            this.btnTimkiem.TabIndex = 10;
            this.btnTimkiem.Text = "Search";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // grbGioiTInh
            // 
            this.grbGioiTInh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grbGioiTInh.Controls.Add(this.rdbNu);
            this.grbGioiTInh.Controls.Add(this.rdbNam);
            this.grbGioiTInh.Location = new System.Drawing.Point(37, 136);
            this.grbGioiTInh.Name = "grbGioiTInh";
            this.grbGioiTInh.Size = new System.Drawing.Size(272, 68);
            this.grbGioiTInh.TabIndex = 2;
            this.grbGioiTInh.TabStop = false;
            this.grbGioiTInh.Text = "Giới tính";
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(164, 25);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(47, 24);
            this.rdbNu.TabIndex = 3;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(49, 25);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(60, 24);
            this.rdbNam.TabIndex = 2;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // txbTimKiemNV
            // 
            this.txbTimKiemNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbTimKiemNV.Location = new System.Drawing.Point(725, 178);
            this.txbTimKiemNV.Name = "txbTimKiemNV";
            this.txbTimKiemNV.Size = new System.Drawing.Size(226, 26);
            this.txbTimKiemNV.TabIndex = 9;
            this.txbTimKiemNV.Click += new System.EventHandler(this.txbTimKiemNV_Click);
            this.txbTimKiemNV.Leave += new System.EventHandler(this.txbTimKiemNV_Leave);
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbDiaChi.Location = new System.Drawing.Point(478, 136);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(182, 26);
            this.txbDiaChi.TabIndex = 6;
            // 
            // txbDienThoaiNV
            // 
            this.txbDienThoaiNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbDienThoaiNV.Location = new System.Drawing.Point(478, 82);
            this.txbDienThoaiNV.Name = "txbDienThoaiNV";
            this.txbDienThoaiNV.Size = new System.Drawing.Size(182, 26);
            this.txbDienThoaiNV.TabIndex = 5;
            // 
            // txbLuongNV
            // 
            this.txbLuongNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbLuongNV.Location = new System.Drawing.Point(816, 88);
            this.txbLuongNV.Name = "txbLuongNV";
            this.txbLuongNV.Size = new System.Drawing.Size(182, 26);
            this.txbLuongNV.TabIndex = 8;
            this.txbLuongNV.TextChanged += new System.EventHandler(this.txbLuongNV_TextChanged);
            // 
            // txbChucVuNV
            // 
            this.txbChucVuNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbChucVuNV.Location = new System.Drawing.Point(816, 36);
            this.txbChucVuNV.Name = "txbChucVuNV";
            this.txbChucVuNV.Size = new System.Drawing.Size(182, 26);
            this.txbChucVuNV.TabIndex = 7;
            // 
            // txbNamSinhNV
            // 
            this.txbNamSinhNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbNamSinhNV.Location = new System.Drawing.Point(478, 33);
            this.txbNamSinhNV.Name = "txbNamSinhNV";
            this.txbNamSinhNV.Size = new System.Drawing.Size(182, 26);
            this.txbNamSinhNV.TabIndex = 4;
            this.txbNamSinhNV.TextChanged += new System.EventHandler(this.txbNamSinhNV_TextChanged);
            // 
            // txbTenNV
            // 
            this.txbTenNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbTenNV.Location = new System.Drawing.Point(127, 82);
            this.txbTenNV.Name = "txbTenNV";
            this.txbTenNV.Size = new System.Drawing.Size(182, 26);
            this.txbTenNV.TabIndex = 1;
            // 
            // txbMaNV
            // 
            this.txbMaNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbMaNV.Location = new System.Drawing.Point(127, 36);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(182, 26);
            this.txbMaNV.TabIndex = 0;
            // 
            // lbDiaChiNV
            // 
            this.lbDiaChiNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDiaChiNV.AutoSize = true;
            this.lbDiaChiNV.Location = new System.Drawing.Point(383, 139);
            this.lbDiaChiNV.Name = "lbDiaChiNV";
            this.lbDiaChiNV.Size = new System.Drawing.Size(57, 20);
            this.lbDiaChiNV.TabIndex = 0;
            this.lbDiaChiNV.Text = "Địa chỉ";
            // 
            // lbDienThoaiNV
            // 
            this.lbDienThoaiNV.AccessibleDescription = "";
            this.lbDienThoaiNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDienThoaiNV.AutoSize = true;
            this.lbDienThoaiNV.Location = new System.Drawing.Point(383, 88);
            this.lbDienThoaiNV.Name = "lbDienThoaiNV";
            this.lbDienThoaiNV.Size = new System.Drawing.Size(81, 20);
            this.lbDienThoaiNV.TabIndex = 0;
            this.lbDienThoaiNV.Text = "Điện thoại";
            // 
            // lbLuongNV
            // 
            this.lbLuongNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbLuongNV.AutoSize = true;
            this.lbLuongNV.Location = new System.Drawing.Point(721, 91);
            this.lbLuongNV.Name = "lbLuongNV";
            this.lbLuongNV.Size = new System.Drawing.Size(54, 20);
            this.lbLuongNV.TabIndex = 0;
            this.lbLuongNV.Text = "Lương";
            // 
            // lbChucVuNV
            // 
            this.lbChucVuNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbChucVuNV.AutoSize = true;
            this.lbChucVuNV.Location = new System.Drawing.Point(721, 36);
            this.lbChucVuNV.Name = "lbChucVuNV";
            this.lbChucVuNV.Size = new System.Drawing.Size(66, 20);
            this.lbChucVuNV.TabIndex = 0;
            this.lbChucVuNV.Text = "Chức vụ";
            // 
            // lbNamSinhNV
            // 
            this.lbNamSinhNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNamSinhNV.AutoSize = true;
            this.lbNamSinhNV.Location = new System.Drawing.Point(383, 36);
            this.lbNamSinhNV.Name = "lbNamSinhNV";
            this.lbNamSinhNV.Size = new System.Drawing.Size(75, 20);
            this.lbNamSinhNV.TabIndex = 0;
            this.lbNamSinhNV.Text = "Năm sinh";
            // 
            // lbTenNV
            // 
            this.lbTenNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Location = new System.Drawing.Point(28, 88);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(62, 20);
            this.lbTenNV.TabIndex = 0;
            this.lbTenNV.Text = "Tên NV";
            // 
            // lbMaNV
            // 
            this.lbMaNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(33, 36);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(57, 20);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Mã NV";
            // 
            // panelListNV
            // 
            this.panelListNV.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelListNV.Controls.Add(this.lbListNV);
            this.panelListNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelListNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelListNV.ForeColor = System.Drawing.Color.White;
            this.panelListNV.Location = new System.Drawing.Point(0, 307);
            this.panelListNV.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelListNV.Name = "panelListNV";
            this.panelListNV.Size = new System.Drawing.Size(1064, 39);
            this.panelListNV.TabIndex = 3;
            // 
            // lbListNV
            // 
            this.lbListNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbListNV.AutoSize = true;
            this.lbListNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListNV.Location = new System.Drawing.Point(369, 4);
            this.lbListNV.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbListNV.Name = "lbListNV";
            this.lbListNV.Size = new System.Drawing.Size(274, 24);
            this.lbListNV.TabIndex = 0;
            this.lbListNV.Text = "Danh sách chi tiết nhân viên";
            // 
            // dtgvListNV
            // 
            this.dtgvListNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.TenNhanVien,
            this.NamSinh,
            this.GioiTinh,
            this.DienThoai,
            this.DiaChi,
            this.ChucVu,
            this.Luong});
            this.dtgvListNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvListNV.Location = new System.Drawing.Point(0, 346);
            this.dtgvListNV.Name = "dtgvListNV";
            this.dtgvListNV.ReadOnly = true;
            this.dtgvListNV.RowHeadersWidth = 51;
            this.dtgvListNV.RowTemplate.Height = 24;
            this.dtgvListNV.Size = new System.Drawing.Size(1064, 341);
            this.dtgvListNV.TabIndex = 17;
            this.dtgvListNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListNV_CellClick);
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            this.MaNhanVien.Width = 120;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNhanVien.DataPropertyName = "TenNhanVien";
            this.TenNhanVien.HeaderText = "Tên nhân viên";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.ReadOnly = true;
            // 
            // NamSinh
            // 
            this.NamSinh.DataPropertyName = "NamSinh";
            this.NamSinh.HeaderText = "Năm sinh";
            this.NamSinh.Name = "NamSinh";
            this.NamSinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 90;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Số điện thoại";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.ReadOnly = true;
            this.DienThoai.Width = 120;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 150;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            this.ChucVu.Width = 150;
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.Name = "Luong";
            this.Luong.ReadOnly = true;
            this.Luong.Width = 120;
            // 
            // panelControlNV
            // 
            this.panelControlNV.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelControlNV.Controls.Add(this.BtnThoat);
            this.panelControlNV.Controls.Add(this.btnCancelNV);
            this.panelControlNV.Controls.Add(this.btnSaveNV);
            this.panelControlNV.Controls.Add(this.btnDeleteNV);
            this.panelControlNV.Controls.Add(this.btnUpdateNV);
            this.panelControlNV.Controls.Add(this.btnAddNV);
            this.panelControlNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlNV.Location = new System.Drawing.Point(0, 623);
            this.panelControlNV.Name = "panelControlNV";
            this.panelControlNV.Size = new System.Drawing.Size(1064, 64);
            this.panelControlNV.TabIndex = 5;
            // 
            // BtnThoat
            // 
            this.BtnThoat.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThoat.ForeColor = System.Drawing.Color.White;
            this.BtnThoat.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_delete_32__1_;
            this.BtnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnThoat.Location = new System.Drawing.Point(868, 7);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(130, 45);
            this.BtnThoat.TabIndex = 16;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = false;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // btnCancelNV
            // 
            this.btnCancelNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelNV.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelNV.ForeColor = System.Drawing.Color.White;
            this.btnCancelNV.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_delete_32__1_;
            this.btnCancelNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelNV.Location = new System.Drawing.Point(667, 7);
            this.btnCancelNV.Name = "btnCancelNV";
            this.btnCancelNV.Size = new System.Drawing.Size(130, 45);
            this.btnCancelNV.TabIndex = 15;
            this.btnCancelNV.Text = "Hủy";
            this.btnCancelNV.UseVisualStyleBackColor = false;
            this.btnCancelNV.Click += new System.EventHandler(this.btnCancelNV_Click);
            // 
            // btnSaveNV
            // 
            this.btnSaveNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveNV.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNV.ForeColor = System.Drawing.Color.White;
            this.btnSaveNV.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_update_32;
            this.btnSaveNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveNV.Location = new System.Drawing.Point(499, 7);
            this.btnSaveNV.Name = "btnSaveNV";
            this.btnSaveNV.Size = new System.Drawing.Size(130, 45);
            this.btnSaveNV.TabIndex = 14;
            this.btnSaveNV.Text = "Lưu";
            this.btnSaveNV.UseVisualStyleBackColor = false;
            this.btnSaveNV.Click += new System.EventHandler(this.btnSaveNV_Click);
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteNV.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNV.ForeColor = System.Drawing.Color.White;
            this.btnDeleteNV.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_delete_view_32;
            this.btnDeleteNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteNV.Location = new System.Drawing.Point(334, 7);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Size = new System.Drawing.Size(130, 45);
            this.btnDeleteNV.TabIndex = 13;
            this.btnDeleteNV.Text = "Xóa";
            this.btnDeleteNV.UseVisualStyleBackColor = false;
            this.btnDeleteNV.Click += new System.EventHandler(this.btnDeleteNV_Click);
            // 
            // btnUpdateNV
            // 
            this.btnUpdateNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdateNV.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateNV.ForeColor = System.Drawing.Color.White;
            this.btnUpdateNV.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_edit_property_32__1_;
            this.btnUpdateNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateNV.Location = new System.Drawing.Point(168, 7);
            this.btnUpdateNV.Name = "btnUpdateNV";
            this.btnUpdateNV.Size = new System.Drawing.Size(130, 45);
            this.btnUpdateNV.TabIndex = 12;
            this.btnUpdateNV.Text = "Sửa";
            this.btnUpdateNV.UseVisualStyleBackColor = false;
            this.btnUpdateNV.Click += new System.EventHandler(this.btnUpdateNV_Click_1);
            // 
            // btnAddNV
            // 
            this.btnAddNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddNV.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNV.ForeColor = System.Drawing.Color.White;
            this.btnAddNV.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_add_new_32__2_;
            this.btnAddNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNV.Location = new System.Drawing.Point(4, 7);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(130, 45);
            this.btnAddNV.TabIndex = 11;
            this.btnAddNV.Text = "Thêm mới";
            this.btnAddNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNV.UseVisualStyleBackColor = false;
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 687);
            this.Controls.Add(this.panelControlNV);
            this.Controls.Add(this.dtgvListNV);
            this.Controls.Add(this.panelListNV);
            this.Controls.Add(this.grbNhanVien);
            this.Controls.Add(this.panelTittleNhanVien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 726);
            this.MinimumSize = new System.Drawing.Size(1080, 726);
            this.Name = "frmNhanVien";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhanVien";
            this.TopMost = true;
            this.panelTittleNhanVien.ResumeLayout(false);
            this.panelTittleNhanVien.PerformLayout();
            this.grbNhanVien.ResumeLayout(false);
            this.grbNhanVien.PerformLayout();
            this.grbGioiTInh.ResumeLayout(false);
            this.grbGioiTInh.PerformLayout();
            this.panelListNV.ResumeLayout(false);
            this.panelListNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListNV)).EndInit();
            this.panelControlNV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTittleNhanVien;
        private System.Windows.Forms.Label lbTittleNhanVien;
        private System.Windows.Forms.GroupBox grbNhanVien;
        private System.Windows.Forms.GroupBox grbGioiTInh;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.TextBox txbTimKiemNV;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.TextBox txbDienThoaiNV;
        private System.Windows.Forms.TextBox txbLuongNV;
        private System.Windows.Forms.TextBox txbChucVuNV;
        private System.Windows.Forms.TextBox txbNamSinhNV;
        private System.Windows.Forms.TextBox txbTenNV;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.Label lbDiaChiNV;
        private System.Windows.Forms.Label lbDienThoaiNV;
        private System.Windows.Forms.Label lbLuongNV;
        private System.Windows.Forms.Label lbChucVuNV;
        private System.Windows.Forms.Label lbNamSinhNV;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Panel panelListNV;
        private System.Windows.Forms.Label lbListNV;
        private System.Windows.Forms.DataGridView dtgvListNV;
        private System.Windows.Forms.Panel panelControlNV;
        private System.Windows.Forms.Button btnAddNV;
        private System.Windows.Forms.Button btnCancelNV;
        private System.Windows.Forms.Button btnSaveNV;
        private System.Windows.Forms.Button btnDeleteNV;
        private System.Windows.Forms.Button btnUpdateNV;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
    }
}