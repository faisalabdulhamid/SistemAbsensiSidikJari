using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SistemAbsensiSidikJari.Controller;
using System.Net;
using System.IO.Ports;

namespace SistemAbsensiSidikJari.View
{
    public partial class MainForm : Form
    {
        public string api, nama, jabatan, nip;
        User user;
        public bool set_port = false;
        public bool sms_starter = false;

        public MainForm()
        {
            InitializeComponent();
            user = new User();

            if(set_port == false)
            {
                btnConnect.Text = "Connect";
                btnFalse();
            }
            else
            {
                btnConnect.Text = "Disconnect";
                btnTrue();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            jamBerjalan.Enabled = true;
            labelSelamat.Text = "Selamat Datang "+this.nama;

            dataSiswa();
            dataGuru();
            dataAbsensi();
            getPort();
        }

        private void btnTambahSiswa_Click(object sender, EventArgs e)
        {
            FormSiswa ts = new FormSiswa();
            ts.Text = "Tambah Siswa";
            ts.status = "tambah";
            ts.ShowDialog();
        }

        private void btnEditSiswa_Click(object sender, EventArgs e)
        {
            FormSiswa ts = new FormSiswa();
            ts.Text = "Ubah Siswa";
            ts.tbNis.ReadOnly = true;
            ts.status = "ubah";
            int row_index =  this.dgSiswa.SelectedRows[0].Index;

            ts.tbNis.Text = this.dgSiswa.Rows[row_index].Cells[0].Value.ToString();
            ts.tbNama.Text = this.dgSiswa.Rows[row_index].Cells[1].Value.ToString();
            ts.cbJenisKelamin.Text = this.dgSiswa.Rows[row_index].Cells[2].Value.ToString();
            ts.tbTempatLahir.Text = this.dgSiswa.Rows[row_index].Cells[3].Value.ToString();
            ts.tbTanggalLahir.Text = this.dgSiswa.Rows[row_index].Cells[4].Value.ToString();
            ts.cbAgama.Text = this.dgSiswa.Rows[row_index].Cells[5].Value.ToString();
            ts.cbWarganegara.Text = this.dgSiswa.Rows[row_index].Cells[6].Value.ToString();
            ts.rtALamat.Text = this.dgSiswa.Rows[row_index].Cells[7].Value.ToString();
            ts.tbAyah.Text = this.dgSiswa.Rows[row_index].Cells[8].Value.ToString();
            ts.tbIbu.Text = this.dgSiswa.Rows[row_index].Cells[9].Value.ToString();
            ts.tbTelepon.Text = this.dgSiswa.Rows[row_index].Cells[10].Value.ToString();
            ts.cbKelas.Text = this.dgSiswa.Rows[row_index].Cells[11].Value.ToString();
            
            ts.ShowDialog();
        }

        DateTime Jam;
        private void jamBerjalan_Tick(object sender, EventArgs e)
        {
            Jam = DateTime.Now;
            labelJamBerjalan.Text = Convert.ToString(Jam.ToLongTimeString());
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            AbsensiForm absen = new AbsensiForm();
            absen.status = "masuk";
            absen.api = this.api;
            absen.ShowDialog();
            if(absen.DialogResult == DialogResult.OK)
            {
                serialPort.Write("3");
                MainForm_Load(sender.ToString(), EventArgs.Empty);
            }
        }

        private void btnIzin_Click(object sender, EventArgs e)
        {
            AbsensiForm absen = new AbsensiForm();
            absen.status = "izin";
            absen.api = this.api;
            absen.ShowDialog();
            if (absen.DialogResult == DialogResult.OK)
            {
                MainForm_Load(sender.ToString(), EventArgs.Empty);
            }
        }

        private void btnSakit_Click(object sender, EventArgs e)
        {
            AbsensiForm absen = new AbsensiForm();
            absen.status = "sakit";
            absen.api = this.api;
            absen.ShowDialog();
            if (absen.DialogResult == DialogResult.OK)
            {
                MainForm_Load(sender.ToString(), EventArgs.Empty);
            }
        }

        private void btnAlpa_Click(object sender, EventArgs e)
        {
            AbsensiForm absen = new AbsensiForm();
            absen.status = "alpa";
            absen.api = this.api;
            absen.ShowDialog();
            if (absen.DialogResult == DialogResult.OK)
            {
                serialPort.Write("2");
                MainForm_Load(sender.ToString(), EventArgs.Empty);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string port = cbPort.Text;
            if (port.Equals(""))
            {
                MessageBox.Show("Anda Belum Memilih Port Arduino");
            }
            else
            {
                if (set_port == false)
                {
                    set_port = true;
                    btnConnect.Text = "Disconnect";
                    cbPort.Enabled = false;
                    btnTrue();
                    serialPort.PortName = cbPort.Text;
                    serialPort.BaudRate = 9600;
                    serialPort.Open();
                    Console.WriteLine(serialPort.ReadLine());

                }
                else
                {
                    set_port = false;
                    btnConnect.Text = "Connect";
                    cbPort.Enabled = true;
                    btnFalse();
                    serialPort.Close();
                    sms_starter = false;
                }

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getPort();
        }

        void dataSiswa()
        {
            RestClient json = new RestClient("http://sidik-jari.laravel/api/siswa?api_token="+this.api, "POST", "api_token="+this.api);
            try
            {
                DataSet setSiswa = JsonConvert.DeserializeObject<DataSet>(json.GetResponse());
                DataTable dataSiswa = setSiswa.Tables["data"];
                dgSiswa.DataSource = null;
                dgSiswa.Columns.Clear();
                dgSiswa.DataSource = dataSiswa;
                dgSiswa.Columns[0].HeaderText = "NIS";
                dgSiswa.Columns[1].HeaderText = "Nama";
                dgSiswa.Columns[2].HeaderText = "Jenis Kelamin";
                dgSiswa.Columns[3].HeaderText = "Tempat Lahir";
                dgSiswa.Columns[4].HeaderText = "Tanggal Lahir";
                dgSiswa.Columns[5].HeaderText = "Agama";
                dgSiswa.Columns[6].HeaderText = "Warganegara";
                dgSiswa.Columns[7].HeaderText = "Alamat";
                dgSiswa.Columns[8].HeaderText = "Ayah";
                dgSiswa.Columns[9].HeaderText = "Ibu";
                dgSiswa.Columns[10].HeaderText = "Kelas";
                dgSiswa.Columns[11].HeaderText = "Foto";

                dgSiswa.Columns[3].Visible = false;
                dgSiswa.Columns[5].Visible = false;
                dgSiswa.Columns[6].Visible = false;
                dgSiswa.Columns[7].Visible = false;
                dgSiswa.Columns[8].Visible = false;
                dgSiswa.Columns[9].Visible = false;
                dgSiswa.Columns[10].Visible = false;
                dgSiswa.Columns[11].Visible = false;
                dgSiswa.Columns[12].Visible = false;
                dgSiswa.Columns[13].Visible = false;

            }
            catch (WebException)
            {}
        }

        void dataGuru()
        {
            RestClient json = new RestClient("http://sidik-jari.laravel/api/guru?api_token=" + this.api, "POST", "api_token=" + this.api);
            try
            {
                DataSet setGuru = JsonConvert.DeserializeObject<DataSet>(json.GetResponse());
                DataTable dataGuru = setGuru.Tables["data"];
                dgGuru.DataSource = null;
                dgGuru.Columns.Clear();
                dgGuru.DataSource = dataGuru;
                dgGuru.Columns[0].HeaderText = "NIP";
                dgGuru.Columns[1].HeaderText = "Nama";
                dgGuru.Columns[2].HeaderText = "Jabatan";
                dgGuru.Columns[3].HeaderText = "Foto";

                dgGuru.Columns[3].Visible = false;
                dgGuru.Columns[2].Visible = false;

            }
            catch (WebException)
            { }
        }

        void dataAbsensi()
        {
            RestClient json = new RestClient("http://sidik-jari.laravel/api/absensi-data?api_token=" + this.api, "POST", "api_token=" + this.api);
            try
            {
                DataSet setAbsensi = JsonConvert.DeserializeObject<DataSet>(json.GetResponse());
                DataTable dataGuru = setAbsensi.Tables["data"];
                dgAbsensi.DataSource = null;
                dgAbsensi.Columns.Clear();
                dgAbsensi.DataSource = dataGuru;
                dgAbsensi.Columns[0].HeaderText = "NIS / NIP";
                dgAbsensi.Columns[1].HeaderText = "Nama";
                dgAbsensi.Columns[2].HeaderText = "Jam Masuk";
                dgAbsensi.Columns[3].HeaderText = "Keterangan";

            }
            catch (WebException)
            { }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
                serialPort.Close();
        }

        void getPort()
        {
            cbPort.Items.Clear();
            String[] ports = SerialPort.GetPortNames();

            cbPort.Items.AddRange(ports);
        }
        
        void btnFalse()
        {
            btnMasuk.Enabled = false;
            btnSakit.Enabled = false;
            btnIzin.Enabled = false;
            btnAlpa.Enabled = false;

            btnTambahSiswa.Enabled = false;
            btnTambahGuru.Enabled = false;
            btnEditSiswa.Enabled = false;
            btnEditGuru.Enabled = false;
        }

        void btnTrue()
        {
            btnMasuk.Enabled = true;
            btnSakit.Enabled = true;
            btnIzin.Enabled = true;
            btnAlpa.Enabled = true;

            btnTambahSiswa.Enabled = true;
            btnTambahGuru.Enabled = true;
            btnEditSiswa.Enabled = true;
            btnEditGuru.Enabled = true;

        }
    }
}
