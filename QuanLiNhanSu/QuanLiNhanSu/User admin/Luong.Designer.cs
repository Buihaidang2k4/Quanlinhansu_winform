namespace QuanLiNhanSu
{
    partial class Luong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gb_hth = new System.Windows.Forms.GroupBox();
            this.dgv_Hienthiluong = new System.Windows.Forms.DataGridView();
            this.colManv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltienthuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltienphat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grbox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Tienphat = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Tienthuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTimma = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimMa = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_TinhLuong = new Guna.UI2.WinForms.Guna2Button();
            this.cbbthangluong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbnamluong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTienluong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMnv = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.gb_hth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hienthiluong)).BeginInit();
            this.panel2.SuspendLayout();
            this.grbox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_hth
            // 
            this.gb_hth.Controls.Add(this.dgv_Hienthiluong);
            this.gb_hth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_hth.Location = new System.Drawing.Point(0, 0);
            this.gb_hth.Name = "gb_hth";
            this.gb_hth.Size = new System.Drawing.Size(900, 421);
            this.gb_hth.TabIndex = 0;
            this.gb_hth.TabStop = false;
            this.gb_hth.Text = "Bảng Lương";
            // 
            // dgv_Hienthiluong
            // 
            this.dgv_Hienthiluong.AllowUserToAddRows = false;
            this.dgv_Hienthiluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hienthiluong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colManv,
            this.ColTenNV,
            this.Column4,
            this.Column1,
            this.colTienLuong,
            this.Column3,
            this.Column2,
            this.PhuCap,
            this.coltienthuong,
            this.coltienphat,
            this.Column9});
            this.dgv_Hienthiluong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Hienthiluong.Location = new System.Drawing.Point(3, 23);
            this.dgv_Hienthiluong.Name = "dgv_Hienthiluong";
            this.dgv_Hienthiluong.RowHeadersWidth = 51;
            this.dgv_Hienthiluong.RowTemplate.Height = 24;
            this.dgv_Hienthiluong.Size = new System.Drawing.Size(894, 395);
            this.dgv_Hienthiluong.TabIndex = 5;
            this.dgv_Hienthiluong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Hienthiluong_CellClick);
            // 
            // colManv
            // 
            this.colManv.DataPropertyName = "MaNV";
            this.colManv.HeaderText = "Mã NV";
            this.colManv.MinimumWidth = 6;
            this.colManv.Name = "colManv";
            this.colManv.Width = 125;
            // 
            // ColTenNV
            // 
            this.ColTenNV.DataPropertyName = "TenNV";
            this.ColTenNV.HeaderText = "Tên Nhân Viên";
            this.ColTenNV.MinimumWidth = 6;
            this.ColTenNV.Name = "ColTenNV";
            this.ColTenNV.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ChucVu";
            this.Column4.HeaderText = "Chức Vụ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ThangNhanLuong";
            this.Column1.HeaderText = "Tháng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // colTienLuong
            // 
            this.colTienLuong.DataPropertyName = "Luongthucte";
            this.colTienLuong.HeaderText = "Tiền Lương";
            this.colTienLuong.MinimumWidth = 6;
            this.colTienLuong.Name = "colTienLuong";
            this.colTienLuong.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoNgayCong";
            this.Column3.HeaderText = "Tổng Ngày làm";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "LuongMotNgay";
            this.Column2.HeaderText = "Lương 1 Ngày";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // PhuCap
            // 
            this.PhuCap.DataPropertyName = "PhuCap";
            this.PhuCap.HeaderText = "Phụ Cấp";
            this.PhuCap.MinimumWidth = 6;
            this.PhuCap.Name = "PhuCap";
            this.PhuCap.Width = 125;
            // 
            // coltienthuong
            // 
            this.coltienthuong.DataPropertyName = "Tienthuong";
            this.coltienthuong.HeaderText = "Tiền Thưởng";
            this.coltienthuong.MinimumWidth = 6;
            this.coltienthuong.Name = "coltienthuong";
            this.coltienthuong.Width = 125;
            // 
            // coltienphat
            // 
            this.coltienphat.DataPropertyName = "Tienphat";
            this.coltienphat.HeaderText = "Tiền Phạt";
            this.coltienphat.MinimumWidth = 6;
            this.coltienphat.Name = "coltienphat";
            this.coltienphat.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Nam";
            this.Column9.HeaderText = "năm";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gb_hth);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 421);
            this.panel2.TabIndex = 1;
            // 
            // grbox1
            // 
            this.grbox1.Controls.Add(this.label2);
            this.grbox1.Controls.Add(this.label1);
            this.grbox1.Controls.Add(this.btnLuu);
            this.grbox1.Controls.Add(this.btnSua);
            this.grbox1.Controls.Add(this.txt_Tienphat);
            this.grbox1.Controls.Add(this.txt_Tienthuong);
            this.grbox1.Controls.Add(this.btnTimma);
            this.grbox1.Controls.Add(this.txtTimMa);
            this.grbox1.Controls.Add(this.btn_TinhLuong);
            this.grbox1.Controls.Add(this.cbbthangluong);
            this.grbox1.Controls.Add(this.cbbnamluong);
            this.grbox1.Controls.Add(this.txtTienluong);
            this.grbox1.Controls.Add(this.txtMnv);
            this.grbox1.Controls.Add(this.label6);
            this.grbox1.Controls.Add(this.label5);
            this.grbox1.Controls.Add(this.label4);
            this.grbox1.Controls.Add(this.label3);
            this.grbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbox1.Location = new System.Drawing.Point(0, 0);
            this.grbox1.Name = "grbox1";
            this.grbox1.Size = new System.Drawing.Size(900, 179);
            this.grbox1.TabIndex = 0;
            this.grbox1.TabStop = false;
            this.grbox1.Text = "Lương";
            this.grbox1.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Lương";
            // 
            // btnLuu
            // 
            this.btnLuu.BorderRadius = 10;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.Enabled = false;
            this.btnLuu.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(610, 77);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(68, 34);
            this.btnLuu.TabIndex = 32;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 10;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(533, 76);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(71, 32);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txt_Tienphat
            // 
            this.txt_Tienphat.BorderRadius = 10;
            this.txt_Tienphat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Tienphat.DefaultText = "";
            this.txt_Tienphat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Tienphat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Tienphat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Tienphat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Tienphat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Tienphat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Tienphat.ForeColor = System.Drawing.Color.Black;
            this.txt_Tienphat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Tienphat.Location = new System.Drawing.Point(359, 82);
            this.txt_Tienphat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Tienphat.Name = "txt_Tienphat";
            this.txt_Tienphat.PasswordChar = '\0';
            this.txt_Tienphat.PlaceholderText = "";
            this.txt_Tienphat.ReadOnly = true;
            this.txt_Tienphat.SelectedText = "";
            this.txt_Tienphat.Size = new System.Drawing.Size(138, 31);
            this.txt_Tienphat.TabIndex = 30;
            this.txt_Tienphat.TextChanged += new System.EventHandler(this.txt_Tienphat_TextChanged);
            this.txt_Tienphat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Tienphat_KeyPress);
            // 
            // txt_Tienthuong
            // 
            this.txt_Tienthuong.BorderRadius = 10;
            this.txt_Tienthuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Tienthuong.DefaultText = "";
            this.txt_Tienthuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Tienthuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Tienthuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Tienthuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Tienthuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Tienthuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Tienthuong.ForeColor = System.Drawing.Color.Black;
            this.txt_Tienthuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Tienthuong.Location = new System.Drawing.Point(359, 32);
            this.txt_Tienthuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Tienthuong.Name = "txt_Tienthuong";
            this.txt_Tienthuong.PasswordChar = '\0';
            this.txt_Tienthuong.PlaceholderText = "";
            this.txt_Tienthuong.ReadOnly = true;
            this.txt_Tienthuong.SelectedText = "";
            this.txt_Tienthuong.Size = new System.Drawing.Size(138, 31);
            this.txt_Tienthuong.TabIndex = 29;
            this.txt_Tienthuong.TextChanged += new System.EventHandler(this.txt_Tienthuong_TextChanged);
            this.txt_Tienthuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Tienthuong_KeyPress);
            // 
            // btnTimma
            // 
            this.btnTimma.BorderRadius = 10;
            this.btnTimma.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimma.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimma.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimma.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimma.Enabled = false;
            this.btnTimma.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnTimma.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimma.ForeColor = System.Drawing.Color.White;
            this.btnTimma.Location = new System.Drawing.Point(533, 33);
            this.btnTimma.Name = "btnTimma";
            this.btnTimma.Size = new System.Drawing.Size(71, 30);
            this.btnTimma.TabIndex = 28;
            this.btnTimma.Text = "Tìm";
            this.btnTimma.Click += new System.EventHandler(this.btnTimma_Click);
            // 
            // txtTimMa
            // 
            this.txtTimMa.BorderRadius = 10;
            this.txtTimMa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimMa.DefaultText = "";
            this.txtTimMa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimMa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimMa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimMa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimMa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimMa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimMa.ForeColor = System.Drawing.Color.Black;
            this.txtTimMa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimMa.Location = new System.Drawing.Point(610, 33);
            this.txtTimMa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimMa.Name = "txtTimMa";
            this.txtTimMa.PasswordChar = '\0';
            this.txtTimMa.PlaceholderText = "NV000";
            this.txtTimMa.SelectedText = "";
            this.txtTimMa.Size = new System.Drawing.Size(68, 30);
            this.txtTimMa.TabIndex = 27;
            this.txtTimMa.TextChanged += new System.EventHandler(this.txtTimMa_TextChanged);
            // 
            // btn_TinhLuong
            // 
            this.btn_TinhLuong.BorderRadius = 10;
            this.btn_TinhLuong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TinhLuong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TinhLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TinhLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TinhLuong.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btn_TinhLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_TinhLuong.ForeColor = System.Drawing.Color.White;
            this.btn_TinhLuong.Location = new System.Drawing.Point(533, 126);
            this.btn_TinhLuong.Name = "btn_TinhLuong";
            this.btn_TinhLuong.Size = new System.Drawing.Size(145, 36);
            this.btn_TinhLuong.TabIndex = 26;
            this.btn_TinhLuong.Text = "Bảng Lương";
            this.btn_TinhLuong.Click += new System.EventHandler(this.btn_TinhLuong_Click);
            // 
            // cbbthangluong
            // 
            this.cbbthangluong.BackColor = System.Drawing.Color.Transparent;
            this.cbbthangluong.BorderRadius = 10;
            this.cbbthangluong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbthangluong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbthangluong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbthangluong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbthangluong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbthangluong.ForeColor = System.Drawing.Color.Black;
            this.cbbthangluong.ItemHeight = 30;
            this.cbbthangluong.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbbthangluong.Location = new System.Drawing.Point(78, 77);
            this.cbbthangluong.Name = "cbbthangluong";
            this.cbbthangluong.Size = new System.Drawing.Size(128, 36);
            this.cbbthangluong.TabIndex = 25;
            this.cbbthangluong.SelectedIndexChanged += new System.EventHandler(this.cbbthangluong_SelectedIndexChanged);
            // 
            // cbbnamluong
            // 
            this.cbbnamluong.BackColor = System.Drawing.Color.Transparent;
            this.cbbnamluong.BorderRadius = 10;
            this.cbbnamluong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbnamluong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbnamluong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbnamluong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbnamluong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbnamluong.ForeColor = System.Drawing.Color.Black;
            this.cbbnamluong.ItemHeight = 30;
            this.cbbnamluong.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025"});
            this.cbbnamluong.Location = new System.Drawing.Point(78, 33);
            this.cbbnamluong.Name = "cbbnamluong";
            this.cbbnamluong.Size = new System.Drawing.Size(128, 36);
            this.cbbnamluong.TabIndex = 24;
            this.cbbnamluong.SelectedIndexChanged += new System.EventHandler(this.cbbnamluong_SelectedIndexChanged);
            // 
            // txtTienluong
            // 
            this.txtTienluong.BorderRadius = 10;
            this.txtTienluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTienluong.DefaultText = "";
            this.txtTienluong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTienluong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTienluong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienluong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienluong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTienluong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTienluong.ForeColor = System.Drawing.Color.Black;
            this.txtTienluong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTienluong.Location = new System.Drawing.Point(359, 131);
            this.txtTienluong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTienluong.Name = "txtTienluong";
            this.txtTienluong.PasswordChar = '\0';
            this.txtTienluong.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTienluong.PlaceholderText = "Tiền Lương";
            this.txtTienluong.ReadOnly = true;
            this.txtTienluong.SelectedText = "";
            this.txtTienluong.Size = new System.Drawing.Size(138, 31);
            this.txtTienluong.TabIndex = 23;
            this.txtTienluong.TextChanged += new System.EventHandler(this.txtTienluong_TextChanged);
            // 
            // txtMnv
            // 
            this.txtMnv.BorderRadius = 10;
            this.txtMnv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMnv.DefaultText = "";
            this.txtMnv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMnv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMnv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMnv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMnv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMnv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMnv.ForeColor = System.Drawing.Color.Black;
            this.txtMnv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMnv.Location = new System.Drawing.Point(78, 126);
            this.txtMnv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMnv.Name = "txtMnv";
            this.txtMnv.PasswordChar = '\0';
            this.txtMnv.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtMnv.PlaceholderText = "Mã NV";
            this.txtMnv.ReadOnly = true;
            this.txtMnv.SelectedText = "";
            this.txtMnv.Size = new System.Drawing.Size(128, 31);
            this.txtMnv.TabIndex = 22;
            this.txtMnv.TextChanged += new System.EventHandler(this.txtMnv_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tiền phạt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tiền thưởng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tháng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 179);
            this.panel1.TabIndex = 0;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Manv";
            // 
            // Luong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Luong";
            this.Size = new System.Drawing.Size(900, 600);
            this.gb_hth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hienthiluong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.grbox1.ResumeLayout(false);
            this.grbox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_hth;
        private System.Windows.Forms.DataGridView dgv_Hienthiluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltienthuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltienphat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grbox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2TextBox txt_Tienphat;
        private Guna.UI2.WinForms.Guna2TextBox txt_Tienthuong;
        private Guna.UI2.WinForms.Guna2Button btnTimma;
        private Guna.UI2.WinForms.Guna2TextBox txtTimMa;
        private Guna.UI2.WinForms.Guna2Button btn_TinhLuong;
        private Guna.UI2.WinForms.Guna2ComboBox cbbthangluong;
        private Guna.UI2.WinForms.Guna2ComboBox cbbnamluong;
        private Guna.UI2.WinForms.Guna2TextBox txtTienluong;
        private Guna.UI2.WinForms.Guna2TextBox txtMnv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label2;
    }
}
