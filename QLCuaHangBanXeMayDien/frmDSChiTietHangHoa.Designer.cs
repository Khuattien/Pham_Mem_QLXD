namespace QLCuaHangBanXeMayDien
{
    partial class frmDSChiTietHangHoa
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.btnImage = new System.Windows.Forms.Button();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.panelControlButton = new System.Windows.Forms.Panel();
            this.btnCancelHang = new System.Windows.Forms.Button();
            this.btnSaveHang = new System.Windows.Forms.Button();
            this.btnDeleteHang = new System.Windows.Forms.Button();
            this.btnUpdateHang = new System.Windows.Forms.Button();
            this.btnInsertHang = new System.Windows.Forms.Button();
            this.picAMH = new System.Windows.Forms.PictureBox();
            this.txbBaoHanh = new System.Windows.Forms.TextBox();
            this.txbMoTa = new System.Windows.Forms.TextBox();
            this.txbDonVi = new System.Windows.Forms.TextBox();
            this.txbNhaSX = new System.Windows.Forms.TextBox();
            this.txbTenHang = new System.Windows.Forms.TextBox();
            this.txbMaHang = new System.Windows.Forms.TextBox();
            this.lbDonVi = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbNhaSanXuat = new System.Windows.Forms.Label();
            this.lbTenHang = new System.Windows.Forms.Label();
            this.lbTTBH = new System.Windows.Forms.Label();
            this.lbMT = new System.Windows.Forms.Label();
            this.lbMaHang = new System.Windows.Forms.Label();
            this.dtgvDanhSach = new System.Windows.Forms.DataGridView();
            this.colMaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeading = new System.Windows.Forms.Panel();
            this.lbHeađing = new System.Windows.Forms.Label();
            this.picIcoSearch = new System.Windows.Forms.PictureBox();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.txbSearchID = new System.Windows.Forms.TextBox();
            this.panelHeader.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.panelControlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSach)).BeginInit();
            this.panelHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcoSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Teal;
            this.panelHeader.Controls.Add(this.lbHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1370, 66);
            this.panelHeader.TabIndex = 1;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.White;
            this.lbHeader.Location = new System.Drawing.Point(488, 18);
            this.lbHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(293, 26);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "Thông tin chi tiết hàng hóa";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelInfo.Controls.Add(this.btnImage);
            this.panelInfo.Controls.Add(this.numSoLuong);
            this.panelInfo.Controls.Add(this.panelControlButton);
            this.panelInfo.Controls.Add(this.picAMH);
            this.panelInfo.Controls.Add(this.txbBaoHanh);
            this.panelInfo.Controls.Add(this.txbMoTa);
            this.panelInfo.Controls.Add(this.txbDonVi);
            this.panelInfo.Controls.Add(this.txbNhaSX);
            this.panelInfo.Controls.Add(this.txbTenHang);
            this.panelInfo.Controls.Add(this.txbMaHang);
            this.panelInfo.Controls.Add(this.lbDonVi);
            this.panelInfo.Controls.Add(this.lbSoLuong);
            this.panelInfo.Controls.Add(this.lbNhaSanXuat);
            this.panelInfo.Controls.Add(this.lbTenHang);
            this.panelInfo.Controls.Add(this.lbTTBH);
            this.panelInfo.Controls.Add(this.lbMT);
            this.panelInfo.Controls.Add(this.lbMaHang);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 66);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1370, 303);
            this.panelInfo.TabIndex = 3;
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnImage.ForeColor = System.Drawing.Color.White;
            this.btnImage.Location = new System.Drawing.Point(971, 256);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(162, 30);
            this.btnImage.TabIndex = 8;
            this.btnImage.Text = "Ảnh sản phẩm";
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(216, 166);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(200, 24);
            this.numSoLuong.TabIndex = 4;
            // 
            // panelControlButton
            // 
            this.panelControlButton.Controls.Add(this.btnCancelHang);
            this.panelControlButton.Controls.Add(this.btnSaveHang);
            this.panelControlButton.Controls.Add(this.btnDeleteHang);
            this.panelControlButton.Controls.Add(this.btnUpdateHang);
            this.panelControlButton.Controls.Add(this.btnInsertHang);
            this.panelControlButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControlButton.Location = new System.Drawing.Point(1170, 0);
            this.panelControlButton.Name = "panelControlButton";
            this.panelControlButton.Size = new System.Drawing.Size(200, 303);
            this.panelControlButton.TabIndex = 3;
            // 
            // btnCancelHang
            // 
            this.btnCancelHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelHang.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancelHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelHang.ForeColor = System.Drawing.Color.White;
            this.btnCancelHang.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_delete_32__1_;
            this.btnCancelHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelHang.Location = new System.Drawing.Point(21, 234);
            this.btnCancelHang.Name = "btnCancelHang";
            this.btnCancelHang.Size = new System.Drawing.Size(149, 45);
            this.btnCancelHang.TabIndex = 12;
            this.btnCancelHang.Text = "Hủy";
            this.btnCancelHang.UseVisualStyleBackColor = false;
            this.btnCancelHang.Click += new System.EventHandler(this.btnCancelHang_Click);
            // 
            // btnSaveHang
            // 
            this.btnSaveHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveHang.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSaveHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveHang.ForeColor = System.Drawing.Color.White;
            this.btnSaveHang.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_update_32;
            this.btnSaveHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveHang.Location = new System.Drawing.Point(21, 183);
            this.btnSaveHang.Name = "btnSaveHang";
            this.btnSaveHang.Size = new System.Drawing.Size(149, 45);
            this.btnSaveHang.TabIndex = 11;
            this.btnSaveHang.Text = "Lưu";
            this.btnSaveHang.UseVisualStyleBackColor = false;
            this.btnSaveHang.Click += new System.EventHandler(this.btnSaveHang_Click);
            // 
            // btnDeleteHang
            // 
            this.btnDeleteHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteHang.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteHang.ForeColor = System.Drawing.Color.White;
            this.btnDeleteHang.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_delete_view_32;
            this.btnDeleteHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteHang.Location = new System.Drawing.Point(21, 132);
            this.btnDeleteHang.Name = "btnDeleteHang";
            this.btnDeleteHang.Size = new System.Drawing.Size(149, 45);
            this.btnDeleteHang.TabIndex = 10;
            this.btnDeleteHang.Text = "Xóa";
            this.btnDeleteHang.UseVisualStyleBackColor = false;
            this.btnDeleteHang.Click += new System.EventHandler(this.btnDeleteHang_Click);
            // 
            // btnUpdateHang
            // 
            this.btnUpdateHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdateHang.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateHang.ForeColor = System.Drawing.Color.White;
            this.btnUpdateHang.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_edit_property_32__1_;
            this.btnUpdateHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateHang.Location = new System.Drawing.Point(21, 81);
            this.btnUpdateHang.Name = "btnUpdateHang";
            this.btnUpdateHang.Size = new System.Drawing.Size(149, 45);
            this.btnUpdateHang.TabIndex = 9;
            this.btnUpdateHang.Text = "Sửa";
            this.btnUpdateHang.UseVisualStyleBackColor = false;
            this.btnUpdateHang.Click += new System.EventHandler(this.btnUpdateHang_Click);
            // 
            // btnInsertHang
            // 
            this.btnInsertHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInsertHang.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInsertHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertHang.ForeColor = System.Drawing.Color.White;
            this.btnInsertHang.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_add_new_32__2_;
            this.btnInsertHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertHang.Location = new System.Drawing.Point(21, 30);
            this.btnInsertHang.Name = "btnInsertHang";
            this.btnInsertHang.Size = new System.Drawing.Size(149, 45);
            this.btnInsertHang.TabIndex = 8;
            this.btnInsertHang.Text = "Thêm mới";
            this.btnInsertHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertHang.UseVisualStyleBackColor = false;
            this.btnInsertHang.Click += new System.EventHandler(this.BtnInsertHang_Click);
            // 
            // picAMH
            // 
            this.picAMH.BackColor = System.Drawing.Color.DarkSlateGray;
            this.picAMH.Location = new System.Drawing.Point(925, 26);
            this.picAMH.Name = "picAMH";
            this.picAMH.Size = new System.Drawing.Size(274, 224);
            this.picAMH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAMH.TabIndex = 2;
            this.picAMH.TabStop = false;
            // 
            // txbBaoHanh
            // 
            this.txbBaoHanh.Location = new System.Drawing.Point(597, 147);
            this.txbBaoHanh.Multiline = true;
            this.txbBaoHanh.Name = "txbBaoHanh";
            this.txbBaoHanh.Size = new System.Drawing.Size(307, 103);
            this.txbBaoHanh.TabIndex = 7;
            // 
            // txbMoTa
            // 
            this.txbMoTa.Location = new System.Drawing.Point(597, 26);
            this.txbMoTa.Multiline = true;
            this.txbMoTa.Name = "txbMoTa";
            this.txbMoTa.Size = new System.Drawing.Size(307, 97);
            this.txbMoTa.TabIndex = 6;
            // 
            // txbDonVi
            // 
            this.txbDonVi.Location = new System.Drawing.Point(216, 215);
            this.txbDonVi.Name = "txbDonVi";
            this.txbDonVi.Size = new System.Drawing.Size(200, 24);
            this.txbDonVi.TabIndex = 5;
            // 
            // txbNhaSX
            // 
            this.txbNhaSX.Location = new System.Drawing.Point(216, 116);
            this.txbNhaSX.Name = "txbNhaSX";
            this.txbNhaSX.Size = new System.Drawing.Size(200, 24);
            this.txbNhaSX.TabIndex = 3;
            // 
            // txbTenHang
            // 
            this.txbTenHang.Location = new System.Drawing.Point(216, 71);
            this.txbTenHang.Name = "txbTenHang";
            this.txbTenHang.Size = new System.Drawing.Size(200, 24);
            this.txbTenHang.TabIndex = 2;
            // 
            // txbMaHang
            // 
            this.txbMaHang.Location = new System.Drawing.Point(216, 27);
            this.txbMaHang.Name = "txbMaHang";
            this.txbMaHang.Size = new System.Drawing.Size(200, 24);
            this.txbMaHang.TabIndex = 1;
            // 
            // lbDonVi
            // 
            this.lbDonVi.AutoSize = true;
            this.lbDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonVi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDonVi.Location = new System.Drawing.Point(61, 215);
            this.lbDonVi.Name = "lbDonVi";
            this.lbDonVi.Size = new System.Drawing.Size(56, 18);
            this.lbDonVi.TabIndex = 0;
            this.lbDonVi.Text = "Đơn vị";
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSoLuong.Location = new System.Drawing.Point(61, 166);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(75, 18);
            this.lbSoLuong.TabIndex = 0;
            this.lbSoLuong.Text = "Số lượng";
            // 
            // lbNhaSanXuat
            // 
            this.lbNhaSanXuat.AutoSize = true;
            this.lbNhaSanXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhaSanXuat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNhaSanXuat.Location = new System.Drawing.Point(61, 120);
            this.lbNhaSanXuat.Name = "lbNhaSanXuat";
            this.lbNhaSanXuat.Size = new System.Drawing.Size(106, 18);
            this.lbNhaSanXuat.TabIndex = 0;
            this.lbNhaSanXuat.Text = "Nhà sản xuất";
            // 
            // lbTenHang
            // 
            this.lbTenHang.AutoSize = true;
            this.lbTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTenHang.Location = new System.Drawing.Point(61, 75);
            this.lbTenHang.Name = "lbTenHang";
            this.lbTenHang.Size = new System.Drawing.Size(77, 18);
            this.lbTenHang.TabIndex = 0;
            this.lbTenHang.Text = "Tên hàng";
            // 
            // lbTTBH
            // 
            this.lbTTBH.AutoSize = true;
            this.lbTTBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTTBH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTTBH.Location = new System.Drawing.Point(474, 150);
            this.lbTTBH.Name = "lbTTBH";
            this.lbTTBH.Size = new System.Drawing.Size(94, 18);
            this.lbTTBH.TabIndex = 0;
            this.lbTTBH.Text = "Bảo hành  :";
            // 
            // lbMT
            // 
            this.lbMT.AutoSize = true;
            this.lbMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMT.Location = new System.Drawing.Point(474, 30);
            this.lbMT.Name = "lbMT";
            this.lbMT.Size = new System.Drawing.Size(66, 18);
            this.lbMT.TabIndex = 0;
            this.lbMT.Text = "Mô tả : ";
            // 
            // lbMaHang
            // 
            this.lbMaHang.AutoSize = true;
            this.lbMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMaHang.Location = new System.Drawing.Point(61, 29);
            this.lbMaHang.Name = "lbMaHang";
            this.lbMaHang.Size = new System.Drawing.Size(72, 18);
            this.lbMaHang.TabIndex = 0;
            this.lbMaHang.Text = "Mã hàng";
            // 
            // dtgvDanhSach
            // 
            this.dtgvDanhSach.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dtgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHang,
            this.colTenHang,
            this.colNSX,
            this.colMoTa,
            this.colBaoHanh,
            this.colSoLuong,
            this.colDonVi,
            this.colImage});
            this.dtgvDanhSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvDanhSach.Location = new System.Drawing.Point(0, 438);
            this.dtgvDanhSach.Name = "dtgvDanhSach";
            this.dtgvDanhSach.RowHeadersWidth = 51;
            this.dtgvDanhSach.RowTemplate.Height = 24;
            this.dtgvDanhSach.Size = new System.Drawing.Size(1370, 293);
            this.dtgvDanhSach.TabIndex = 4;
            this.dtgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSach_CellContentClick);
            this.dtgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSach_CellContentClick);
            // 
            // colMaHang
            // 
            this.colMaHang.DataPropertyName = "Mahang";
            this.colMaHang.HeaderText = "Mã hàng";
            this.colMaHang.MinimumWidth = 6;
            this.colMaHang.Name = "colMaHang";
            this.colMaHang.ReadOnly = true;
            this.colMaHang.Width = 150;
            // 
            // colTenHang
            // 
            this.colTenHang.DataPropertyName = "TenHang";
            this.colTenHang.HeaderText = "Tên hàng";
            this.colTenHang.MinimumWidth = 6;
            this.colTenHang.Name = "colTenHang";
            this.colTenHang.ReadOnly = true;
            this.colTenHang.Width = 200;
            // 
            // colNSX
            // 
            this.colNSX.DataPropertyName = "NhaSanXuat";
            this.colNSX.HeaderText = "Nhà sản xuất";
            this.colNSX.MinimumWidth = 6;
            this.colNSX.Name = "colNSX";
            this.colNSX.ReadOnly = true;
            this.colNSX.Width = 150;
            // 
            // colMoTa
            // 
            this.colMoTa.DataPropertyName = "MoTa";
            this.colMoTa.HeaderText = "Mô tả";
            this.colMoTa.MinimumWidth = 6;
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.ReadOnly = true;
            this.colMoTa.Width = 200;
            // 
            // colBaoHanh
            // 
            this.colBaoHanh.DataPropertyName = "ThongTinBaoHanh";
            this.colBaoHanh.HeaderText = "Bảo hành";
            this.colBaoHanh.MinimumWidth = 6;
            this.colBaoHanh.Name = "colBaoHanh";
            this.colBaoHanh.ReadOnly = true;
            this.colBaoHanh.Width = 200;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            this.colSoLuong.Width = 125;
            // 
            // colDonVi
            // 
            this.colDonVi.DataPropertyName = "DonViTinh";
            this.colDonVi.HeaderText = "Đơn vị";
            this.colDonVi.MinimumWidth = 6;
            this.colDonVi.Name = "colDonVi";
            this.colDonVi.ReadOnly = true;
            this.colDonVi.Width = 125;
            // 
            // colImage
            // 
            this.colImage.DataPropertyName = "AnhMinhHoa";
            this.colImage.HeaderText = "Thư mục lưu ảnh mô tả";
            this.colImage.MinimumWidth = 6;
            this.colImage.Name = "colImage";
            this.colImage.ReadOnly = true;
            this.colImage.Width = 200;
            // 
            // panelHeading
            // 
            this.panelHeading.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelHeading.Controls.Add(this.lbHeađing);
            this.panelHeading.Controls.Add(this.picIcoSearch);
            this.panelHeading.Controls.Add(this.btnSearchID);
            this.panelHeading.Controls.Add(this.txbSearchID);
            this.panelHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeading.Location = new System.Drawing.Point(0, 369);
            this.panelHeading.Name = "panelHeading";
            this.panelHeading.Size = new System.Drawing.Size(1370, 69);
            this.panelHeading.TabIndex = 5;
            // 
            // lbHeađing
            // 
            this.lbHeađing.AutoSize = true;
            this.lbHeađing.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeađing.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbHeađing.Location = new System.Drawing.Point(591, 3);
            this.lbHeađing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHeađing.Name = "lbHeađing";
            this.lbHeađing.Size = new System.Drawing.Size(145, 26);
            this.lbHeađing.TabIndex = 0;
            this.lbHeađing.Text = "Bảng chi tiết";
            this.lbHeađing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picIcoSearch
            // 
            this.picIcoSearch.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_search_26;
            this.picIcoSearch.Location = new System.Drawing.Point(440, 9);
            this.picIcoSearch.Margin = new System.Windows.Forms.Padding(0);
            this.picIcoSearch.Name = "picIcoSearch";
            this.picIcoSearch.Size = new System.Drawing.Size(28, 26);
            this.picIcoSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcoSearch.TabIndex = 6;
            this.picIcoSearch.TabStop = false;
            // 
            // btnSearchID
            // 
            this.btnSearchID.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchID.ForeColor = System.Drawing.Color.White;
            this.btnSearchID.Location = new System.Drawing.Point(19, 9);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(133, 30);
            this.btnSearchID.TabIndex = 5;
            this.btnSearchID.Text = "Tìm mã hàng";
            this.btnSearchID.UseVisualStyleBackColor = false;
            this.btnSearchID.Click += new System.EventHandler(this.btnSearchID_Click);
            // 
            // txbSearchID
            // 
            this.txbSearchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchID.Location = new System.Drawing.Point(158, 9);
            this.txbSearchID.Name = "txbSearchID";
            this.txbSearchID.Size = new System.Drawing.Size(310, 26);
            this.txbSearchID.TabIndex = 4;
            // 
            // frmDSChiTietHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 731);
            this.Controls.Add(this.panelHeading);
            this.Controls.Add(this.dtgvDanhSach);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1423, 778);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "frmDSChiTietHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDSChiTietHangHoa";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.panelControlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSach)).EndInit();
            this.panelHeading.ResumeLayout(false);
            this.panelHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcoSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.DataGridView dtgvDanhSach;
        private System.Windows.Forms.Panel panelControlButton;
        private System.Windows.Forms.PictureBox picAMH;
        private System.Windows.Forms.TextBox txbBaoHanh;
        private System.Windows.Forms.TextBox txbMoTa;
        private System.Windows.Forms.TextBox txbDonVi;
        private System.Windows.Forms.TextBox txbNhaSX;
        private System.Windows.Forms.TextBox txbTenHang;
        private System.Windows.Forms.TextBox txbMaHang;
        private System.Windows.Forms.Label lbDonVi;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbNhaSanXuat;
        private System.Windows.Forms.Label lbTenHang;
        private System.Windows.Forms.Label lbMaHang;
        private System.Windows.Forms.Panel panelHeading;
        private System.Windows.Forms.Label lbHeađing;
        private System.Windows.Forms.Button btnInsertHang;
        private System.Windows.Forms.Button btnUpdateHang;
        private System.Windows.Forms.Button btnDeleteHang;
        private System.Windows.Forms.Button btnSaveHang;
        private System.Windows.Forms.Button btnCancelHang;
        private System.Windows.Forms.PictureBox picIcoSearch;
        private System.Windows.Forms.Button btnSearchID;
        private System.Windows.Forms.TextBox txbSearchID;
        private System.Windows.Forms.Label lbTTBH;
        private System.Windows.Forms.Label lbMT;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBaoHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImage;
    }
}