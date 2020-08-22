namespace QLCuaHangBanXeMayDien
{
    partial class frmInforMatHang
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
            this.lbTenHang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNhaSX = new System.Windows.Forms.Label();
            this.lbMoTa = new System.Windows.Forms.Label();
            this.lbTTBH = new System.Windows.Forms.Label();
            this.lbSL = new System.Windows.Forms.Label();
            this.lbDonVi = new System.Windows.Forms.Label();
            this.btnDeleleHangHoa = new System.Windows.Forms.Button();
            this.btnUpdateHangHoa = new System.Windows.Forms.Button();
            this.txbMota = new System.Windows.Forms.TextBox();
            this.txbThongTinBaoHanh = new System.Windows.Forms.TextBox();
            this.lbGiaBan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTenHang
            // 
            this.lbTenHang.AutoSize = true;
            this.lbTenHang.Location = new System.Drawing.Point(35, 22);
            this.lbTenHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenHang.Name = "lbTenHang";
            this.lbTenHang.Size = new System.Drawing.Size(107, 24);
            this.lbTenHang.TabIndex = 0;
            this.lbTenHang.Text = "Tên hàng : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 0;
            // 
            // lbNhaSX
            // 
            this.lbNhaSX.AutoSize = true;
            this.lbNhaSX.Location = new System.Drawing.Point(35, 66);
            this.lbNhaSX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNhaSX.Name = "lbNhaSX";
            this.lbNhaSX.Size = new System.Drawing.Size(135, 24);
            this.lbNhaSX.TabIndex = 0;
            this.lbNhaSX.Text = "Nhà sản xuất : ";
            // 
            // lbMoTa
            // 
            this.lbMoTa.AutoSize = true;
            this.lbMoTa.Location = new System.Drawing.Point(35, 238);
            this.lbMoTa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMoTa.Name = "lbMoTa";
            this.lbMoTa.Size = new System.Drawing.Size(71, 24);
            this.lbMoTa.TabIndex = 0;
            this.lbMoTa.Text = "Mô tả : ";
            // 
            // lbTTBH
            // 
            this.lbTTBH.AutoSize = true;
            this.lbTTBH.Location = new System.Drawing.Point(35, 388);
            this.lbTTBH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTTBH.Name = "lbTTBH";
            this.lbTTBH.Size = new System.Drawing.Size(195, 24);
            this.lbTTBH.TabIndex = 0;
            this.lbTTBH.Text = "Thông tin bảo hành  : ";
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Location = new System.Drawing.Point(35, 121);
            this.lbSL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(101, 24);
            this.lbSL.TabIndex = 0;
            this.lbSL.Text = "Số lượng : ";
            // 
            // lbDonVi
            // 
            this.lbDonVi.AutoSize = true;
            this.lbDonVi.Location = new System.Drawing.Point(215, 121);
            this.lbDonVi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDonVi.Name = "lbDonVi";
            this.lbDonVi.Size = new System.Drawing.Size(59, 24);
            this.lbDonVi.TabIndex = 0;
            this.lbDonVi.Text = "Chiếc";
            // 
            // btnDeleleHangHoa
            // 
            this.btnDeleleHangHoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeleleHangHoa.Location = new System.Drawing.Point(0, 583);
            this.btnDeleleHangHoa.Name = "btnDeleleHangHoa";
            this.btnDeleleHangHoa.Size = new System.Drawing.Size(403, 40);
            this.btnDeleleHangHoa.TabIndex = 2;
            this.btnDeleleHangHoa.Text = "Xóa";
            this.btnDeleleHangHoa.UseVisualStyleBackColor = true;
            this.btnDeleleHangHoa.Click += new System.EventHandler(this.btnDeleleHangHoa_Click);
            // 
            // btnUpdateHangHoa
            // 
            this.btnUpdateHangHoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpdateHangHoa.Location = new System.Drawing.Point(0, 543);
            this.btnUpdateHangHoa.Name = "btnUpdateHangHoa";
            this.btnUpdateHangHoa.Size = new System.Drawing.Size(403, 40);
            this.btnUpdateHangHoa.TabIndex = 1;
            this.btnUpdateHangHoa.Text = "Sửa thông tin";
            this.btnUpdateHangHoa.UseVisualStyleBackColor = true;
            this.btnUpdateHangHoa.Click += new System.EventHandler(this.btnUpdateHangHoa_Click);
            // 
            // txbMota
            // 
            this.txbMota.Enabled = false;
            this.txbMota.Location = new System.Drawing.Point(115, 279);
            this.txbMota.Multiline = true;
            this.txbMota.Name = "txbMota";
            this.txbMota.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txbMota.Size = new System.Drawing.Size(279, 83);
            this.txbMota.TabIndex = 3;
            // 
            // txbThongTinBaoHanh
            // 
            this.txbThongTinBaoHanh.Enabled = false;
            this.txbThongTinBaoHanh.Location = new System.Drawing.Point(115, 436);
            this.txbThongTinBaoHanh.Multiline = true;
            this.txbThongTinBaoHanh.Name = "txbThongTinBaoHanh";
            this.txbThongTinBaoHanh.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txbThongTinBaoHanh.Size = new System.Drawing.Size(279, 87);
            this.txbThongTinBaoHanh.TabIndex = 3;
            // 
            // lbGiaBan
            // 
            this.lbGiaBan.AutoSize = true;
            this.lbGiaBan.Location = new System.Drawing.Point(35, 178);
            this.lbGiaBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGiaBan.Name = "lbGiaBan";
            this.lbGiaBan.Size = new System.Drawing.Size(95, 24);
            this.lbGiaBan.TabIndex = 0;
            this.lbGiaBan.Text = "Giá bán  : ";
            // 
            // frmInforMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 623);
            this.Controls.Add(this.txbThongTinBaoHanh);
            this.Controls.Add(this.txbMota);
            this.Controls.Add(this.btnUpdateHangHoa);
            this.Controls.Add(this.btnDeleleHangHoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDonVi);
            this.Controls.Add(this.lbGiaBan);
            this.Controls.Add(this.lbSL);
            this.Controls.Add(this.lbTTBH);
            this.Controls.Add(this.lbMoTa);
            this.Controls.Add(this.lbNhaSX);
            this.Controls.Add(this.lbTenHang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(421, 694);
            this.MinimumSize = new System.Drawing.Size(421, 670);
            this.Name = "frmInforMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin xe";
            this.Load += new System.EventHandler(this.frmInforMatHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNhaSX;
        private System.Windows.Forms.Label lbMoTa;
        private System.Windows.Forms.Label lbTTBH;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.Label lbDonVi;
        private System.Windows.Forms.Button btnDeleleHangHoa;
        private System.Windows.Forms.Button btnUpdateHangHoa;
        private System.Windows.Forms.TextBox txbMota;
        private System.Windows.Forms.TextBox txbThongTinBaoHanh;
        private System.Windows.Forms.Label lbGiaBan;
    }
}