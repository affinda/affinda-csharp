// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Affinda.API.Models
{
    /// <summary> The YearsExperienceAnnotation. </summary>
    public partial class YearsExperienceAnnotation : Annotation
    {
        /// <summary> Initializes a new instance of YearsExperienceAnnotation. </summary>
        /// <param name="rectangle"></param>
        /// <param name="pageIndex"></param>
        /// <param name="raw"></param>
        /// <param name="confidence"></param>
        /// <param name="isVerified"></param>
        /// <param name="classification"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="rectangle"/> or <paramref name="classification"/> is null. </exception>
        internal YearsExperienceAnnotation(Rectangle rectangle, int? pageIndex, string raw, float confidence, bool isVerified, string classification) : base(rectangle, pageIndex, raw, confidence, isVerified, classification)
        {
            if (rectangle == null)
            {
                throw new ArgumentNullException(nameof(rectangle));
            }
            if (classification == null)
            {
                throw new ArgumentNullException(nameof(classification));
            }
        }

        /// <summary> Initializes a new instance of YearsExperienceAnnotation. </summary>
        /// <param name="id"></param>
        /// <param name="rectangle"></param>
        /// <param name="pageIndex"></param>
        /// <param name="raw"></param>
        /// <param name="confidence"></param>
        /// <param name="isVerified"></param>
        /// <param name="classification"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="parsed"> Years of experience range. </param>
        internal YearsExperienceAnnotation(int? id, Rectangle rectangle, int? pageIndex, string raw, float confidence, bool isVerified, string classification, IReadOnlyDictionary<string, object> additionalProperties, YearsExperienceAnnotationParsed parsed) : base(id, rectangle, pageIndex, raw, confidence, isVerified, classification, additionalProperties)
        {
            Parsed = parsed;
        }

        /// <summary> Years of experience range. </summary>
        public YearsExperienceAnnotationParsed Parsed { get; }
    }
}
