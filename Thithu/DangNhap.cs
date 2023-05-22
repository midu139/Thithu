using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thithu
{
    public partial class Frm_DangNhap : Form
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Frm_TrangChu frm_TrangChu = new Frm_TrangChu();
            frm_TrangChu.Show();
            this.Close();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            KiemTraDN dn = new KiemTraDN();
            Frm_HomeDN frm_HomeDN = new Frm_HomeDN();
            if (dn.CheckLogin(txt_tenDangNhap.Text, txt_matKhau.Text) == 1) // Kiểm tra data từ TextBox và data trong database
            {
                MessageBox.Show("Bạn đã đăng nhập thành công");
                this.Hide(); // Form Đăng Nhập sẽ ẩn đi => home DN sẽ load lên
                frm_HomeDN.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu bị sai!");
                txt_tenDangNhap.Clear();
                txt_matKhau.Clear();
                txt_tenDangNhap.Focus();
            }
        }
    }
}
