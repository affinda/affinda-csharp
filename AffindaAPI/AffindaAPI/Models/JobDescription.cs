// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Affinda.API.Models
{
    /// <summary> The JobDescription. </summary>
    public partial class JobDescription : Document
    {
        /// <summary> Initializes a new instance of JobDescription. </summary>
        /// <param name="meta"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="meta"/> is null. </exception>
        public JobDescription(DocumentMeta meta) : base(meta)
        {
            if (meta == null)
            {
                throw new ArgumentNullException(nameof(meta));
            }

            Extractor = "job-description";
        }

        /// <summary> Initializes a new instance of JobDescription. </summary>
        /// <param name="data"> Any object. </param>
        /// <param name="extractor"></param>
        /// <param name="meta"></param>
        /// <param name="error"></param>
        /// <param name="warnings"></param>
        internal JobDescription(object data, string extractor, DocumentMeta meta, DocumentError error, IList<DocumentWarning> warnings) : base(data, extractor, meta, error, warnings)
        {
            Extractor = extractor ?? "job-description";
        }
    }
}
