// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The AnnotationBatchUpdate. </summary>
    public partial class AnnotationBatchUpdate
    {
        /// <summary> Initializes a new instance of AnnotationBatchUpdate. </summary>
        /// <param name="id"> Annotation&apos;s ID. </param>
        public AnnotationBatchUpdate(int id)
        {
            Id = id;
            Rectangles = new ChangeTrackingList<Rectangle>();
            ValidationResults = new ChangeTrackingList<ChangedValidationResults>();
        }

        /// <summary> Annotation&apos;s ID. </summary>
        public int Id { get; }
        /// <summary> x/y coordinates for the rectangles containing the data. An annotation can be contained within multiple rectangles. </summary>
        public IList<Rectangle> Rectangles { get; }
        /// <summary> Unique identifier for the document. </summary>
        public string Document { get; set; }
        /// <summary> The page number within the document, starting from 0. </summary>
        public int? PageIndex { get; set; }
        /// <summary> Raw data extracted from the before any post-processing. </summary>
        public string Raw { get; set; }
        /// <summary> Anything. </summary>
        public object Parsed { get; set; }
        /// <summary> Indicates whether the data has been validated by a human. </summary>
        public bool? IsClientVerified { get; set; }
        /// <summary> Data point&apos;s identifier. </summary>
        public string DataPoint { get; set; }
        /// <summary> The parent annotation&apos;s ID. </summary>
        public int? Parent { get; set; }
        /// <summary> The validation results created, changed or deleted as a result of updating the annotation. </summary>
        public IList<ChangedValidationResults> ValidationResults { get; }
    }
}
