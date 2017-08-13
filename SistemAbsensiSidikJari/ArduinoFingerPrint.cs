using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Configuration;
using SistemAbsensiSidikJari.Controller;
using Newtonsoft.Json;
using System.Net;
using System.Data;

namespace SistemAbsensiSidikJari
{
    public class ArduinoFingerPrint
    {
        SerialPort fingerprintBoard = new SerialPort();

        List<Siswa> siswaItems = new List<Siswa>();

        internal List<Siswa> SiswaItem
        {
            get { return siswaItems; }
        }

        public event EventHandler NewDataReceived;

        public void CloseArduinoConnection()
        {
            fingerprintBoard.Close();
        }

        public void OpenArduinoConnection()
        {
            if ((!fingerprintBoard.IsOpen))
            {
                fingerprintBoard.DataReceived += fingerprintBoard_DataReceived;
                fingerprintBoard.PortName = ConfigurationSettings.AppSettings["port_fingerprint"];
                fingerprintBoard.Open();
            }
            else
            {
                throw new InvalidOperationException("Port is already Open");
            }
        }

        public void openAbsensiFinger()
        {
            if (fingerprintBoard.IsOpen)
            {
                fingerprintBoard.Write("1#");
            }
            else
            {
                throw new InvalidOperationException("Can't get weather data if the serial Port is closed!");
            }
        }

        public void closeAbsensiFinger()
        {
            if (fingerprintBoard.IsOpen)
            {
                fingerprintBoard.Write("2#");
            }
            else
            {
                throw new InvalidOperationException("Can't get weather data if the serial Port is closed!");
            }
        }

        public bool isOpen()
        {
            if (fingerprintBoard.IsOpen)
            {
                return true;
            }else
            {
                return false;
            }
        }

        void fingerprintBoard_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Console.WriteLine("STATUS FINGERPRInt");
            string data = fingerprintBoard.ReadTo("\x03");
            string[] dataArray = data.Split(new string[] { "\x02", "$" }, StringSplitOptions.RemoveEmptyEntries);

            string alamat = ConfigurationSettings.AppSettings["AlamatApi"];
            
            foreach (string item in dataArray.ToList())
            {
                
                //Siswa sis = new Siswa();
                RestClient json = new RestClient(alamat + "siswa-by-id/" + item + "?api_token=$2y$10$v1njqriEy6ndnru7BuCQru4f9d2SAUpC2Cz40KlTjH7ApV78V5EUS&kategori=csharp", "POST", "api_token=$2y$10$v1njqriEy6ndnru7BuCQru4f9d2SAUpC2Cz40KlTjH7ApV78V5EUS");

                string dataSiswa = json.GetResponse();
                try
                {
                    Console.WriteLine(json.GetResponse());
                    //string djson = @"{""siswa"":{""nis"":""151610005"",""nama"":""AYU NOVIYANTI"",""telepon"": ""0897""}}";
                    Siswa siswa = new Siswa(dataSiswa);
                    siswaItems.Add(siswa);

                }
                catch (WebException)
                { }

            }

            if (NewDataReceived != null)
            {
                NewDataReceived(this, new EventArgs());
            }
        }
    }
}
