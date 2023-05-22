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
    public partial class Frm_LamBaiTest : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4OLQIDQ\MAYAO;Initial Catalog=thu1;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public Frm_LamBaiTest()
        {
            InitializeComponent();
        }

        private void Frm_LamBaiTest_Load(object sender, EventArgs e)
        {
            richTextBox1.Enabled = false;
            dataGridView1.Focus();
        }

        private void btn_batDau_Click(object sender, EventArgs e)
        {
            richTextBox1.Enabled = true;
            HienThi();
        }
        private void HienThi()
        {
            con.Open();
            string sql =
                "select TextDisplay.TextDisplay from TextDisplay  INNER JOIN Session  ON TextDisplay.SessionId = Session.SessionId Where Session.IsOpen = 1";// lay  du lieu trong bang seassion va textdisplay
            SqlCommand com = new SqlCommand(sql, con); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào cai kho vua tao
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
            con.Close();  // đóng kết nối
            if (dataGridView1.Rows[0].Cells[0].Value != null)
            {
                richde.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            }
        }
    }
}
