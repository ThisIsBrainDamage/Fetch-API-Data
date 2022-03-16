using System;
using System.Net.Http;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Specialized;

namespace JStoCsharp
{
    internal class Program
    {
        // MAIN method, this is the first method that is called when the program is written
        static void Main(string[] args)
        {
            // This calls the class and save the response to a string called "token"
            Reader read = new Reader();
            string token = read.ReadToken();

            // This creates a HttpRequest, adds a header, and gets the response, in that order
            var httpRequest = (HttpWebRequest)WebRequest.Create(read.ReadAPILink());
            httpRequest.Headers.Add("Authorization", token);
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();

            /// <summary>
                // This uses the Streamreader class, gets the response and saves it as a variables "Result"
                // This will then write the 'Result' to the Console
                // it will then convert the 'Result' to a string
                // It will the call the function "Return JSON"
            /// </summary>
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                Console.WriteLine(JsonConvert.DeserializeObject(result));
                string stringJSON = Convert.ToString(result);
                ReturnJSON(result);
            }
        }

        /// <summary>
            // This will take the 'Result" as a parameter, then it will call the class "File" 
            // GO TO FILE FOR MORE COMMENTS
        /// <summary>
        public static void ReturnJSON(string result)
        {
            File file = new File();
            file.WriteToFile(result);
        }
    }
}
