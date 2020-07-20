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
    public partial class frmKL : Form
    {
        ketnoi k = new ketnoi();
        DataTable dt;
        public frmKL()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (txtMKL.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã mã kỷ luật cần tìm");
            }
            else
            {
                dt = new DataTable();
                dt = k.bcKyLuat(txtMKL.Text.Trim());
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Mã Kỷ luật " + txtMKL.Text + " không tồn tại. Vui lòng kiểm tra lại");
                }
                txtMKL.ResetText();
                txtMKL.Focus();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            k.loadbcKyLuat(dataGridView1);
        }

        private void frmKL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHoSoNVDataSet11.loadbcKyLuat' table. You can move, or remove it, as needed.
            this.loadbcKyLuatTableAdapter.Fill(this.qLHoSoNVDataSet11.loadbcKyLuat);

        }
    }
}
