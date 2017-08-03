using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace SistemAbsensiSidikJari
{
    class koneksi
    {
        private string api_token, nip, nama, foto, jabatan;

        public string Api
        {
            set { api_token = value; }
            get { return api_token; }
        }

        public string Nip
        {
            set { nip = value; }
            get { return nip; }
        }

        public string Nama
        {
            set { nama = value; }
            get { return nama; }
        }

        public string Foto
        {
            set { foto = value; }
            get { return foto; }
        }

        public string Jabatan 
        {
            set { jabatan = value; }
            get { return jabatan; }
        }
    }
}
