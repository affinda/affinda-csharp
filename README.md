.NET / C# Client Library for Affinda Resume Parser API
======================================================

![affinda logo](https://raw.githubusercontent.com/affinda/affinda-dotnet/master/affinda_logo.png)
[![license](https://img.shields.io/github/license/affinda/affinda-dotnet)](https://choosealicense.com/licenses/mit/)

[![Open in Visual Studio Code](https://open.vscode.dev/badges/open-in-vscode.svg)](https://open.vscode.dev/affinda/affinda-dotnet)

- [Installation](#installation)
- [Quickstart](#quickstart)

Generated using [autorest](https://github.com/Azure/autorest)
and [autorest.csharp](https://github.com/Azure/autorest.csharp).

*NOTE: You are viewing a deprecated version of the documentation, this release is only compatible with `v2` of the
Affinda API. Please go to [the master branch](https://github.com/affinda/affinda-dotnet/tree/master) to view the
latest revision.*


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
| v2                  | 0.1.0 - 3.x.x             |
| v3                  | \>= 4.x.x                 |

Quickstart
----------

```C#
using System;
using System.IO;
using Affinda.API;
using Affinda.API.Models;

...

string resumePath = "PATH_TO_RESUME";
using (FileStream fs = File.OpenRead(resumePath))
{
    var credential = new AffindaTokenCredential("REPLACE_TOKEN");
    var client = new AffindaAPIClient(credential);
    var resume = client.CreateResume(file: fs);
}
```

An example project is provided [here](./SampleProgram/SampleProgram.csproj)

Further examples can be found [here](./docs/samples_csharp.md)
