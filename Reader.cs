using System;
using System.Net.Http;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace JStoCsharp
{
    internal class Reader
    {
        public string ReadUserName() {
            // Read the JSON
            StreamReader r = new StreamReader("passwords.json");
            string jsonString = r.ReadToEnd();
            Reader m = JsonConvert.DeserializeObject<Reader>(jsonString);

            dynamic read = JObject.Parse(jsonString);
            string userName = read.username;

            return userName;
        }

        public string ReadPassword() {
            // Read the JSON
            StreamReader r = new StreamReader("passwords.json");
            string jsonString = r.ReadToEnd();
            Reader m = JsonConvert.DeserializeObject<Reader>(jsonString);

            dynamic read = JObject.Parse(jsonString);
            string password = read.password;

            return password;
        }

        public string ReadAPILink() {
            // Read the JSON
            StreamReader r = new StreamReader("passwords.json");
            string jsonString = r.ReadToEnd();
            Reader m = JsonConvert.DeserializeObject<Reader>(jsonString);

            dynamic read = JObject.Parse(jsonString);
            string API = read.apiLink;

            return API;
        }
    }
}
