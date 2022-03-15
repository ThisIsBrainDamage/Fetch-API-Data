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
            httpRequest.Headers.Add("username", "JustGetGoodBro");
            httpRequest.Headers.Add("password", "Password123");

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();

            try {
                // This uses the httpResponse and when they is used it'll run the code in the Curly Braces
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    // This reads the result from using the httpResponse
                    var result = streamReader.ReadToEnd();

                    // This prints out the json file in CORRECT FORMAT
                    Console.WriteLine(JsonConvert.DeserializeObject(result));

                    string stringJSON = Convert.ToString(result);
                    returnJSON(result);
                }
            } catch (Exception e) {
                Console.WriteLine(e);
            } finally {
                if(Convert.ToString(httpResponse.StatusCode) == "OK") {
                    Console.WriteLine("Success!");
                } else {
                    Console.WriteLine("Could not fetch data from API");
                }
            }

            // Writes the NETWORK staus code if we succeded
            if (Convert.ToString(httpResponse.StatusCode) == "OK") {
                Console.WriteLine("Success!");
            } else {
                try {
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream())) {
                        var result = streamReader.ReadToEnd();

                        // This prints out the json file in CORRECT FORMAT
                        Console.WriteLine(JsonConvert.DeserializeObject(result));

                        string stringJSON = Convert.ToString(result);
                        returnJSON(result);
                    }
                } catch (Exception e) {
                    Console.WriteLine(e);
                } finally {
                    if (Convert.ToString(httpResponse.StatusCode) == "OK") {
                        Console.WriteLine("Success!");
                    } else {
                        Console.WriteLine("Could not fetch data from API");
                    }
                }
            }
        }

        public static void returnJSON(string result) {
            File file = new File();
            
            file.WriteToFile(result);
        }
    }
}
