

Search & Match - Searching
--------------------------

Search & Match - Embedding
--------------------------

Search & Match - Indexing
-------------------------

Organization & User - Organization
----------------------------------

Organization & User - Membership
--------------------------------

Organization & User - Invitation
--------------------------------

Document API - Extractor
------------------------

Document API - Data Point
-------------------------

Document API - Workspace
------------------------

Document API - Collection
-------------------------

Document API - Upload Documents
-------------------------------

### getDocument - Get specific document

```c#
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
            var credential = new AffindaTokenCredential("REPLACE_TOKEN");
            var client = new AffindaAPIClient(credential);
            var response = client.GetDocument(identifier: "REPLACE_RESUME_IDENTIFIER");

            // Depend on whether the document you're getting is a resume/invoice/job description,
            // you can cast the value to ResumeDocument, InvoiceDocument or JobDescriptionDocument
            var resume = (ResumeDocument) response.Value;

            // Example: print the candidate's raw name
            Console.WriteLine(resume.Data.Name.Raw);
        }
    }
}
```

Document API - Tag
------------------

Webhook
-------