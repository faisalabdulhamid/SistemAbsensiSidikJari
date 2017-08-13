using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemAbsensiSidikJari.Controller
{
    
    public class Siswa
    {
        public Siswa()
        {

        }

        public Siswa(string json)
        {
            try
            {
                JObject jObject = JObject.Parse(json);
                JToken jSiswa = jObject["siswa"];
                nis = (string)jSiswa["nis"];
                nama = (string)jSiswa["nama"];
                telepon = (string)jSiswa["telepon"];
            }
            catch(JsonReaderException e) {
                Console.WriteLine(e.Message);
            }

        }
        public string nama { get; set; }
        public string telepon { get; set; }
        public string nis { get; set; }
    }
}
