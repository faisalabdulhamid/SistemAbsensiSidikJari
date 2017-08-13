using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Configuration;

namespace SistemAbsensiSidikJari
{
    public class ArduinoSim900A
    {
        SerialPort sim900aBoard = new SerialPort();

        public event EventHandler NewDataReceived;

        public void CloseArduinoConnection()
        {
            sim900aBoard.Close();
        }

        public void OpenArduinoConnection()
        {
            if ((!sim900aBoard.IsOpen))
            {
                //sim900aBoard.DataReceived += sim900aBoard_DataReceived;
                sim900aBoard.PortName = ConfigurationSettings.AppSettings["port_sim_900a"];
                sim900aBoard.Open();
            }
            else
            {
                throw new InvalidOperationException("Port is already Open");
            }
        }

        public void sendSMS(String jsonSms)
        {
            if (sim900aBoard.IsOpen)
            {
                sim900aBoard.Write(jsonSms);
            }
            else
            {
                throw new InvalidOperationException("Can't get weather data if the serial Port is closed!");
            }
        }

        public void arduinoBoard_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = sim900aBoard.ReadTo("\x03");//Read until the EOT code
            //Split into 'date=temparature' formatted text
            string[] dataArray = data.Split(new string[] { "\x02", "$" }, StringSplitOptions.RemoveEmptyEntries);
            //Iterate through the splitted data and parse it into weather data items
            //and add them to the list of received weather data.
            Console.WriteLine("status SMS");
            foreach (string dataItem in dataArray.ToList())
            {
                Console.Write(dataItem);
            }
            if (NewDataReceived != null)//If there is someone waiting for this event to be fired
            {
                NewDataReceived(this, new EventArgs()); //Fire the event, indicating that new WeatherData was added to the list.
            }
        }
    }
}
