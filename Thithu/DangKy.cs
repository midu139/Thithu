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
    public partial class Frm_DangKy : Form
    {
        Connection conn = new Connection();
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public Frm_DangKy()
        {
            InitializeComponent();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            if (txt_HoTen.Text != string.Empty || txt_soThuTu.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from Users where UserName='" + txt_soThuTu.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())// Doc xem co bị trung ko
                {
                    dr.Close();
                    MessageBox.Show("So thu tu da bị trùng! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into Users(UserName,Fullname,Birthday) values(@username,@fullname,@birthday)", cn);
                    cmd.Parameters.AddWithValue("UserName", txt_soThuTu.Text);
                    cmd.Parameters.AddWithValue("Fullname", txt_HoTen.Text);
                    cmd.Parameters.AddWithValue("Birthday", dateTimePicker1.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ban da dang ký thanh công", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm_HomeDK frm_HomeDK1 = new Frm_HomeDK();
                    frm_HomeDK1.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_DangKy_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-4OLQIDQ\MAYAO;Initial Catalog=thu1;Integrated Security=True");
            cn.Open();
        }
    }
}
