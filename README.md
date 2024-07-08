# .NET / C# Client Library for Affinda Resume Parser API

![affinda logo](https://api.affinda.com/static/documentation/affinda_logo_light.png)
[![license](https://img.shields.io/github/license/affinda/affinda-dotnet)](https://choosealicense.com/licenses/mit/)

[![Open in Visual Studio Code](https://open.vscode.dev/badges/open-in-vscode.svg)](https://open.vscode.dev/affinda/affinda-dotnet)


- [Installation](#installation)
- [API Version Compatibility](#api-version-compatibility)
- [Quickstart](#quickstart)
- [Examples](#examples)
- [Serializing custom request bodies](#serializing-custom-request-bodies)


Generated using [autorest](https://github.com/Azure/autorest)
and [autorest.csharp](https://github.com/Azure/autorest.csharp).

## Installation

Install from NuGet via the Visual Studio NuGet GUI or from the terminal:

```shell
dotnet add package Affinda.API
```

## API Version Compatibility

The Affinda API is currently on `v3`, with breaking changes meant the release of new versions of the client library.
Please see below for which versions are compatible with which API version.

| Affinda API version | `affinda-dotnet` versions |
| ------------------- | ------------------------- |
| v2                  | 0.1.0 - 4.x.x             |
| v3                  | \>= 5.x.x                 |

## Quickstart

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

## Examples

An example project is provided [here](./SampleProgram/SampleProgram.csproj)

Further examples can be found [here](./docs/samples_csharp.md)

## Serializing custom request bodies

Some endpoints accept a request body that's too flexible for Autorest to type precisely.
Normally, this is indicated by a body parameter of type `object`.
Due to limitations of Autorest's JSON serialization, you can't pass arbitrary data classes as body parameters directly.
Instead, we provide `Utf8JsonAdapter` to integrate `System.Text.Json` into Autorest's serialization.
To pass a custom data object to the client library, you simply need to wrap it in `Utf8JsonAdapter`.
For example:

```csharp
class Data
{
    // System.Text.Json annotations will work here
    public string Label { get; set; }
    public string Value { get; set; }
}

void MakeAwesomeApiRequest(AffindaAPIClient client)
{
    var data = new Data[]
    {
        new Data { Label = "Name", Value = "John Doe" },
        new Data { Label = "Email", Value = "john@doe.com" },
    };

    // Can also provide a JsonSerializerOptions instance to customise behaviour
    var body = new Utf8JsonAdapter<Data[]>(data);

    // void MakeAwesomeRequest(object body);
    client.MakeAwesomeRequest(body);
}
```
