// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> A JSON-encoded string of the `ResumeData` object. </summary>
    public partial class ResumeData
    {
        /// <summary> Initializes a new instance of ResumeData. </summary>
        public ResumeData()
        {
            PhoneNumbers = new ChangeTrackingList<string>();
            Websites = new ChangeTrackingList<string>();
            Emails = new ChangeTrackingList<string>();
            Languages = new ChangeTrackingList<string>();
            LanguageCodes = new ChangeTrackingList<string>();
            Education = new ChangeTrackingList<Education>();
            WorkExperience = new ChangeTrackingList<ResumeDataWorkExperienceItem>();
            Skills = new ChangeTrackingList<ResumeDataSkillsItem>();
            Certifications = new ChangeTrackingList<string>();
            Publications = new ChangeTrackingList<string>();
            Referees = new ChangeTrackingList<ResumeDataRefereesItem>();
            Sections = new ChangeTrackingList<ResumeDataSectionsItem>();
            AdditionalProperties = new ChangeTrackingDictionary<string, ComponentsEyyf0ZSchemasResumedataAdditionalproperties>();
        }

        /// <summary> Initializes a new instance of ResumeData. </summary>
        /// <param name="name"></param>
        /// <param name="phoneNumbers"></param>
        /// <param name="websites"></param>
        /// <param name="emails"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="location"></param>
        /// <param name="objective"></param>
        /// <param name="languages"></param>
        /// <param name="languageCodes"></param>
        /// <param name="summary"></param>
        /// <param name="totalYearsExperience"></param>
        /// <param name="headShot"> base64 encoded string. </param>
        /// <param name="education"></param>
        /// <param name="profession"> Prediction of the candidate&apos;s profession based on recent work experience. </param>
        /// <param name="linkedin"> Linkedin account associated with the candidate. </param>
        /// <param name="workExperience"></param>
        /// <param name="skills"></param>
        /// <param name="certifications"></param>
        /// <param name="publications"></param>
        /// <param name="referees"></param>
        /// <param name="sections"></param>
        /// <param name="isResumeProbability"> Probability that the given document is a resume. Values below 30 suggest that the document is not a resume. </param>
        /// <param name="rawText"> All of the raw text of the parsed resume, example is shortened for readability. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal ResumeData(ResumeDataName name, IList<string> phoneNumbers, IList<string> websites, IList<string> emails, string dateOfBirth, Location location, string objective, IReadOnlyList<string> languages, IReadOnlyList<string> languageCodes, string summary, int? totalYearsExperience, byte[] headShot, IList<Education> education, string profession, string linkedin, IList<ResumeDataWorkExperienceItem> workExperience, IList<ResumeDataSkillsItem> skills, IList<string> certifications, IList<string> publications, IList<ResumeDataRefereesItem> referees, IReadOnlyList<ResumeDataSectionsItem> sections, int? isResumeProbability, string rawText, IDictionary<string, ComponentsEyyf0ZSchemasResumedataAdditionalproperties> additionalProperties)
        {
            Name = name;
            PhoneNumbers = phoneNumbers;
            Websites = websites;
            Emails = emails;
            DateOfBirth = dateOfBirth;
            Location = location;
            Objective = objective;
            Languages = languages;
            LanguageCodes = languageCodes;
            Summary = summary;
            TotalYearsExperience = totalYearsExperience;
            HeadShot = headShot;
            Education = education;
            Profession = profession;
            Linkedin = linkedin;
            WorkExperience = workExperience;
            Skills = skills;
            Certifications = certifications;
            Publications = publications;
            Referees = referees;
            Sections = sections;
            IsResumeProbability = isResumeProbability;
            RawText = rawText;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Gets or sets the name. </summary>
        public ResumeDataName Name { get; set; }
        /// <summary> Gets or sets the phone numbers. </summary>
        public IList<string> PhoneNumbers { get; set; }
        /// <summary> Gets or sets the websites. </summary>
        public IList<string> Websites { get; set; }
        /// <summary> Gets or sets the emails. </summary>
        public IList<string> Emails { get; set; }
        /// <summary> Gets or sets the date of birth. </summary>
        public string DateOfBirth { get; set; }
        /// <summary> Gets or sets the location. </summary>
        public Location Location { get; set; }
        /// <summary> Gets or sets the objective. </summary>
        public string Objective { get; set; }
        /// <summary> Gets the languages. </summary>
        public IReadOnlyList<string> Languages { get; }
        /// <summary> Gets the language codes. </summary>
        public IReadOnlyList<string> LanguageCodes { get; }
        /// <summary> Gets or sets the summary. </summary>
        public string Summary { get; set; }
        /// <summary> Gets or sets the total years experience. </summary>
        public int? TotalYearsExperience { get; set; }
        /// <summary> base64 encoded string. </summary>
        public byte[] HeadShot { get; }
        /// <summary> Gets the education. </summary>
        public IList<Education> Education { get; }
        /// <summary> Prediction of the candidate&apos;s profession based on recent work experience. </summary>
        public string Profession { get; }
        /// <summary> Linkedin account associated with the candidate. </summary>
        public string Linkedin { get; }
        /// <summary> Gets the work experience. </summary>
        public IList<ResumeDataWorkExperienceItem> WorkExperience { get; }
        /// <summary> Gets the skills. </summary>
        public IList<ResumeDataSkillsItem> Skills { get; }
        /// <summary> Gets the certifications. </summary>
        public IList<string> Certifications { get; }
        /// <summary> Gets the publications. </summary>
        public IList<string> Publications { get; }
        /// <summary> Gets the referees. </summary>
        public IList<ResumeDataRefereesItem> Referees { get; }
        /// <summary> Gets the sections. </summary>
        public IReadOnlyList<ResumeDataSectionsItem> Sections { get; }
        /// <summary> Probability that the given document is a resume. Values below 30 suggest that the document is not a resume. </summary>
        public int? IsResumeProbability { get; }
        /// <summary> All of the raw text of the parsed resume, example is shortened for readability. </summary>
        public string RawText { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, ComponentsEyyf0ZSchemasResumedataAdditionalproperties> AdditionalProperties { get; }
    }
}
