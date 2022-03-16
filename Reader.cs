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
        public string ReadToken()
        {
            // This creates a new object of StreamReader, so we can READ THE .JSON Passwords.json which is hidden on Github
            StreamReader r = new StreamReader("passwords.json");
            string jsonString = r.ReadToEnd();

            // This will then DDeserialize the JSON that is saved as "string jsonString" above, then it will Parse the JSON
            Reader m = JsonConvert.DeserializeObject<Reader>(jsonString);
            dynamic read = JObject.Parse(jsonString);

            // This will then save the JSON TOKEN and only gives it's object within'
            string password = read.token;

            // This will then return the token saved as "password"
            return password;
        }

        /// <summary>
            // This does the exact same thing as what was done in the function "ReadToken()"
            // EXCEPT it'll return the API link, whihc is hidden from GIT in "passwords.json"
        /// <summary>
        public string ReadAPILink()
        {
            StreamReader r = new StreamReader("passwords.json");
            string jsonString = r.ReadToEnd();

            Reader m = JsonConvert.DeserializeObject<Reader>(jsonString);
            dynamic read = JObject.Parse(jsonString);

            string API = read.apiLink;
            
            return API;
        }
    }
}
