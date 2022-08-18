// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class LanguagesSearchScoreComponent
    {
        internal static LanguagesSearchScoreComponent DeserializeLanguagesSearchScoreComponent(JsonElement element)
        {
            Optional<string> value = default;
            string label = default;
            Optional<float?> score = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("score"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        score = null;
                        continue;
                    }
                    score = property.Value.GetSingle();
                    continue;
                }
            }
            return new LanguagesSearchScoreComponent(value.Value, label, Optional.ToNullable(score));
        }
    }
}
