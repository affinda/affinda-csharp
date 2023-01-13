

Resume Parser
-------------

### createResume - Upload a resume for parsing

```c#
using System;
using System.IO;
using Affinda.API;
using Affinda.API.Models;

string resumePath = "path_to_file.pdf";
using (FileStream fs = File.OpenRead(resumePath))
{
    var credential = new AffindaTokenCredential("REPLACE_TOKEN");
    var client = new AffindaAPIClient(credential);
    var resume = client.CreateResume(file: fs);
}
```

Resume Redactor
---------------

Search & Match - Searching
--------------------------

Search & Match - Embedding
--------------------------

Job Description Parser
----------------------

### createJobDescription - Upload a job description for parsing

```c#
using System;
using System.IO;
using Affinda.API;
using Affinda.API.Models;

string resumePath = "path_to_file.pdf";
using (FileStream fs = File.OpenRead(resumePath))
{
    var credential = new AffindaTokenCredential("REPLACE_TOKEN");
    var client = new AffindaAPIClient(credential);
    var job_description = client.CreateJobDescription(file: fs);
}
```

Search & Match - Indexing
-------------------------

Invoice Extractor
-----------------

### createInvoice - Upload an invoice for parsing

```c#
using System;
using System.IO;
using Affinda.API;
using Affinda.API.Models;

string resumePath = "path_to_file.pdf";
using (FileStream fs = File.OpenRead(resumePath))
{
    var credential = new AffindaTokenCredential("REPLACE_TOKEN");
    var client = new AffindaAPIClient(credential);
    var resume = client.CreateResume(file: fs);
}
```

Users
-----