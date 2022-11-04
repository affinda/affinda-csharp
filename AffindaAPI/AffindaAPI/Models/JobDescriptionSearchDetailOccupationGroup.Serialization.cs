// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class JobDescriptionSearchDetailOccupationGroup
    {
        internal static JobDescriptionSearchDetailOccupationGroup DeserializeJobDescriptionSearchDetailOccupationGroup(JsonElement element)
        {
            Optional<IReadOnlyList<int>> missing = default;
            Optional<IReadOnlyList<JobDescriptionSearchDetailOccupationGroupValueItem>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("missing"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    missing = array;
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        value = null;
                        continue;
                    }
                    List<JobDescriptionSearchDetailOccupationGroupValueItem> array = new List<JobDescriptionSearchDetailOccupationGroupValueItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JobDescriptionSearchDetailOccupationGroupValueItem.DeserializeJobDescriptionSearchDetailOccupationGroupValueItem(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new JobDescriptionSearchDetailOccupationGroup(Optional.ToList(missing), Optional.ToList(value));
        }
    }
}
