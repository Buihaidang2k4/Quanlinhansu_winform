using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhanSu.Login_Register
{
    public partial class Key : Form
    {
        public Key()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string key = "12345";
            try
            {
                if (txt_Key.Text.Trim() == key) { 
                    Register register = new Register();
                    register.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Khóa không đúng","Thông báo!");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erorr!"+ex);
            }
        }
    }
}
