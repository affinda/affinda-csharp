// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Affinda.API.Models
{
    /// <summary> The data point to be created for this field. If a data point with the same slug and collection already exists, it will be reused. </summary>
    public partial class DataFieldCreateDataPoint
    {
        /// <summary> Initializes a new instance of DataFieldCreateDataPoint. </summary>
        /// <param name="name"> Name of the data point. </param>
        /// <param name="slug"> A camelCase string that will be used as the key in the API response. </param>
        /// <param name="type"> The different data types of annotations. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="slug"/> is null. </exception>
        public DataFieldCreateDataPoint(string name, string slug, AnnotationContentType type)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (slug == null)
            {
                throw new ArgumentNullException(nameof(slug));
            }

            Name = name;
            Slug = slug;
            Type = type;
        }

        /// <summary> Name of the data point. </summary>
        public string Name { get; }
        /// <summary> A camelCase string that will be used as the key in the API response. </summary>
        public string Slug { get; }
        /// <summary> Gets or sets the description. </summary>
        public string Description { get; set; }
        /// <summary> The different data types of annotations. </summary>
        public AnnotationContentType Type { get; }
        /// <summary> Gets or sets the multiple. </summary>
        public bool? Multiple { get; set; }
        /// <summary> Gets or sets the no rect. </summary>
        public bool? NoRect { get; set; }
        /// <summary> The identifier of the parent data point if applicable. </summary>
        public string Parent { get; set; }
        /// <summary> If true, the model will not be used to predict this data point. Instead, the user will be able to manually enter the value in the validation tool. </summary>
        public bool? ManualEntry { get; set; }
        /// <summary> If populated, the model will learn to predict this field using the data source, rather than relying on fuzzy string matching. </summary>
        public string MappingDataSource { get; set; }
    }
}
