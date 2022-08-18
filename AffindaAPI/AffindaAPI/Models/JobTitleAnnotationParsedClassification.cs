// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The JobTitleAnnotationParsedClassification. </summary>
    public partial class JobTitleAnnotationParsedClassification
    {
        /// <summary> Initializes a new instance of JobTitleAnnotationParsedClassification. </summary>
        internal JobTitleAnnotationParsedClassification()
        {
        }

        /// <summary> Initializes a new instance of JobTitleAnnotationParsedClassification. </summary>
        /// <param name="socCode"></param>
        /// <param name="title"></param>
        /// <param name="minorGroup"></param>
        /// <param name="subMajorGroup"></param>
        /// <param name="majorGroup"></param>
        internal JobTitleAnnotationParsedClassification(float? socCode, string title, string minorGroup, string subMajorGroup, string majorGroup)
        {
            SocCode = socCode;
            Title = title;
            MinorGroup = minorGroup;
            SubMajorGroup = subMajorGroup;
            MajorGroup = majorGroup;
        }

        /// <summary> Gets the soc code. </summary>
        public float? SocCode { get; }
        /// <summary> Gets the title. </summary>
        public string Title { get; }
        /// <summary> Gets the minor group. </summary>
        public string MinorGroup { get; }
        /// <summary> Gets the sub major group. </summary>
        public string SubMajorGroup { get; }
        /// <summary> Gets the major group. </summary>
        public string MajorGroup { get; }
    }
}
