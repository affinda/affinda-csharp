// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> Matching job title to extracted text. </summary>
    internal partial class JobTitleParsedParsed
    {
        /// <summary> Initializes a new instance of JobTitleParsedParsed. </summary>
        internal JobTitleParsedParsed()
        {
        }

        /// <summary> Initializes a new instance of JobTitleParsedParsed. </summary>
        /// <param name="name"></param>
        /// <param name="managementLevel"></param>
        /// <param name="classification"></param>
        internal JobTitleParsedParsed(string name, string managementLevel, JobTitleParsedClassification classification)
        {
            Name = name;
            ManagementLevel = managementLevel;
            Classification = classification;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the management level. </summary>
        public string ManagementLevel { get; }
        /// <summary> Gets the classification. </summary>
        public JobTitleParsedClassification Classification { get; }
    }
}
