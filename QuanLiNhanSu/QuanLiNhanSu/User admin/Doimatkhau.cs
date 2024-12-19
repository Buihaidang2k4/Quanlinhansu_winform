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

namespace QuanLiNhanSu.User_admin
{
    public partial class Doimatkhau : UserControl
    {
        public Doimatkhau()
        {
            InitializeComponent();
        }



        private void btn_DMK_Click(object sender, EventArgs e)
        {
            // Lấy thông tin mật khẩu hiện tại, mật khẩu mới và mật khẩu xác nhận
            string currentPassword = txt_pass0.Text.Trim();
            string newPassword = txt_pass1.Text.Trim();
            string confirmPassword = txt_pass2.Text.Trim();
            try { 
                // Kiểm tra mật khẩu hiện tại (pass0) có đúng không
                if (currentPassword != LOGIN.LoggedInPassword) // Giả sử mật khẩu hiện tại đã được lưu trong Login.LoggedInPassword
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng!");
                    return;
                }

                // Kiểm tra mật khẩu mới và xác nhận mật khẩu mới (pass1 và pass2)
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không trùng khớp!");
                    return;
                }

                // Kiểm tra mật khẩu mới có đủ yêu cầu (ít nhất 6 ký tự, có số, chữ và ký tự đặc biệt)
                if (newPassword.Length < 6 || !HasUpperCase(txt_pass0.Text.Trim()) || !HasLowerCase(txt_pass1.Text.Trim()) || !HasDigit(txt_pass2.Text.Trim()))
                {
                    MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự, bao gồm cả chữ hoa, chữ thường và số.");
                    return;
                }

                // Cập nhật mật khẩu mới vào cơ sở dữ liệu
                Database_connect database_Connect = new Database_connect();
                database_Connect.MoKetNoi();

                // Giả sử bạn có bảng "TaiKhoan" và trường "matkhau"
                string sql = "UPDATE TaiKhoan SET matkhau = @newPassword WHERE email = @email";
                SqlCommand cmd = new SqlCommand(sql, database_Connect.sqlCon);
                cmd.Parameters.AddWithValue("@newPassword", newPassword);
                cmd.Parameters.AddWithValue("@email", LOGIN.LoggedInEmail); // Lấy email đã đăng nhập để cập nhật mật khẩu

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    LOGIN.LoggedInPassword = newPassword; // Cập nhật mật khẩu mới vào biến toàn cục
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu không thành công!");
                }
             }catch (Exception ex)
                {
                    MessageBox.Show("Error! " + ex.Message);
                } 

}

        // Kiểm tra mật khẩu có chữ hoa
        private bool HasUpperCase(string input)
        {
            return input.Any(char.IsUpper);
        }

        // Kiểm tra mật khẩu có chữ thường
        private bool HasLowerCase(string input)
        {
            return input.Any(char.IsLower);
        }

        // Kiểm tra mật khẩu có số
        private bool HasDigit(string input)
        {
            return input.Any(char.IsDigit);
        }
        private void btn_xem_Click(object sender, EventArgs e)
        {
            string email = LOGIN.LoggedInEmail;
            string matkhau = LOGIN.LoggedInPassword;
            txt_taikhoan .Text = email; 
            txt_matkhau .Text = matkhau;    
        }
    }
}
