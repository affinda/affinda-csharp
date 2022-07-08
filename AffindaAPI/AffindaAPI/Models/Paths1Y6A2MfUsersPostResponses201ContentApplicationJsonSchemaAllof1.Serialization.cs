// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Affinda.API.Models
{
    public partial class Paths1Y6A2MfUsersPostResponses201ContentApplicationJsonSchemaAllof1
    {
        internal static Paths1Y6A2MfUsersPostResponses201ContentApplicationJsonSchemaAllof1 DeserializePaths1Y6A2MfUsersPostResponses201ContentApplicationJsonSchemaAllof1(JsonElement element)
        {
            Optional<string> apiKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("apiKey"))
                {
                    apiKey = property.Value.GetString();
                    continue;
                }
            }
            return new Paths1Y6A2MfUsersPostResponses201ContentApplicationJsonSchemaAllof1(apiKey.Value);
        }
    }
}
