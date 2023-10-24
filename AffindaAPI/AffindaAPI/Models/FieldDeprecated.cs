// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The FieldDeprecated. </summary>
    public partial class FieldDeprecated
    {
        /// <summary> Initializes a new instance of FieldDeprecated. </summary>
        /// <param name="label"></param>
        /// <param name="dataPoint"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="label"/> or <paramref name="dataPoint"/> is null. </exception>
        public FieldDeprecated(string label, string dataPoint)
        {
            if (label == null)
            {
                throw new ArgumentNullException(nameof(label));
            }
            if (dataPoint == null)
            {
                throw new ArgumentNullException(nameof(dataPoint));
            }

            Label = label;
            DataPoint = dataPoint;
            Fields = new ChangeTrackingList<FieldDeprecated>();
        }

        /// <summary> Initializes a new instance of FieldDeprecated. </summary>
        /// <param name="label"></param>
        /// <param name="slug"></param>
        /// <param name="dataPoint"></param>
        /// <param name="mandatory"></param>
        /// <param name="disabled"></param>
        /// <param name="autoValidationThreshold"></param>
        /// <param name="showDropdown"></param>
        /// <param name="displayEnumValue"></param>
        /// <param name="fields"></param>
        internal FieldDeprecated(string label, string slug, string dataPoint, bool? mandatory, bool? disabled, float? autoValidationThreshold, bool? showDropdown, bool? displayEnumValue, IList<FieldDeprecated> fields)
        {
            Label = label;
            Slug = slug;
            DataPoint = dataPoint;
            Mandatory = mandatory;
            Disabled = disabled;
            AutoValidationThreshold = autoValidationThreshold;
            ShowDropdown = showDropdown;
            DisplayEnumValue = displayEnumValue;
            Fields = fields;
        }

        /// <summary> Gets or sets the label. </summary>
        public string Label { get; set; }
        /// <summary> Gets or sets the slug. </summary>
        public string Slug { get; set; }
        /// <summary> Gets or sets the data point. </summary>
        public string DataPoint { get; set; }
        /// <summary> Gets or sets the mandatory. </summary>
        public bool? Mandatory { get; set; }
        /// <summary> Gets or sets the disabled. </summary>
        public bool? Disabled { get; set; }
        /// <summary> Gets or sets the auto validation threshold. </summary>
        public float? AutoValidationThreshold { get; set; }
        /// <summary> Gets or sets the show dropdown. </summary>
        public bool? ShowDropdown { get; set; }
        /// <summary> Gets or sets the display enum value. </summary>
        public bool? DisplayEnumValue { get; set; }
        /// <summary> Gets the fields. </summary>
        public IList<FieldDeprecated> Fields { get; }
    }
}
