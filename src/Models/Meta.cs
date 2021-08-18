// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace affinda.Models
{
    /// <summary> The Meta. </summary>
    public partial class Meta
    {
        /// <summary> Initializes a new instance of Meta. </summary>
        /// <param name="identifier"> Unique identifier for the resume. If creating a document and left blank, one will be automatically generated. </param>
        /// <param name="ready"> If true, the document has finished processing. Particularly useful if an endpoint request specified wait=False, when polling use this variable to determine when to stop polling. </param>
        /// <param name="failed"> If true, some exception was raised during processing. Check the &apos;error&apos; field of the main return object. </param>
        internal Meta(string identifier, bool ready, bool failed)
        {
            Identifier = identifier;
            Ready = ready;
            Failed = failed;
        }

        /// <summary> Initializes a new instance of Meta. </summary>
        /// <param name="identifier"> Unique identifier for the resume. If creating a document and left blank, one will be automatically generated. </param>
        /// <param name="fileName"> Optional filename of the file. </param>
        /// <param name="ready"> If true, the document has finished processing. Particularly useful if an endpoint request specified wait=False, when polling use this variable to determine when to stop polling. </param>
        /// <param name="readyDt"> The datetime when the document was ready. </param>
        /// <param name="failed"> If true, some exception was raised during processing. Check the &apos;error&apos; field of the main return object. </param>
        /// <param name="expiryTime"> The date/time in ISO-8601 format when the resume will be automatically deleted.  Defaults to no expiry. </param>
        internal Meta(string identifier, string fileName, bool ready, DateTimeOffset? readyDt, bool failed, string expiryTime)
        {
            Identifier = identifier;
            FileName = fileName;
            Ready = ready;
            ReadyDt = readyDt;
            Failed = failed;
            ExpiryTime = expiryTime;
        }

        /// <summary> Unique identifier for the resume. If creating a document and left blank, one will be automatically generated. </summary>
        public string Identifier { get; }
        /// <summary> Optional filename of the file. </summary>
        public string FileName { get; }
        /// <summary> If true, the document has finished processing. Particularly useful if an endpoint request specified wait=False, when polling use this variable to determine when to stop polling. </summary>
        public bool Ready { get; }
        /// <summary> The datetime when the document was ready. </summary>
        public DateTimeOffset? ReadyDt { get; }
        /// <summary> If true, some exception was raised during processing. Check the &apos;error&apos; field of the main return object. </summary>
        public bool Failed { get; }
        /// <summary> The date/time in ISO-8601 format when the resume will be automatically deleted.  Defaults to no expiry. </summary>
        public string ExpiryTime { get; }
    }
}
