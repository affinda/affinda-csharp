// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The ResumeDataEducationItem. </summary>
    public partial class ResumeDataEducationItem
    {
        /// <summary> Initializes a new instance of ResumeDataEducationItem. </summary>
        public ResumeDataEducationItem()
        {
        }

        /// <summary> Initializes a new instance of ResumeDataEducationItem. </summary>
        /// <param name="id"></param>
        /// <param name="organization"></param>
        /// <param name="accreditation"></param>
        /// <param name="grade"></param>
        /// <param name="location"></param>
        /// <param name="dates"></param>
        internal ResumeDataEducationItem(int? id, string organization, ResumeDataEducationItemAccreditation accreditation, ResumeDataEducationItemGrade grade, Location location, ResumeDataEducationItemDates dates)
        {
            Id = id;
            Organization = organization;
            Accreditation = accreditation;
            Grade = grade;
            Location = location;
            Dates = dates;
        }

        /// <summary> Gets or sets the id. </summary>
        public int? Id { get; set; }
        /// <summary> Gets or sets the organization. </summary>
        public string Organization { get; set; }
        /// <summary> Gets or sets the accreditation. </summary>
        public ResumeDataEducationItemAccreditation Accreditation { get; set; }
        /// <summary> Gets or sets the grade. </summary>
        public ResumeDataEducationItemGrade Grade { get; set; }
        /// <summary> Gets or sets the location. </summary>
        public Location Location { get; set; }
        /// <summary> Gets or sets the dates. </summary>
        public ResumeDataEducationItemDates Dates { get; set; }
    }
}
