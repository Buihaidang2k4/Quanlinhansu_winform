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
using QuanLiNhanSu.Class;
using QuanLiNhanSu.Login_Register;

namespace QuanLiNhanSu
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }
        public static string LoggedInEmail { get; set; }
        public static string LoggedInPassword { get; set; }


        private void cb_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Show.Checked)
            {
                txt_pass.PasswordChar = '\0';
            }
            else
            {
                txt_pass.PasswordChar = '*';
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                Database_connect database_Connect = new Database_connect();
                database_Connect.MoKetNoi();
                string email = txt_email.Text.Trim();
                string matkhau = txt_pass.Text.Trim();

                string query = "SELECT * FROM TaiKhoan WHERE email = @Email AND matkhau = @Matkhau";
                using (SqlCommand command = new SqlCommand(query, database_Connect.sqlCon))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Matkhau", matkhau);
                    LoggedInEmail = email;
                    LoggedInPassword = matkhau;


                    using (SqlDataReader data = command.ExecuteReader())
                    {
                        if (data.HasRows)
                        {
                            data.Read();
                            // Lấy giá trị quyền từ cột thứ 3 (chỉ số 2)
                            Const.quyen_ = (float)data.GetDouble(2);

                            if (Const.quyen_ == 0)
                            {
                                // Nếu quyền là 0, mở form Home
                                Home home = new Home();
                                home.Show();
                            }
                            else if (Const.quyen_ == 1)
                            {
                                // Nếu quyền là 1, mở form User
                                User userForm = new User();
                                userForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Quyền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Ẩn form hiện tại
                            this.Hide();
                        }
                        else
                        {
                            // Hiển thị thông báo nếu thông tin đăng nhập không đúng
                            MessageBox.Show("Email hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ở đây : " + ex.Message);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Key key = new Key();
            key.Show();
            this.Hide();
        }
    }
    }
