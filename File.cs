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
            // This is the path of "something.json" which is hidden from git
            string fullPath = "something.json";

            /// <summary>
                // This is using the StreamWriter class, going to the File path, then it will write the result to something.json
                // WHICH IS HIDDEN FROM GIT
            /// </summary>
            using (StreamWriter writer = new StreamWriter(fullPath)) {
                writer.WriteLine(result);
            }
        }
    }
}
