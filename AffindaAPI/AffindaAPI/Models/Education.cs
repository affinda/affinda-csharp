// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The Education. </summary>
    public partial class Education
    {
        /// <summary> Initializes a new instance of Education. </summary>
        internal Education()
        {
        }

        /// <summary> Initializes a new instance of Education. </summary>
        /// <param name="organization"></param>
        /// <param name="accreditation"></param>
        /// <param name="grade"></param>
        /// <param name="location"></param>
        /// <param name="dates"></param>
        internal Education(string organization, Accreditation accreditation, EducationGrade grade, Location location, EducationDates dates)
        {
            Organization = organization;
            Accreditation = accreditation;
            Grade = grade;
            Location = location;
            Dates = dates;
        }

        /// <summary> Gets the organization. </summary>
        public string Organization { get; }
        /// <summary> Gets the accreditation. </summary>
        public Accreditation Accreditation { get; }
        /// <summary> Gets the grade. </summary>
        public EducationGrade Grade { get; }
        /// <summary> Gets the location. </summary>
        public Location Location { get; }
        /// <summary> Gets the dates. </summary>
        public EducationDates Dates { get; }
    }
}
