using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTest
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void CARI_TextChanged(object sender, EventArgs e)
        {
            // lalukan pencarian di event ini, search bynama
        }

        private void jurusanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // masuk ke form data master jurusan
        }

        private void btnREFRESH_Click(object sender, EventArgs e)
        {
            // refresh data dan untuk merefresh periode tanggal
        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            // panggil form add mahasiswa
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // buat event jika datetime2 tidak
        }
    }
}
