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
            string documentPath = "PATH_TO_DOCUMENT";
            var credential = new AffindaTokenCredential("INSERT_API_TOKEN");
            var client = new AffindaAPIClient(credential);

            // First get the organisation, by default your first one will have free credits
            var myOrganisation = client.GetAllOrganizations().Value[0];

            // And within that organisation, create a workspace, for example for Recruitment:
            var workspaceBody = new WorkspaceCreate(myOrganisation.Identifier, "My Workspace");
            var recruitmentWorkspace = client.CreateWorkspace(workspaceBody).Value;

            var collectionBody = new CollectionCreate("Resumes", recruitmentWorkspace.Identifier, "resume");
            var resumeCollection = client.CreateCollection(collectionBody).Value;

            using (FileStream fs = File.OpenRead(documentPath))
            {
                var document = client.CreateDocument(file: fs, collection: resumeCollection.Identifier);
                Console.WriteLine(JsonConvert.SerializeObject(document, Formatting.Indented));
            }
        }
    }
}
