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

namespace Thithu
{
    public partial class Frm_TrangChu : Form
    {
        public Frm_TrangChu()
        {
            InitializeComponent();
        }

        private void Btn_DangNhap_Click(object sender, EventArgs e)
        {
            Frm_DangNhap frm_DangNhap = new Frm_DangNhap();
            frm_DangNhap.Show();
            this.Hide();
        }

        private void Btn_DangKy_Click(object sender, EventArgs e)
        {
            Frm_DangKy frm_DangKy = new Frm_DangKy();
            frm_DangKy.Show();
            this.Hide();
        }

        private void Btn_Thoat_Click(object sender, EventArgs e)
        {
            string MessageBoxTitle = "Thông Báo";
            string MessageBoxContent = "Bạn chắc chắn muốn đóng chương trình?";

            DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                Frm_TrangChu frm_TrangChu = new Frm_TrangChu();
                this.Close();
                frm_TrangChu.Show();

            }
        }
    }
}
