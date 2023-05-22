using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thithu
{
    public partial class Frm_DanhSach : Form
    {
        utility utility = new utility();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4OLQIDQ\MAYAO;Initial Catalog=thu1;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        private object ConfigurationManager;

        public Frm_DanhSach()
        {
            utility.OpenConnection();
            InitializeComponent();
            dataGridView1.DataSource = utility.GetDataTable("select * from Session");
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                try
                {
                    cmd.CommandText = "SP_Them_Session";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = dateTimePicker1.Text;
                    cmd.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = dateTimePicker2.Text;
                    cmd.Parameters.Add("@SessionName", SqlDbType.NVarChar).Value = txt_session.Text;
                    cmd.Parameters.Add("@Remark", SqlDbType.NVarChar).Value = richTextBox2.Text;
                    cmd.Parameters.Add("@IsOpen", SqlDbType.Bit).Value = txt_Open.Text;

                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThi();
                    Reset();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void HienThi()
        {
            utility.OpenConnection();
            //con.ConnectionString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            string sql = "select * from Session";  // lay het du lieu trong bang seassion
            SqlCommand com = new SqlCommand(sql, con); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào cai kho vua tao
            utility.CloseConnection();
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void S_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        public bool KTThongTin()
        {
            if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePicker1.Focus();
                return false;
            }
            if (dateTimePicker2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ngày tạo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePicker2.Focus();
                return false;
            }
            if (txt_session.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên session", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_session.Focus();
                return false;
            }
            if (richTextBox2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ghi chú cho session", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox2.Focus();
                return false;
            }
            return true;
        }
        private void Reset()
        {
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            txt_session.Text = "";
            richTextBox2.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nhap vao CellClick trong sk
            dataGridView1.CurrentRow.Selected = true;
            txt_SessionId.Text = dataGridView1.Rows[e.RowIndex].Cells["SessionId"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells["FromDate"].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells["ToDate"].Value.ToString();
            txt_session.Text = dataGridView1.Rows[e.RowIndex].Cells["SessionName"].Value.ToString();
            richTextBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Remark"].Value.ToString();
            txt_Open.Text = dataGridView1.Rows[e.RowIndex].Cells["IsOpen"].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    con.Open();
                    cmd.CommandText = "SP_Sua_Session";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@SessionId", SqlDbType.Int).Value = txt_SessionId.Text;
                    cmd.Parameters.Add("@FromDate", SqlDbType.NVarChar).Value = dateTimePicker1.Text;
                    cmd.Parameters.Add("@ToDate", SqlDbType.NVarChar).Value = dateTimePicker2.Text;
                    cmd.Parameters.Add("@SessionName", SqlDbType.NVarChar).Value = txt_session.Text;
                    cmd.Parameters.Add("@Remark", SqlDbType.NVarChar).Value = richTextBox2.Text;
                    cmd.Parameters.Add("@IsOpen", SqlDbType.Bit).Value = txt_Open.Text;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    HienThi();
                    Reset();
                    MessageBox.Show("Đã sửa danh sach dot thi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_Xoa_Session";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SessionId", SqlDbType.Int).Value = Convert.ToInt32(txt_SessionId.Text);

                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();   
                con.Close();
                HienThi();
                Reset();
                MessageBox.Show("Đã xóa danh sách cac đợt thi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkb_them_CheckedChanged(object sender, EventArgs e)
        {
            txt_session.Clear();
            richTextBox2.Clear();
            if (chkb_them.Checked == true)
            {
                btn_sua.Enabled = false;
            }
            else
            {
                btn_sua.Enabled = true;
            }
        }
    }
}
