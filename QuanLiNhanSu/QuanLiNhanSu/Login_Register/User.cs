using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using QuanLiNhanSu.User_admin;
using QuanLiNhanSu;

namespace QuanLiNhanSu
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void btn_Nhanvien__Click(object sender, EventArgs e)
        {
            Xuatds xuatds = new Xuatds();
            xuatds.Dock = DockStyle.Fill;
            this.Controls.Add(xuatds);
            xuatds.BringToFront();
        }

        private void btn_Taikhoan__Click(object sender, EventArgs e)
        {
            Doimatkhau doimatkhau = new Doimatkhau();
            doimatkhau.Dock = DockStyle.Fill;
            this.Controls.Add(doimatkhau);
            doimatkhau.BringToFront();
        }

        private void btn_Dangxuat___Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có đăng xuất không ?", "Thông báo",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                LOGIN lOGIN  = new LOGIN();
                lOGIN.Show();
                this.Hide();    
            }
        }

        private void btn_Xinnghi_Click(object sender, EventArgs e)
        {
            Xinnghi xinnghi = new Xinnghi();
            xinnghi.Dock = DockStyle.Fill;
            this.Controls.Add((xinnghi));
            xinnghi.BringToFront();
        }
    }
}
