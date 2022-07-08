// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class ComponentsH65QjbSchemasResumesearchdetailPropertiesSkillsPropertiesValueItemsAllof1
    {
        internal static ComponentsH65QjbSchemasResumesearchdetailPropertiesSkillsPropertiesValueItemsAllof1 DeserializeComponentsH65QjbSchemasResumesearchdetailPropertiesSkillsPropertiesValueItemsAllof1(JsonElement element)
        {
            Optional<bool> match = default;
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
            }
            return new ComponentsH65QjbSchemasResumesearchdetailPropertiesSkillsPropertiesValueItemsAllof1(Optional.ToNullable(match));
        }
    }
}
