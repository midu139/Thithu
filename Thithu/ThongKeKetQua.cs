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
using static System.Net.Mime.MediaTypeNames;

namespace Thithu
{
    public partial class Frm_ThongKeKetQua : Form
    { 
        SqlConnection cnn;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        utility utility = new utility();

        public Frm_ThongKeKetQua()
        {
            utility.OpenConnection();
            InitializeComponent();
            dataGridView1.DataSource = utility.GetDataTable("select u.UserName, u.FullName, u.Birthday, u.SessionId, t.CorrectNo, t.InCorrectNo, s.SessionName from Users u INNER JOIN Test t ON u.UserId = t.UserId INNER JOIN Session s ON u.SessionId = s.SessionId");
        }
                                                              
        private void Frm_ThongKeKetQua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'typingTestDataSet.Session' table. You can move, or remove it, as needed.
            //  this.sessionTableAdapter.Fill(this.typingTestDataSet.Session);
            // HienThi();
            this.ShowComBoBox();
        }


        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            /*da = new SqlDataAdapter("Select * from Session where SessionId = " + comboBox1.SelectedValue, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            dataGridView1.DataSource = dt;*/
        }
        //Tao su kiem cho tung cai trong cbb

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             string a = comboBox1.Text;
             string sql = "select u.UserName, u.FullName, u.Birthday, u.SessionId, t.CorrectNo, t.InCorrectNo, s.SessionName from Users u INNER JOIN Test t ON u.UserId = t.UserId INNER JOIN Session s ON u.SessionId = s.SessionId where SessionName = N'" + a + "'";
             this.ShowData(sql);
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
        public void ShowData(string sql)
        {
            utility.OpenConnection();
            dataGridView1.DataSource = utility.GetDataTable(sql);
        }
       

    }
}

