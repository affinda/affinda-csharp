// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The DataPoint. </summary>
    public partial class DataPoint
    {
        /// <summary> Initializes a new instance of DataPoint. </summary>
        /// <param name="identifier"> Uniquely identify a data point. </param>
        /// <param name="name"> Name of the data point. </param>
        /// <param name="slug"> A camelCase string that will be used as the key in the API response. </param>
        /// <param name="annotationContentType"> The different data types of annotations. </param>
        /// <param name="organization"></param>
        /// <param name="extractor"> Uniquely identify an extractor. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="identifier"/>, <paramref name="name"/> or <paramref name="slug"/> is null. </exception>
        internal DataPoint(string identifier, string name, string slug, AnnotationContentType annotationContentType, Organization organization, string extractor)
        {
            if (identifier == null)
            {
                throw new ArgumentNullException(nameof(identifier));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (slug == null)
            {
                throw new ArgumentNullException(nameof(slug));
            }

            Identifier = identifier;
            Name = name;
            Slug = slug;
            AnnotationContentType = annotationContentType;
            Organization = organization;
            Extractor = extractor;
            Children = new ChangeTrackingList<DataPoint>();
        }

        /// <summary> Initializes a new instance of DataPoint. </summary>
        /// <param name="identifier"> Uniquely identify a data point. </param>
        /// <param name="name"> Name of the data point. </param>
        /// <param name="slug"> A camelCase string that will be used as the key in the API response. </param>
        /// <param name="description"></param>
        /// <param name="annotationContentType"> The different data types of annotations. </param>
        /// <param name="organization"></param>
        /// <param name="extractor"> Uniquely identify an extractor. </param>
        /// <param name="multiple"></param>
        /// <param name="noRect"></param>
        /// <param name="displayEnumValue"> If true, both the value and the label for the enums will appear in the dropdown in the validation tool. </param>
        /// <param name="parent"> The identifier of the parent data point if applicable. </param>
        /// <param name="children"></param>
        internal DataPoint(string identifier, string name, string slug, string description, AnnotationContentType annotationContentType, Organization organization, string extractor, bool? multiple, bool? noRect, bool? displayEnumValue, string parent, IReadOnlyList<DataPoint> children)
        {
            Identifier = identifier;
            Name = name;
            Slug = slug;
            Description = description;
            AnnotationContentType = annotationContentType;
            Organization = organization;
            Extractor = extractor;
            Multiple = multiple;
            NoRect = noRect;
            DisplayEnumValue = displayEnumValue;
            Parent = parent;
            Children = children;
        }

        /// <summary> Uniquely identify a data point. </summary>
        public string Identifier { get; }
        /// <summary> Name of the data point. </summary>
        public string Name { get; }
        /// <summary> A camelCase string that will be used as the key in the API response. </summary>
        public string Slug { get; }
        /// <summary> Gets the description. </summary>
        public string Description { get; }
        /// <summary> The different data types of annotations. </summary>
        public AnnotationContentType AnnotationContentType { get; }
        /// <summary> Gets the organization. </summary>
        public Organization Organization { get; }
        /// <summary> Uniquely identify an extractor. </summary>
        public string Extractor { get; }
        /// <summary> Gets the multiple. </summary>
        public bool? Multiple { get; }
        /// <summary> Gets the no rect. </summary>
        public bool? NoRect { get; }
        /// <summary> If true, both the value and the label for the enums will appear in the dropdown in the validation tool. </summary>
        public bool? DisplayEnumValue { get; }
        /// <summary> The identifier of the parent data point if applicable. </summary>
        public string Parent { get; }
        /// <summary> Gets the children. </summary>
        public IReadOnlyList<DataPoint> Children { get; }
    }
}
