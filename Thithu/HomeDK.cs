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
    public partial class Frm_HomeDK : Form
    {
        public Frm_HomeDK()
        {
            InitializeComponent();
        }

        private void thayĐổiThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ThayDoi frm_ThayDoi = new Frm_ThayDoi();
            frm_ThayDoi.MdiParent = this;
            frm_ThayDoi.Show();
        }

        private void kiểmTraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_LamBaiTest frm_LamKiemTra = new Frm_LamBaiTest();
            frm_LamKiemTra.MdiParent = this;
            frm_LamKiemTra.Show();
        }

        private void đăngNhậpUserKhácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string thongBao = "Chức năng nay chỉ dành cho người quản trị!";
            MessageBox.Show(thongBao);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Frm_TrangChu frm_Home = new Frm_TrangChu();
                frm_Home.Show();
                this.Close();
            }
            else
            {
                Frm_HomeDK frm_HomeDK = new Frm_HomeDK();
                frm_HomeDK.Show();
                this.Close();
            }
        }
    }
}
