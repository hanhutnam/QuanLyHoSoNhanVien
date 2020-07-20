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
    public partial class frmTrinhDo : Form
    {
        ketnoi k = new ketnoi();
        DataTable dt;
        public frmTrinhDo()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (txtTDHV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã TDHV cần tìm");
            }
            else
            {
                dt = new DataTable();
                dt = k.TrinhDo(txtTDHV.Text.Trim());
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Mã Trình độ học vấn " + txtTDHV.Text + " không tồn tại hoặc sai chính tả . Vui lòng kiểm tra lại");
                }
                txtTDHV.ResetText();
                txtTDHV.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            k.loadtrinhdo(dataGridView1);
        }

        private void frmTrinhDo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHoSoNVDataSet7.loadtrinhdo' table. You can move, or remove it, as needed.
            this.loadtrinhdoTableAdapter.Fill(this.qLHoSoNVDataSet7.loadtrinhdo);

        }
    }
}

    