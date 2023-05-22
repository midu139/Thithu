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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Thithu
{
    public partial class Frm_QuanLyText : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-4OLQIDQ\MAYAO;Initial Catalog=thu1;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Frm_QuanLyText()
        {
            InitializeComponent();
        }

        private void Frm_QuanLyText_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        private void HienThi()
        {
            //cnn.Open();
            utility.OpenConnection();
            string sql = "select t.Id, t.MinuteTest,t.TextDisplay,t.CreateDate,t.SessionId,s.SessionName from TextDisplay t INNER JOIN Session s ON t.SessionId = s.SessionId";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            //cnn.Close();  // đóng kết nối
            utility.CloseConnection();
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            txt_Id.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            txt_thoigian.Text = dataGridView1.Rows[e.RowIndex].Cells["MinuteTest"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells["CreateDate"].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["TextDisplay"].Value.ToString();
            txt_SessionId.Text = dataGridView1.Rows[e.RowIndex].Cells["SessionId"].Value.ToString();
            txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells["SessionName"].Value.ToString();
        }
        //
        private void Reset()
        {
            txt_thoigian.Text = "";
            richTextBox1.Text = "";

        }
        public bool KTThongTin()
        {
            if (txt_thoigian.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thoi gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_thoigian.Focus();
                return false;
            }
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đoạn text", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox1.Focus();
                return false;
            }
            return true;
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {

                cmd.CommandText = "SP_Xoa_TexDisplay";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Convert.ToInt32(txt_SessionId.Text);

                cmd.Connection = cnn;
                //cnn.Open();
                utility.OpenConnection();
                cmd.ExecuteNonQuery();
                //cnn.Close();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_thoigian.Clear();
            richTextBox1.Clear();
            if (checkBox1.Checked == true)
            {
                btn_Sua.Enabled = false;
            }
            else
            {
                btn_Sua.Enabled = true;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {

                try
                {
                    cmd.CommandText = "SP_Them_TexDisplay";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@TextDisplay", SqlDbType.NText).Value = richTextBox1.Text;
                    cmd.Parameters.Add("@MinuteTest", SqlDbType.Int).Value = Convert.ToInt32(txt_thoigian.Text);
                    cmd.Parameters.Add("@CreateDate", SqlDbType.DateTime).Value = dateTimePicker1.Text;
                    cmd.Parameters.Add("@SessionId", SqlDbType.Int).Value = Convert.ToInt32(txt_SessionId.Text);
                    cmd.Parameters.Add("@SessionName", SqlDbType.NVarChar).Value = txt_Name.Text;

                    cmd.Connection = cnn;
                    //cnn.Open();
                    utility.OpenConnection();
                    cmd.ExecuteNonQuery();
                    //cnn.Close();
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

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                try
                {
                    cmd.CommandText = "SP_Sua_Text";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Convert.ToInt32(txt_Id.Text);
                   // cmd.Parameters.Add("@Id", SqlDbType.Int).Value = 21;
                    cmd.Parameters.Add("@TextDisplay", SqlDbType.NText).Value = richTextBox1.Text;
                    cmd.Parameters.Add("@MinuteTest", SqlDbType.Int).Value = Convert.ToInt32(txt_thoigian.Text);
                    cmd.Parameters.Add("@CreateDate", SqlDbType.DateTime).Value = dateTimePicker1.Text;
                    cmd.Parameters.Add("@SessionId", SqlDbType.Int).Value = Convert.ToInt32(txt_SessionId.Text);
                    cmd.Parameters.Add("@SessionName", SqlDbType.NVarChar).Value = txt_Name.Text;


                    cmd.Connection = cnn;
                    //cnn.Open();
                    utility.OpenConnection();
                    cmd.ExecuteNonQuery();
                    //cnn.Close();
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
    }
}

