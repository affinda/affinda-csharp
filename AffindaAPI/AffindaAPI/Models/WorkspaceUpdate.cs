// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The WorkspaceUpdate. </summary>
    public partial class WorkspaceUpdate
    {
        /// <summary> Initializes a new instance of WorkspaceUpdate. </summary>
        public WorkspaceUpdate()
        {
            WhitelistIngestAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary> Visibility &quot;organization&quot; means everyone in the organization can access the workspace. Visibility &quot;private&quot; means only people explicitly added can access the workspace. </summary>
        public WorkspaceVisibility? Visibility { get; set; }
        /// <summary> If true, the uploaded document will be rejected if it&apos;s of the wrong document type, or if its document type cannot be determined. No credits will be consumed. </summary>
        public bool? RejectInvalidDocuments { get; set; }
        /// <summary> If &quot;true&quot;, parsing will fail when the uploaded document is duplicate of an existing document, no credits will be consumed. If &quot;false&quot; (default), will parse the document normally whether its a duplicate or not. </summary>
        public string RejectDuplicates { get; set; }
        /// <summary> If specified, only emails from these addresses will be ingested for parsing. Wild cards are allowed, e.g. &quot;*@eyefind.info&quot;. </summary>
        public IList<string> WhitelistIngestAddresses { get; set; }
    }
}
