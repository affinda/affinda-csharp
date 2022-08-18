// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class Paths2T1Oc0ResumeSearchEmbedPostRequestbodyContentApplicationJsonSchema : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ConfigOverride))
            {
                writer.WritePropertyName("configOverride");
                writer.WriteObjectValue(ConfigOverride);
            }
            writer.WriteEndObject();
        }
    }
}
