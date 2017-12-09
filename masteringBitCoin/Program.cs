using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NBitcoin;
using NBitcoin.BitcoinCore;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;
using System.Net;
using Newtonsoft.Json.Linq;
using System.IO;

namespace masteringBitCoin
{
    public class Program
    {
        // Using NBitcoin framework for basic tasks
        // bitcoin-cli getinfo example - Seite 49

        // Create a connection to local Bitcoin Core Node with Newtonsoft.Json library
        private static void Main(string[] args)
        {
            Console.WriteLine("Bitcoin getinfo");
            var data = RequestServer("getinfo");
            Console.WriteLine(data);
            Console.ReadKey();
        }

        //// Es fehlt noch eine Liste mit Parametern übergeben zu können bei Übergabe der Methode:
        public static string RequestServer(string methodName)
        {
            // Use the values you specified in the bitcoin server command line
            string ServerIp = "http://localhost.:8332";
            string UserName = "bitcoinrpc";
            string Password = "d0n7Blue";

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(ServerIp);
            webRequest.Credentials = new NetworkCredential(UserName, Password);

            webRequest.ContentType = "application/json-rpc";
            webRequest.Method = "POST";

            string responseValue = string.Empty;
            // Configure request type
            JObject jo = new JObject();
            jo.Add(new JProperty("jsonrpc", "1.0"));
            jo.Add(new JProperty("id", "1"));
            jo.Add(new JProperty("method", methodName));

            //// Es fehlt noch eine Liste mit Parametern übergeben zu können bei Übergabe der Methode:
            //JArray props = new JArray();
            //foreach (var parameter in parameters)
            //{
            //    props.Add(parameter);
            //}

            //joe.Add(new JProperty("params", props));

            // serialize JSON for request
            string s = JsonConvert.SerializeObject(jo);
            byte[] byteArray = Encoding.UTF8.GetBytes(s);
            webRequest.ContentLength = byteArray.Length;
            Stream dataStream = webRequest.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            // deserialze the response
            StreamReader sReader = null;
            WebResponse webResponse = webRequest.GetResponse();
            sReader = new StreamReader(webResponse.GetResponseStream(), true);
            responseValue = sReader.ReadToEnd();
            var data = JsonConvert.DeserializeObject(responseValue).ToString();
            return data;
        }
    }
}
