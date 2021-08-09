// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace affinda.Models
{
    /// <summary> The PathsWt95EfResumesPostResponses201ContentApplicationJsonSchema. </summary>
    public partial class PathsWt95EfResumesPostResponses201ContentApplicationJsonSchema
    {
        /// <summary> Initializes a new instance of PathsWt95EfResumesPostResponses201ContentApplicationJsonSchema. </summary>
        internal PathsWt95EfResumesPostResponses201ContentApplicationJsonSchema()
        {
        }

        /// <summary> Initializes a new instance of PathsWt95EfResumesPostResponses201ContentApplicationJsonSchema. </summary>
        /// <param name="identifier"> Unique identifier for the resume. If creating a document and left blank, one will be automatically generated. </param>
        /// <param name="fileName"> Optional filename of the file. </param>
        internal PathsWt95EfResumesPostResponses201ContentApplicationJsonSchema(string identifier, string fileName)
        {
            Identifier = identifier;
            FileName = fileName;
        }

        /// <summary> Unique identifier for the resume. If creating a document and left blank, one will be automatically generated. </summary>
        public string Identifier { get; }
        /// <summary> Optional filename of the file. </summary>
        public string FileName { get; }
    }
}
