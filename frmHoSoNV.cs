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
    public partial class frmHoSoNV : Form
    {
        ketnoi k = new ketnoi();
        DataTable dt;
        public frmHoSoNV(frmMain frmMain)
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            txbManv.DataBindings.Clear();//xóa dữ liệu có sẵn trên textbox
            txbManv.DataBindings.Add("Text", dataGridView1.DataSource, "manv");
            txbHovaten.DataBindings.Clear();
            txbHovaten.DataBindings.Add("Text", dataGridView1.DataSource, "hotennv");
            txbtim.DataBindings.Clear();
            txbtim.DataBindings.Add("Text", dataGridView1.DataSource, "manv");
            dtpNgaysinh.DataBindings.Clear();
            dtpNgaysinh.DataBindings.Add("Text", dataGridView1.DataSource, "ns");
            txbDantoc.DataBindings.Clear();
            txbDantoc.DataBindings.Add("Text", dataGridView1.DataSource, "dt");
            txbDiachi.DataBindings.Clear();
            txbDiachi.DataBindings.Add("Text", dataGridView1.DataSource, "dc");
            txbSodienthoai.DataBindings.Clear();
            txbSodienthoai.DataBindings.Add("Text", dataGridView1.DataSource, "sdt");
            cbGT.DataBindings.Clear();
            cbGT.DataBindings.Add("Text", dataGridView1.DataSource, "gt");
            txbLuongCB.DataBindings.Clear();
            txbLuongCB.DataBindings.Add("Text", dataGridView1.DataSource, "luongcb");
            txbLuongPC.DataBindings.Clear();
            txbLuongPC.DataBindings.Add("Text", dataGridView1.DataSource, "luongpc");
            txbHeso.DataBindings.Clear();
            txbHeso.DataBindings.Add("Text", dataGridView1.DataSource, "heso");
            txbPhongban.DataBindings.Clear();
            txbPhongban.DataBindings.Add("Text", dataGridView1.DataSource, "phongban");
            txbTrinhdo.DataBindings.Clear();
            txbTrinhdo.DataBindings.Add("Text", dataGridView1.DataSource, "tdhv");
            txbChucvu.DataBindings.Clear();
            txbChucvu.DataBindings.Add("Text", dataGridView1.DataSource, "chucvu");
            dtpNgaynhanchuc.DataBindings.Clear();
            dtpNgaynhanchuc.DataBindings.Add("Text", dataGridView1.DataSource, "ngaynhanchuc");

        }
        public void Xoa()
        {
            txbAnhnhanvien.ResetText();
            txbChucvu.ResetText();
            txbDantoc.ResetText();
            txbDiachi.ResetText();
            txbHovaten.ResetText();
            txbLuongCB.ResetText();
            txbLuongPC.ResetText();
            txbManv.ResetText();
            dtpNgaysinh.ResetText();
            dtpNgaynhanchuc.Text="";
            txbPhongban.ResetText();
            txbTrinhdo.ResetText();
            txbHeso.ResetText();
            txbSodienthoai.ResetText();
            cbGT.ResetText();
            txbManv.Focus();
        }
        public void Dong()
        {
            txbChucvu.Enabled = false;
            txbDantoc.Enabled = false;
            txbDiachi.Enabled = false;
            txbHovaten.Enabled = false;
            txbLuongCB.Enabled = false;
            txbLuongPC.Enabled = false;
            txbManv.Enabled = false;
            dtpNgaysinh.Enabled = false;
            dtpNgaynhanchuc.Enabled = false;
            txbPhongban.Enabled = false;
            txbTrinhdo.Enabled = false;
            txbHeso.Enabled = false;
            txbSodienthoai.Enabled = false;
            txbAnhnhanvien.Enabled = false;
            txbHovaten.Enabled = false;
            cbGT.Enabled = false;
        }
        public void Mo()
        {
            txbChucvu.Enabled = true;
            txbDantoc.Enabled = true;
            txbDiachi.Enabled = true;
            txbHovaten.Enabled = true;
            txbLuongCB.Enabled = true;
            txbLuongPC.Enabled = true;
            txbManv.Enabled = true;
            dtpNgaysinh.Enabled = true;
            dtpNgaynhanchuc.Enabled = true;
            txbPhongban.Enabled = true;
            txbHeso.Enabled = true;
            txbTrinhdo.Enabled = true;
            txbSodienthoai.Enabled = true;
            txbAnhnhanvien.Enabled = true;
            txbHovaten.Enabled = true;
            cbGT.Enabled = true;
        }
       
        private void frmHoSoNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHoSoNVDataSet.loadnhanvien' table. You can move, or remove it, as needed.
            this.loadnhanvienTableAdapter.Fill(this.qLHoSoNVDataSet.loadnhanvien);
            dtpNgaysinh.CustomFormat = " MM / dd / yyyy ";
            dtpNgaynhanchuc.CustomFormat = " MM / dd / yyyy ";
            k.LoadCSDL(this.dataGridView1);
            Dong();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txbtim.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã mã nhân viên cần tìm");
            }
            else
            {
                dt = new DataTable();
                dt = k.Timkiem(txbtim.Text.Trim());
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Mã nhân viên " + txbtim.Text + " không tồn tại. Vui lòng kiểm tra lại");
                }
                txbtim.ResetText();
            }
            Xoa();Dong();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txbManv.Text == maNVDataGridViewTextBoxColumn.ToString())
            {
                MessageBox.Show("Mã bị trùng vui lòng nhập lại");
                Xoa();
            }
            else
            {          
                 k.ThemCSDLnhanvien(txbManv.Text, txbHovaten.Text, cbGT.Text, dtpNgaysinh.Text,txbDantoc.Text,
                    txbDiachi.Text, txbSodienthoai.Text, txbLuongCB.Text,txbLuongPC.Text,txbHeso.Text
                 , txbPhongban.Text,txbChucvu.Text,txbTrinhdo.Text,dtpNgaynhanchuc.Text);           
                k.LoadCSDL(this.dataGridView1);
                MessageBox.Show("Thêm thành công");
            }
            Dong();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
           Xoa(); Mo();
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
            txbManv.Enabled = false;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            Mo();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            k.SuaCSDLnhanvien(txbManv.Text, txbHovaten.Text, cbGT.Text, dtpNgaysinh.Text, txbDantoc.Text,
                    txbDiachi.Text, txbSodienthoai.Text, txbLuongCB.Text, txbLuongPC.Text, txbHeso.Text
                 , txbPhongban.Text, txbChucvu.Text, txbTrinhdo.Text, dtpNgaynhanchuc.Text);
            k.LoadCSDL(this.dataGridView1);
            MessageBox.Show("Sửa thành công");
            Dong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa thông tin  có mã số: " + txbtim.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                k.XoaCSDLnhanvien(txbtim.Text);

                k.LoadCSDL(this.dataGridView1);
                MessageBox.Show("Xóa thành công");
                txbtim.ResetText();
                LoadData();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            k.LoadCSDL(dataGridView1);
        }
    }
}
