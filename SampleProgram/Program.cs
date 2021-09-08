using System;
using System.IO;
using Affinda.API;
using Affinda.API.Models;
using Newtonsoft.Json;

namespace AffindaAPISample
{
    class Program
    {
        static void Main(string[] args)
        {
            string resumePath = "PATH_TO_RESUME";
            using (FileStream fs = File.OpenRead(resumePath))
            {
                var credential = new AffindaTokenCredential("REPLACE_TOKEN");
                var client = new AffindaAPIClient(credential);
                var resume = client.CreateResume(file: fs);
                Console.WriteLine(JsonConvert.SerializeObject(resume, Formatting.Indented));
            }
        }
    }
}
