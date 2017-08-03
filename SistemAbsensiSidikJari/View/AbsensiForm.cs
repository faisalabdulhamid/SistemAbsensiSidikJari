using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json.Linq;


namespace SistemAbsensiSidikJari.View
{
    public partial class AbsensiForm : Form
    {
        public string status = "";
        public string api = "";
        public bool reset = false;
        public AbsensiForm()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nis = txtNis.Text;
            if (nis.Equals(""))
            {
                MessageBox.Show("Nis Tidak Boleh Kosong");
            }

            RestClient json = new RestClient("http://sidik-jari.laravel/api/absensi?api_token" + this.api, "POST", "api_token=" + this.api + "&keterangan=" + this.status + "&nis=" + txtNis.Text.ToString());
            try
            {
                
                JToken token = JObject.Parse(json.GetResponse());
                object saved = (object)token.SelectToken("saved");
                Console.WriteLine(saved.ToString());
                if(saved.ToString() == "True")
                {
                    this.reset = true;
                }
            }
            catch(WebException)
            { }

            if(reset)
            {
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
        }
    }
}
