// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The JobDescriptionData. </summary>
    public partial class JobDescriptionData
    {
        /// <summary> Initializes a new instance of JobDescriptionData. </summary>
        public JobDescriptionData()
        {
            Languages = new ChangeTrackingList<LanguageAnnotation>();
            Skills = new ChangeTrackingList<SkillAnnotation>();
            Certifications = new ChangeTrackingList<TextAnnotation>();
            AdditionalProperties = new ChangeTrackingDictionary<string, ComponentsTk0GmxSchemasJobdescriptiondataAdditionalproperties>();
        }

        /// <summary> Initializes a new instance of JobDescriptionData. </summary>
        /// <param name="jobTitle"></param>
        /// <param name="contactEmail"></param>
        /// <param name="contactName"></param>
        /// <param name="contactPhone"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="jobType"></param>
        /// <param name="languages"></param>
        /// <param name="skills"></param>
        /// <param name="organizationName"></param>
        /// <param name="organizationWebsite"></param>
        /// <param name="educationLevel"></param>
        /// <param name="educationAccreditation"></param>
        /// <param name="expectedRemuneration"></param>
        /// <param name="location"></param>
        /// <param name="certifications"></param>
        /// <param name="yearsExperience"></param>
        /// <param name="rawText"> All of the raw text of the parsed job description, example is shortened for readability. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal JobDescriptionData(JobTitleAnnotation jobTitle, TextAnnotation contactEmail, TextAnnotation contactName, TextAnnotation contactPhone, DateAnnotation startDate, DateAnnotation endDate, TextAnnotation jobType, IList<LanguageAnnotation> languages, IList<SkillAnnotation> skills, TextAnnotation organizationName, TextAnnotation organizationWebsite, TextAnnotation educationLevel, TextAnnotation educationAccreditation, ExpectedRemunerationAnnotation expectedRemuneration, LocationAnnotation location, IList<TextAnnotation> certifications, YearsExperienceAnnotation yearsExperience, string rawText, IDictionary<string, ComponentsTk0GmxSchemasJobdescriptiondataAdditionalproperties> additionalProperties)
        {
            JobTitle = jobTitle;
            ContactEmail = contactEmail;
            ContactName = contactName;
            ContactPhone = contactPhone;
            StartDate = startDate;
            EndDate = endDate;
            JobType = jobType;
            Languages = languages;
            Skills = skills;
            OrganizationName = organizationName;
            OrganizationWebsite = organizationWebsite;
            EducationLevel = educationLevel;
            EducationAccreditation = educationAccreditation;
            ExpectedRemuneration = expectedRemuneration;
            Location = location;
            Certifications = certifications;
            YearsExperience = yearsExperience;
            RawText = rawText;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Gets or sets the job title. </summary>
        public JobTitleAnnotation JobTitle { get; set; }
        /// <summary> Gets or sets the contact email. </summary>
        public TextAnnotation ContactEmail { get; set; }
        /// <summary> Gets or sets the contact name. </summary>
        public TextAnnotation ContactName { get; set; }
        /// <summary> Gets or sets the contact phone. </summary>
        public TextAnnotation ContactPhone { get; set; }
        /// <summary> Gets or sets the start date. </summary>
        public DateAnnotation StartDate { get; set; }
        /// <summary> Gets or sets the end date. </summary>
        public DateAnnotation EndDate { get; set; }
        /// <summary> Gets or sets the job type. </summary>
        public TextAnnotation JobType { get; set; }
        /// <summary> Gets the languages. </summary>
        public IList<LanguageAnnotation> Languages { get; }
        /// <summary> Gets the skills. </summary>
        public IList<SkillAnnotation> Skills { get; }
        /// <summary> Gets or sets the organization name. </summary>
        public TextAnnotation OrganizationName { get; set; }
        /// <summary> Gets or sets the organization website. </summary>
        public TextAnnotation OrganizationWebsite { get; set; }
        /// <summary> Gets or sets the education level. </summary>
        public TextAnnotation EducationLevel { get; set; }
        /// <summary> Gets or sets the education accreditation. </summary>
        public TextAnnotation EducationAccreditation { get; set; }
        /// <summary> Gets or sets the expected remuneration. </summary>
        public ExpectedRemunerationAnnotation ExpectedRemuneration { get; set; }
        /// <summary> Gets or sets the location. </summary>
        public LocationAnnotation Location { get; set; }
        /// <summary> Gets the certifications. </summary>
        public IList<TextAnnotation> Certifications { get; }
        /// <summary> Gets or sets the years experience. </summary>
        public YearsExperienceAnnotation YearsExperience { get; set; }
        /// <summary> All of the raw text of the parsed job description, example is shortened for readability. </summary>
        public string RawText { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, ComponentsTk0GmxSchemasJobdescriptiondataAdditionalproperties> AdditionalProperties { get; }
    }
}
