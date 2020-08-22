namespace QLCuaHangBanXeMayDien
{
    partial class frmHangHoa
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
            this.panelBottomLine = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.panelControlHangHoa = new System.Windows.Forms.Panel();
            this.flpListHangHoa = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTittleHangHoa = new System.Windows.Forms.Label();
            this.panelTittleHangHoa = new System.Windows.Forms.Panel();
            this.btnViewListHH = new System.Windows.Forms.Button();
            this.btnAddHangHoa = new System.Windows.Forms.Button();
            this.picIconSearch = new System.Windows.Forms.PictureBox();
            this.panelBottomLine.SuspendLayout();
            this.panelControlHangHoa.SuspendLayout();
            this.panelTittleHangHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBottomLine
            // 
            this.panelBottomLine.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelBottomLine.Controls.Add(this.picIconSearch);
            this.panelBottomLine.Controls.Add(this.btnSearch);
            this.panelBottomLine.Controls.Add(this.txbSearch);
            this.panelBottomLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomLine.Location = new System.Drawing.Point(0, 614);
            this.panelBottomLine.Name = "panelBottomLine";
            this.panelBottomLine.Size = new System.Drawing.Size(1062, 59);
            this.panelBottomLine.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(517, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm tên hàng";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(656, 15);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(310, 30);
            this.txbSearch.TabIndex = 1;
            // 
            // panelControlHangHoa
            // 
            this.panelControlHangHoa.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelControlHangHoa.Controls.Add(this.btnViewListHH);
            this.panelControlHangHoa.Controls.Add(this.btnAddHangHoa);
            this.panelControlHangHoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControlHangHoa.Location = new System.Drawing.Point(0, 70);
            this.panelControlHangHoa.Name = "panelControlHangHoa";
            this.panelControlHangHoa.Size = new System.Drawing.Size(228, 544);
            this.panelControlHangHoa.TabIndex = 2;
            // 
            // flpListHangHoa
            // 
            this.flpListHangHoa.AutoScroll = true;
            this.flpListHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpListHangHoa.Location = new System.Drawing.Point(228, 70);
            this.flpListHangHoa.Name = "flpListHangHoa";
            this.flpListHangHoa.Size = new System.Drawing.Size(834, 544);
            this.flpListHangHoa.TabIndex = 3;
            // 
            // lbTittleHangHoa
            // 
            this.lbTittleHangHoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTittleHangHoa.AutoSize = true;
            this.lbTittleHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittleHangHoa.Location = new System.Drawing.Point(446, 18);
            this.lbTittleHangHoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTittleHangHoa.Name = "lbTittleHangHoa";
            this.lbTittleHangHoa.Size = new System.Drawing.Size(183, 32);
            this.lbTittleHangHoa.TabIndex = 0;
            this.lbTittleHangHoa.Text = "Xe máy điện";
            // 
            // panelTittleHangHoa
            // 
            this.panelTittleHangHoa.BackColor = System.Drawing.Color.Teal;
            this.panelTittleHangHoa.Controls.Add(this.lbTittleHangHoa);
            this.panelTittleHangHoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittleHangHoa.ForeColor = System.Drawing.Color.White;
            this.panelTittleHangHoa.Location = new System.Drawing.Point(0, 0);
            this.panelTittleHangHoa.Margin = new System.Windows.Forms.Padding(4);
            this.panelTittleHangHoa.Name = "panelTittleHangHoa";
            this.panelTittleHangHoa.Size = new System.Drawing.Size(1062, 70);
            this.panelTittleHangHoa.TabIndex = 0;
            // 
            // btnViewListHH
            // 
            this.btnViewListHH.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnViewListHH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewListHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewListHH.ForeColor = System.Drawing.Color.White;
            this.btnViewListHH.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_edit_property_32__1_;
            this.btnViewListHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewListHH.Location = new System.Drawing.Point(0, 63);
            this.btnViewListHH.Name = "btnViewListHH";
            this.btnViewListHH.Size = new System.Drawing.Size(228, 63);
            this.btnViewListHH.TabIndex = 3;
            this.btnViewListHH.Text = "DS chi tiết";
            this.btnViewListHH.UseVisualStyleBackColor = false;
            this.btnViewListHH.Click += new System.EventHandler(this.btnViewListHH_Click);
            // 
            // btnAddHangHoa
            // 
            this.btnAddHangHoa.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAddHangHoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHangHoa.ForeColor = System.Drawing.Color.White;
            this.btnAddHangHoa.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_add_new_32__2_;
            this.btnAddHangHoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddHangHoa.Location = new System.Drawing.Point(0, 0);
            this.btnAddHangHoa.Name = "btnAddHangHoa";
            this.btnAddHangHoa.Size = new System.Drawing.Size(228, 63);
            this.btnAddHangHoa.TabIndex = 0;
            this.btnAddHangHoa.Text = "Thêm mới";
            this.btnAddHangHoa.UseVisualStyleBackColor = false;
            this.btnAddHangHoa.Click += new System.EventHandler(this.btnAddHangHoa_Click);
            // 
            // picIconSearch
            // 
            this.picIconSearch.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_search_32;
            this.picIconSearch.Location = new System.Drawing.Point(969, 16);
            this.picIconSearch.Margin = new System.Windows.Forms.Padding(0);
            this.picIconSearch.Name = "picIconSearch";
            this.picIconSearch.Size = new System.Drawing.Size(33, 29);
            this.picIconSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIconSearch.TabIndex = 3;
            this.picIconSearch.TabStop = false;
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.flpListHangHoa);
            this.Controls.Add(this.panelControlHangHoa);
            this.Controls.Add(this.panelBottomLine);
            this.Controls.Add(this.panelTittleHangHoa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "frmHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hàng hóa";
            this.panelBottomLine.ResumeLayout(false);
            this.panelBottomLine.PerformLayout();
            this.panelControlHangHoa.ResumeLayout(false);
            this.panelTittleHangHoa.ResumeLayout(false);
            this.panelTittleHangHoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBottomLine;
        private System.Windows.Forms.Panel panelControlHangHoa;
        private System.Windows.Forms.Button btnAddHangHoa;
        private System.Windows.Forms.FlowLayoutPanel flpListHangHoa;
        private System.Windows.Forms.Button btnViewListHH;
        private System.Windows.Forms.Label lbTittleHangHoa;
        private System.Windows.Forms.Panel panelTittleHangHoa;
        private System.Windows.Forms.PictureBox picIconSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbSearch;
    }
}