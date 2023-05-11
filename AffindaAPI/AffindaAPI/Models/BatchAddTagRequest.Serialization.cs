// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class BatchAddTagRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Identifiers))
            {
                writer.WritePropertyName("identifiers");
                writer.WriteStartArray();
                foreach (var item in Identifiers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Tag))
            {
                writer.WritePropertyName("tag");
                writer.WriteNumberValue(Tag.Value);
            }
            writer.WriteEndObject();
        }
    }
}
