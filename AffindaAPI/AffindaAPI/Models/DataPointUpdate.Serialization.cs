// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class DataPointUpdate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Slug))
            {
                writer.WritePropertyName("slug");
                writer.WriteStringValue(Slug);
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description");
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsDefined(Parent))
            {
                if (Parent != null)
                {
                    writer.WritePropertyName("parent");
                    writer.WriteStringValue(Parent);
                }
                else
                {
                    writer.WriteNull("parent");
                }
            }
            writer.WriteEndObject();
        }
    }
}
