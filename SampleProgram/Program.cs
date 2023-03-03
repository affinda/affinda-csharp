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
                var document = client.CreateDocument(file: fs);
                Console.WriteLine(JsonConvert.SerializeObject(document, Formatting.Indented));
            }
        }
    }
}
