using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiNhanSu.Class.TaiKhoan;
using TheArtOfDevHtmlRenderer.Adapters;

namespace QuanLiNhanSu
{
    public partial class Taikhoan : UserControl
    {
        public Taikhoan()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Taikhoan_Load);

        }

        private void Taikhoan_Load(object sender, EventArgs e)
        {
            HienThiThongtin();
            NotEnabledChucNang();
            btn_Xoa_.Enabled = false;
            btn_Sua_.Enabled = false;
        }

        SqlDataAdapter adapter = null;
        DataSet ds = null;

        private void HienThiThongtin()
        {
            Database_connect database_Connect = new Database_connect();
            database_Connect.MoKetNoi();
            string sql = "select * from TaiKhoan";

            adapter = new SqlDataAdapter(sql, database_Connect.sqlCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "TaiKhoan");
            dgv_TaiKhoan.DataSource = ds.Tables["TaiKhoan"];

        }
        private void XoaDuLieu()
        {
            txt_TK_ten.Clear();
            txt_TK_matkhau.Clear();
            txt_TK_Tktentaikhoan.Clear();
        }
        public void EnabledChucNang()
        {
            txt_TK_ten.Enabled = true;
            txt_TK_matkhau.Enabled = true;
            cb_TK_Quyen.Enabled = true;
        }

        public void NotEnabledChucNang()
        {
            txt_TK_ten.Enabled = false;
            txt_TK_matkhau.Enabled = false;
            cb_TK_Quyen.Enabled = false;
        }

        private void ThemTK()
        {
            try
            {
                Database_connect database_Connect = new Database_connect();
                database_Connect.MoKetNoi();

                DataRow row = ds.Tables["TaiKhoan"].NewRow();

                string email = txt_TK_ten.Text.Trim();
                string password = txt_TK_matkhau.Text.Trim();

                // Kiểm tra email hợp lệ
                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Email không hợp lệ! Vui lòng sử dụng định dạng @gmail.com.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra mật khẩu hợp lệ
                if (!IsValidPassword(password))
                {
                    MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự, bao gồm ít nhất 1 chữ cái, 1 số và 1 ký tự đặc biệt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                row["email"] = txt_TK_ten.Text.Trim();
                row["matkhau"] = txt_TK_matkhau.Text.Trim();

                if (cb_TK_Quyen.SelectedIndex == 0) row["quyen"] = 0;
                else if (cb_TK_Quyen.SelectedIndex == 1) row["quyen"] = 1;


                ds.Tables["TaiKhoan"].Rows.Add(row);
                int kq = adapter.Update(ds.Tables["TaiKhoan"]);
                if (kq > 0)
                {
                    MessageBox.Show("Thêm tai khoan thành công!");
                    HienThiThongtin();
                }
                else
                {
                    MessageBox.Show("Thêm tai khoan không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error !" + ex);
            }
            XoaDuLieu();
            HienThiThongtin();
            NotEnabledChucNang();
        }

        private bool IsValidEmail(string email)
        {
            return email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase) &&
                   System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        // Hàm kiểm tra mật khẩu hợp lệ
        private bool IsValidPassword(string password)
        {
            if (password.Length < 6)
                return false;

            bool hasLetter = false;
            bool hasDigit = false;
            bool hasSpecialChar = false;

            foreach (char c in password)
            {
                if (char.IsLetter(c)) hasLetter = true;
                else if (char.IsDigit(c)) hasDigit = true;
                else if (!char.IsLetterOrDigit(c)) hasSpecialChar = true;

                if (hasLetter && hasDigit && hasSpecialChar)
                    return true;
            }

            return false;
        }
        private void SuaTK()
        {
            try
            {
                if (vt == -1) return;
                Database_connect database_Connect = new Database_connect();
                database_Connect.MoKetNoi();

                DataRow row = ds.Tables["TaiKhoan"].Rows[vt];
                row.BeginEdit();
                row["email"] = txt_TK_ten.Text.Trim();
                row["matkhau"] = txt_TK_matkhau.Text.Trim();
                if (cb_TK_Quyen.SelectedIndex == 0) row["quyen"] = 0;
                else if (cb_TK_Quyen.SelectedIndex == 1) row["quyen"] = 1;
                row.EndEdit();

                int kq = adapter.Update(ds.Tables["TaiKhoan"]);
                if (kq > 0)
                {
                    MessageBox.Show("Chỉnh sửa tài khoản thành công!");
                    HienThiThongtin();
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa tài khoản không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error !" + ex);

            }
            XoaDuLieu();
            NotEnabledChucNang();
            btn_Sua_.Enabled = false;
            btn_Xoa_.Enabled = false;
        }

        private void XoaTaiKhoan()
        {
            try
            {
                if (vt == -1) return;
                Database_connect database_Connect = new Database_connect();
                database_Connect.MoKetNoi();
                DataRow row = ds.Tables["TaiKhoan"].Rows[vt];
                row.Delete();

                int kq = adapter.Update(ds.Tables["TaiKhoan"]);
                if (kq > 0)
                {
                    MessageBox.Show("Xoa tai khoan thành công!");
                    HienThiThongtin();
                }
                else
                {
                    MessageBox.Show("Xoa tai khoan không thành công!", "Xoa tai khoan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error !" + ex);
            }
        }

        int vt = -1;
        private void dgv_TaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            btn_Sua_.Enabled = true;
            btn_Xoa_.Enabled = true;
            if (vt == -1) return;

            DataRow row = ds.Tables["TaiKhoan"].Rows[vt];
            txt_TK_ten.Text = row["email"].ToString().Trim();
            txt_TK_matkhau.Text = row["matkhau"].ToString().Trim();
            if (row["quyen"].ToString().Trim() == "0") cb_TK_Quyen.SelectedIndex = 0;
            else if (row["quyen"].ToString().Trim() == "1") cb_TK_Quyen.SelectedIndex = 1;
        }

        private void btn_Timkiem__Click(object sender, EventArgs e)
        {
            Database_connect database_Connect = new Database_connect();
            database_Connect.MoKetNoi();
            string tentk = txt_TK_Tktentaikhoan.Text.Trim();
            string sql = "select * from TaiKhoan where email like '%" + tentk + "%'";
            adapter = new SqlDataAdapter(sql, database_Connect.sqlCon);
            ds = new DataSet();
            adapter.Fill(ds, "TKTen");
            dgv_TaiKhoan.DataSource = ds.Tables["TKTen"];
        }

        int cn = 0;
        private void btn_Luu__Click(object sender, EventArgs e)
        {
            if (cn == 1) ThemTK();
            else if (cn == 2) SuaTK();
        }

        private void btn_Huy__Click(object sender, EventArgs e)
        {
            XoaDuLieu();
            NotEnabledChucNang();
            btn_Sua_.Enabled = false;
            btn_Xoa_.Enabled = false;
        }

        private void btn_Them__Click(object sender, EventArgs e)
        {
            EnabledChucNang();
            XoaDuLieu();
            cn = 1;
        }

        private void btn_Sua__Click(object sender, EventArgs e)
        {
            cn = 2;
            EnabledChucNang();
        }

        private void btn_Xoa__Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa tai khoan này không ?", "Thông báo"
           , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                XoaTaiKhoan();
                XoaDuLieu();
                NotEnabledChucNang();
                btn_Sua_.Enabled = false;
                btn_Xoa_.Enabled = false;
            }
        }
    }
}
