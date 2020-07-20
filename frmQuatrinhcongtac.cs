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
    public partial class frmQuatrinhcongtac : Form
    {
        ketnoi k = new ketnoi();
        DataTable dt;
        public frmQuatrinhcongtac()
        {
            InitializeComponent();
        }
        public void Mo()
        {
            txbMaCT.Enabled = true;
            txbMaNV.Enabled = true;
            txbTenCT.Enabled = true;
            dtpngaybatdau.Enabled = true;
            dtpngayketthuc.Enabled = true;
        }

        public void Dong()
        {
            txbMaCT.Enabled = false;
            txbMaNV.Enabled = false;
            txbTenCT.Enabled = false;
            dtpngaybatdau.Enabled = false;
            dtpngayketthuc.Enabled = false;
        }

        public void Xoa()
        {
            txbTenCT.ResetText();
            txbMaNV.ResetText();
            txbMaCT.ResetText();
            dtpngaybatdau.ResetText();
            dtpngayketthuc.ResetText();
        }

        public void LoadData()
        {
            txbMaCT.DataBindings.Clear();
            txbMaCT.DataBindings.Add("Text", dataGridView1.DataSource, "mact");
            txbMaNV.DataBindings.Clear();//xóa dữ liệu có sẵn trên textbox
            txbMaNV.DataBindings.Add("Text", dataGridView1.DataSource, "manv");
            txbTenCT.DataBindings.Clear();
            txbTenCT.DataBindings.Add("Text", dataGridView1.DataSource, "tenct");
            dtpngaybatdau.DataBindings.Clear();
            dtpngaybatdau.DataBindings.Add("Text", dataGridView1.DataSource, "ngaybd");
            dtpngayketthuc.DataBindings.Clear();
            dtpngayketthuc.DataBindings.Add("Text", dataGridView1.DataSource, "ngaykt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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



        private void frmQuatrinhcongtac_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHoSoNVDataSet4.loadQTCT' table. You can move, or remove it, as needed.
            this.loadQTCTTableAdapter.Fill(this.qLHoSoNVDataSet4.loadQTCT);

            k.LoadCSDLchoQTCT(this.dataGridView1);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            LoadData();
            txbMaCT.Enabled = false;
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            Xoa();Mo();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txbMaCT.Text == dataGridViewTextBoxColumn6.ToString())
            {
                MessageBox.Show("Mã bị trùng vui lòng nhập lại");
                Xoa();
            }
            else
            {
                k.ThemCSDLqtct(txbMaCT.Text, txbMaNV.Text, txbTenCT.Text, dtpngaybatdau.Text,dtpngayketthuc.Text);
                k.LoadCSDLchoQTCT(this.dataGridView1);
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
            k.SuaCSDLqtct(txbMaCT.Text, txbMaNV.Text, txbTenCT.Text, dtpngaybatdau.Text, dtpngayketthuc.Text);
            k.LoadCSDLchoQTCT(this.dataGridView1);
            MessageBox.Show("Sửa thành công");
            Dong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa thông tin  có mã số: " + txbMaCT.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                k.XoaCSDLqtct(txbMaCT.Text);

                k.LoadCSDLchoQTCT(this.dataGridView1);
                MessageBox.Show("Xóa thành công");
                txbMaCT.ResetText();
                LoadData();

            }
        }
    }
}
