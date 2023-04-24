// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The ResumeDataPhoneNumberDetailsItem. </summary>
    public partial class ResumeDataPhoneNumberDetailsItem
    {
        /// <summary> Initializes a new instance of ResumeDataPhoneNumberDetailsItem. </summary>
        public ResumeDataPhoneNumberDetailsItem()
        {
        }

        /// <summary> Initializes a new instance of ResumeDataPhoneNumberDetailsItem. </summary>
        /// <param name="rawText"></param>
        /// <param name="formattedNumber"></param>
        /// <param name="countryCode"></param>
        /// <param name="nationalNumber"></param>
        internal ResumeDataPhoneNumberDetailsItem(string rawText, string formattedNumber, string countryCode, string nationalNumber)
        {
            RawText = rawText;
            FormattedNumber = formattedNumber;
            CountryCode = countryCode;
            NationalNumber = nationalNumber;
        }

        /// <summary> Gets or sets the raw text. </summary>
        public string RawText { get; set; }
        /// <summary> Gets or sets the formatted number. </summary>
        public string FormattedNumber { get; set; }
        /// <summary> Gets or sets the country code. </summary>
        public string CountryCode { get; set; }
        /// <summary> Gets or sets the national number. </summary>
        public string NationalNumber { get; set; }
    }
}
