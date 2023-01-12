// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Affinda.API.Models
{
    /// <summary> The DataPointChoicesItem. </summary>
    public partial class DataPointChoicesItem
    {
        /// <summary> Initializes a new instance of DataPointChoicesItem. </summary>
        /// <param name="label"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="label"/> is null. </exception>
        internal DataPointChoicesItem(string label)
        {
            if (label == null)
            {
                throw new ArgumentNullException(nameof(label));
            }

            Label = label;
        }

        /// <summary> Gets the label. </summary>
        public string Label { get; }
    }
}
