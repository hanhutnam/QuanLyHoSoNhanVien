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
    public partial class frmKT : Form
    {
        ketnoi k = new ketnoi();
        DataTable dt;
        public frmKT()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (txtMKT.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã mã khen thưởng cần tìm");
            }
            else
            {
                dt = new DataTable();
                dt = k.bcKhenTHuong(txtMKT.Text.Trim());
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Mã  Khen thưởng " + txtMKT.Text + " không tồn tại. Vui lòng kiểm tra lại");
                }
                txtMKT.ResetText();
                txtMKT.Focus();
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            k.loadbcKhenthuong(dataGridView1);
        }

        private void frmKT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHoSoNVDataSet12.loadbcKhenthuong' table. You can move, or remove it, as needed.
            this.loadbcKhenthuongTableAdapter.Fill(this.qLHoSoNVDataSet12.loadbcKhenthuong);

        }
    }
}

