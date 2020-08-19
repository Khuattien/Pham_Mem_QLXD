namespace QLCuaHangBanXeMayDien
{
    partial class frmDoanhThu
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
            this.panelTittleDT = new System.Windows.Forms.Panel();
            this.lbTittleXuatHang = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewBenefit = new System.Windows.Forms.Button();
            this.lbEndTime = new System.Windows.Forms.Label();
            this.lbStartTime = new System.Windows.Forms.Label();
            this.dtpkEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpkStart = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelTittleDT.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTittleDT
            // 
            this.panelTittleDT.BackColor = System.Drawing.Color.DarkBlue;
            this.panelTittleDT.Controls.Add(this.lbTittleXuatHang);
            this.panelTittleDT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittleDT.Location = new System.Drawing.Point(0, 0);
            this.panelTittleDT.Margin = new System.Windows.Forms.Padding(4);
            this.panelTittleDT.Name = "panelTittleDT";
            this.panelTittleDT.Size = new System.Drawing.Size(1062, 52);
            this.panelTittleDT.TabIndex = 0;
            // 
            // lbTittleXuatHang
            // 
            this.lbTittleXuatHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTittleXuatHang.AutoSize = true;
            this.lbTittleXuatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittleXuatHang.ForeColor = System.Drawing.Color.White;
            this.lbTittleXuatHang.Location = new System.Drawing.Point(424, 9);
            this.lbTittleXuatHang.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTittleXuatHang.Name = "lbTittleXuatHang";
            this.lbTittleXuatHang.Size = new System.Drawing.Size(164, 32);
            this.lbTittleXuatHang.TabIndex = 2;
            this.lbTittleXuatHang.Text = "Doanh Thu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.btnViewBenefit);
            this.panel2.Controls.Add(this.lbEndTime);
            this.panel2.Controls.Add(this.lbStartTime);
            this.panel2.Controls.Add(this.dtpkEnd);
            this.panel2.Controls.Add(this.dtpkStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 68);
            this.panel2.TabIndex = 1;
            // 
            // btnViewBenefit
            // 
            this.btnViewBenefit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnViewBenefit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBenefit.ForeColor = System.Drawing.Color.White;
            this.btnViewBenefit.Image = global::QLCuaHangBanXeMayDien.Properties.Resources.icons8_view_32__2_;
            this.btnViewBenefit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewBenefit.Location = new System.Drawing.Point(756, 11);
            this.btnViewBenefit.Name = "btnViewBenefit";
            this.btnViewBenefit.Size = new System.Drawing.Size(130, 45);
            this.btnViewBenefit.TabIndex = 3;
            this.btnViewBenefit.Text = "Xem";
            this.btnViewBenefit.UseVisualStyleBackColor = false;
            // 
            // lbEndTime
            // 
            this.lbEndTime.AutoSize = true;
            this.lbEndTime.Location = new System.Drawing.Point(345, 21);
            this.lbEndTime.Name = "lbEndTime";
            this.lbEndTime.Size = new System.Drawing.Size(91, 24);
            this.lbEndTime.TabIndex = 2;
            this.lbEndTime.Text = "Đến ngày";
            // 
            // lbStartTime
            // 
            this.lbStartTime.AutoSize = true;
            this.lbStartTime.Location = new System.Drawing.Point(12, 21);
            this.lbStartTime.Name = "lbStartTime";
            this.lbStartTime.Size = new System.Drawing.Size(79, 24);
            this.lbStartTime.TabIndex = 2;
            this.lbStartTime.Text = "Từ ngày";
            // 
            // dtpkEnd
            // 
            this.dtpkEnd.Location = new System.Drawing.Point(442, 21);
            this.dtpkEnd.Name = "dtpkEnd";
            this.dtpkEnd.Size = new System.Drawing.Size(200, 28);
            this.dtpkEnd.TabIndex = 0;
            // 
            // dtpkStart
            // 
            this.dtpkStart.Location = new System.Drawing.Point(98, 21);
            this.dtpkStart.Name = "dtpkStart";
            this.dtpkStart.Size = new System.Drawing.Size(200, 28);
            this.dtpkStart.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1062, 536);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(868, 451);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 656);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTittleDT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 703);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1080, 703);
            this.Name = "frmDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoanhThu";
            this.panelTittleDT.ResumeLayout(false);
            this.panelTittleDT.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTittleDT;
        private System.Windows.Forms.Label lbTittleXuatHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbEndTime;
        private System.Windows.Forms.Label lbStartTime;
        private System.Windows.Forms.DateTimePicker dtpkEnd;
        private System.Windows.Forms.DateTimePicker dtpkStart;
        private System.Windows.Forms.Button btnViewBenefit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}