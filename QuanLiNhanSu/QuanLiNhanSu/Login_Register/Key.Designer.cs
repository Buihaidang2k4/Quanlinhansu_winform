namespace QuanLiNhanSu.Login_Register
{
    partial class Key
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Key));
            this.btn_Confirm = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Key = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.AutoRoundedCorners = true;
            this.btn_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm.BorderRadius = 18;
            this.btn_Confirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Confirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Confirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Confirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Confirm.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Confirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Confirm.ForeColor = System.Drawing.Color.White;
            this.btn_Confirm.Image = ((System.Drawing.Image)(resources.GetObject("btn_Confirm.Image")));
            this.btn_Confirm.Location = new System.Drawing.Point(155, 121);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(112, 38);
            this.btn_Confirm.TabIndex = 25;
            this.btn_Confirm.Text = "&Confirm";
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // txt_Key
            // 
            this.txt_Key.BorderRadius = 10;
            this.txt_Key.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Key.DefaultText = "";
            this.txt_Key.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Key.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Key.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Key.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Key.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Key.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Key.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Key.ForeColor = System.Drawing.Color.Black;
            this.txt_Key.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Key.Location = new System.Drawing.Point(106, 55);
            this.txt_Key.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.PasswordChar = '*';
            this.txt_Key.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txt_Key.PlaceholderText = "Enter key";
            this.txt_Key.SelectedText = "";
            this.txt_Key.Size = new System.Drawing.Size(212, 37);
            this.txt_Key.TabIndex = 26;
            this.txt_Key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Key
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 212);
            this.Controls.Add(this.txt_Key);
            this.Controls.Add(this.btn_Confirm);
            this.Name = "Key";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_Confirm;
        private Guna.UI2.WinForms.Guna2TextBox txt_Key;
    }
}