// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The ResumeSearchDetailLanguages. </summary>
    public partial class ResumeSearchDetailLanguages
    {
        /// <summary> Initializes a new instance of ResumeSearchDetailLanguages. </summary>
        internal ResumeSearchDetailLanguages()
        {
            Missing = new ChangeTrackingList<ResumeSearchParametersSkill>();
            Value = new ChangeTrackingList<ResumeSearchDetailLanguagesValueItem>();
        }

        /// <summary> Initializes a new instance of ResumeSearchDetailLanguages. </summary>
        /// <param name="missing"></param>
        /// <param name="value"></param>
        internal ResumeSearchDetailLanguages(IReadOnlyList<ResumeSearchParametersSkill> missing, IReadOnlyList<ResumeSearchDetailLanguagesValueItem> value)
        {
            Missing = missing;
            Value = value;
        }

        /// <summary> Gets the missing. </summary>
        public IReadOnlyList<ResumeSearchParametersSkill> Missing { get; }
        /// <summary> Gets the value. </summary>
        public IReadOnlyList<ResumeSearchDetailLanguagesValueItem> Value { get; }
    }
}
