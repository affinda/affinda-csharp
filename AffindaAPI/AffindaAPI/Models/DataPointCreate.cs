// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Affinda.API.Models
{
    /// <summary> The DataPointCreate. </summary>
    public partial class DataPointCreate
    {
        /// <summary> Initializes a new instance of DataPointCreate. </summary>
        /// <param name="name"> Name of the data point. </param>
        /// <param name="slug"> A camelCase string that will be used as the key in the API response. </param>
        /// <param name="annotationContentType"> The different data types of annotations. </param>
        /// <param name="organization"> Uniquely identify an organization. </param>
        /// <param name="extractor"> Uniquely identify an extractor. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="slug"/>, <paramref name="organization"/> or <paramref name="extractor"/> is null. </exception>
        public DataPointCreate(string name, string slug, AnnotationContentType annotationContentType, string organization, string extractor)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (slug == null)
            {
                throw new ArgumentNullException(nameof(slug));
            }
            if (organization == null)
            {
                throw new ArgumentNullException(nameof(organization));
            }
            if (extractor == null)
            {
                throw new ArgumentNullException(nameof(extractor));
            }

            Name = name;
            Slug = slug;
            AnnotationContentType = annotationContentType;
            Organization = organization;
            Extractor = extractor;
        }

        /// <summary> Name of the data point. </summary>
        public string Name { get; }
        /// <summary> A camelCase string that will be used as the key in the API response. </summary>
        public string Slug { get; }
        /// <summary> Gets or sets the description. </summary>
        public string Description { get; set; }
        /// <summary> The different data types of annotations. </summary>
        public AnnotationContentType AnnotationContentType { get; }
        /// <summary> Uniquely identify an organization. </summary>
        public string Organization { get; }
        /// <summary> Uniquely identify an extractor. </summary>
        public string Extractor { get; }
        /// <summary> Gets or sets the multiple. </summary>
        public bool? Multiple { get; set; }
        /// <summary> Gets or sets the no rect. </summary>
        public bool? NoRect { get; set; }
        /// <summary> If true, both the value and the label for the enums will appear in the dropdown in the validation tool. </summary>
        public bool? DisplayEnumValue { get; set; }
        /// <summary> The identifier of the parent data point if applicable. </summary>
        public string Parent { get; set; }
    }
}
