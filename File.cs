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
    internal class File
    {
        public void WriteToFile(string result) {
            // array
            string[] stuff = { result };

            string fullPath = "something.json";

            using (StreamWriter writer = new StreamWriter(fullPath)) {
                writer.WriteLine(result);
            }
        }
    }
}
