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
            this.panelTittleKho.SuspendLayout();
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
            this.panelTittleKho.Size = new System.Drawing.Size(886, 72);
            this.panelTittleKho.TabIndex = 1;
            // 
            // lbTittleKho
            // 
            this.lbTittleKho.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTittleKho.AutoSize = true;
            this.lbTittleKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittleKho.ForeColor = System.Drawing.Color.White;
            this.lbTittleKho.Location = new System.Drawing.Point(382, 20);
            this.lbTittleKho.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTittleKho.Name = "lbTittleKho";
            this.lbTittleKho.Size = new System.Drawing.Size(113, 26);
            this.lbTittleKho.TabIndex = 2;
            this.lbTittleKho.Text = "Kho hàng";
            // 
            // frmKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 498);
            this.Controls.Add(this.panelTittleKho);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKhoHang";
            this.Text = "dngư";
            this.panelTittleKho.ResumeLayout(false);
            this.panelTittleKho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTittleKho;
        private System.Windows.Forms.Label lbTittleKho;
    }
}