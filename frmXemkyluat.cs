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
    public partial class frmXemkyluat : Form
    {
        ketnoi k = new ketnoi();
        DataTable dt;
        public frmXemkyluat()
        {
            InitializeComponent();
        }
        public void Mo()
        {
            txbMaKL.Enabled = true;
            txbMaNV.Enabled = true;
            txbTenKL.Enabled = true;
            dtpngaykyluat.Enabled = true;
        }

        public void Dong()
        {
            txbMaKL.Enabled = false;
            txbMaNV.Enabled = false;
            txbTenKL.Enabled = false;
            dtpngaykyluat.Enabled = false;
        }

        public void Xoa()
        {
            txbTenKL.ResetText();
            txbMaNV.ResetText();
            txbMaKL.ResetText();
            dtpngaykyluat.ResetText();
        }

        public void LoadData()
        {
            txbMaKL.DataBindings.Clear();
            txbMaKL.DataBindings.Add("Text", dataGridView1.DataSource, "makl");
            txbMaNV.DataBindings.Clear();//xóa dữ liệu có sẵn trên textbox
            txbMaNV.DataBindings.Add("Text", dataGridView1.DataSource, "manv");
            txbTenKL.DataBindings.Clear();
            txbTenKL.DataBindings.Add("Text", dataGridView1.DataSource, "kyluat");
            dtpngaykyluat.DataBindings.Clear();
            dtpngaykyluat.DataBindings.Add("Text", dataGridView1.DataSource, "ngaykl");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmXemkyluat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHoSoNVDataSet10.loadKyLuat' table. You can move, or remove it, as needed.
            this.loadKyLuatTableAdapter.Fill(this.qLHoSoNVDataSet10.loadKyLuat);
            k.LoadCSDLchoKL(this.dataGridView1);
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            Xoa();Mo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView1.CurrentRow.Selected = true;
            }
            catch
            {

            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            LoadData();
            txbMaKL.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txbMaKL.Text == dataGridViewTextBoxColumn9.ToString())
            {
                MessageBox.Show("Mã bị trùng vui lòng nhập lại");
                Xoa();
            }
            else
            {
                k.ThemCSDLkyluat(txbMaKL.Text, txbMaNV.Text, txbTenKL.Text, dtpngaykyluat.Text);
                k.LoadCSDLchoKL(this.dataGridView1);
                MessageBox.Show("Thêm thành công");
            }
            Dong();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Mo();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            k.SuaCSDLkyluat(txbMaKL.Text, txbMaNV.Text, txbTenKL.Text, dtpngaykyluat.Text);
            k.LoadCSDLchoKL(this.dataGridView1);
            MessageBox.Show("Sửa thành công");
            Dong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa thông tin  có mã số: " + txbMaKL.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                k.XoaCSDLkyluat(txbMaKL.Text);
                k.LoadCSDLchoKL(this.dataGridView1);
                MessageBox.Show("Xóa thành công");
                txbMaKL.ResetText();
                LoadData();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
