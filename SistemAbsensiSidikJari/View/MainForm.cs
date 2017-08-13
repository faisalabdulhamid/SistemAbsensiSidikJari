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
using System.Configuration;
using System.Threading;


namespace SistemAbsensiSidikJari.View
{
    public partial class MainForm : Form
    {
        public string api, nama, jabatan, nip;
        public string kelas = "all";
        

        User user;

        //GetDataContainer fingerData = new GetDataContainer();
        ArduinoFingerPrint finger = new ArduinoFingerPrint();
        ArduinoSim900A sim900 = new ArduinoSim900A();
        //Siswa siswa = new Siswa();

        public MainForm()
        {
            InitializeComponent();
            user = new User();

            sim900.NewDataReceived += data_NewDataReceivedSim900;
            try
            {
                sim900.OpenArduinoConnection();
            }
            catch
            {
                MessageBox.Show("Error: Can not connect to the Arduino Board - Configure the COM Port in the app.config file and check whether an Arduino Board is connected to your computer.");
            }

            finger.NewDataReceived += data_NewDataReceived;
            try
            {
                finger.OpenArduinoConnection();
            }
            catch
            {
                MessageBox.Show("Error: Can not connect to the Arduino Board - Configure the COM Port in the app.config file and check whether an Arduino Board is connected to your computer.");
            }
        }

        //FROM ARDUINO FINGERPRINT
        void data_NewDataReceived(object sender, EventArgs e)
        {
            //Console.WriteLine("Data Received");
            Thread t = new Thread(() => SmsOrangTua(this, EventArgs.Empty));
            t.Start();
            
        }

        void data_NewDataReceivedSim900(object sender, EventArgs e)
        {

            //Thread t = new Thread(() => ButtonAktif());
            //t.Start();

        }
        private void SmsOrangTua(object sender, EventArgs e)
        {
            Console.WriteLine("SMS Orang Tua");
            foreach (Siswa sis in finger.SiswaItem)
            {
                Console.WriteLine(sis.nis);
                Console.WriteLine(sis.nama);
                Console.WriteLine(sis.telepon);

                //Post Data
                Thread postData = new Thread(() => PostDataAbsensi(this, EventArgs.Empty, sis.nis));
                postData.Start();

                SMS sms = new SMS();
                sms.n = sis.nama;
                sms.t = sis.telepon;
                
                string smsJson = JsonConvert.SerializeObject(sms) + "#";
                Console.WriteLine(smsJson);
                sim900.sendSMS(smsJson);
            }
        }

        private void PostDataAbsensi(object sender, EventArgs e, string nis)
        {
            string alamat = ConfigurationSettings.AppSettings["AlamatApi"];

            RestClient json = new RestClient(alamat + "absensi?api_token=" + this.api, "POST", "api_token=" + this.api + "&keterangan=masuk&nis=" + nis);

            //RestClient json = new RestClient("http://sidik-jari.laravel/api/absensi?api_token" + this.api, "POST", "api_token=" + this.api + "&keterangan=" + this.status + "&nis=" + txtNis.Text.ToString());
            try
            {

                JToken token = JObject.Parse(json.GetResponse());
                object saved = (object)token.SelectToken("saved");
                Console.WriteLine(saved.ToString());
            }
            catch (WebException)
            { }
        }

        private void ButtonAktif()
        {
            Console.WriteLine("Button Aktif");
            btnMasuk.Enabled = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            jamBerjalan.Enabled = true;
            labelSelamat.Text = "Selamat Datang "+this.nama;

            dataSiswa();
            dataGuru();
            dataAbsensi();
            dataKelas();

            if (finger.isOpen())
            {
                btnMasuk.Enabled = true;
                //btnNotAktif.Enabled = false;
            }
            else
            {
                btnMasuk.Enabled = false;
                //btnNotAktif.Enabled = true;
            }

            
        }

        //Tambah Finger Print
        private void btnFinger_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            finger.openAbsensiFinger();

            btnNotAktif.Enabled = true;
            btnMasuk.Enabled = false;

        }

        private void btnNotAktif_Click(object sender, EventArgs e)
        {
            finger.closeAbsensiFinger();
            btnNotAktif.Enabled = false;
            btnMasuk.Enabled = true;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string[] kls = cbkelas.Text.Split('-');

            this.kelas = kls[0];
            dataSiswa();
        }

        void dataSiswa()
        {
            string alamat = ConfigurationSettings.AppSettings["AlamatApi"];

            RestClient json = new RestClient(alamat+"siswa?api_token=" +this.api+"&kelas="+this.kelas, "POST", "api_token="+this.api);
            try
            {
                //Console.WriteLine(json.GetResponse());
                DataSet setSiswa = JsonConvert.DeserializeObject<DataSet>(json.GetResponse());
                DataTable dataSiswa = setSiswa.Tables["data"];
                dgSiswa.DataSource = null;
                dgSiswa.Columns.Clear();
                dgSiswa.DataSource = dataSiswa;
                dgSiswa.Columns[0].HeaderText = "NIS";
                dgSiswa.Columns[1].HeaderText = "Nama";
                dgSiswa.Columns[2].HeaderText = "Jenis Kelamin";
                dgSiswa.Columns[3].HeaderText = "Kelas";
                dgSiswa.Columns[4].HeaderText = "Finger";
                dgSiswa.Columns[5].HeaderText = "Foto";

                
                dgSiswa.Columns[5].Visible = false;
                dgSiswa.Columns[4].Visible = false;
                

            }
            catch (WebException)
            {}
        }

        void dataGuru()
        {
            string alamat = ConfigurationSettings.AppSettings["AlamatApi"];

            RestClient json = new RestClient(alamat+"guru?api_token=" + this.api, "POST", "api_token=" + this.api);
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
            string alamat = ConfigurationSettings.AppSettings["AlamatApi"];
            RestClient json = new RestClient(alamat+"absensi-data?api_token=" + this.api, "POST", "api_token=" + this.api);
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

        void dataKelas()
        {
            
            string alamat = ConfigurationSettings.AppSettings["AlamatApi"];
            //string
            RestClient json = new RestClient(alamat + "kelas?api_token=" + this.api+ "&kategori=csharp", "POST", "api_token=" + this.api);
            try
            {
                cbkelas.Items.Clear();
                //string data = "[1,2,3]";
                cbkelas.DataSource = JsonConvert.DeserializeObject<IEnumerable<string>>(json.GetResponse());
            }
            catch(WebException)
            { }
        }
        private void dgSiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currRow = int.Parse(e.RowIndex.ToString());
            Console.WriteLine(currRow);
            Console.WriteLine(this.dgSiswa.Rows[currRow].Cells[1].Value.ToString());
            Console.WriteLine(this.dgSiswa.Rows[currRow].Cells[4].Value.ToString());
            if (this.dgSiswa.Rows[currRow].Cells[4].Value.ToString() == "0")
            {
                btnFinger.Enabled = true;
            }
            else
            {
                btnFinger.Enabled = false;
            }
            //Console.WriteLine(dgSiswa.Columns[4].Row)
        }
        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            finger.CloseArduinoConnection();
            sim900.CloseArduinoConnection();
        }

        DateTime Jam;
        private void jamBerjalan_Tick(object sender, EventArgs e)
        {
            Jam = DateTime.Now;
            labelJamBerjalan.Text = Convert.ToString(Jam.ToLongTimeString());
        }
        
    }
}
