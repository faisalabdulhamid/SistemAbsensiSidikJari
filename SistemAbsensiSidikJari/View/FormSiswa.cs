using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemAbsensiSidikJari.View
{
    public partial class FormSiswa : Form
    {
        public string status = "";
        public FormSiswa()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //tbNis.Text = "";
            tbNama.Text = "";
            tbTanggalLahir.Text = "";
            tbTempatLahir.Text = "";
            tbAyah.Text = "";
            tbIbu.Text = "";
            cbAgama.Text = "";
            cbJenisKelamin.Text = "";
            cbKelas.Text = "";
            cbWarganegara.Text = "";
            tbTelepon.Text = "";
            rtALamat.Text = "";
        }

        private void FormSiswa_Load(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if(status == "tambah")
            {

                this.Hide();
            }
            else if(status == "ubah")
            {
                this.Hide();
            }
        }
    }
}
