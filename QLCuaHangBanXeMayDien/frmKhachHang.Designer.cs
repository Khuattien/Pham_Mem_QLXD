﻿namespace QLCuaHangBanXeMayDien
{
    partial class frmKhachHang
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
            this.panelTittleKhachHang = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbTittleKhachHang = new System.Windows.Forms.Label();
            this.grbNhanVien = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTimKiemKH = new System.Windows.Forms.TextBox();
            this.txbDiaChiKH = new System.Windows.Forms.TextBox();
            this.txbDienThoaiKH = new System.Windows.Forms.TextBox();
            this.txbEmailKH = new System.Windows.Forms.TextBox();
            this.txbTenKH = new System.Windows.Forms.TextBox();
            this.txbMaKH = new System.Windows.Forms.TextBox();
            this.lbDiaChiKH = new System.Windows.Forms.Label();
            this.lbDienThoaiKH = new System.Windows.Forms.Label();
            this.lbEmailKH = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.panelListKH = new System.Windows.Forms.Panel();
            this.lbListKH = new System.Windows.Forms.Label();
            this.dtgvKhachHang = new System.Windows.Forms.DataGridView();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControlNV = new System.Windows.Forms.Panel();
            this.btnCancelKH = new System.Windows.Forms.Button();
            this.btnSaveKH = new System.Windows.Forms.Button();
            this.btnDeleteKH = new System.Windows.Forms.Button();
            this.btnUpdateKH = new System.Windows.Forms.Button();
            this.btnAddKH = new System.Windows.Forms.Button();
            this.btnSeacrh = new System.Windows.Forms.Button();
            this.panelTittleKhachHang.SuspendLayout();
            this.grbNhanVien.SuspendLayout();
            this.panelListKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).BeginInit();
            this.panelControlNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTittleKhachHang
            // 
            this.panelTittleKhachHang.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTittleKhachHang.Controls.Add(this.button1);
            this.panelTittleKhachHang.Controls.Add(this.lbTittleKhachHang);
            this.panelTittleKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittleKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTittleKhachHang.ForeColor = System.Drawing.Color.White;
            this.panelTittleKhachHang.Location = new System.Drawing.Point(0, 0);
            this.panelTittleKhachHang.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelTittleKhachHang.Name = "panelTittleKhachHang";
            this.panelTittleKhachHang.Size = new System.Drawing.Size(1093, 75);
            this.panelTittleKhachHang.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 73);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbTittleKhachHang
            // 
            this.lbTittleKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTittleKhachHang.AutoSize = true;
            this.lbTittleKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittleKhachHang.Location = new System.Drawing.Point(473, 25);
            this.lbTittleKhachHang.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTittleKhachHang.Name = "lbTittleKhachHang";
            this.lbTittleKhachHang.Size = new System.Drawing.Size(181, 32);
            this.lbTittleKhachHang.TabIndex = 0;
            this.lbTittleKhachHang.Text = "Khách Hàng";
            // 
            // grbNhanVien
            // 
            this.grbNhanVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbNhanVien.Controls.Add(this.label1);
            this.grbNhanVien.Controls.Add(this.btnSeacrh);
            this.grbNhanVien.Controls.Add(this.txbTimKiemKH);
            this.grbNhanVien.Controls.Add(this.txbDiaChiKH);
            this.grbNhanVien.Controls.Add(this.txbDienThoaiKH);
            this.grbNhanVien.Controls.Add(this.txbEmailKH);
            this.grbNhanVien.Controls.Add(this.txbTenKH);
            this.grbNhanVien.Controls.Add(this.txbMaKH);
            this.grbNhanVien.Controls.Add(this.lbDiaChiKH);
            this.grbNhanVien.Controls.Add(this.lbDienThoaiKH);
            this.grbNhanVien.Controls.Add(this.lbEmailKH);
            this.grbNhanVien.Controls.Add(this.lbTenKH);
            this.grbNhanVien.Controls.Add(this.lbMaKH);
            this.grbNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhanVien.Location = new System.Drawing.Point(0, 75);
            this.grbNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.grbNhanVien.Name = "grbNhanVien";
            this.grbNhanVien.Padding = new System.Windows.Forms.Padding(4);
            this.grbNhanVien.Size = new System.Drawing.Size(1093, 213);
            this.grbNhanVien.TabIndex = 3;
            this.grbNhanVien.TabStop = false;
            this.grbNhanVien.Text = "Thông tin khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(784, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tìm mã khách hàng";
            // 
            // txbTimKiemKH
            // 
            this.txbTimKiemKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbTimKiemKH.BackColor = System.Drawing.Color.White;
            this.txbTimKiemKH.Location = new System.Drawing.Point(787, 171);
            this.txbTimKiemKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTimKiemKH.Name = "txbTimKiemKH";
            this.txbTimKiemKH.Size = new System.Drawing.Size(269, 30);
            this.txbTimKiemKH.TabIndex = 6;
            // 
            // txbDiaChiKH
            // 
            this.txbDiaChiKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbDiaChiKH.BackColor = System.Drawing.Color.White;
            this.txbDiaChiKH.Location = new System.Drawing.Point(478, 98);
            this.txbDiaChiKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDiaChiKH.Name = "txbDiaChiKH";
            this.txbDiaChiKH.Size = new System.Drawing.Size(183, 30);
            this.txbDiaChiKH.TabIndex = 4;
            // 
            // txbDienThoaiKH
            // 
            this.txbDienThoaiKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbDienThoaiKH.Location = new System.Drawing.Point(478, 49);
            this.txbDienThoaiKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDienThoaiKH.Name = "txbDienThoaiKH";
            this.txbDienThoaiKH.Size = new System.Drawing.Size(183, 30);
            this.txbDienThoaiKH.TabIndex = 3;
            this.txbDienThoaiKH.TextChanged += new System.EventHandler(this.txbDienThoaiKH_TextChanged);
            // 
            // txbEmailKH
            // 
            this.txbEmailKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbEmailKH.Location = new System.Drawing.Point(787, 48);
            this.txbEmailKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbEmailKH.Name = "txbEmailKH";
            this.txbEmailKH.Size = new System.Drawing.Size(269, 30);
            this.txbEmailKH.TabIndex = 5;
            // 
            // txbTenKH
            // 
            this.txbTenKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbTenKH.Location = new System.Drawing.Point(123, 98);
            this.txbTenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTenKH.Name = "txbTenKH";
            this.txbTenKH.Size = new System.Drawing.Size(183, 30);
            this.txbTenKH.TabIndex = 2;
            // 
            // txbMaKH
            // 
            this.txbMaKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbMaKH.BackColor = System.Drawing.Color.White;
            this.txbMaKH.Location = new System.Drawing.Point(123, 48);
            this.txbMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMaKH.Name = "txbMaKH";
            this.txbMaKH.Size = new System.Drawing.Size(183, 30);
            this.txbMaKH.TabIndex = 1;
            // 
            // lbDiaChiKH
            // 
            this.lbDiaChiKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDiaChiKH.AutoSize = true;
            this.lbDiaChiKH.Location = new System.Drawing.Point(365, 102);
            this.lbDiaChiKH.Name = "lbDiaChiKH";
            this.lbDiaChiKH.Size = new System.Drawing.Size(71, 25);
            this.lbDiaChiKH.TabIndex = 0;
            this.lbDiaChiKH.Text = "Địa chỉ";
            // 
            // lbDienThoaiKH
            // 
            this.lbDienThoaiKH.AccessibleDescription = "";
            this.lbDienThoaiKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDienThoaiKH.AutoSize = true;
            this.lbDienThoaiKH.Location = new System.Drawing.Point(365, 52);
            this.lbDienThoaiKH.Name = "lbDienThoaiKH";
            this.lbDienThoaiKH.Size = new System.Drawing.Size(99, 25);
            this.lbDienThoaiKH.TabIndex = 0;
            this.lbDienThoaiKH.Text = "Điện thoại";
            // 
            // lbEmailKH
            // 
            this.lbEmailKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEmailKH.AutoSize = true;
            this.lbEmailKH.Location = new System.Drawing.Point(718, 53);
            this.lbEmailKH.Name = "lbEmailKH";
            this.lbEmailKH.Size = new System.Drawing.Size(60, 25);
            this.lbEmailKH.TabIndex = 0;
            this.lbEmailKH.Text = "Email";
            // 
            // lbTenKH
            // 
            this.lbTenKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Location = new System.Drawing.Point(29, 102);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(80, 25);
            this.lbTenKH.TabIndex = 0;
            this.lbTenKH.Text = "Tên KH";
            // 
            // lbMaKH
            // 
            this.lbMaKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Location = new System.Drawing.Point(35, 52);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(73, 25);
            this.lbMaKH.TabIndex = 0;
            this.lbMaKH.Text = "Mã KH";
            // 
            // panelListKH
            // 
            this.panelListKH.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelListKH.Controls.Add(this.lbListKH);
            this.panelListKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelListKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelListKH.ForeColor = System.Drawing.Color.White;
            this.panelListKH.Location = new System.Drawing.Point(0, 288);
            this.panelListKH.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelListKH.Name = "panelListKH";
            this.panelListKH.Size = new System.Drawing.Size(1093, 39);
            this.panelListKH.TabIndex = 4;
            // 
            // lbListKH
            // 
            this.lbListKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbListKH.AutoSize = true;
            this.lbListKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListKH.Location = new System.Drawing.Point(383, 4);
            this.lbListKH.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbListKH.Name = "lbListKH";
            this.lbListKH.Size = new System.Drawing.Size(357, 29);
            this.lbListKH.TabIndex = 0;
            this.lbListKH.Text = "Danh sách chi tiết khách hàng";
            // 
            // dtgvKhachHang
            // 
            this.dtgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhachHang,
            this.TenKhachHang,
            this.DienThoai,
            this.DiaChi,
            this.Email});
            this.dtgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvKhachHang.Location = new System.Drawing.Point(0, 327);
            this.dtgvKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvKhachHang.Name = "dtgvKhachHang";
            this.dtgvKhachHang.ReadOnly = true;
            this.dtgvKhachHang.RowHeadersWidth = 51;
            this.dtgvKhachHang.RowTemplate.Height = 24;
            this.dtgvKhachHang.Size = new System.Drawing.Size(1093, 382);
            this.dtgvKhachHang.TabIndex = 5;
            this.dtgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvKhachHang_CellClick);
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.DataPropertyName = "MaKhachHang";
            this.MaKhachHang.HeaderText = "Mã Khách Hàng";
            this.MaKhachHang.MinimumWidth = 6;
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.ReadOnly = true;
            this.MaKhachHang.Width = 120;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên Khách Hàng";
            this.TenKhachHang.MinimumWidth = 6;
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            this.TenKhachHang.Width = 150;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện thoại";
            this.DienThoai.MinimumWidth = 6;
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.ReadOnly = true;
            this.DienThoai.Width = 120;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 200;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 180;
            // 
            // panelControlNV
            // 
            this.panelControlNV.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelControlNV.Controls.Add(this.btnCancelKH);
            this.panelControlNV.Controls.Add(this.btnSaveKH);
            this.panelControlNV.Controls.Add(this.btnDeleteKH);
            this.panelControlNV.Controls.Add(this.btnUpdateKH);
            this.panelControlNV.Controls.Add(this.btnAddKH);
            this.panelControlNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlNV.Location = new System.Drawing.Point(0, 645);
            this.panelControlNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControlNV.Name = "panelControlNV";
            this.panelControlNV.Size = new System.Drawing.Size(1093, 64);
            this.panelControlNV.TabIndex = 6;
            // 
            // btnCancelKH
            // 
            this.btnCancelKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelKH.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelKH.ForeColor = System.Drawing.Color.White;
            this.btnCancelKH.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_delete_32__1_;
            this.btnCancelKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelKH.Location = new System.Drawing.Point(665, 7);
            this.btnCancelKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelKH.Name = "btnCancelKH";
            this.btnCancelKH.Size = new System.Drawing.Size(131, 46);
            this.btnCancelKH.TabIndex = 5;
            this.btnCancelKH.Text = "Hủy";
            this.btnCancelKH.UseVisualStyleBackColor = false;
            this.btnCancelKH.Click += new System.EventHandler(this.btnCancelKH_Click);
            // 
            // btnSaveKH
            // 
            this.btnSaveKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveKH.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveKH.ForeColor = System.Drawing.Color.White;
            this.btnSaveKH.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_update_32;
            this.btnSaveKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveKH.Location = new System.Drawing.Point(497, 7);
            this.btnSaveKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveKH.Name = "btnSaveKH";
            this.btnSaveKH.Size = new System.Drawing.Size(131, 46);
            this.btnSaveKH.TabIndex = 4;
            this.btnSaveKH.Text = "Lưu";
            this.btnSaveKH.UseVisualStyleBackColor = false;
            this.btnSaveKH.Click += new System.EventHandler(this.btnSaveKH_Click);
            // 
            // btnDeleteKH
            // 
            this.btnDeleteKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteKH.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteKH.ForeColor = System.Drawing.Color.White;
            this.btnDeleteKH.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_delete_view_32;
            this.btnDeleteKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteKH.Location = new System.Drawing.Point(331, 7);
            this.btnDeleteKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteKH.Name = "btnDeleteKH";
            this.btnDeleteKH.Size = new System.Drawing.Size(131, 46);
            this.btnDeleteKH.TabIndex = 3;
            this.btnDeleteKH.Text = "Xóa";
            this.btnDeleteKH.UseVisualStyleBackColor = false;
            this.btnDeleteKH.Click += new System.EventHandler(this.btnDeleteKH_Click);
            // 
            // btnUpdateKH
            // 
            this.btnUpdateKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdateKH.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateKH.ForeColor = System.Drawing.Color.White;
            this.btnUpdateKH.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_edit_property_32__1_;
            this.btnUpdateKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateKH.Location = new System.Drawing.Point(165, 7);
            this.btnUpdateKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateKH.Name = "btnUpdateKH";
            this.btnUpdateKH.Size = new System.Drawing.Size(131, 46);
            this.btnUpdateKH.TabIndex = 2;
            this.btnUpdateKH.Text = "Sửa";
            this.btnUpdateKH.UseVisualStyleBackColor = false;
            this.btnUpdateKH.Click += new System.EventHandler(this.btnUpdateKH_Click);
            // 
            // btnAddKH
            // 
            this.btnAddKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddKH.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddKH.ForeColor = System.Drawing.Color.White;
            this.btnAddKH.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_add_new_32__2_;
            this.btnAddKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddKH.Location = new System.Drawing.Point(1, 7);
            this.btnAddKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddKH.Name = "btnAddKH";
            this.btnAddKH.Size = new System.Drawing.Size(131, 46);
            this.btnAddKH.TabIndex = 1;
            this.btnAddKH.Text = "Thêm mới";
            this.btnAddKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddKH.UseVisualStyleBackColor = false;
            this.btnAddKH.Click += new System.EventHandler(this.btnAddKH_Click);
            // 
            // btnSeacrh
            // 
            this.btnSeacrh.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSeacrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeacrh.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSeacrh.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_search_26;
            this.btnSeacrh.Location = new System.Drawing.Point(723, 169);
            this.btnSeacrh.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeacrh.Name = "btnSeacrh";
            this.btnSeacrh.Size = new System.Drawing.Size(59, 36);
            this.btnSeacrh.TabIndex = 7;
            this.btnSeacrh.UseVisualStyleBackColor = false;
            this.btnSeacrh.Click += new System.EventHandler(this.btnSeacrh_Click);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 709);
            this.Controls.Add(this.panelControlNV);
            this.Controls.Add(this.dtgvKhachHang);
            this.Controls.Add(this.panelListKH);
            this.Controls.Add(this.grbNhanVien);
            this.Controls.Add(this.panelTittleKhachHang);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1111, 756);
            this.MinimumSize = new System.Drawing.Size(1111, 756);
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng";
            this.panelTittleKhachHang.ResumeLayout(false);
            this.panelTittleKhachHang.PerformLayout();
            this.grbNhanVien.ResumeLayout(false);
            this.grbNhanVien.PerformLayout();
            this.panelListKH.ResumeLayout(false);
            this.panelListKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhachHang)).EndInit();
            this.panelControlNV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTittleKhachHang;
        private System.Windows.Forms.Label lbTittleKhachHang;
        private System.Windows.Forms.GroupBox grbNhanVien;
        private System.Windows.Forms.TextBox txbTimKiemKH;
        private System.Windows.Forms.TextBox txbDiaChiKH;
        private System.Windows.Forms.TextBox txbDienThoaiKH;
        private System.Windows.Forms.TextBox txbEmailKH;
        private System.Windows.Forms.TextBox txbTenKH;
        private System.Windows.Forms.TextBox txbMaKH;
        private System.Windows.Forms.Label lbDiaChiKH;
        private System.Windows.Forms.Label lbDienThoaiKH;
        private System.Windows.Forms.Label lbEmailKH;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Panel panelListKH;
        private System.Windows.Forms.Label lbListKH;
        private System.Windows.Forms.DataGridView dtgvKhachHang;
        private System.Windows.Forms.Panel panelControlNV;
        private System.Windows.Forms.Button btnCancelKH;
        private System.Windows.Forms.Button btnSaveKH;
        private System.Windows.Forms.Button btnDeleteKH;
        private System.Windows.Forms.Button btnUpdateKH;
        private System.Windows.Forms.Button btnAddKH;
        private System.Windows.Forms.Button btnSeacrh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}