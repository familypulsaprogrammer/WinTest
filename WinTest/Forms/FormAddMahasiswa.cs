﻿using System;
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
    public partial class FormAddMahasiswa : Form
    {
        public FormAddMahasiswa()
        {
            InitializeComponent();
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            // proses simpan data baru dan update data lama jadi satu
            // lalu close form jika berhasil
        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            // proses hapus data
            // lalu close form jika berhasil
        }

        private void FormAddMahasiswa_Load(object sender, EventArgs e)
        {
            // untuk mengisi combo box jurusan bisa di ambil dari database
        }
    }
}
