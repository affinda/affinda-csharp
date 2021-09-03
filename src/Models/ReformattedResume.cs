// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace affinda.Models
{
    /// <summary> The ReformattedResume. </summary>
    public partial class ReformattedResume
    {
        /// <summary> Initializes a new instance of ReformattedResume. </summary>
        /// <param name="data"></param>
        /// <param name="meta"></param>
        /// <param name="error"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="meta"/> or <paramref name="error"/> is null. </exception>
        internal ReformattedResume(ReformattedResumeData data, Meta meta, Error error)
        {
            if (meta == null)
            {
                throw new ArgumentNullException(nameof(meta));
            }
            if (error == null)
            {
                throw new ArgumentNullException(nameof(error));
            }

            Data = data;
            Meta = meta;
            Error = error;
        }

        public ReformattedResumeData Data { get; }
        public Meta Meta { get; }
        public Error Error { get; }
    }
}
