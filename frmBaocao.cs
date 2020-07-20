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
    public partial class frmBaocao : Form
    {
        ketnoi k = new ketnoi();
        DataTable dt;
        public frmBaocao()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            
        }
        
        

        private void dgvBC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmBaocao_Load(object sender, EventArgs e)
        {
           
        }

        private void click_Click(object sender, EventArgs e)
        {
            frmVungMien n = new frmVungMien();
            n.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmTrinhDo n = new frmTrinhDo();
            n.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmKT n = new frmKT();
            n.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKL n = new frmKL();
            n.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmDoTuoi n = new frmDoTuoi();
            n.ShowDialog();
        }
    }
}
