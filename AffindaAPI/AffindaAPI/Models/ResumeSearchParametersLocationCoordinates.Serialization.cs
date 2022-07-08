// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class ResumeSearchParametersLocationCoordinates : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Latitude))
            {
                if (Latitude != null)
                {
                    writer.WritePropertyName("latitude");
                    writer.WriteNumberValue(Latitude.Value);
                }
                else
                {
                    writer.WriteNull("latitude");
                }
            }
            if (Optional.IsDefined(Longitude))
            {
                if (Longitude != null)
                {
                    writer.WritePropertyName("longitude");
                    writer.WriteNumberValue(Longitude.Value);
                }
                else
                {
                    writer.WriteNull("longitude");
                }
            }
            writer.WriteEndObject();
        }

        internal static ResumeSearchParametersLocationCoordinates DeserializeResumeSearchParametersLocationCoordinates(JsonElement element)
        {
            Optional<float?> latitude = default;
            Optional<float?> longitude = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("latitude"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        latitude = null;
                        continue;
                    }
                    latitude = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("longitude"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        longitude = null;
                        continue;
                    }
                    longitude = property.Value.GetSingle();
                    continue;
                }
            }
            return new ResumeSearchParametersLocationCoordinates(Optional.ToNullable(latitude), Optional.ToNullable(longitude));
        }
    }
}
