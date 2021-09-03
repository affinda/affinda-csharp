// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace affinda.Models
{
    /// <summary> The Components8Sxs33Responses400ErrorContentApplicationJsonSchema. </summary>
    public partial class Components8Sxs33Responses400ErrorContentApplicationJsonSchema
    {
        /// <summary> Initializes a new instance of Components8Sxs33Responses400ErrorContentApplicationJsonSchema. </summary>
        internal Components8Sxs33Responses400ErrorContentApplicationJsonSchema()
        {
        }

        /// <summary> Initializes a new instance of Components8Sxs33Responses400ErrorContentApplicationJsonSchema. </summary>
        /// <param name="statusCode"></param>
        /// <param name="detail"></param>
        internal Components8Sxs33Responses400ErrorContentApplicationJsonSchema(int? statusCode, string detail)
        {
            StatusCode = statusCode;
            Detail = detail;
        }

        public int? StatusCode { get; }
        public string Detail { get; }
    }
}
