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
    public partial class frmXemkhenthuong : Form
    {
        ketnoi k = new ketnoi();
        DataTable dt;
        public frmXemkhenthuong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void Mo()
        {
            txbMaKT.Enabled = true;
            txbMaNV.Enabled = true;
            txbTenKT.Enabled = true;
            dtpNgaykhenthuong.Enabled = true;
        }
        
        public void Dong()
        {
            txbMaKT.Enabled = false;
            txbMaNV.Enabled = false;
            txbTenKT.Enabled = false;
            dtpNgaykhenthuong.Enabled = false;
        }

        public void Xoa()
        {
            txbTenKT.ResetText();
            txbMaNV.ResetText();
            txbMaKT.ResetText();
            dtpNgaykhenthuong.ResetText();
        }
        
        public void LoadData()
        {
            txbMaKT.DataBindings.Clear();
            txbMaKT.DataBindings.Add("Text", dataGridView1.DataSource, "makt");
            txbMaNV.DataBindings.Clear();//xóa dữ liệu có sẵn trên textbox
            txbMaNV.DataBindings.Add("Text", dataGridView1.DataSource, "manv");            
            txbTenKT.DataBindings.Clear();
            txbTenKT.DataBindings.Add("Text", dataGridView1.DataSource, "khenthuong");
            dtpNgaykhenthuong.DataBindings.Clear();
            dtpNgaykhenthuong.DataBindings.Add("Text", dataGridView1.DataSource, "ngaykhenthuong");
        }




        private void frmXemkhenthuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHoSoNVDataSet9.loadKhenThuong' table. You can move, or remove it, as needed.
            this.loadKhenThuongTableAdapter.Fill(this.qLHoSoNVDataSet9.loadKhenThuong);
            k.LoadCSDLchoKT(this.dataGridView1);
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
            txbMaKT.Enabled = false;
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            Xoa();Mo();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txbMaKT.Text == dataGridViewTextBoxColumn9.ToString())
            {
                MessageBox.Show("Mã bị trùng vui lòng nhập lại");
                Xoa();
            }
            else
            {
                k.ThemCSDLkhenthuong(txbMaKT.Text, txbMaNV.Text, txbTenKT.Text, dtpNgaykhenthuong.Text);
                k.LoadCSDLchoKT(this.dataGridView1);
                MessageBox.Show("Thêm thành công");
            }
            Dong();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Mo();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            k.SuaCSDLkhenthuong(txbMaKT.Text, txbMaNV.Text, txbTenKT.Text, dtpNgaykhenthuong.Text);
            k.LoadCSDLchoKT(this.dataGridView1);
            MessageBox.Show("Sửa thành công");
            Dong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa thông tin  có mã số: " + txbMaKT.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                k.XoaCSDLkhenthuong(txbMaKT.Text);

                k.LoadCSDLchoKT(this.dataGridView1);
                MessageBox.Show("Xóa thành công");
                txbMaKT.ResetText();
                LoadData();

            }
        }
    }
}
