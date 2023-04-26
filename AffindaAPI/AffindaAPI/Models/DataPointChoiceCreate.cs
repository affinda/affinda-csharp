// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The DataPointChoiceCreate. </summary>
    public partial class DataPointChoiceCreate
    {
        /// <summary> Initializes a new instance of DataPointChoiceCreate. </summary>
        /// <param name="dataPoint"> Uniquely identify a data point. </param>
        /// <param name="label"></param>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataPoint"/>, <paramref name="label"/> or <paramref name="value"/> is null. </exception>
        public DataPointChoiceCreate(string dataPoint, string label, string value)
        {
            if (dataPoint == null)
            {
                throw new ArgumentNullException(nameof(dataPoint));
            }
            if (label == null)
            {
                throw new ArgumentNullException(nameof(label));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            DataPoint = dataPoint;
            Label = label;
            Value = value;
            Synonyms = new ChangeTrackingList<string>();
        }

        /// <summary> Uniquely identify a data point. </summary>
        public string DataPoint { get; }
        /// <summary> Uniquely identify an organization. </summary>
        public string Organization { get; set; }
        /// <summary> Uniquely identify a collection. </summary>
        public string Collection { get; set; }
        /// <summary> Gets the label. </summary>
        public string Label { get; }
        /// <summary> Gets the value. </summary>
        public string Value { get; }
        /// <summary> Gets or sets the synonyms. </summary>
        public IList<string> Synonyms { get; set; }
        /// <summary> Gets or sets the description. </summary>
        public string Description { get; set; }
    }
}
