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
    public partial class frmquatrinhdaotao : Form
    {
        ketnoi k = new ketnoi();
        DataTable dt;
        public frmquatrinhdaotao()
        {
            InitializeComponent();
        }
        public void Mo()
        {
            txbMaDT.Enabled = true;
            txbMaNV.Enabled = true;
            dtpngaybatdau.Enabled = true;
            dtpngayketthuc.Enabled = true;
            txbMota.Enabled = true;
        }

        public void Dong()
        {
            txbMaDT.Enabled = false;
            txbMaNV.Enabled = false;
            dtpngaybatdau.Enabled = false;
            dtpngayketthuc.Enabled = false;
            txbMota.Enabled = false;
        }

        public void Xoa()
        {
            txbMaNV.ResetText();
            txbMaDT.ResetText();
            dtpngaybatdau.ResetText();
            dtpngayketthuc.ResetText();
            txbMota.ResetText();
        }

        public void LoadData()
        {
            txbMaDT.DataBindings.Clear();
            txbMaDT.DataBindings.Add("Text", dataGridView1.DataSource, "madt");
            txbMaNV.DataBindings.Clear();//xóa dữ liệu có sẵn trên textbox
            txbMaNV.DataBindings.Add("Text", dataGridView1.DataSource, "manv");
            dtpngaybatdau.DataBindings.Clear();
            dtpngaybatdau.DataBindings.Add("Text", dataGridView1.DataSource, "ngaybd");
            dtpngayketthuc.DataBindings.Clear();
            dtpngayketthuc.DataBindings.Add("Text", dataGridView1.DataSource, "ngaykt");
            txbMota.DataBindings.Clear();
            txbMota.DataBindings.Add("Text", dataGridView1.DataSource, "mota");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmquatrinhdaotao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHoSoNVDataSet5.loadQTDT' table. You can move, or remove it, as needed.
            this.loadQTDTTableAdapter.Fill(this.qLHoSoNVDataSet5.loadQTDT);
            k.LoadCSDLchoQTDT(this.dataGridView1);
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
            txbMaDT.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txbMaDT.Text == dataGridViewTextBoxColumn1.ToString())
            {
                MessageBox.Show("Mã bị trùng vui lòng nhập lại");
                Xoa();
            }
            else
            {
                k.ThemCSDLqtdt(txbMaDT.Text, txbMaNV.Text, dtpngaybatdau.Text, dtpngayketthuc.Text,txbMota.Text);
                k.LoadCSDLchoQTDT(this.dataGridView1);
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
            k.SuaCSDLqtdt(txbMaDT.Text, txbMaNV.Text, dtpngaybatdau.Text, dtpngayketthuc.Text, txbMota.Text);
            k.LoadCSDLchoQTDT(this.dataGridView1);
            MessageBox.Show("Thêm thành công");
            Dong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa thông tin  có mã số: " + txbMaDT.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                k.XoaCSDLqtdt(txbMaDT.Text);

                k.LoadCSDLchoQTDT(this.dataGridView1);
                MessageBox.Show("Xóa thành công");
                txbMaDT.ResetText();
                LoadData();

            }
        }
    }
}
