// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The ResumeSkill. </summary>
    public partial class ResumeSkill
    {
        /// <summary> Initializes a new instance of ResumeSkill. </summary>
        internal ResumeSkill()
        {
            Sources = new ChangeTrackingList<ResumeSkillSourcesItem>();
        }

        /// <summary> Initializes a new instance of ResumeSkill. </summary>
        /// <param name="name"></param>
        /// <param name="lastUsed"></param>
        /// <param name="numberOfMonths"></param>
        /// <param name="type"></param>
        /// <param name="sources"></param>
        internal ResumeSkill(string name, string lastUsed, int? numberOfMonths, string type, IReadOnlyList<ResumeSkillSourcesItem> sources)
        {
            Name = name;
            LastUsed = lastUsed;
            NumberOfMonths = numberOfMonths;
            Type = type;
            Sources = sources;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the last used. </summary>
        public string LastUsed { get; }
        /// <summary> Gets the number of months. </summary>
        public int? NumberOfMonths { get; }
        /// <summary> Gets the type. </summary>
        public string Type { get; }
        /// <summary> Gets the sources. </summary>
        public IReadOnlyList<ResumeSkillSourcesItem> Sources { get; }
    }
}
