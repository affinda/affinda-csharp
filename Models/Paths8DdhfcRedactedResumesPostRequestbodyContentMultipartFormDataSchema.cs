// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.IO;

namespace affinda.Models
{
    /// <summary> The Paths8DdhfcRedactedResumesPostRequestbodyContentMultipartFormDataSchema. </summary>
    internal partial class Paths8DdhfcRedactedResumesPostRequestbodyContentMultipartFormDataSchema
    {
        /// <summary> Initializes a new instance of Paths8DdhfcRedactedResumesPostRequestbodyContentMultipartFormDataSchema. </summary>
        internal Paths8DdhfcRedactedResumesPostRequestbodyContentMultipartFormDataSchema()
        {
        }

        /// <summary> File as binary data blob. </summary>
        public Stream File { get; }
        /// <summary> Unique identifier for the resume. If creating a document and left blank, one will be automatically generated. </summary>
        public string Identifier { get; }
        /// <summary> Optional filename of the file. </summary>
        public string FileName { get; }
        /// <summary> URL to file to download and process. </summary>
        public string Url { get; }
        /// <summary> Language code in ISO 639-1 format. Must specify zh-cn or zh-tw for Chinese. </summary>
        public string ResumeLanguage { get; }
        /// <summary> The date/time in ISO-8601 format when the resume will be automatically deleted.  Defaults to no expiry. </summary>
        public string ExpiryTime { get; }
    }
}
