using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SistemAbsensiSidikJari.Controller;
using System.Configuration;

namespace SistemAbsensiSidikJari.View
{
    public partial class loginForm : Form
    {
        

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            jamBerjalan.Enabled = true;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxnip.Text = "";
            textBoxpassword.Text = "";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string nip = textBoxnip.Text.ToString();
            string pass = textBoxpassword.Text.ToString();

            if (nip.Equals("") && pass.Equals(""))
            {
                MessageBox.Show("Maaf NIP Atau Password yang Anda masukkan Salah ", "PEMBERITAHUAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                string alamat = ConfigurationSettings.AppSettings["AlamatApi"];

                RestClient json = new RestClient(alamat+"login", "POST", "nip=" + nip + "&password=" + pass);

                try
                {
                    JToken token = JObject.Parse(json.GetResponse());
                    object data = (object)token.SelectToken("data");
                    object meta = (object)token.SelectToken("meta");
                    JToken jData = JObject.Parse(data.ToString());
                    JToken jMeta = JObject.Parse(meta.ToString());
                    
                    User user2 = JsonConvert.DeserializeObject<User>(jData.ToString());
                    User apitoken = JsonConvert.DeserializeObject<User>(jMeta.ToString());

                    //Console.WriteLine("nama User "+user2.Nama);
                    //Console.WriteLine("Token " + apitoken.Token);

                    MainForm mainForm = new MainForm();
                    mainForm.nip = user2.NIP;
                    mainForm.nama = user2.Nama;
                    mainForm.jabatan = user2.Jabatan;
                    mainForm.api = apitoken.Token;
                    this.Hide();
                    mainForm.Show();

                }
                catch (WebException)
                {
                    MessageBox.Show("Maaf NIP Atau Password yang Anda masukkan Salah ", "PEMBERITAHUAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
            }

        }
        
        DateTime Jam;
        private void jamBerjalan_Tick(object sender, EventArgs e)
        {
            Jam = DateTime.Now;
            labelJamBerjalan.Text = Convert.ToString(Jam.ToLongTimeString());
        }
        
    }
}
