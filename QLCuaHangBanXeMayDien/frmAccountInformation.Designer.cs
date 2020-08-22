namespace QLCuaHangBanXeMayDien
{
    partial class frmAccountInformation
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
            this.panelInforAccount = new System.Windows.Forms.Panel();
            this.lbUserNameActive = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txbAccountType = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.lbAccountType = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.lbDisplayName = new System.Windows.Forms.Label();
            this.panelInforAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInforAccount
            // 
            this.panelInforAccount.Controls.Add(this.lbUserNameActive);
            this.panelInforAccount.Controls.Add(this.btnOK);
            this.panelInforAccount.Controls.Add(this.btnSua);
            this.panelInforAccount.Controls.Add(this.txbAccountType);
            this.panelInforAccount.Controls.Add(this.txbEmail);
            this.panelInforAccount.Controls.Add(this.txbPhoneNumber);
            this.panelInforAccount.Controls.Add(this.txbDisplayName);
            this.panelInforAccount.Controls.Add(this.lbAccountType);
            this.panelInforAccount.Controls.Add(this.lbEmail);
            this.panelInforAccount.Controls.Add(this.lbPhoneNumber);
            this.panelInforAccount.Controls.Add(this.lbDisplayName);
            this.panelInforAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInforAccount.Location = new System.Drawing.Point(0, 0);
            this.panelInforAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelInforAccount.Name = "panelInforAccount";
            this.panelInforAccount.Size = new System.Drawing.Size(485, 461);
            this.panelInforAccount.TabIndex = 0;
            // 
            // lbUserNameActive
            // 
            this.lbUserNameActive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbUserNameActive.AutoSize = true;
            this.lbUserNameActive.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserNameActive.ForeColor = System.Drawing.Color.Lime;
            this.lbUserNameActive.Location = new System.Drawing.Point(33, 9);
            this.lbUserNameActive.Name = "lbUserNameActive";
            this.lbUserNameActive.Size = new System.Drawing.Size(172, 24);
            this.lbUserNameActive.TabIndex = 3;
            this.lbUserNameActive.Text = "Account is active";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOK.BackColor = System.Drawing.Color.DarkCyan;
            this.btnOK.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(311, 336);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 41);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSua.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(93, 336);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 41);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txbAccountType
            // 
            this.txbAccountType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbAccountType.BackColor = System.Drawing.Color.Black;
            this.txbAccountType.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAccountType.ForeColor = System.Drawing.Color.White;
            this.txbAccountType.Location = new System.Drawing.Point(177, 237);
            this.txbAccountType.MaxLength = 50;
            this.txbAccountType.Name = "txbAccountType";
            this.txbAccountType.Size = new System.Drawing.Size(126, 36);
            this.txbAccountType.TabIndex = 1;
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbEmail.BackColor = System.Drawing.Color.Black;
            this.txbEmail.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.ForeColor = System.Drawing.Color.White;
            this.txbEmail.Location = new System.Drawing.Point(149, 181);
            this.txbEmail.MaxLength = 200;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(299, 36);
            this.txbEmail.TabIndex = 3;
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbPhoneNumber.BackColor = System.Drawing.Color.Black;
            this.txbPhoneNumber.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.txbPhoneNumber.Location = new System.Drawing.Point(147, 123);
            this.txbPhoneNumber.MaxLength = 10;
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(299, 36);
            this.txbPhoneNumber.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbDisplayName.BackColor = System.Drawing.Color.Black;
            this.txbDisplayName.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDisplayName.ForeColor = System.Drawing.Color.White;
            this.txbDisplayName.Location = new System.Drawing.Point(149, 72);
            this.txbDisplayName.MaxLength = 100;
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(299, 36);
            this.txbDisplayName.TabIndex = 1;
            // 
            // lbAccountType
            // 
            this.lbAccountType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAccountType.AutoSize = true;
            this.lbAccountType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountType.Location = new System.Drawing.Point(33, 245);
            this.lbAccountType.Name = "lbAccountType";
            this.lbAccountType.Size = new System.Drawing.Size(138, 22);
            this.lbAccountType.TabIndex = 0;
            this.lbAccountType.Text = "Loại tài khoản : ";
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(33, 189);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(73, 22);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email : ";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNumber.Location = new System.Drawing.Point(33, 131);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(108, 22);
            this.lbPhoneNumber.TabIndex = 0;
            this.lbPhoneNumber.Text = "Điện thoại : ";
            // 
            // lbDisplayName
            // 
            this.lbDisplayName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDisplayName.AutoSize = true;
            this.lbDisplayName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplayName.Location = new System.Drawing.Point(30, 80);
            this.lbDisplayName.Name = "lbDisplayName";
            this.lbDisplayName.Size = new System.Drawing.Size(114, 22);
            this.lbDisplayName.TabIndex = 0;
            this.lbDisplayName.Text = "Tên hiển thị :";
            // 
            // frmAccountInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(485, 461);
            this.Controls.Add(this.panelInforAccount);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(503, 508);
            this.Name = "frmAccountInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tài khoản đang hoạt động";
            this.panelInforAccount.ResumeLayout(false);
            this.panelInforAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInforAccount;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label lbDisplayName;
        private System.Windows.Forms.Label lbUserNameActive;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txbAccountType;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbPhoneNumber;
        private System.Windows.Forms.Label lbAccountType;
        private System.Windows.Forms.Label lbEmail;
    }
}