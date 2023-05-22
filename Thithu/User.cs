using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Thithu
{
    public partial class Frm_User : Form
    {
        SqlConnection cnn;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        utility utility = new utility();
        public Frm_User()
        {
            utility.OpenConnection();
            InitializeComponent();
            dataGridView1.DataSource = utility.GetDataTable("select u.UserId, u.Username, u.FullName, u.Birthday, s.SessionId, s.SessionName from Users u INNER JOIN Session s ON u.SessionId = s.SessionId");
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Reset();
                btn_sua.Enabled = false;
            }
            else
            {
                btn_sua.Enabled = true;
            }
        }

        private void Frm_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'typingTestDataSet1.Session' table. You can move, or remove it, as needed.
            //this.sessionTableAdapter.Fill(this.typingTestDataSet1.Session);
            //HienThi();
            this.ShowComBoBox();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            txt_UserId.Text = dataGridView1.Rows[e.RowIndex].Cells["UserId"].Value.ToString();
            txt_maso.Text = dataGridView1.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
            txt_hoten.Text = dataGridView1.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells["Birthday"].Value.ToString();
            txt_SesionId.Text = dataGridView1.Rows[e.RowIndex].Cells["SessionId"].Value.ToString();
            txt_SessionName.Text = dataGridView1.Rows[e.RowIndex].Cells["SessionName"].Value.ToString();
        }
        public void ShowComBoBox()
        {
            cnn = utility.OpenDB();
            cnn.Open();

            cmd = new SqlCommand("Select * from Session", cnn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "SessionName";
            comboBox1.ValueMember = "SessionId";
        }
        //Click doi tuong trong cbb hien len datagridview
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = comboBox1.Text;
            string sql = "select u.UserId, u.Username, u.FullName,u.Birthday,s.SessionId,s.SessionName from Users u INNER JOIN Session s ON u.SessionId = s.SessionId where SessionName = N'" + a + "'";
            this.ShowData(sql);
        }
        public void ShowData(string sql)
        {
            utility.OpenConnection();
            dataGridView1.DataSource = utility.GetDataTable(sql);
        }
        // cac nut them, sua , xoa
        public bool KTThongTin()
        {
            if (txt_maso.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số thứ tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_maso.Focus();
                return false;
            }
            if (txt_hoten.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_hoten.Focus();
                return false;
            }
            return true;
        }
        private void HienThi()
        {
            utility.OpenConnection();
            string sql = "select u.UserId, u.Username, u.FullName,u.Birthday,s.SessionId,s.SessionName from Users u INNER JOIN Session s ON u.SessionId = s.SessionId";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            utility.CloseConnection();
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void Reset()
        {
            txt_maso.Text = "";
            txt_hoten.Text = "";

        }

        //Them
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {

                try
                {
                    cmd.CommandText = "SP_Them_Users";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = txt_maso.Text;
                    cmd.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = txt_hoten.Text;
                    cmd.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = dateTimePicker1.Text;
                    cmd.Parameters.Add("@SessionId", SqlDbType.Int).Value = Convert.ToInt32(txt_SesionId.Text);
                    cmd.Parameters.Add("@SessionName", SqlDbType.NVarChar).Value = txt_SessionName.Text;

                    cmd.Connection = cnn;
                    utility.OpenConnection();
                    cmd.ExecuteNonQuery();
                    utility.CloseConnection();
                    HienThi();
                    Reset();
                    MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //Sua
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                try
                {
                    cmd.CommandText = "SP_Sua_Users                                                                            ";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = Convert.ToInt32(txt_UserId.Text);
                    cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = txt_maso.Text;
                    cmd.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = txt_hoten.Text;
                    cmd.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = dateTimePicker1.Text;
                    cmd.Parameters.Add("@SessionId", SqlDbType.Int).Value = Convert.ToInt32(txt_SesionId.Text);
                    cmd.Parameters.Add("@SessionName", SqlDbType.NVarChar).Value = txt_SessionName.Text;


                    cmd.Connection = cnn;
                    utility.OpenConnection();
                    cmd.ExecuteNonQuery();
                    utility.CloseConnection();

                    HienThi();
                    Reset();
                    MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                cmd.CommandText = "SP_Xoa_Users";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = Convert.ToInt32(txt_UserId.Text);

                cmd.Connection = cnn;
                utility.OpenConnection();
                cmd.ExecuteNonQuery();
                utility.CloseConnection();

                HienThi();
                Reset();
                MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
