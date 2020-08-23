namespace QLCuaHangBanXeMayDien
{
    partial class frmQuanLyTaiKhoan
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
            this.components = new System.ComponentModel.Container();
            this.panelHeading = new System.Windows.Forms.Panel();
            this.lbHeading = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.dtgvListAccount = new System.Windows.Forms.DataGridView();
            this.grbInfoAccount = new System.Windows.Forms.GroupBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txbDisplayname = new System.Windows.Forms.TextBox();
            this.lbDisplayName = new System.Windows.Forms.Label();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbAccountType = new System.Windows.Forms.Label();
            this.panelHeading2 = new System.Windows.Forms.Panel();
            this.btnInsertAcc = new System.Windows.Forms.Button();
            this.btnUpdateAcc = new System.Windows.Forms.Button();
            this.btnDeleteAcc = new System.Windows.Forms.Button();
            this.btnSaveAcc = new System.Windows.Forms.Button();
            this.btnCancelAcc = new System.Windows.Forms.Button();
            this.cbxAccountType = new System.Windows.Forms.ComboBox();
            this.lbHeading2 = new System.Windows.Forms.Label();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccountType = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbErrorUserName = new System.Windows.Forms.Label();
            this.lbErrorPass = new System.Windows.Forms.Label();
            this.lbErrorPhoneNumber = new System.Windows.Forms.Label();
            this.lbErrorEmail = new System.Windows.Forms.Label();
            this.toolTipUser = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPass = new System.Windows.Forms.ToolTip(this.components);
            this.panelHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListAccount)).BeginInit();
            this.grbInfoAccount.SuspendLayout();
            this.panelHeading2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeading
            // 
            this.panelHeading.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelHeading.Controls.Add(this.lbHeading);
            this.panelHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeading.Location = new System.Drawing.Point(0, 0);
            this.panelHeading.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHeading.Name = "panelHeading";
            this.panelHeading.Size = new System.Drawing.Size(1018, 70);
            this.panelHeading.TabIndex = 0;
            // 
            // lbHeading
            // 
            this.lbHeading.AutoSize = true;
            this.lbHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeading.ForeColor = System.Drawing.Color.White;
            this.lbHeading.Location = new System.Drawing.Point(399, 18);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(236, 32);
            this.lbHeading.TabIndex = 0;
            this.lbHeading.Text = "Quản lý tài khoản";
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(151, 39);
            this.txbUsername.MaxLength = 30;
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(232, 30);
            this.txbUsername.TabIndex = 1;
            this.toolTipUser.SetToolTip(this.txbUsername, "Tên tài khoản ít nhất 6 ký tự. Gồm các ký tụ a-z 0-9 và viết liền không dấu.");
            // 
            // dtgvListAccount
            // 
            this.dtgvListAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUsername,
            this.colPassword,
            this.colAccountType,
            this.colDisplayName,
            this.colPhoneNumber,
            this.colEmail});
            this.dtgvListAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvListAccount.Location = new System.Drawing.Point(0, 434);
            this.dtgvListAccount.Name = "dtgvListAccount";
            this.dtgvListAccount.RowHeadersWidth = 51;
            this.dtgvListAccount.RowTemplate.Height = 24;
            this.dtgvListAccount.Size = new System.Drawing.Size(1018, 259);
            this.dtgvListAccount.TabIndex = 2;
            this.dtgvListAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListAccount_CellClick);
            // 
            // grbInfoAccount
            // 
            this.grbInfoAccount.Controls.Add(this.lbErrorPass);
            this.grbInfoAccount.Controls.Add(this.lbErrorEmail);
            this.grbInfoAccount.Controls.Add(this.lbErrorPhoneNumber);
            this.grbInfoAccount.Controls.Add(this.lbErrorUserName);
            this.grbInfoAccount.Controls.Add(this.cbxAccountType);
            this.grbInfoAccount.Controls.Add(this.btnCancelAcc);
            this.grbInfoAccount.Controls.Add(this.btnSaveAcc);
            this.grbInfoAccount.Controls.Add(this.btnDeleteAcc);
            this.grbInfoAccount.Controls.Add(this.btnUpdateAcc);
            this.grbInfoAccount.Controls.Add(this.btnInsertAcc);
            this.grbInfoAccount.Controls.Add(this.lbDisplayName);
            this.grbInfoAccount.Controls.Add(this.txbDisplayname);
            this.grbInfoAccount.Controls.Add(this.lbPassword);
            this.grbInfoAccount.Controls.Add(this.txbPassword);
            this.grbInfoAccount.Controls.Add(this.lbAccountType);
            this.grbInfoAccount.Controls.Add(this.lbEmail);
            this.grbInfoAccount.Controls.Add(this.txbEmail);
            this.grbInfoAccount.Controls.Add(this.lbPhoneNumber);
            this.grbInfoAccount.Controls.Add(this.txbPhoneNumber);
            this.grbInfoAccount.Controls.Add(this.lbUserName);
            this.grbInfoAccount.Controls.Add(this.txbUsername);
            this.grbInfoAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbInfoAccount.Location = new System.Drawing.Point(0, 70);
            this.grbInfoAccount.Name = "grbInfoAccount";
            this.grbInfoAccount.Size = new System.Drawing.Size(1018, 288);
            this.grbInfoAccount.TabIndex = 4;
            this.grbInfoAccount.TabStop = false;
            this.grbInfoAccount.Text = "Thông tin chi tiết";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(46, 42);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(99, 25);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Tài khoản";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(151, 111);
            this.txbPassword.MaxLength = 20;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(232, 30);
            this.txbPassword.TabIndex = 2;
            this.toolTipPass.SetToolTip(this.txbPassword, "Mật khẩu ít nhất phải 8 ký tự. Gồm ít nhất một số, một chữ in hoa và một ký đặc b" +
        "iệt. ");
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(52, 116);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(93, 25);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Mật khẩu";
            // 
            // txbDisplayname
            // 
            this.txbDisplayname.Location = new System.Drawing.Point(151, 181);
            this.txbDisplayname.MaxLength = 30;
            this.txbDisplayname.Name = "txbDisplayname";
            this.txbDisplayname.Size = new System.Drawing.Size(232, 30);
            this.txbDisplayname.TabIndex = 3;
            // 
            // lbDisplayName
            // 
            this.lbDisplayName.AutoSize = true;
            this.lbDisplayName.Location = new System.Drawing.Point(31, 184);
            this.lbDisplayName.Name = "lbDisplayName";
            this.lbDisplayName.Size = new System.Drawing.Size(114, 25);
            this.lbDisplayName.TabIndex = 0;
            this.lbDisplayName.Text = "Tên hiển thị";
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Location = new System.Drawing.Point(556, 39);
            this.txbPhoneNumber.MaxLength = 10;
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(232, 30);
            this.txbPhoneNumber.TabIndex = 1;
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(451, 40);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(99, 25);
            this.lbPhoneNumber.TabIndex = 0;
            this.lbPhoneNumber.Text = "Điện thoại";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(556, 111);
            this.txbEmail.MaxLength = 200;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(232, 30);
            this.txbEmail.TabIndex = 5;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(455, 114);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(60, 25);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email";
            // 
            // lbAccountType
            // 
            this.lbAccountType.AutoSize = true;
            this.lbAccountType.Location = new System.Drawing.Point(451, 184);
            this.lbAccountType.Name = "lbAccountType";
            this.lbAccountType.Size = new System.Drawing.Size(109, 25);
            this.lbAccountType.TabIndex = 0;
            this.lbAccountType.Text = "Quyền hạn";
            // 
            // panelHeading2
            // 
            this.panelHeading2.Controls.Add(this.lbHeading2);
            this.panelHeading2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeading2.Location = new System.Drawing.Point(0, 358);
            this.panelHeading2.Name = "panelHeading2";
            this.panelHeading2.Size = new System.Drawing.Size(1018, 76);
            this.panelHeading2.TabIndex = 4;
            // 
            // btnInsertAcc
            // 
            this.btnInsertAcc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInsertAcc.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnInsertAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertAcc.ForeColor = System.Drawing.Color.White;
            this.btnInsertAcc.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_add_new_32__2_;
            this.btnInsertAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertAcc.Location = new System.Drawing.Point(859, 21);
            this.btnInsertAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertAcc.Name = "btnInsertAcc";
            this.btnInsertAcc.Size = new System.Drawing.Size(131, 46);
            this.btnInsertAcc.TabIndex = 7;
            this.btnInsertAcc.Text = "Thêm mới";
            this.btnInsertAcc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertAcc.UseVisualStyleBackColor = false;
            this.btnInsertAcc.Click += new System.EventHandler(this.btnInsertAcc_Click);
            // 
            // btnUpdateAcc
            // 
            this.btnUpdateAcc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdateAcc.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAcc.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAcc.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_edit_property_32__1_;
            this.btnUpdateAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAcc.Location = new System.Drawing.Point(859, 71);
            this.btnUpdateAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateAcc.Name = "btnUpdateAcc";
            this.btnUpdateAcc.Size = new System.Drawing.Size(131, 46);
            this.btnUpdateAcc.TabIndex = 8;
            this.btnUpdateAcc.Text = "Sửa";
            this.btnUpdateAcc.UseVisualStyleBackColor = false;
            this.btnUpdateAcc.Click += new System.EventHandler(this.btnUpdateAcc_Click);
            // 
            // btnDeleteAcc
            // 
            this.btnDeleteAcc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteAcc.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAcc.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAcc.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_delete_view_32;
            this.btnDeleteAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAcc.Location = new System.Drawing.Point(859, 121);
            this.btnDeleteAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteAcc.Name = "btnDeleteAcc";
            this.btnDeleteAcc.Size = new System.Drawing.Size(131, 46);
            this.btnDeleteAcc.TabIndex = 9;
            this.btnDeleteAcc.Text = "Xóa";
            this.btnDeleteAcc.UseVisualStyleBackColor = false;
            this.btnDeleteAcc.Click += new System.EventHandler(this.btnDeleteAcc_Click);
            // 
            // btnSaveAcc
            // 
            this.btnSaveAcc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveAcc.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSaveAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAcc.ForeColor = System.Drawing.Color.White;
            this.btnSaveAcc.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_update_32;
            this.btnSaveAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveAcc.Location = new System.Drawing.Point(859, 175);
            this.btnSaveAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveAcc.Name = "btnSaveAcc";
            this.btnSaveAcc.Size = new System.Drawing.Size(131, 46);
            this.btnSaveAcc.TabIndex = 10;
            this.btnSaveAcc.Text = "Lưu";
            this.btnSaveAcc.UseVisualStyleBackColor = false;
            this.btnSaveAcc.Click += new System.EventHandler(this.btnSaveAcc_Click);
            // 
            // btnCancelAcc
            // 
            this.btnCancelAcc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelAcc.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAcc.ForeColor = System.Drawing.Color.White;
            this.btnCancelAcc.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_delete_32__1_;
            this.btnCancelAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelAcc.Location = new System.Drawing.Point(859, 226);
            this.btnCancelAcc.Name = "btnCancelAcc";
            this.btnCancelAcc.Size = new System.Drawing.Size(130, 45);
            this.btnCancelAcc.TabIndex = 11;
            this.btnCancelAcc.Text = "Hủy";
            this.btnCancelAcc.UseVisualStyleBackColor = false;
            // 
            // cbxAccountType
            // 
            this.cbxAccountType.FormattingEnabled = true;
            this.cbxAccountType.Items.AddRange(new object[] {
            "Thường",
            "Admin"});
            this.cbxAccountType.Location = new System.Drawing.Point(590, 178);
            this.cbxAccountType.Name = "cbxAccountType";
            this.cbxAccountType.Size = new System.Drawing.Size(198, 33);
            this.cbxAccountType.TabIndex = 6;
            this.cbxAccountType.Text = "Loại tài khoản";
            // 
            // lbHeading2
            // 
            this.lbHeading2.AutoSize = true;
            this.lbHeading2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeading2.Location = new System.Drawing.Point(12, 26);
            this.lbHeading2.Name = "lbHeading2";
            this.lbHeading2.Size = new System.Drawing.Size(264, 29);
            this.lbHeading2.TabIndex = 0;
            this.lbHeading2.Text = "Bảng chi tiết tài khoản : ";
            // 
            // colUsername
            // 
            this.colUsername.DataPropertyName = "UserName";
            this.colUsername.HeaderText = "Tài khoản";
            this.colUsername.MinimumWidth = 6;
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            this.colUsername.Width = 170;
            // 
            // colPassword
            // 
            this.colPassword.DataPropertyName = "PassWord";
            this.colPassword.HeaderText = "Mật khẩu";
            this.colPassword.MinimumWidth = 6;
            this.colPassword.Name = "colPassword";
            this.colPassword.ReadOnly = true;
            this.colPassword.Width = 170;
            // 
            // colAccountType
            // 
            this.colAccountType.DataPropertyName = "LoaiTaiKhoan";
            this.colAccountType.HeaderText = "Admin";
            this.colAccountType.MinimumWidth = 6;
            this.colAccountType.Name = "colAccountType";
            this.colAccountType.ReadOnly = true;
            this.colAccountType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAccountType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAccountType.Width = 90;
            // 
            // colDisplayName
            // 
            this.colDisplayName.DataPropertyName = "TenHienThi";
            this.colDisplayName.HeaderText = "Tên hiển thị";
            this.colDisplayName.MinimumWidth = 6;
            this.colDisplayName.Name = "colDisplayName";
            this.colDisplayName.ReadOnly = true;
            this.colDisplayName.Width = 170;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.DataPropertyName = "DienThoai";
            this.colPhoneNumber.HeaderText = "Điện thoại đăng ký";
            this.colPhoneNumber.MinimumWidth = 6;
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.ReadOnly = true;
            this.colPhoneNumber.Width = 165;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email đăng ký";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 200;
            // 
            // lbErrorUserName
            // 
            this.lbErrorUserName.AutoSize = true;
            this.lbErrorUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorUserName.ForeColor = System.Drawing.Color.Red;
            this.lbErrorUserName.Location = new System.Drawing.Point(151, 71);
            this.lbErrorUserName.Name = "lbErrorUserName";
            this.lbErrorUserName.Size = new System.Drawing.Size(28, 18);
            this.lbErrorUserName.TabIndex = 12;
            this.lbErrorUserName.Text = "     ";
            // 
            // lbErrorPass
            // 
            this.lbErrorPass.AutoSize = true;
            this.lbErrorPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorPass.ForeColor = System.Drawing.Color.Red;
            this.lbErrorPass.Location = new System.Drawing.Point(151, 144);
            this.lbErrorPass.Name = "lbErrorPass";
            this.lbErrorPass.Size = new System.Drawing.Size(28, 18);
            this.lbErrorPass.TabIndex = 12;
            this.lbErrorPass.Text = "     ";
            // 
            // lbErrorPhoneNumber
            // 
            this.lbErrorPhoneNumber.AutoSize = true;
            this.lbErrorPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorPhoneNumber.ForeColor = System.Drawing.Color.Red;
            this.lbErrorPhoneNumber.Location = new System.Drawing.Point(553, 71);
            this.lbErrorPhoneNumber.Name = "lbErrorPhoneNumber";
            this.lbErrorPhoneNumber.Size = new System.Drawing.Size(28, 18);
            this.lbErrorPhoneNumber.TabIndex = 12;
            this.lbErrorPhoneNumber.Text = "     ";
            // 
            // lbErrorEmail
            // 
            this.lbErrorEmail.AutoSize = true;
            this.lbErrorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lbErrorEmail.Location = new System.Drawing.Point(553, 144);
            this.lbErrorEmail.Name = "lbErrorEmail";
            this.lbErrorEmail.Size = new System.Drawing.Size(28, 18);
            this.lbErrorEmail.TabIndex = 12;
            this.lbErrorEmail.Text = "     ";
            // 
            // toolTipUser
            // 
            this.toolTipUser.ToolTipTitle = "Tài khoản hợp lệ :";
            // 
            // toolTipPass
            // 
            this.toolTipPass.ToolTipTitle = "Mật khẩu hợp lệ :";
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1018, 693);
            this.Controls.Add(this.panelHeading2);
            this.Controls.Add(this.grbInfoAccount);
            this.Controls.Add(this.dtgvListAccount);
            this.Controls.Add(this.panelHeading);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQuanLyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLyTaiKhoan";
            this.panelHeading.ResumeLayout(false);
            this.panelHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListAccount)).EndInit();
            this.grbInfoAccount.ResumeLayout(false);
            this.grbInfoAccount.PerformLayout();
            this.panelHeading2.ResumeLayout(false);
            this.panelHeading2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeading;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.DataGridView dtgvListAccount;
        private System.Windows.Forms.GroupBox grbInfoAccount;
        private System.Windows.Forms.Label lbDisplayName;
        private System.Windows.Forms.TextBox txbDisplayname;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label lbAccountType;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.TextBox txbPhoneNumber;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Panel panelHeading2;
        private System.Windows.Forms.Button btnInsertAcc;
        private System.Windows.Forms.Button btnUpdateAcc;
        private System.Windows.Forms.Button btnDeleteAcc;
        private System.Windows.Forms.Button btnSaveAcc;
        private System.Windows.Forms.ComboBox cbxAccountType;
        private System.Windows.Forms.Button btnCancelAcc;
        private System.Windows.Forms.Label lbHeading2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAccountType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.Label lbErrorPass;
        private System.Windows.Forms.Label lbErrorEmail;
        private System.Windows.Forms.Label lbErrorPhoneNumber;
        private System.Windows.Forms.Label lbErrorUserName;
        private System.Windows.Forms.ToolTip toolTipUser;
        private System.Windows.Forms.ToolTip toolTipPass;
    }
}