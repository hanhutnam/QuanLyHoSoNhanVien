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
    public partial class frmThongtincanhan : Form
    {
        ketnoi k = new ketnoi();
        DataTable dt;
        public frmThongtincanhan(frmMain frmMain)
        {
            InitializeComponent();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            txbManv.DataBindings.Clear();//xóa dữ liệu có sẵn trên textbox
            txbManv.DataBindings.Add("Text", dataGridView1.DataSource, "manv");
            txbHovaTen.DataBindings.Clear();
            txbHovaTen.DataBindings.Add("Text", dataGridView1.DataSource, "hotennv");
            txbtim.DataBindings.Clear();
            txbtim.DataBindings.Add("Text", dataGridView1.DataSource, "manv");
            txbNgaysinh.DataBindings.Clear();
            txbNgaysinh.DataBindings.Add("Text", dataGridView1.DataSource, "NS");
            txbDT.DataBindings.Clear();
            txbDT.DataBindings.Add("Text", dataGridView1.DataSource, "dt");
            txbDiachi.DataBindings.Clear();
            txbDiachi.DataBindings.Add("Text", dataGridView1.DataSource, "dc");
            txbSDT.DataBindings.Clear();
            txbSDT.DataBindings.Add("Text", dataGridView1.DataSource, "sdt");
            cbGT.DataBindings.Clear();
            cbGT.DataBindings.Add("Text", dataGridView1.DataSource, "gt");
            txbLuongCB.DataBindings.Clear();
            txbLuongCB.DataBindings.Add("Text", dataGridView1.DataSource, "luongcb");
            txbLuongPC.DataBindings.Clear();
            txbLuongPC.DataBindings.Add("Text", dataGridView1.DataSource, "luongpc");
            txbHeso.DataBindings.Clear();
            txbHeso.DataBindings.Add("Text", dataGridView1.DataSource, "heso");
            txbPB.DataBindings.Clear();
            txbPB.DataBindings.Add("Text", dataGridView1.DataSource, "phongban");
            txbTD.DataBindings.Clear();
            txbTD.DataBindings.Add("Text", dataGridView1.DataSource, "tdhv");
            txbCV.DataBindings.Clear();
            txbCV.DataBindings.Add("Text", dataGridView1.DataSource, "chucvu");
            txbNgayvaolam.DataBindings.Clear();
            txbNgayvaolam.DataBindings.Add("Text", dataGridView1.DataSource, "ngaynhanchuc");
            txbMakt.DataBindings.Clear();
            txbMakt.DataBindings.Add("Text", dataGridView1.DataSource, "makt");
            txbKT.DataBindings.Clear();
            txbKT.DataBindings.Add("Text", dataGridView1.DataSource, "KhenThuong");
            txbNgaykhenthuong.DataBindings.Clear();
            txbNgaykhenthuong.DataBindings.Add("Text", dataGridView1.DataSource, "ngaykhenthuong");
            txbMakl.DataBindings.Clear();
            txbMakl.DataBindings.Add("Text", dataGridView1.DataSource, "makl");
            txbKyluat.DataBindings.Clear();
            txbKyluat.DataBindings.Add("Text", dataGridView1.DataSource, "kyluat");
            txbNgaykl.DataBindings.Clear();
            txbNgaykl.DataBindings.Add("Text", dataGridView1.DataSource, "ngaykl");
            txbMaDT.DataBindings.Clear();
            txbMaDT.DataBindings.Add("Text", dataGridView1.DataSource, "madt");
            txbMota.DataBindings.Clear();
            txbMota.DataBindings.Add("Text", dataGridView1.DataSource, "mota");
            txbNgaybatdau.DataBindings.Clear();
            txbNgaybatdau.DataBindings.Add("Text", dataGridView1.DataSource, "ngaybd");
            txbNgayketthuc.DataBindings.Clear();
            txbNgayketthuc.DataBindings.Add("Text", dataGridView1.DataSource, "ngaykt");

        }
        
        private void btntim_Click(object sender, EventArgs e)
        {
            if (txbtim.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã mã nhân viên cần tìm");
            }
            else
            {
                dt = new DataTable();
                dt = k.loadttcanhan(txbtim.Text.Trim());
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
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

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
    }
}
