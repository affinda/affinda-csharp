// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Affinda.API.Models
{
    /// <summary> The FieldGroup. </summary>
    public partial class FieldGroup
    {
        /// <summary> Initializes a new instance of FieldGroup. </summary>
        /// <param name="label"></param>
        /// <param name="fields"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="label"/> or <paramref name="fields"/> is null. </exception>
        public FieldGroup(string label, IEnumerable<Field> fields)
        {
            if (label == null)
            {
                throw new ArgumentNullException(nameof(label));
            }
            if (fields == null)
            {
                throw new ArgumentNullException(nameof(fields));
            }

            Label = label;
            Fields = fields.ToList();
        }

        /// <summary> Initializes a new instance of FieldGroup. </summary>
        /// <param name="label"></param>
        /// <param name="fields"></param>
        internal FieldGroup(string label, IList<Field> fields)
        {
            Label = label;
            Fields = fields;
        }

        /// <summary> Gets or sets the label. </summary>
        public string Label { get; set; }
        /// <summary> Gets the fields. </summary>
        public IList<Field> Fields { get; }
    }
}
