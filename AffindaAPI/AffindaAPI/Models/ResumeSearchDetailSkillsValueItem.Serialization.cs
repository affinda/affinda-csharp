// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class ResumeSearchDetailSkillsValueItem
    {
        internal static ResumeSearchDetailSkillsValueItem DeserializeResumeSearchDetailSkillsValueItem(JsonElement element)
        {
            Optional<bool> match = default;
            Optional<string> name = default;
            Optional<string> lastUsed = default;
            Optional<int?> numberOfMonths = default;
            Optional<string> type = default;
            Optional<IReadOnlyList<ResumeSkillSourcesItem>> sources = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("match"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    match = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        name = null;
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUsed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        lastUsed = null;
                        continue;
                    }
                    lastUsed = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberOfMonths"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        numberOfMonths = null;
                        continue;
                    }
                    numberOfMonths = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        type = null;
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sources"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ResumeSkillSourcesItem> array = new List<ResumeSkillSourcesItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResumeSkillSourcesItem.DeserializeResumeSkillSourcesItem(item));
                    }
                    sources = array;
                    continue;
                }
            }
            return new ResumeSearchDetailSkillsValueItem(name.Value, lastUsed.Value, Optional.ToNullable(numberOfMonths), type.Value, Optional.ToList(sources), Optional.ToNullable(match));
        }
    }
}
