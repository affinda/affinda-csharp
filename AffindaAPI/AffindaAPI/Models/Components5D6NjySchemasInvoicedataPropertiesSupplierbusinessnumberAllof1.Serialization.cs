// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class Components5D6NjySchemasInvoicedataPropertiesSupplierbusinessnumberAllof1 : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Raw != null)
            {
                writer.WritePropertyName("raw");
                writer.WriteStringValue(Raw);
            }
            else
            {
                writer.WriteNull("raw");
            }
            if (Optional.IsDefined(Parsed))
            {
                if (Parsed != null)
                {
                    writer.WritePropertyName("parsed");
                    writer.WriteStringValue(Parsed);
                }
                else
                {
                    writer.WriteNull("parsed");
                }
            }
            writer.WriteEndObject();
        }

        internal static Components5D6NjySchemasInvoicedataPropertiesSupplierbusinessnumberAllof1 DeserializeComponents5D6NjySchemasInvoicedataPropertiesSupplierbusinessnumberAllof1(JsonElement element)
        {
            string raw = default;
            Optional<string> parsed = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("raw"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        raw = null;
                        continue;
                    }
                    raw = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parsed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        parsed = null;
                        continue;
                    }
                    parsed = property.Value.GetString();
                    continue;
                }
            }
            return new Components5D6NjySchemasInvoicedataPropertiesSupplierbusinessnumberAllof1(raw, parsed.Value);
        }
    }
}
