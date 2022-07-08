// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class ResumeSearchParametersSkill : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Required))
            {
                writer.WritePropertyName("required");
                writer.WriteBooleanValue(Required.Value);
            }
            writer.WriteEndObject();
        }

        internal static ResumeSearchParametersSkill DeserializeResumeSearchParametersSkill(JsonElement element)
        {
            Optional<string> name = default;
            Optional<bool> required = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("required"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    required = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ResumeSearchParametersSkill(name.Value, Optional.ToNullable(required));
        }
    }
}
