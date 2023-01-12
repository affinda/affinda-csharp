// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class CollectionUpdate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(AutoValidationThreshold))
            {
                writer.WritePropertyName("autoValidationThreshold");
                writer.WriteNumberValue(AutoValidationThreshold.Value);
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
            if (Optional.IsDefined(DateFormatPreference))
            {
                if (DateFormatPreference != null)
                {
                    writer.WritePropertyName("dateFormatPreference");
                    writer.WriteStringValue(DateFormatPreference.Value.ToString());
                }
                else
                {
                    writer.WriteNull("dateFormatPreference");
                }
            }
            if (Optional.IsDefined(DateFormatFromDocument))
            {
                if (DateFormatFromDocument != null)
                {
                    writer.WritePropertyName("dateFormatFromDocument");
                    writer.WriteBooleanValue(DateFormatFromDocument.Value);
                }
                else
                {
                    writer.WriteNull("dateFormatFromDocument");
                }
            }
            if (Optional.IsCollectionDefined(ExtractorConfig))
            {
                if (ExtractorConfig != null)
                {
                    writer.WritePropertyName("extractorConfig");
                    writer.WriteStartObject();
                    foreach (var item in ExtractorConfig)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("extractorConfig");
                }
            }
            writer.WriteEndObject();
        }
    }
}
