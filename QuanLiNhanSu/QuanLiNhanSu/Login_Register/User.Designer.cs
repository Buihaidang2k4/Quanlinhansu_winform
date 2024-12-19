namespace QuanLiNhanSu
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_Dangxuat__ = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Nhanvien_ = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Taikhoan_ = new Guna.UI2.WinForms.Guna2Button();
            this.doimatkhau1 = new QuanLiNhanSu.User_admin.Doimatkhau();
            this.xuatds1 = new QuanLiNhanSu.Xuatds();
            this.xinnghi1 = new QuanLiNhanSu.User_admin.Xinnghi();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.btn_Dangxuat__);
            this.guna2Panel1.Controls.Add(this.btn_Nhanvien_);
            this.guna2Panel1.Controls.Add(this.btn_Taikhoan_);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(200, 583);
            this.guna2Panel1.TabIndex = 2;
            // 
            // btn_Dangxuat__
            // 
            this.btn_Dangxuat__.AutoRoundedCorners = true;
            this.btn_Dangxuat__.BackColor = System.Drawing.Color.Transparent;
            this.btn_Dangxuat__.BorderRadius = 21;
            this.btn_Dangxuat__.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Dangxuat__.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Dangxuat__.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Dangxuat__.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Dangxuat__.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Dangxuat__.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Dangxuat__.ForeColor = System.Drawing.Color.White;
            this.btn_Dangxuat__.Image = ((System.Drawing.Image)(resources.GetObject("btn_Dangxuat__.Image")));
            this.btn_Dangxuat__.Location = new System.Drawing.Point(28, 380);
            this.btn_Dangxuat__.Name = "btn_Dangxuat__";
            this.btn_Dangxuat__.Size = new System.Drawing.Size(135, 45);
            this.btn_Dangxuat__.TabIndex = 20;
            this.btn_Dangxuat__.Text = "&DANG XUAT";
            this.btn_Dangxuat__.Click += new System.EventHandler(this.btn_Dangxuat___Click);
            // 
            // btn_Nhanvien_
            // 
            this.btn_Nhanvien_.AutoRoundedCorners = true;
            this.btn_Nhanvien_.BackColor = System.Drawing.Color.Transparent;
            this.btn_Nhanvien_.BorderRadius = 20;
            this.btn_Nhanvien_.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Nhanvien_.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Nhanvien_.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Nhanvien_.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Nhanvien_.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Nhanvien_.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Nhanvien_.ForeColor = System.Drawing.Color.White;
            this.btn_Nhanvien_.Image = ((System.Drawing.Image)(resources.GetObject("btn_Nhanvien_.Image")));
            this.btn_Nhanvien_.Location = new System.Drawing.Point(28, 198);
            this.btn_Nhanvien_.Name = "btn_Nhanvien_";
            this.btn_Nhanvien_.Size = new System.Drawing.Size(135, 42);
            this.btn_Nhanvien_.TabIndex = 19;
            this.btn_Nhanvien_.Text = "&NHAN VIEN";
            this.btn_Nhanvien_.Click += new System.EventHandler(this.btn_Nhanvien__Click);
            // 
            // btn_Taikhoan_
            // 
            this.btn_Taikhoan_.AutoRoundedCorners = true;
            this.btn_Taikhoan_.BackColor = System.Drawing.Color.Transparent;
            this.btn_Taikhoan_.BorderRadius = 21;
            this.btn_Taikhoan_.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Taikhoan_.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Taikhoan_.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Taikhoan_.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Taikhoan_.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Taikhoan_.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Taikhoan_.ForeColor = System.Drawing.Color.White;
            this.btn_Taikhoan_.Image = ((System.Drawing.Image)(resources.GetObject("btn_Taikhoan_.Image")));
            this.btn_Taikhoan_.Location = new System.Drawing.Point(28, 280);
            this.btn_Taikhoan_.Name = "btn_Taikhoan_";
            this.btn_Taikhoan_.Size = new System.Drawing.Size(135, 45);
            this.btn_Taikhoan_.TabIndex = 18;
            this.btn_Taikhoan_.Text = "&TAI KHOAN";
            this.btn_Taikhoan_.Click += new System.EventHandler(this.btn_Taikhoan__Click);
            // 
            // doimatkhau1
            // 
            this.doimatkhau1.Location = new System.Drawing.Point(206, 0);
            this.doimatkhau1.Name = "doimatkhau1";
            this.doimatkhau1.Size = new System.Drawing.Size(908, 571);
            this.doimatkhau1.TabIndex = 3;
            // 
            // xuatds1
            // 
            this.xuatds1.Location = new System.Drawing.Point(206, 13);
            this.xuatds1.Name = "xuatds1";
            this.xuatds1.Size = new System.Drawing.Size(900, 558);
            this.xuatds1.TabIndex = 1;
            // 
            // xinnghi1
            // 
            this.xinnghi1.Location = new System.Drawing.Point(206, 0);
            this.xinnghi1.Name = "xinnghi1";
            this.xinnghi1.Size = new System.Drawing.Size(908, 583);
            this.xinnghi1.TabIndex = 4;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 583);
            this.Controls.Add(this.xinnghi1);
            this.Controls.Add(this.doimatkhau1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.xuatds1);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Xuatds xuatds1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_Taikhoan_;
        private Guna.UI2.WinForms.Guna2Button btn_Nhanvien_;
        private User_admin.Doimatkhau doimatkhau1;
        private Guna.UI2.WinForms.Guna2Button btn_Dangxuat__;
        private User_admin.Xinnghi xinnghi1;
    }
}