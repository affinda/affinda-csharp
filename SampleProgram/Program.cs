using System;
using System.IO;
using Affinda.API;
using Newtonsoft.Json;

namespace AffindaAPISample
{
    class Program
    {
        static void Main(string[] args)
        {
            string documentPath = "PATH_TO_DOCUMENT";
            using (FileStream fs = File.OpenRead(documentPath))
            {
                var credential = new AffindaTokenCredential("REPLACE_TOKEN");
                var client = new AffindaAPIClient(credential);
                var resume = client.CreateResume(file: fs);
                Console.WriteLine(JsonConvert.SerializeObject(resume, Formatting.Indented));
            }
        }
    }
}
