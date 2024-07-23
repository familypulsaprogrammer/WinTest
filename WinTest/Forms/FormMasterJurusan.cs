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
    public partial class FormMasterJurusan : Form
    {
        public FormMasterJurusan()
        {
            InitializeComponent();
        }

        private void CARI_TextChanged(object sender, EventArgs e)
        {
            // lalukan pencarian di event ini
        }

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            // buka form untuk add jurusan, dengan from master jurusan
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // buka form detail dari jurusan, dengan from master jurusan
        }
    }
}
