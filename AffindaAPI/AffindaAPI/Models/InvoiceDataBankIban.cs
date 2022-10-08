// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Affinda.API.Models
{
    /// <summary> The InvoiceDataBankIban. </summary>
    public partial class InvoiceDataBankIban : TextAnnotation
    {
        /// <summary> Initializes a new instance of InvoiceDataBankIban. </summary>
        /// <param name="rectangle"></param>
        /// <param name="pageIndex"></param>
        /// <param name="raw"></param>
        /// <param name="confidence"></param>
        /// <param name="isVerified"></param>
        /// <param name="classification"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="classification"/> is null. </exception>
        internal InvoiceDataBankIban(Rectangle rectangle, int? pageIndex, string raw, float? confidence, bool isVerified, string classification) : base(rectangle, pageIndex, raw, confidence, isVerified, classification)
        {
            if (classification == null)
            {
                throw new ArgumentNullException(nameof(classification));
            }
        }

        /// <summary> Initializes a new instance of InvoiceDataBankIban. </summary>
        /// <param name="id"></param>
        /// <param name="rectangle"></param>
        /// <param name="pageIndex"></param>
        /// <param name="raw"></param>
        /// <param name="confidence"></param>
        /// <param name="isVerified"></param>
        /// <param name="isClientVerified"></param>
        /// <param name="isAutoVerified"></param>
        /// <param name="classification"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="parsed"></param>
        internal InvoiceDataBankIban(int? id, Rectangle rectangle, int? pageIndex, string raw, float? confidence, bool isVerified, bool? isClientVerified, bool? isAutoVerified, string classification, IReadOnlyDictionary<string, object> additionalProperties, string parsed) : base(id, rectangle, pageIndex, raw, confidence, isVerified, isClientVerified, isAutoVerified, classification, additionalProperties, parsed)
        {
        }
    }
}
