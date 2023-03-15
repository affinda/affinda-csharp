// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Affinda.API.Models
{
    /// <summary> The JobDescriptionSearchDetailOccupationGroupValue. </summary>
    public partial class JobDescriptionSearchDetailOccupationGroupValue : OccupationGroupSearchResult
    {
        /// <summary> Initializes a new instance of JobDescriptionSearchDetailOccupationGroupValue. </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="children"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="children"/> is null. </exception>
        internal JobDescriptionSearchDetailOccupationGroupValue(int code, string name, IEnumerable<OccupationGroup> children) : base(code, name, children)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (children == null)
            {
                throw new ArgumentNullException(nameof(children));
            }
        }

        /// <summary> Initializes a new instance of JobDescriptionSearchDetailOccupationGroupValue. </summary>
        /// <param name="match"></param>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="children"></param>
        /// <param name="parents"></param>
        internal JobDescriptionSearchDetailOccupationGroupValue(bool? match, int code, string name, IReadOnlyList<OccupationGroup> children, IReadOnlyList<OccupationGroup> parents) : base(match, code, name, children, parents)
        {
        }
    }
}
