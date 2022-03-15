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
            // Class new
            hidden hide = new hidden();

            // Variables
            string header;

            var httpRequest = (HttpWebRequest)WebRequest.Create(hide.NameReturn());

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();

            // This uses the httpResponse and when they is used it'll run the code in the Curly Braces
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                // This reads the result from using the httpResponse
                var result = streamReader.ReadToEnd();

                // This prints out the json file in CORRECT FORMAT
                Console.WriteLine(JsonConvert.DeserializeObject(result));

                // This parses the json, and only gets what we want
                dynamic stuff = JObject.Parse(result);
                header = stuff.wordle;

                // This will write what we want to the console
                Console.WriteLine(header);

                string stringJSON = Convert.ToString(result);
                returnJSON(result);
            }

            // Writes the NETWORK staus code if we succeded
            if (Convert.ToString(httpResponse.StatusCode) == "OK") {
                Console.WriteLine("Sucess!");
            } else {
                Console.WriteLine("Failiure.");
            }
        }

        public static void returnJSON(string result) {
            File file = new File();
            
            file.WriteToFile(result);
        }
    }
}
