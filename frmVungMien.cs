using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLHSNV
{
    public partial class frmVungMien : Form
    {
        ketnoi k = new ketnoi();
        DataTable dt;
        public frmVungMien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtVM.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên vùng miền cần tìm");
            }
            else
            {
                dt = new DataTable();
                dt = k.Vungmien(txtVM.Text.Trim());
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không có nhân viên nào ở " + txtVM.Text + "! Hoặc sai chính tả . Vui lòng kiểm tra lại");
                }
                txtVM.ResetText();
                txtVM.Focus();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            k.loadvungmien(dataGridView1);
        }

        private void frmVungMien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHoSoNVDataSet8.loadvungmien' table. You can move, or remove it, as needed.
            this.loadvungmienTableAdapter.Fill(this.qLHoSoNVDataSet8.loadvungmien);

        }
    }
}
