// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The PathsSnpek6InvitationsGetResponses200ContentApplicationJsonSchemaAllof1. </summary>
    public partial class PathsSnpek6InvitationsGetResponses200ContentApplicationJsonSchemaAllof1
    {
        /// <summary> Initializes a new instance of PathsSnpek6InvitationsGetResponses200ContentApplicationJsonSchemaAllof1. </summary>
        internal PathsSnpek6InvitationsGetResponses200ContentApplicationJsonSchemaAllof1()
        {
            Results = new ChangeTrackingList<Invitation>();
        }

        /// <summary> Initializes a new instance of PathsSnpek6InvitationsGetResponses200ContentApplicationJsonSchemaAllof1. </summary>
        /// <param name="results"></param>
        internal PathsSnpek6InvitationsGetResponses200ContentApplicationJsonSchemaAllof1(IReadOnlyList<Invitation> results)
        {
            Results = results;
        }

        /// <summary> Gets the results. </summary>
        public IReadOnlyList<Invitation> Results { get; }
    }
}
