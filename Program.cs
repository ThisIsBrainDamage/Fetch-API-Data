using System;
using System.Net.Http;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JStoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string header;
            string innerHeader;
            var url = "https://fusionsidapi.herokuapp.com/api/wordle/";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();

            // This uses the httpResponse and when they is used it'll run the code in the Curly Braces
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();

                /*
                Console.WriteLine(JsonConvert.DeserializeObject(result));
                */

                dynamic stuff = JObject.Parse(result);
                header = stuff.wordle;

                Console.WriteLine(header);
            }
        }
    }
}
