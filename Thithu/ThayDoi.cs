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
    public partial class Frm_ThayDoi : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmd ;
        SqlDataAdapter da ;
        SqlDataReader dr;
        public Frm_ThayDoi()
        {
            InitializeComponent();
        }

        private void btn_thayDoi_Click(object sender, EventArgs e)
        {
            if (txt_maSoDuThi.Text != string.Empty || txt_hoTen.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from Users where UserName='" + txt_maSoDuThi.Text + "'", cnn);
                dr = cmd.ExecuteReader();
                if (dr.Read())// Doc xem co bị trung ko
                {
                    dr.Close();
                    MessageBox.Show("Số thứ tự đã bị trùng! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into Users(UserName,Fullname,Birthday) values(@username,@fullname,@birthday)", cnn);
                    cmd.Parameters.AddWithValue("UserName", txt_maSoDuThi.Text);
                    cmd.Parameters.AddWithValue("Fullname", txt_hoTen.Text);
                    cmd.Parameters.AddWithValue("Birthday", dateTimePicker1.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ban da thay đổi thanh công", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
