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
    public partial class frmMain : Form
    {

        
        public frmMain()
        {
            InitializeComponent();
        }

        


        private void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }


        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        
        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaocao s = new frmBaocao();
            s.MdiParent = this;
            s.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn muốn Thoát?", "Thông báo", MessageBoxButtons.OKCancel);
            if(thongbao==DialogResult.OK)
            Close();      
        }

        private void đăngNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDangnhap s = new frmDangnhap(this);
            s.MdiParent = this;
            s.Show();
            
        }
        public void clock()
        {
            khenThưởngToolStripMenuItem.Enabled = false;
            kỹLuậtToolStripMenuItem.Enabled = false;
            báocáoToolStripMenuItem.Enabled = false;
            hồSơNhânViênToolStripMenuItem.Enabled = false;
            quáTrìnhCôngTácToolStripMenuItem.Enabled = false;
            quáTrìnhĐàoTạoToolStripMenuItem.Enabled = false;
            đăngXuấtToolStripMenuItem.Enabled = false;


        }
        public void open()
        {
            khenThưởngToolStripMenuItem.Enabled = true;
            kỹLuậtToolStripMenuItem.Enabled = true;
            báocáoToolStripMenuItem.Enabled = true;
            hồSơNhânViênToolStripMenuItem.Enabled = true;
            quáTrìnhĐàoTạoToolStripMenuItem.Enabled = true;
            quáTrìnhCôngTácToolStripMenuItem.Enabled = true;
            đăngXuấtToolStripMenuItem.Enabled = true;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công");
            clock();
            
        }

        private void hồSơNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoSoNV s = new frmHoSoNV(this);
            s.MdiParent = this;
            s.Show();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongtincanhan s = new frmThongtincanhan(this);
            s.MdiParent = this;
            s.Show();
        }

        private void quáTrìnhCôngTácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuatrinhcongtac s = new frmQuatrinhcongtac();
            s.MdiParent = this;
            s.Show();
        }

        private void quáTrìnhĐàoTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmquatrinhdaotao s = new frmquatrinhdaotao();
            s.MdiParent = this;
            s.Show();
        }

        private void kỹLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXemkyluat s = new frmXemkyluat();
            s.MdiParent = this;
            s.Show();
        }

        private void khenThưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXemkhenthuong s = new frmXemkhenthuong();
            s.MdiParent = this;
            s.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
