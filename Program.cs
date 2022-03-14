using System;
using System.Net.Http;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace JStoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var url = "https://fusionsidapi.herokuapp.com/api/wordle/";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);


            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                Console.WriteLine(result);

                
            }
        }
    }
}
