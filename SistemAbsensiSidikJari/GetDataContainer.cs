using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Configuration;

namespace SistemAbsensiSidikJari
{
    
    public class GetDataContainer
    {
        SerialPort arduinoBoard = new SerialPort();

        public event EventHandler NewDataReceived;

        public void CloseArduinoConnection()
        {
            arduinoBoard.Close();
        }

        public void OpenArduinoConnection()
        {
            if((!arduinoBoard.IsOpen))
            {
                arduinoBoard.DataReceived += arduinoBoard_DataReceived;
                arduinoBoard.PortName = ConfigurationSettings.AppSettings["ArduinoPort"];
                arduinoBoard.Open();
            }
            else
            {
                throw new InvalidOperationException("Port is already Open");
            }
        }

        public void AddFingerPrint()
        {
            if(arduinoBoard.IsOpen)
            {
                arduinoBoard.Write("1#");
            }
            else
            {
                throw new InvalidOperationException("Can't get weather data if the serial Port is closed!");
            }
        }

        public void FingerPrintAktif()
        {
            if (arduinoBoard.IsOpen)
            {
                arduinoBoard.Write("2#");
            }
            else
            {
                throw new InvalidOperationException("Can't get weather data if the serial Port is closed!");
            }
        }

        void arduinoBoard_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = arduinoBoard.ReadTo("\x03");

            if(NewDataReceived != null)
            {
                NewDataReceived(this, new EventArgs());
            }
        }
    }
}
