using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLHSNV
{
    public partial class frmDangnhap : Form
    {
        frmMain frm;
        public frmDangnhap(frmMain f)
        {
            InitializeComponent();
            frm = f;
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOPVTCVN-PC\SQLEXPRESS;Initial Catalog=QLHoSoNV;Integrated Security=True");
        DataTable dt;
        private DataTable ktdangnhap(string taikhoan, string matkhau)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "dangnhap";
            SqlCommand comd = new SqlCommand(sql, con);
            comd.CommandType = CommandType.StoredProcedure;
            comd.Parameters.Add(new SqlParameter("user", SqlDbType.NChar)).Value = taikhoan;
            comd.Parameters.Add(new SqlParameter("pass", SqlDbType.NVarChar)).Value = matkhau;
            SqlDataAdapter da = new SqlDataAdapter(comd);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
            

        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
            txtUser.Focus();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDangnhap_Click_1(object sender, EventArgs e)
        {
            con.Open();
            dt = new DataTable();
            dt = ktdangnhap(txtUser.Text, txtPassword.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                frm.open();
                Close();

            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu. Vui lòng kiểm tra lại");
                txtUser.Text = "";
                txtPassword.Text = "";
                txtUser.Focus();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {

        }

        private void lbtittle_Click(object sender, EventArgs e)
        {

        }
    }
}
