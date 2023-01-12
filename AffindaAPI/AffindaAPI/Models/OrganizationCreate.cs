// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;

namespace Affinda.API.Models
{
    /// <summary> The OrganizationCreate. </summary>
    internal partial class OrganizationCreate
    {
        /// <summary> Initializes a new instance of OrganizationCreate. </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal OrganizationCreate(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Upload avatar for the organization. </summary>
        public Stream Avatar { get; }
        /// <summary> Used to sign webhook payloads so you can verify their integrity. </summary>
        public string ResthookSignatureKey { get; }
    }
}
