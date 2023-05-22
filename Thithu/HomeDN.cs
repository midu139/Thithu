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
    public partial class Frm_HomeDN : Form
    {
        public Frm_HomeDN()
        {
            InitializeComponent();
        }

        private void quảnLýTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_QuanLyText frm_QuanLyText = new Frm_QuanLyText();
            frm_QuanLyText.MdiParent = this;
            frm_QuanLyText.Show();
        }

        private void danhSáchCácĐợtThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DanhSach frm_DanhSach = new Frm_DanhSach();
            frm_DanhSach.MdiParent = this;
            frm_DanhSach.Show();
        }

        private void quảnLýUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_User frm_User = new Frm_User();
            frm_User.MdiParent = this;
            frm_User.Show();
        }

        private void thốngKêKếtQuảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ThongKeKetQua frm_ThongKeKetQua = new Frm_ThongKeKetQua();
            frm_ThongKeKetQua.MdiParent = this;
            frm_ThongKeKetQua.Show();
        }
    }
}
