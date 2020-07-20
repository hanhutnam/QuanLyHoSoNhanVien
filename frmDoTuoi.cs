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
    public partial class frmDoTuoi : Form
    {
        ketnoi k = new ketnoi();
        DataTable dt;
        public frmDoTuoi()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            k.LoadCSDLchoTuoithanhnien(dataGridView1);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            k.LoadCSDLchoDotuoi(dataGridView1);
        }

        private void btnTrungnien_Click(object sender, EventArgs e)
        {
            k.LoadCSDLchoTuoitrungnien(dataGridView1);
        }

        private void btnCaonien_Click(object sender, EventArgs e)
        {
            k.LoadCSDLchoTuoicaonien(dataGridView1);
        }

        private void frmDoTuoi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHoSoNVDataSet1.loaddotuoi' table. You can move, or remove it, as needed.
            this.loaddotuoiTableAdapter.Fill(this.qLHoSoNVDataSet1.loaddotuoi);

        }
    }
}
