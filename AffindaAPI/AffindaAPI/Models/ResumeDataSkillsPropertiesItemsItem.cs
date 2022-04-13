// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The ResumeDataSkillsPropertiesItemsItem. </summary>
    public partial class ResumeDataSkillsPropertiesItemsItem
    {
        /// <summary> Initializes a new instance of ResumeDataSkillsPropertiesItemsItem. </summary>
        internal ResumeDataSkillsPropertiesItemsItem()
        {
        }

        /// <summary> Initializes a new instance of ResumeDataSkillsPropertiesItemsItem. </summary>
        /// <param name="section"></param>
        /// <param name="position"></param>
        internal ResumeDataSkillsPropertiesItemsItem(string section, int? position)
        {
            Section = section;
            Position = position;
        }

        /// <summary> Gets the section. </summary>
        public string Section { get; }
        /// <summary> Gets the position. </summary>
        public int? Position { get; }
    }
}
