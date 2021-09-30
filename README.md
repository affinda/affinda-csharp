.NET / C# Client Library for Affinda Resume Parser API
======================================================

![affinda logo](https://raw.githubusercontent.com/affinda/affinda-dotnet/main/affinda_logo.png)
[![license](https://img.shields.io/github/license/affinda/affinda-dotnet)](https://choosealicense.com/licenses/mit/)


[![Open in Visual Studio Code](https://open.vscode.dev/badges/open-in-vscode.svg)](https://open.vscode.dev/affinda/affinda-dotnet)

- [Installation](#installation)
- [Quickstart](#quickstart)


Generated using [autorest](https://github.com/Azure/autorest) and [autorest.csharp](https://github.com/Azure/autorest.csharp).

Installation
------------

Install from NuGet via the Visual Studio NuGet GUI or from the terminal:

```shell
dotnet add package Affinda.API --version 1.1.0
```



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
