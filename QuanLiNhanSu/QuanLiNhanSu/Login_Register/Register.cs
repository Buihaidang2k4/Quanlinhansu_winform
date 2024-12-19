using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiNhanSu.Class.TaiKhoan;

namespace QuanLiNhanSu.Login_Register
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            rd_Admin.Checked = true;
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txt_name.Text.Trim();

                if (!IsValidGmail(email))
                {
                    MessageBox.Show("Email không hợp lệ. Vui lòng kiểm tra lại.","Thong bao!");
                    return;
                }
                string password = txt_pass1.Text.Trim();
                string pattern = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$";

                if (password != txt_pass2.Text.Trim())
                {
                    MessageBox.Show("Mật khẩu không khớp.");
                    return;
                }

                if (!Regex.IsMatch(password, pattern))
                {
                    MessageBox.Show("Mật khẩu phải chứa ít nhất 6 ký tự, bao gồm chữ cái, số và ký tự đặc biệt.");
                    return;
                }
                if (IsEmailExists(email))
                {
                    MessageBox.Show("Email này đã được đăng ký. Vui lòng chọn email khác.", "Thong bao!");
                    return;
                }
                int quyen = -1;
                if (rd_Admin.Checked) quyen = 0;
                Database_connect database_Connect = new Database_connect();
                database_Connect.MoKetNoi();

                string sql = "INSERT INTO Taikhoan (Email, matkhau, Quyen) VALUES (@Email, @Password, @Quyen)";

                SqlCommand cmd = new SqlCommand(sql, database_Connect.sqlCon);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password.Trim());
                cmd.Parameters.AddWithValue("@Quyen", quyen);

                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show("Đăng ký thành công!");
                    txt_name.Clear();
                    txt_pass1.Clear();
                    txt_pass2.Clear();
                    Login login   = new Login();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng ký không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi : " + ex.Message);
            }


        }

        private bool IsEmailExists(string email)
        {
            string query = "SELECT COUNT(*) FROM Taikhoan WHERE Email = @Email";
            Database_connect database_Connect = new Database_connect();
            database_Connect.MoKetNoi();
            using (SqlCommand cmd = new SqlCommand(query, database_Connect.sqlCon))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                int count = (int)cmd.ExecuteScalar();  // Trả về số lượng bản ghi tìm thấy
                return count > 0;  // Nếu lớn hơn 0, có nghĩa là email đã tồn tại
            }
        }
        private bool IsValidGmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
    }
}
