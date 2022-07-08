// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The InvoiceDataTablesItem. </summary>
    public partial class InvoiceDataTablesItem
    {
        /// <summary> Initializes a new instance of InvoiceDataTablesItem. </summary>
        internal InvoiceDataTablesItem()
        {
            Rows = new ChangeTrackingList<RowAnnotation>();
        }

        /// <summary> Initializes a new instance of InvoiceDataTablesItem. </summary>
        /// <param name="rows"></param>
        internal InvoiceDataTablesItem(IReadOnlyList<RowAnnotation> rows)
        {
            Rows = rows;
        }

        /// <summary> Gets the rows. </summary>
        public IReadOnlyList<RowAnnotation> Rows { get; }
    }
}
