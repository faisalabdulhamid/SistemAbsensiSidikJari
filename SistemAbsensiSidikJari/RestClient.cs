using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace SistemAbsensiSidikJari
{
    public class RestClient
    {
        private HttpWebRequest request;
        private Stream dataStream;

        private string status;

        public String Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public RestClient(string url)
        {
            // Create a request using a URL that can receive a post.

            request = (HttpWebRequest) WebRequest.Create(url);
        }

        public RestClient(string url, string method) : this(url)
        {

            if (method.Equals("GET") || method.Equals("POST"))
            {
                // Set the Method property of the request to POST.
                request.Method = method;
            }
            else
            {
                throw new Exception("Invalid Method Type");
            }
        }

        public RestClient(string url, string method, string data) : this(url, method)
        {

            // Create POST data and convert it to a byte array.
            string postData = data;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "application/json";
            
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;

            // Get the request stream.
            dataStream = request.GetRequestStream();

            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);

            // Close the Stream object.
            dataStream.Close();


        }

        public string GetResponse()
        {
            // Get the original response.
            string responseFromServer = "";
            WebResponse response = request.GetResponse();

            this.Status = ((HttpWebResponse)response).StatusDescription;

            // Get the stream containing all content returned by the requested server.
            dataStream = response.GetResponseStream();
            /*
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);

            // Read the content fully up to the end.
            responseFromServer = reader.ReadToEnd();

            // Clean up the streams.
            reader.Close();
            */
            try
            {
                // Open the stream using a StreamReader for easy access;
                StreamReader reader = new StreamReader(dataStream, Encoding.UTF8);

               // Read the content fully up to the end.
               responseFromServer = reader.ReadToEnd();

               // Clean up the streams.
               reader.Close();
                
            }catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            /*
            using (StreamReader reader = new StreamReader(dataStream))
            {
                

                // Read the content fully up to the end.
                responseFromServer = reader.ReadToEnd();

                // Clean up the streams.
                reader.Close();
            }
            */
            dataStream.Close();
            response.Close();      

            return responseFromServer;
        }

    }
}
