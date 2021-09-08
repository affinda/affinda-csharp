

Parser
------

### createResume - Uploads a resume for parsing

```c#
using System;
using System.IO;
using Affinda.API;
using Affinda.API.Models;

string resumePath = "PATH_TO_RESUME";
using (FileStream fs = File.OpenRead(resumePath))
{
    var credential = new AffindaTokenCredential("REPLACE_TOKEN");
    var client = new AffindaAPIClient(credential);
    var resume = client.CreateResume(file: fs);
}
```

Redactor
--------

Reformatter
-----------