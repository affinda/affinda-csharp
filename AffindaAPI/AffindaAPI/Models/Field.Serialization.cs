// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class Field : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("label");
            writer.WriteStringValue(Label);
            writer.WritePropertyName("dataPoint");
            writer.WriteStringValue(DataPoint);
            if (Optional.IsDefined(Mandatory))
            {
                writer.WritePropertyName("mandatory");
                writer.WriteBooleanValue(Mandatory.Value);
            }
            if (Optional.IsDefined(AutoValidationThreshold))
            {
                if (AutoValidationThreshold != null)
                {
                    writer.WritePropertyName("autoValidationThreshold");
                    writer.WriteNumberValue(AutoValidationThreshold.Value);
                }
                else
                {
                    writer.WriteNull("autoValidationThreshold");
                }
            }
            if (Optional.IsDefined(ShowDropdown))
            {
                writer.WritePropertyName("showDropdown");
                writer.WriteBooleanValue(ShowDropdown.Value);
            }
            if (Optional.IsCollectionDefined(Fields))
            {
                writer.WritePropertyName("fields");
                writer.WriteStartArray();
                foreach (var item in Fields)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static Field DeserializeField(JsonElement element)
        {
            string label = default;
            string dataPoint = default;
            Optional<bool> mandatory = default;
            Optional<float?> autoValidationThreshold = default;
            Optional<bool> showDropdown = default;
            Optional<IList<Field>> fields = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("label"))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataPoint"))
                {
                    dataPoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mandatory"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    mandatory = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("autoValidationThreshold"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        autoValidationThreshold = null;
                        continue;
                    }
                    autoValidationThreshold = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("showDropdown"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    showDropdown = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("fields"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Field> array = new List<Field>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeField(item));
                    }
                    fields = array;
                    continue;
                }
            }
            return new Field(label, dataPoint, Optional.ToNullable(mandatory), Optional.ToNullable(autoValidationThreshold), Optional.ToNullable(showDropdown), Optional.ToList(fields));
        }
    }
}
