.NET / C# Client Library for Affinda Resume Parser API
======================================================

![affinda logo](https://raw.githubusercontent.com/affinda/affinda-dotnet/master/affinda_logo.png)
[![license](https://img.shields.io/github/license/affinda/affinda-dotnet)](https://choosealicense.com/licenses/mit/)

[![Open in Visual Studio Code](https://open.vscode.dev/badges/open-in-vscode.svg)](https://open.vscode.dev/affinda/affinda-dotnet)

- [Installation](#installation)
- [Quickstart](#quickstart)

Generated using [autorest](https://github.com/Azure/autorest)
and [autorest.csharp](https://github.com/Azure/autorest.csharp).

Installation
------------

Install from NuGet via the Visual Studio NuGet GUI or from the terminal:

```shell
dotnet add package Affinda.API
```

API Version Compatibility
-------------------------

The Affinda API is currently on `v3`, with breaking changes meant the release of new versions of the client library.
Please see below for which versions are compatible with which API version.

| Affinda API version | `affinda-dotnet` versions |
|---------------------|---------------------------|
| v2                  | 0.1.0 - 4.x.x             |
| v3                  | \>= 5.x.x                 |

Quickstart
----------

```C#
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
```

An example project is provided [here](./SampleProgram/SampleProgram.csproj)

Further examples can be found [here](./docs/samples_csharp.md)
